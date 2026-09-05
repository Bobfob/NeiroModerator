namespace NeiroModerator
{
    partial class HistoryForm
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
            pnlMain = new Panel();
            btnClose = new Button();
            btnDeleteAll = new Button();
            btnDeleteSelected = new Button();
            btnRefresh = new Button();
            dgvHistory = new DataGridView();
            lblUser = new Label();
            lblTitle = new Label();
            pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.FromArgb(17, 24, 43);
            pnlMain.Controls.Add(btnClose);
            pnlMain.Controls.Add(btnDeleteAll);
            pnlMain.Controls.Add(btnDeleteSelected);
            pnlMain.Controls.Add(btnRefresh);
            pnlMain.Controls.Add(dgvHistory);
            pnlMain.Controls.Add(lblUser);
            pnlMain.Controls.Add(lblTitle);
            pnlMain.Location = new Point(32, 32);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1036, 636);
            pnlMain.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(25, 34, 56);
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(830, 526);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(170, 52);
            btnClose.TabIndex = 6;
            btnClose.Text = "Назад";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnDeleteAll
            // 
            btnDeleteAll.BackColor = Color.FromArgb(93, 40, 50);
            btnDeleteAll.Cursor = Cursors.Hand;
            btnDeleteAll.FlatStyle = FlatStyle.Flat;
            btnDeleteAll.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDeleteAll.ForeColor = Color.White;
            btnDeleteAll.Location = new Point(448, 526);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Size = new Size(210, 52);
            btnDeleteAll.TabIndex = 5;
            btnDeleteAll.Text = "Удалить всю историю";
            btnDeleteAll.UseVisualStyleBackColor = false;
            btnDeleteAll.Click += btnDeleteAll_Click;
            // 
            // btnDeleteSelected
            // 
            btnDeleteSelected.BackColor = Color.FromArgb(166, 58, 74);
            btnDeleteSelected.Cursor = Cursors.Hand;
            btnDeleteSelected.FlatStyle = FlatStyle.Flat;
            btnDeleteSelected.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDeleteSelected.ForeColor = Color.White;
            btnDeleteSelected.Location = new Point(222, 526);
            btnDeleteSelected.Name = "btnDeleteSelected";
            btnDeleteSelected.Size = new Size(210, 52);
            btnDeleteSelected.TabIndex = 4;
            btnDeleteSelected.Text = "Удалить выбранную";
            btnDeleteSelected.UseVisualStyleBackColor = false;
            btnDeleteSelected.Click += btnDeleteSelected_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(124, 92, 252);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(36, 526);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(170, 52);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Обновить";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvHistory
            // 
            dgvHistory.AllowUserToAddRows = false;
            dgvHistory.AllowUserToDeleteRows = false;
            dgvHistory.AllowUserToResizeColumns = false;
            dgvHistory.BackgroundColor = Color.FromArgb(248, 250, 252);
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistory.Location = new Point(36, 116);
            dgvHistory.MultiSelect = false;
            dgvHistory.Name = "dgvHistory";
            dgvHistory.ReadOnly = true;
            dgvHistory.RowHeadersVisible = false;
            dgvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistory.Size = new Size(964, 382);
            dgvHistory.TabIndex = 2;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.ForeColor = Color.FromArgb(142, 154, 184);
            lblUser.Location = new Point(36, 68);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(150, 19);
            lblUser.TabIndex = 1;
            lblUser.Text = "Пользователь: student";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(247, 248, 252);
            lblTitle.Location = new Point(36, 28);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(267, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "История проверок";
            // 
            // HistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 16, 32);
            ClientSize = new Size(1084, 749);
            Controls.Add(pnlMain);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "HistoryForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "История проверок";
            Load += HistoryForm_Load;
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private Button btnClose;
        private Button btnDeleteAll;
        private Button btnDeleteSelected;
        private Button btnRefresh;
        private DataGridView dgvHistory;
        private Label lblUser;
        private Label lblTitle;
    }
}