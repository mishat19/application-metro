using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Reflection;

namespace application_metro
{
    public static class FontLoader
    {
        private static Dictionary<string, FontFamily> loadedFonts = new Dictionary<string, FontFamily>();
        private static PrivateFontCollection fontCollection = new PrivateFontCollection();

        public static Font GetFont(string fontName, float size, FontStyle style = FontStyle.Regular)
        {
            if (!loadedFonts.ContainsKey(fontName))
            {
                LoadFontFromResource(fontName);
            }

            return new Font(loadedFonts[fontName], size, style);
        }

        private static void LoadFontFromResource(string fontName)
        {
            string resourcePath = fontName switch
            {
                "DynaPuff" => "application_metro.Fonts.DynaPuff-Regular.ttf",
                "Gliker" => "application_metro.Fonts.Gliker-Regular.ttf",
                _ => throw new ArgumentException("Police inconnue : " + fontName)
            };

            Assembly asm = Assembly.GetExecutingAssembly();
            using (Stream stream = asm.GetManifestResourceStream(resourcePath))
            {
                if (stream == null)
                    throw new FileNotFoundException("Police non trouvée dans les ressources : " + resourcePath);

                byte[] data = new byte[stream.Length];
                stream.Read(data, 0, data.Length);

                IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(data.Length);
                System.Runtime.InteropServices.Marshal.Copy(data, 0, fontPtr, data.Length);
                fontCollection.AddMemoryFont(fontPtr, data.Length);

                // Récupère le nom réel de la famille typographique
                loadedFonts[fontName] = fontCollection.Families[fontCollection.Families.Length - 1];
            }
        }
    }
}
