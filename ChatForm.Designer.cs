namespace NeiroModerator
{
    partial class ChatForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlMain = new Panel();
            btnHistory = new Button();
            lblCurrentUser = new Label();
            pnlResult = new Panel();
            pnlConfidence = new Panel();
            lblConfidence = new Label();
            lblConfidenceTitle = new Label();
            lblReason = new Label();
            lblStatus = new Label();
            picStatus = new PictureBox();
            lblResultTitle = new Label();
            btnClear = new Button();
            btnCheck = new Button();
            txtMessage = new TextBox();
            lblCounter = new Label();
            lblMessage = new Label();
            lblDivider = new Label();
            lblSubtitle = new Label();
            lblTitle = new Label();
            picLogo = new PictureBox();
            pnlMain.SuspendLayout();
            pnlResult.SuspendLayout();
            pnlConfidence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picStatus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(btnHistory);
            pnlMain.Controls.Add(lblCurrentUser);
            pnlMain.Controls.Add(pnlResult);
            pnlMain.Controls.Add(btnClear);
            pnlMain.Controls.Add(btnCheck);
            pnlMain.Controls.Add(txtMessage);
            pnlMain.Controls.Add(lblCounter);
            pnlMain.Controls.Add(lblMessage);
            pnlMain.Controls.Add(lblDivider);
            pnlMain.Controls.Add(lblSubtitle);
            pnlMain.Controls.Add(lblTitle);
            pnlMain.Controls.Add(picLogo);
            pnlMain.ForeColor = Color.FromArgb(17, 24, 43);
            pnlMain.Location = new Point(32, 32);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(936, 636);
            pnlMain.TabIndex = 0;
            // 
            // btnHistory
            // 
            btnHistory.BackColor = Color.FromArgb(25, 34, 56);
            btnHistory.Cursor = Cursors.Hand;
            btnHistory.FlatAppearance.BorderColor = Color.FromArgb(53, 65, 95);
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnHistory.ForeColor = Color.FromArgb(198, 206, 224);
            btnHistory.Location = new Point(448, 366);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(150, 54);
            btnHistory.TabIndex = 11;
            btnHistory.Text = "История";
            btnHistory.UseVisualStyleBackColor = false;
            btnHistory.Click += this.btnHistory_Click;
            // 
            // lblCurrentUser
            // 
            lblCurrentUser.BackColor = Color.Transparent;
            lblCurrentUser.ForeColor = Color.FromArgb(142, 154, 184);
            lblCurrentUser.Location = new Point(650, 50);
            lblCurrentUser.Name = "lblCurrentUser";
            lblCurrentUser.Size = new Size(250, 24);
            lblCurrentUser.TabIndex = 10;
            lblCurrentUser.Text = "Пользователь: student";
            lblCurrentUser.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlResult
            // 
            pnlResult.BackColor = Color.FromArgb(21, 29, 48);
            pnlResult.Controls.Add(pnlConfidence);
            pnlResult.Controls.Add(lblReason);
            pnlResult.Controls.Add(lblStatus);
            pnlResult.Controls.Add(picStatus);
            pnlResult.Controls.Add(lblResultTitle);
            pnlResult.Location = new Point(36, 450);
            pnlResult.Name = "pnlResult";
            pnlResult.Size = new Size(864, 144);
            pnlResult.TabIndex = 9;
            // 
            // pnlConfidence
            // 
            pnlConfidence.BackColor = Color.FromArgb(20, 43, 41);
            pnlConfidence.Controls.Add(lblConfidence);
            pnlConfidence.Controls.Add(lblConfidenceTitle);
            pnlConfidence.Location = new Point(667, 46);
            pnlConfidence.Name = "pnlConfidence";
            pnlConfidence.Size = new Size(166, 64);
            pnlConfidence.TabIndex = 4;
            pnlConfidence.Visible = false;
            // 
            // lblConfidence
            // 
            lblConfidence.AutoSize = true;
            lblConfidence.BackColor = Color.Transparent;
            lblConfidence.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblConfidence.ForeColor = Color.FromArgb(221, 251, 240);
            lblConfidence.Location = new Point(20, 28);
            lblConfidence.Name = "lblConfidence";
            lblConfidence.Size = new Size(60, 31);
            lblConfidence.TabIndex = 1;
            lblConfidence.Text = "94%";
            // 
            // lblConfidenceTitle
            // 
            lblConfidenceTitle.AutoSize = true;
            lblConfidenceTitle.BackColor = Color.Transparent;
            lblConfidenceTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblConfidenceTitle.ForeColor = Color.FromArgb(120, 169, 149);
            lblConfidenceTitle.Location = new Point(20, 9);
            lblConfidenceTitle.Name = "lblConfidenceTitle";
            lblConfidenceTitle.Size = new Size(98, 13);
            lblConfidenceTitle.TabIndex = 0;
            lblConfidenceTitle.Text = "УВЕРЕННОСТЬ AI";
            // 
            // lblReason
            // 
            lblReason.BackColor = Color.Transparent;
            lblReason.ForeColor = Color.FromArgb(142, 154, 184);
            lblReason.Location = new Point(68, 91);
            lblReason.Name = "lblReason";
            lblReason.Size = new Size(540, 24);
            lblReason.TabIndex = 3;
            lblReason.Text = "Введите текст и нажмите кнопку «Проверить».";
            // 
            // lblStatus
            // 
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblStatus.ForeColor = Color.FromArgb(230, 234, 243);
            lblStatus.Location = new Point(68, 58);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(520, 31);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Результат появится здесь";
            // 
            // picStatus
            // 
            picStatus.BackColor = Color.Transparent;
            picStatus.Location = new Point(24, 61);
            picStatus.Name = "picStatus";
            picStatus.Size = new Size(30, 30);
            picStatus.SizeMode = PictureBoxSizeMode.Zoom;
            picStatus.TabIndex = 1;
            picStatus.TabStop = false;
            picStatus.Visible = false;
            // 
            // lblResultTitle
            // 
            lblResultTitle.AutoSize = true;
            lblResultTitle.BackColor = Color.Transparent;
            lblResultTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblResultTitle.ForeColor = Color.FromArgb(142, 154, 184);
            lblResultTitle.Location = new Point(24, 20);
            lblResultTitle.Name = "lblResultTitle";
            lblResultTitle.Size = new Size(134, 15);
            lblResultTitle.TabIndex = 0;
            lblResultTitle.Text = "РЕЗУЛЬТАТ ПРОВЕРКИ";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(25, 34, 56);
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderColor = Color.FromArgb(53, 65, 95);
            btnClear.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 28, 47);
            btnClear.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 46, 73);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClear.ForeColor = Color.FromArgb(198, 206, 224);
            btnClear.Location = new Point(282, 366);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(150, 54);
            btnClear.TabIndex = 8;
            btnClear.Text = "Очистить";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnCheck
            // 
            btnCheck.BackColor = Color.FromArgb(124, 92, 252);
            btnCheck.Cursor = Cursors.Hand;
            btnCheck.FlatAppearance.BorderSize = 0;
            btnCheck.FlatAppearance.MouseDownBackColor = Color.FromArgb(103, 75, 224);
            btnCheck.FlatAppearance.MouseOverBackColor = Color.FromArgb(139, 116, 255);
            btnCheck.FlatStyle = FlatStyle.Flat;
            btnCheck.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCheck.ForeColor = Color.White;
            btnCheck.Location = new Point(36, 366);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(230, 54);
            btnCheck.TabIndex = 7;
            btnCheck.Text = "Проверить";
            btnCheck.UseVisualStyleBackColor = false;
            btnCheck.Click += btnCheck_Click;
            // 
            // txtMessage
            // 
            txtMessage.AcceptsReturn = true;
            txtMessage.BackColor = Color.FromArgb(11, 16, 32);
            txtMessage.BorderStyle = BorderStyle.FixedSingle;
            txtMessage.CausesValidation = false;
            txtMessage.Font = new Font("Segoe UI", 12F);
            txtMessage.ForeColor = Color.FromArgb(221, 227, 242);
            txtMessage.Location = new Point(36, 166);
            txtMessage.MaxLength = 500;
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.PlaceholderText = "Введите сообщение для проверки";
            txtMessage.ScrollBars = ScrollBars.Vertical;
            txtMessage.Size = new Size(864, 176);
            txtMessage.TabIndex = 6;
            txtMessage.TextChanged += txtMessage_TextChanged;
            // 
            // lblCounter
            // 
            lblCounter.BackColor = Color.Transparent;
            lblCounter.Font = new Font("Segoe UI", 9F);
            lblCounter.ForeColor = Color.FromArgb(102, 113, 141);
            lblCounter.Location = new Point(810, 137);
            lblCounter.Name = "lblCounter";
            lblCounter.Size = new Size(90, 24);
            lblCounter.TabIndex = 5;
            lblCounter.Text = "0 / 500";
            lblCounter.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.BackColor = Color.Transparent;
            lblMessage.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMessage.ForeColor = Color.FromArgb(221, 227, 242);
            lblMessage.Location = new Point(36, 137);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(102, 21);
            lblMessage.TabIndex = 4;
            lblMessage.Text = "Сообщение";
            // 
            // lblDivider
            // 
            lblDivider.BackColor = Color.FromArgb(38, 48, 74);
            lblDivider.Location = new Point(36, 109);
            lblDivider.Name = "lblDivider";
            lblDivider.Size = new Size(864, 2);
            lblDivider.TabIndex = 3;
            lblDivider.Text = "label1";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.Font = new Font("Segoe UI", 11F);
            lblSubtitle.ForeColor = Color.FromArgb(142, 154, 184);
            lblSubtitle.Location = new Point(100, 72);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(266, 20);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Проверка текста перед публикацией";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(247, 248, 252);
            lblTitle.Location = new Point(100, 32);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(364, 37);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "AI-модератор сообщений";
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.Image = Properties.Resources.logo;
            picLogo.InitialImage = null;
            picLogo.Location = new Point(36, 34);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(48, 48);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // ChatForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 16, 32);
            ClientSize = new Size(984, 749);
            Controls.Add(pnlMain);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ChatForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AI-модератор сообщений";
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            pnlResult.ResumeLayout(false);
            pnlResult.PerformLayout();
            pnlConfidence.ResumeLayout(false);
            pnlConfidence.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picStatus).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private Label lblTitle;
        private PictureBox picLogo;
        private Label lblSubtitle;
        private Label lblMessage;
        private Label lblDivider;
        private TextBox txtMessage;
        private Label lblCounter;
        private Button btnCheck;
        private Button btnClear;
        private Panel pnlResult;
        private Label lblResultTitle;
        private Label lblStatus;
        private PictureBox picStatus;
        private Label lblReason;
        private Panel pnlConfidence;
        private Label lblConfidence;
        private Label lblConfidenceTitle;
        private Label lblCurrentUser;
        private Button btnHistory;
    }
}
