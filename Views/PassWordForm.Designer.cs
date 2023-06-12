namespace Utils.Views
{
    partial class PassWordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnlTitle = new System.Windows.Forms.Panel();
            this.LblTitle = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LblContent = new System.Windows.Forms.Label();
            this.TxbPassword = new System.Windows.Forms.TextBox();
            this.TxbConfirm = new System.Windows.Forms.TextBox();
            this.LblConfirm = new System.Windows.Forms.Label();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.PboxMain = new System.Windows.Forms.PictureBox();
            this.CboxVisible = new System.Windows.Forms.CheckBox();
            this.PnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PboxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlTitle
            // 
            this.PnlTitle.BackColor = System.Drawing.Color.DimGray;
            this.PnlTitle.Controls.Add(this.LblTitle);
            this.PnlTitle.Controls.Add(this.BtnExit);
            this.PnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitle.Location = new System.Drawing.Point(0, 0);
            this.PnlTitle.Name = "PnlTitle";
            this.PnlTitle.Size = new System.Drawing.Size(381, 23);
            this.PnlTitle.TabIndex = 0;
            this.PnlTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlTitle_MouseDown);
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("游ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblTitle.ForeColor = System.Drawing.Color.White;
            this.LblTitle.Location = new System.Drawing.Point(3, 2);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(88, 16);
            this.LblTitle.TabIndex = 2;
            this.LblTitle.Text = "Authentication";
            // 
            // BtnExit
            // 
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(357, 1);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(20, 20);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "X";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LblContent
            // 
            this.LblContent.AutoSize = true;
            this.LblContent.Font = new System.Drawing.Font("游ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblContent.ForeColor = System.Drawing.Color.Black;
            this.LblContent.Location = new System.Drawing.Point(111, 47);
            this.LblContent.Name = "LblContent";
            this.LblContent.Size = new System.Drawing.Size(165, 16);
            this.LblContent.TabIndex = 3;
            this.LblContent.Text = "please enter your password :";
            // 
            // TxbPassword
            // 
            this.TxbPassword.Location = new System.Drawing.Point(114, 66);
            this.TxbPassword.Name = "TxbPassword";
            this.TxbPassword.PasswordChar = '●';
            this.TxbPassword.Size = new System.Drawing.Size(236, 19);
            this.TxbPassword.TabIndex = 4;
            // 
            // TxbConfirm
            // 
            this.TxbConfirm.Location = new System.Drawing.Point(114, 114);
            this.TxbConfirm.Name = "TxbConfirm";
            this.TxbConfirm.PasswordChar = '●';
            this.TxbConfirm.Size = new System.Drawing.Size(236, 19);
            this.TxbConfirm.TabIndex = 6;
            // 
            // LblConfirm
            // 
            this.LblConfirm.AutoSize = true;
            this.LblConfirm.Font = new System.Drawing.Font("游ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblConfirm.ForeColor = System.Drawing.Color.Black;
            this.LblConfirm.Location = new System.Drawing.Point(111, 95);
            this.LblConfirm.Name = "LblConfirm";
            this.LblConfirm.Size = new System.Drawing.Size(177, 16);
            this.LblConfirm.TabIndex = 5;
            this.LblConfirm.Text = "please confirm your password :";
            // 
            // BtnOK
            // 
            this.BtnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOK.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnOK.ForeColor = System.Drawing.Color.Black;
            this.BtnOK.Location = new System.Drawing.Point(248, 146);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(51, 20);
            this.BtnOK.TabIndex = 3;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnCancel.ForeColor = System.Drawing.Color.Black;
            this.BtnCancel.Location = new System.Drawing.Point(318, 146);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(51, 20);
            this.BtnCancel.TabIndex = 7;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // PboxMain
            // 
            this.PboxMain.Location = new System.Drawing.Point(30, 66);
            this.PboxMain.Name = "PboxMain";
            this.PboxMain.Size = new System.Drawing.Size(45, 45);
            this.PboxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PboxMain.TabIndex = 8;
            this.PboxMain.TabStop = false;
            // 
            // CboxVisible
            // 
            this.CboxVisible.AutoSize = true;
            this.CboxVisible.Location = new System.Drawing.Point(114, 146);
            this.CboxVisible.Name = "CboxVisible";
            this.CboxVisible.Size = new System.Drawing.Size(109, 16);
            this.CboxVisible.TabIndex = 9;
            this.CboxVisible.Text = "visible password";
            this.CboxVisible.UseVisualStyleBackColor = true;
            this.CboxVisible.CheckedChanged += new System.EventHandler(this.CboxVisible_CheckedChanged);
            // 
            // PassWordForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(381, 178);
            this.Controls.Add(this.CboxVisible);
            this.Controls.Add(this.PboxMain);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.TxbConfirm);
            this.Controls.Add(this.LblConfirm);
            this.Controls.Add(this.TxbPassword);
            this.Controls.Add(this.LblContent);
            this.Controls.Add(this.PnlTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PassWordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PassWordForm";
            this.PnlTitle.ResumeLayout(false);
            this.PnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PboxMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlTitle;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LblContent;
        private System.Windows.Forms.TextBox TxbPassword;
        private System.Windows.Forms.TextBox TxbConfirm;
        private System.Windows.Forms.Label LblConfirm;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.PictureBox PboxMain;
        private System.Windows.Forms.CheckBox CboxVisible;
    }
}