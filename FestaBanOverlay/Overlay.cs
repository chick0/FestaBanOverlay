using FestaGameOverlay;

namespace FestaBanOverlay
{
    public partial class Overlay : Form
    {
        public Overlay()
        {
            InitializeComponent();

            // Set Font
            PlayerA.Font = Program.fontManager.ToFont(2, 25f);
            PlayerB.Font = Program.fontManager.ToFont(2, 25f);

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
            ButtonA.Location = new(10, 10);
            ButtonB.Location = new(10, 10);

            UpdateBanIconLocation();
            UpdateNameBox();
        }

        public void UpdateBanIconLocation()
        {
            Point banIconLocation = Program.IsBanMode ? (new(0, 0)) : (new(0, 120));
            BanA.Location = banIconLocation;
            BanB.Location = banIconLocation;
        }

        public void UpdateNameBox()
        {
            PlayerA.Text = Program.A.Name;
            PlayerB.Text = Program.B.Name;
        }

        private Image? GetKeyImage(string key)
        {
            if (key == "4B")
            {
                return Properties.Resources._4B;
            }

            if (key == "5B")
            {
                return Properties.Resources._5B;
            }

            return key == "6B" ? Properties.Resources._6B : key == "8B" ? Properties.Resources._8B : (Image?)null;
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
            for(int index = 0; index < buttons.Length; index++)
            {
                RadioButton button = buttons[index];
                UpdateKeyImage(button);
            }
        }
    }
}
