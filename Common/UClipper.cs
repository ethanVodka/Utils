using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClipperLib;
using System.Collections.Generic;
using System.Drawing;
using Utils.Models;
using System.Runtime.InteropServices;
using System.Windows.Shapes;

namespace Utils.Common
{
    public class UClipper
    {
        public static List<List<GPoint>> CombinePolygons(List<List<GPoint>> polygons, double scaleFactor = 1.0)
        {
            // Initialize Clipper
            Clipper clipper = new Clipper();

            // Scale up coordinates and add polygons to clipper
            foreach (List<GPoint> polygon in polygons)
            {
                List<IntPoint> intPolygon = polygon
                    .Select(p => new IntPoint((long)(p.X * scaleFactor), (long)(p.Y * scaleFactor)))
                    .ToList();
                clipper.AddPath(intPolygon, PolyType.ptSubject, true); // true for closed polygons
            }

            // Execute union operation
            List<List<IntPoint>> result = new List<List<IntPoint>>();
            clipper.Execute(ClipType.ctUnion, result, PolyFillType.pftNonZero, PolyFillType.pftNonZero);

            // Scale down coordinates and convert to List<List<GPoint>>
            List<List<GPoint>> convertedResult = new List<List<GPoint>>();
            foreach (List<IntPoint> polygon in result)
            {
                List<GPoint> convertedPolygon = polygon
                    .Select(p => new GPoint(p.X / scaleFactor, p.Y / scaleFactor))
                    .ToList();
                convertedResult.Add(convertedPolygon);
            }

            return convertedResult;
        }

        public static bool IsClockwise(List<GPoint> polygon)
        {
            // Convert GPoints to IntPoints
            List<IntPoint> intPolygon = new List<IntPoint>();
            foreach (GPoint point in polygon)
            {
                IntPoint intPoint = new IntPoint((long)point.X, (long)point.Y);
                intPolygon.Add(intPoint);
            }

            // Check polygon orientation using ClipperLib
            return Clipper.Orientation(intPolygon);
        }

        public static List<GPoint> SubtractPolygons(List<GPoint> outerPolygon, List<GPoint> innerPolygon)
        {
            // Convert GPoints to IntPoints
            List<IntPoint> intOuterPolygon = outerPolygon.ConvertAll(p => new IntPoint((long)p.X, (long)p.Y));
            List<IntPoint> intInnerPolygon = innerPolygon.ConvertAll(p => new IntPoint((long)p.X, (long)p.Y));

            // Create a new Clipper instance
            Clipper clipper = new Clipper();

            // Add the polygons to the Clipper instance
            clipper.AddPath(intOuterPolygon, PolyType.ptSubject, true);
            clipper.AddPath(intInnerPolygon, PolyType.ptClip, true);

            // Perform the difference operation using the Tree structure
            PolyTree solutionTree = new PolyTree();
            clipper.Execute(ClipType.ctDifference, solutionTree);
            // Convert the solution tree to a list of GPoints
            List<GPoint> solutionPolygon = new List<GPoint>();
            AddPolyNodeToList(solutionTree.GetFirst(), solutionPolygon);

            return solutionPolygon;
        }

        private static void AddPolyNodeToList(PolyNode polyNode, List<GPoint> polygons)
        {
            if (polyNode == null) return;

            if (polyNode.IsHole)
            {
                // Handle holes by adding the contour in reverse order
                List<IntPoint> hole = polyNode.Contour;
                //hole.Reverse();
                polygons.AddRange(hole.ConvertAll(p => new GPoint(p.X, p.Y)));
            }
            else
            {
                // Add the contour of the parent polygon
                polygons.AddRange(polyNode.Contour.ConvertAll(p => new GPoint(p.X, p.Y)));
            }

            // Recursively process child polygons
            for (int i = 0; i < polyNode.ChildCount; i++)
            {
                AddPolyNodeToList(polyNode.Childs[i], polygons);
            }
        }
    }
}
