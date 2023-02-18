namespace FestaBanOverlay
{
    public partial class Overlay : Form
    {
        public Overlay()
        {
            InitializeComponent();

            // Set Font
            PlayerA.Font = Program.fontManager.ToFont(FontId.Light, 45f);
            PlayerB.Font = Program.fontManager.ToFont(FontId.Light, 45f);

            ScoreA.Font = Program.fontManager.ToFont(FontId.Black, 100f);
            ScoreB.Font = Program.fontManager.ToFont(FontId.Black, 100f);

            // Set Parent (A)
            ButtonA.Parent = PlateA;
            BanA.Parent = ButtonA;

            // Set Parent (B)
            ButtonB.Parent = PlateB;
            BanB.Parent = ButtonB;

            // Set SizeMode
            ButtonA.SizeMode = PictureBoxSizeMode.Zoom;
            ButtonB.SizeMode = PictureBoxSizeMode.Zoom;

            // Set Button Location
            ButtonA.Location = new(15, 15);
            ButtonB.Location = new(15, 15);

            // Set Timer
            TimeLeft.Location = new(15, 0);
            TimeLeft.Parent = TimerBackground;
            Timer.Tick += Timer_Tick;

            UpdateBanIconLocation();
            UpdateNameBox();
            UpdateScoreBox();
        }

        public void UpdateBanIconLocation()
        {
            Point banIconLocation = Program.IsBanMode ? (new(35, 35)) : (new(0, 200));
            BanA.Location = banIconLocation;
            BanB.Location = banIconLocation;
        }

        public void UpdateNameBox()
        {
            PlayerA.Text = Program.A.Name;
            PlayerB.Text = Program.B.Name;
        }

        public void UpdateScoreBox()
        {
            ScoreA.Text = Program.A.Score;
            ScoreB.Text = Program.B.Score;
        }

        private Image? GetKeyImage(string key)
        {
            return key == "4B"
                ? Properties.Resources._4B
                : key == "5B"
                ? Properties.Resources._5B
                : key == "6B" ? Properties.Resources._6B : key == "8B" ? Properties.Resources._8B : (Image?)null;
        }

        public void UpdateKeyImage(RadioButton button)
        {
            if (!button.Checked)
            {
                return;
            }

            if (button.Name.StartsWith("PlayerA"))
            {
                ButtonA.Image?.Dispose();
                ButtonA.Image = GetKeyImage(button.Text);
            }
            else
            {
                ButtonB.Image?.Dispose();
                ButtonB.Image = GetKeyImage(button.Text);
            }
        }

        public void InitKeyImage(RadioButton[] buttons)
        {
            for (int index = 0; index < buttons.Length; index++)
            {
                RadioButton button = buttons[index];
                UpdateKeyImage(button);
            }
        }

        public void SetTimerText()
        {
            TimeLeft.Text = Program.TimeLeft <= 0 ? "" : Program.TimeLeft.ToString();
        }

        private void Timer_Tick(object sender, EventArgs args)
        {
            if (!Program.TimerEnabled)
            {
                return;
            }

            if (Program.TimeLeft > 0)
            {
                Program.TimeLeft -= 1;
            }

            SetTimerText();
        }
    }
}
