using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Png;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public static class ImageSharpExtension
    {
        // Borrowed from lecture demo
        public static System.Drawing.Image ToSystemDrawing(this SixLabors.ImageSharp.Image image)
        {
            if (image is null)
                return null;

            using MemoryStream ms = new();
            image.Save(ms, Configuration.Default.ImageFormatsManager.FindEncoder(PngFormat.Instance));
            ms.Position = 0;
            return System.Drawing.Image.FromStream(ms);
        }
    }
}
