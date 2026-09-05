namespace NeiroModerator
{
    partial class LoginForm
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
            pnlLogin = new Panel();
            lblError = new Label();
            btnLogin = new Button();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtLogin = new TextBox();
            lblLogin = new Label();
            lblSubtitle = new Label();
            lblTitle = new Label();
            pnlLogin.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = Color.FromArgb(17, 24, 43);
            pnlLogin.Controls.Add(lblError);
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Controls.Add(txtPassword);
            pnlLogin.Controls.Add(lblPassword);
            pnlLogin.Controls.Add(txtLogin);
            pnlLogin.Controls.Add(lblLogin);
            pnlLogin.Controls.Add(lblSubtitle);
            pnlLogin.Controls.Add(lblTitle);
            pnlLogin.Location = new Point(40, 40);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(440, 480);
            pnlLogin.TabIndex = 0;
            // 
            // lblError
            // 
            lblError.ForeColor = Color.FromArgb(239, 123, 138);
            lblError.Location = new Point(48, 400);
            lblError.Name = "lblError";
            lblError.Size = new Size(344, 24);
            lblError.TabIndex = 7;
            lblError.Text = "Неверный логин или пароль";
            lblError.TextAlign = ContentAlignment.MiddleCenter;
            lblError.Visible = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(124, 92, 252);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(48, 326);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(344, 52);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += this.btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(11, 16, 32);
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.ForeColor = Color.FromArgb(221, 227, 242);
            txtPassword.Location = new Point(48, 256);
            txtPassword.MaxLength = 50;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(344, 29);
            txtPassword.TabIndex = 5;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(221, 227, 242);
            lblPassword.Location = new Point(48, 230);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(63, 20);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Пароль";
            // 
            // txtLogin
            // 
            txtLogin.BackColor = Color.FromArgb(11, 16, 32);
            txtLogin.Font = new Font("Segoe UI", 12F);
            txtLogin.ForeColor = Color.FromArgb(221, 227, 242);
            txtLogin.Location = new Point(48, 168);
            txtLogin.MaxLength = 50;
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(344, 29);
            txtLogin.TabIndex = 3;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblLogin.ForeColor = Color.FromArgb(221, 227, 242);
            lblLogin.Location = new Point(48, 142);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(53, 20);
            lblLogin.TabIndex = 2;
            lblLogin.Text = "Логин";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.ForeColor = Color.FromArgb(142, 154, 184);
            lblSubtitle.Location = new Point(112, 78);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(175, 19);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "AI-модератор сообщений";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(247, 248, 252);
            lblTitle.Location = new Point(112, 42);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(207, 36);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Вход в систему";
            // 
            // LoginForm
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 16, 32);
            ClientSize = new Size(504, 590);
            Controls.Add(pnlLogin);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вход — AI-модератор";
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLogin;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtLogin;
        private Label lblLogin;
        private Label lblSubtitle;
        private Label lblTitle;
        private Label lblError;
        private Button btnLogin;
    }
}