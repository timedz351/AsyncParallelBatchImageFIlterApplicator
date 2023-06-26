using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

namespace Projekt.Filters
{
    public interface IFilter
    {
        string Name { get; }
        void Apply(Image<Rgba32> image, int strength, SixLabors.ImageSharp.Rectangle coords);
    }
}
