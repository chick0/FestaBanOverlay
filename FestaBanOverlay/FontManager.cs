using System.Drawing.Text;

namespace FestaBanOverlay
{
    internal enum FontId
    {
        Default = 0,
        Light = 1,
        Black = 2
    }

    internal class FontManager
    {
        public PrivateFontCollection pfc = new();

        public FontManager()
        {
            string BaseDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources");

            string Bold = Path.Combine(BaseDir, "Pretendard-Black.ttf");
            string Regular = Path.Combine(BaseDir, "Pretendard-Regular.ttf");
            string Light = Path.Combine(BaseDir, "Pretendard-Light.ttf");

            pfc.AddFontFile(Bold);
            pfc.AddFontFile(Regular);
            pfc.AddFontFile(Light);
        }

        private FontFamily GetFont(FontId fontId)
        {
            FontFamily font = pfc.Families[0];
            string fontName = fontId == FontId.Default ? "Pretendard" : fontId == FontId.Light ? "Pretendard Light" : "Pretendard Black";

            foreach (FontFamily tmp in pfc.Families)
            {
                if (fontName == tmp.Name)
                {
                    font = tmp;
                }
            }

            return font;
        }

        public Font ToFont(FontId fontId, float fontSize)
        {
            return new Font(
                GetFont(fontId),
                fontSize,
                FontStyle.Regular
            );
        }
    }
}
