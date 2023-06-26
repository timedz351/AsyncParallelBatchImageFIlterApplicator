using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

namespace Projekt.Filters
{
    internal class GrayscaleFilter : IFilter
    {
        public string Name => "Grayscale";

        public void Apply(Image<Rgba32> image, int strength, SixLabors.ImageSharp.Rectangle coords)
        {
            image.ProcessPixelRows(accessor =>
            {
                for (int y = 0; y < accessor.Height; y++)
                {
                    Span<Rgba32> pixelRow = accessor.GetRowSpan(y);

                    for (int x = 0; x < pixelRow.Length; x++)
                    {
                        ref Rgba32 pixel = ref pixelRow[x];

                        var sum = pixel.R + pixel.G + pixel.B;
                        var res = (byte)(sum / 3);

                        pixel.R = res;
                        pixel.G = res;
                        pixel.B = res;

                    }
                }
            });
        }
    }
}
