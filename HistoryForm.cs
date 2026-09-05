using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeiroModerator
{
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            lblUser.Text = "Пользователь: " + Session.Login;
            LoadHistory();
        }

        private void LoadHistory()
        {
            try
            {
                dgvHistory.DataSource = Database.GetHistory();

                dgvHistory.Columns["idModerationHistory"].Visible = false;

                dgvHistory.Columns["Message"].HeaderText = "Сообщение";
                dgvHistory.Columns["Status"].HeaderText = "Статус";
                dgvHistory.Columns["Confidence"].HeaderText = "Уверенность, %";
                dgvHistory.Columns["CreatedAt"].HeaderText = "Дата";
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Не удалось загрузить историю.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            if (dgvHistory.CurrentRow == null)
            {
                MessageBox.Show("Выберите запись.");
                return;
            }

            DialogResult answer = MessageBox.Show(
                "Удалить выбранную запись?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (answer != DialogResult.Yes)
            {
                return;
            }

            try
            {
                int historyId = Convert.ToInt32(
                    dgvHistory.CurrentRow.Cells["id"].Value);

                Database.DeleteHistory(historyId);
                LoadHistory();
            }

            catch (Exception)
            {
                MessageBox.Show("Не удалось удалить запись.");
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show(
                "Вы действительно хотите удалить всю историю?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (answer != DialogResult.Yes)
            {
                return;
            }

            try
            {
                Database.DeleteAllHistory();
                LoadHistory();
            }

            catch (Exception)
            {
                MessageBox.Show("Не удалось удалить историю.");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadHistory();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
