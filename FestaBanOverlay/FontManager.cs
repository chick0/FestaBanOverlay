using System.Drawing.Text;

namespace FestaBanOverlay
{
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

        public Font ToFont(int fontId, float fontSize)
        {
            return new Font(
                pfc.Families[fontId],
                fontSize,
                FontStyle.Regular,
                GraphicsUnit.Point,
                129
            );
        }
    }
}
