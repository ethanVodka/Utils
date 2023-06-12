using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils.Common
{
    public class UPassword
    {
        internal static string Password { get; set; } = string.Empty;

        /// <summary>
        /// パスワード入力フォームを起動し、入力したパスワードを取得する
        /// 何かエラーがあった場合　error を文字列として返す
        /// </summary>
        /// <returns>入力したパスワード</returns>
        public static string GetPassword()
        {
            Views.PassWordForm passWordForm = new Views.PassWordForm();
            passWordForm.ShowDialog();

            if (Password != string.Empty)
            {
                return Password;
            }
            else
            {
                return "error";
            }
        }
    }
}
