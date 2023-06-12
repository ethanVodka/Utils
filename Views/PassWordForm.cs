using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace Utils.Views
{
    internal partial class PassWordForm : Form
    {
        //C++ネイティブコードのインポート
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        public PassWordForm()
        {
            InitializeComponent();

            PboxMain.Image = SystemIcons.Shield.ToBitmap();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (TxbConfirm.Text == TxbPassword.Text)
            {
                Common.UPassword.Password = TxbConfirm.Text;

                this.Close();
            }
            else
            {
                MessageBox.Show("パスワードが異なります、確認してください", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CboxVisible_CheckedChanged(object sender, EventArgs e)
        {
            if (TxbPassword.PasswordChar == '●')
            {
                TxbPassword.PasswordChar = '\0';
                TxbConfirm.PasswordChar = '\0';
            }
            else
            {
                TxbPassword.PasswordChar = '●';
                TxbConfirm.PasswordChar = '●';
            }
        }

        private void PnlTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
    }
}
