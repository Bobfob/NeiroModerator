namespace NeiroModerator
{
    public partial class ChatForm : Form
    {
        private enum ModerationStatus
        {
            Safe,
            Blocked,
            Review
        }

        private readonly string[] blockedWords =
        {
            "пароль",
            "номер карты",
            "cvv",
            "взломать",
            "украсть аккаунт"
        };


        private readonly string[] reviewWords =
        {
            "дурак",
            "идиот",
            "тупой",
            "ненавижу",
            "угроза"
        };

        private readonly Random random = new Random();

        public ChatForm()
        {
            InitializeComponent();

            lblCurrentUser.Text = "Пользователь: " + Session.Login;

            ShowInitialState();
            lblCounter.Text = "0 / 500";
        }

        private void ShowInitialState()
        {
            pnlResult.BackColor = ColorTranslator.FromHtml("#151D30");
            lblResultTitle.ForeColor = ColorTranslator.FromHtml("#8E9AB8");
            lblStatus.ForeColor = ColorTranslator.FromHtml("#E6EAF3");
            lblReason.ForeColor = ColorTranslator.FromHtml("#8E9AB8");

            lblResultTitle.Text = "РЕЗУЛЬТАТ ПРОВЕРКИ";
            lblStatus.Text = "Результат появится здесь";
            lblReason.Text = "Введите текст и нажмите кнопку «Проверить».";

            picStatus.Visible = false;
            pnlConfidence.Visible = false;
        }


        private void btnCheck_Click(object sender, EventArgs e)
        {
            btnCheck.Enabled = false;

            try
            {
                string message = txtMessage.Text.Trim();

                if (string.IsNullOrWhiteSpace(message))
                {
                    MessageBox.Show(
                        "Введите сообщение для проверки.",
                        "Нет сообщения",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtMessage.Focus();
                    return;
                }

                ModerationStatus status = GetModerationStatus(message);
                int confidence = GetConfidence(status);
                string statusText = GetStatusText(status);

                ShowModerationResult(status, confidence);

                Database.AddHistory(message, statusText, confidence);
            }

            catch (Exception)
            {
                MessageBox.Show(
                    "Не удалось проверить сообщение.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            
            finally
            {
                btnCheck.Enabled = true;
            }
        }

        private ModerationStatus GetModerationStatus(string message)
        {
            string normalizedMessage = message.ToLower();

            if (ContainsAny(normalizedMessage, blockedWords))
            {
                return ModerationStatus.Blocked;
            }

            if (ContainsAny(normalizedMessage, reviewWords))
            {
                return ModerationStatus.Review;
            }

            return ModerationStatus.Safe;
        }

        private bool ContainsAny(string message, string[] words)
        {
            foreach (string word in words)
            {
                if (message.Contains(word))
                {
                    return true;
                }
            }

            return false;
        }

        private void ShowModerationResult(ModerationStatus status, int confidence)
        {
            pnlConfidence.Visible = true;
            picStatus.Visible = true;

            switch (status)
            {
                case ModerationStatus.Safe:
                    ShowSafeResult(confidence);
                    break;

                case ModerationStatus.Blocked:
                    ShowBlockedResult(confidence);
                    break;

                case ModerationStatus.Review:
                    ShowReviewResult(confidence);
                    break;
            }
        }

        private void ShowSafeResult(int confidence)
        {
            pnlResult.BackColor = ColorTranslator.FromHtml("#101F22");
            pnlConfidence.BackColor = ColorTranslator.FromHtml("#142B29");
            lblResultTitle.ForeColor = ColorTranslator.FromHtml("#78A995");
            lblStatus.ForeColor = ColorTranslator.FromHtml("#DDFBF0");
            lblReason.ForeColor = ColorTranslator.FromHtml("#78A995");
            lblConfidenceTitle.ForeColor = ColorTranslator.FromHtml("#78A995");
            lblConfidence.ForeColor = ColorTranslator.FromHtml("#DDFBF0");

            lblStatus.Text = "Сообщение безопасно";
            lblReason.Text = "Нарушений не обнаружено";
            lblConfidence.Text = confidence + "%";
            picStatus.Image = Properties.Resources.status_safe;
        }

        private void ShowBlockedResult(int confidence)
        {
            pnlResult.BackColor = ColorTranslator.FromHtml("#25171D");
            pnlConfidence.BackColor = ColorTranslator.FromHtml("#321B23");
            lblResultTitle.ForeColor = ColorTranslator.FromHtml("#D58A96");
            lblStatus.ForeColor = ColorTranslator.FromHtml("#FFE7EB");
            lblReason.ForeColor = ColorTranslator.FromHtml("#D58A96");
            lblConfidenceTitle.ForeColor = ColorTranslator.FromHtml("#D58A96");
            lblConfidence.ForeColor = ColorTranslator.FromHtml("#FFE7EB");

            lblStatus.Text = "Сообщение заблокировано";
            lblReason.Text = "Причина: найден запрещённый текст";
            lblConfidence.Text = confidence + "%";
            picStatus.Image = Properties.Resources.status_blocked;
        }

        private void ShowReviewResult(int confidence)
        {
            pnlResult.BackColor = ColorTranslator.FromHtml("#282314");
            pnlConfidence.BackColor = ColorTranslator.FromHtml("#342B15");
            lblResultTitle.ForeColor = ColorTranslator.FromHtml("#D8B768");
            lblStatus.ForeColor = ColorTranslator.FromHtml("#FFF3D6");
            lblReason.ForeColor = ColorTranslator.FromHtml("#D8B768");
            lblConfidenceTitle.ForeColor = ColorTranslator.FromHtml("#D8B768");
            lblConfidence.ForeColor = ColorTranslator.FromHtml("#FFF3D6");

            lblStatus.Text = "Требуется проверка";
            lblReason.Text = "Контекст сообщения неоднозначен";
            lblConfidence.Text = confidence + "%";
            picStatus.Image = Properties.Resources.status_review;
        }

        private int GetConfidence(ModerationStatus status)
        {
            switch (status)
            {
                case ModerationStatus.Safe:
                    return random.Next(80, 101);

                case ModerationStatus.Blocked:
                    return random.Next(85, 101);

                default:
                    return random.Next(40, 80);
            }
        }

        private string GetStatusText(ModerationStatus status)
        {
            switch (status)
            {
                case ModerationStatus.Safe:
                    return "Сообщение безопасно";

                case ModerationStatus.Blocked:
                    return "Сообщение заблокировано";

                default:
                    return "Требуется проверка";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMessage.Clear();

            ShowInitialState();
            txtMessage.Focus();
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {
            lblCounter.Text = txtMessage.Text.Length + " / 500";

            ShowInitialState();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            using HistoryForm historyForm = new HistoryForm();
            historyForm.ShowDialog();
        }
    }
}
