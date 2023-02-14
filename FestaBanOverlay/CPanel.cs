using FestaBanOverlay;

namespace FestaGameOverlay
{
    public partial class CPanel : Form
    {
        public CPanel()
        {
            InitializeComponent();

            // Set Parent

            RadioButton[] PlayerAB = new RadioButton[] { PlayerA4B, PlayerA5B, PlayerA6B, PlayerA8B, PlayerAX };
            RadioButton[] PlayerBB = new RadioButton[] { PlayerB4B, PlayerB5B, PlayerB6B, PlayerB8B, PlayerBX };

            for (int index = 0; index < PlayerAB.Length; index++)
            {
                RadioButton a = PlayerAB[index];
                RadioButton b = PlayerBB[index];

                a.Parent = PanelA;
                a.Location = new(index * 77, 0);

                b.Parent = PanelB;
                b.Location = new(index * 77, 0);

                // Set EventHandler
                a.CheckedChanged += CheckedChanged;
                b.CheckedChanged += CheckedChanged;
            }
        }

        private void PlayerA_TextChanged(object sender, EventArgs e)
        {
            Program.A.Name = PlayerA.Text;
            Program.OpenedOverlay?.UpdateNameBox();
        }

        private void PlayerB_TextChanged(object sender, EventArgs e)
        {
            Program.B.Name = PlayerB.Text;
            Program.OpenedOverlay?.UpdateNameBox();
        }

        private void DoCollect_Click(object sender, EventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void OpenOverlay_Click(object sender, EventArgs e)
        {
            Program.OpenedOverlay?.Close();

            Program.OpenedOverlay = new();
            Program.OpenedOverlay.Show();

            // Init Key Image
            RadioButton[] buttons = new RadioButton[] {
                PlayerA4B, PlayerA5B, PlayerA6B, PlayerA8B, PlayerAX,
                PlayerB4B, PlayerB5B, PlayerB6B, PlayerB8B, PlayerBX
            };

            Program.OpenedOverlay.InitKeyImage(buttons);
        }

        private void BanModeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Program.IsBanMode = !Program.IsBanMode;
            Program.OpenedOverlay?.UpdateBanIconLocation();
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            Program.OpenedOverlay?.UpdateKeyImage((RadioButton)sender);
        }

        private void ScoreA_TextChanged(object sender, EventArgs e)
        {
            Program.A.Score = ScoreA.Text;
            Program.OpenedOverlay?.UpdateScoreBox();
        }

        private void ScoreB_TextChanged(object sender, EventArgs e)
        {
            Program.B.Score = ScoreB.Text;
            Program.OpenedOverlay?.UpdateScoreBox();
        }

        private void PlayerAP_Click(object sender, EventArgs e)
        {
            bool success = int.TryParse(Program.A.Score, out int score);

            if (success == true)
            {
                score += 1;
                ScoreA.Text = score.ToString();
            }
        }

        private void PlayerAM_Click(object sender, EventArgs e)
        {
            bool success = int.TryParse(Program.A.Score, out int score);

            if (success == true)
            {
                score -= 1;
                ScoreA.Text = score.ToString();
            }
        }

        private void PlayerBP_Click(object sender, EventArgs e)
        {
            bool success = int.TryParse(Program.B.Score, out int score);

            if (success == true)
            {
                score += 1;
                ScoreB.Text = score.ToString();
            }
        }

        private void PlayerBM_Click(object sender, EventArgs e)
        {
            bool success = int.TryParse(Program.B.Score, out int score);

            if (success == true)
            {
                score -= 1;
                ScoreB.Text = score.ToString();
            }
        }
    }
}
