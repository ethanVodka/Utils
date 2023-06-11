using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utils.Views
{
    internal partial class PassWordForm : Form
    {
        public PassWordForm()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
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

        private void PassWordForm_Load(object sender, EventArgs e)
        {
            PboxMain.Image = Properties.Resources.Icon_key;
        }
    }
}
