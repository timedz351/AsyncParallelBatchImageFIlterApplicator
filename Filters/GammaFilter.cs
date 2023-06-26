using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

namespace Projekt.Filters
{
    internal class GammaFilter : IFilter
    {
        public string Name => "Gamma";

        public void Apply(Image<Rgba32> image, int strength, SixLabors.ImageSharp.Rectangle rectangle)
        {
            image.ProcessPixelRows(accessor =>
            {
                for (int y = 0; y < accessor.Height; y++)
                {
                    Span<Rgba32> pixelRow = accessor.GetRowSpan(y);

                    for (int x = 0; x < pixelRow.Length; x++)
                    {
                        ref Rgba32 pixel = ref pixelRow[x];

                        pixel.R = FilterByteOperations.ComputeGamma(pixel.R, strength);
                        pixel.G = FilterByteOperations.ComputeGamma(pixel.G, strength);
                        pixel.B = FilterByteOperations.ComputeGamma(pixel.B, strength);
                    }
                }
            });
        }
    }
}
