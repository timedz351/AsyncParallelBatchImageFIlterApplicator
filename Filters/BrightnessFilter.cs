using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

namespace Projekt.Filters
{
    internal class BrightnessFilter : IFilter
    {
        public string Name => "Brightness";

        public void Apply(Image<Rgba32> image, int strength, SixLabors.ImageSharp.Rectangle coords)
        {
            int startY = coords.Y;
            int startX = coords.X;
            int ySpan = coords.Height;
            int xSpan = coords.Width;

            image.ProcessPixelRows(accessor =>
            {
                for (int y = startY; y < (coords.Y + ySpan); y++)
                {
                    Span<Rgba32> pixelRow = accessor.GetRowSpan(y);

                    for (int x = startX; x < (coords.X + xSpan); x++)
                    {
                        ref Rgba32 pixel = ref pixelRow[x];

                        pixel.R = FilterByteOperations.Addition(pixel.R, strength);
                        pixel.G = FilterByteOperations.Addition(pixel.G, strength);
                        pixel.B = FilterByteOperations.Addition(pixel.B, strength);

                    }
                }
            });
        }
    }
}
