using FestaGameOverlay;

namespace FestaBanOverlay
{
    internal class Player
    {
        public string Name;
        public string Score;
        public string? SelectButton;

        public Player()
        {
            Name = "";
            Score = "0";
            SelectButton = null;
        }
    }

    internal static class Program
    {
        public static Player A = new();
        public static Player B = new();

        public static Overlay? OpenedOverlay = null;
        public static FontManager fontManager = new();

        public static bool IsBanMode = false;

        public static bool TimerEnabled = false;
        public static int TimeLeft = 60;

        [STAThread]
        private static void Main()
        {
            ApplicationConfiguration.Initialize();
            _ = Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
            Application.Run(new CPanel());
        }
    }
}
