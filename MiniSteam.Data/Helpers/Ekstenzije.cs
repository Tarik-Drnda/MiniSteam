using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MiniSteam.Data.Helpers
{
    public static class Ekstenzije
    {
        public static bool isValid(this string tekst)
        {
            return string.IsNullOrEmpty(tekst);
        }
        public static Image ToImage(this byte[] sadrzaj)
        {
            var ms=new MemoryStream(sadrzaj);
            return Image.FromStream(ms);

        }
        public static byte[] ToByteArray(this Image sadrzaj)
        {
            var ms = new MemoryStream();
            sadrzaj.Save(ms, ImageFormat.Jpeg);
            return ms.ToArray();
        }


    }
}
