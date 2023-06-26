using Projekt.Filters;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
namespace Projekt
{
    public class FilterImageObject
    {
        public string Path { get;} = String.Empty;
        public string Name = String.Empty;
        public Image<Rgba32> ImageObject { get; set; }
        
        
        public FilterImageObject(string Path)
        {
            this.Path = Path;
            Name = System.IO.Path.GetFileNameWithoutExtension(Path);
        }

        public async void SaveAsync(string outputPath)
        {
            await ImageExtensions.SaveAsPngAsync(ImageObject, outputPath);
        }
        public async Task<Image<Rgba32>> LoadAsync()
        {
            ImageObject = await SixLabors.ImageSharp.Image.LoadAsync<Rgba32>(Path);
            return ImageObject;
        }

        public async Task ApplyFilterParallelAsync(IFilter filter, int strength)
        {
            int h = ImageObject.Height / 2;
            int w = ImageObject.Width / 2;

            int hUneven = ImageObject.Height % 2 == 1 ? h+1 : h;
            int wUneven = ImageObject.Width % 2 == 1 ? w+1 : w;

            // Rectangle(x, y, x-range, y-range)
            SixLabors.ImageSharp.Rectangle coords1 = new(0, 0, w, h);
            SixLabors.ImageSharp.Rectangle coords2 = new(w, 0, wUneven, h);
            SixLabors.ImageSharp.Rectangle coords3 = new(0, h, w, hUneven);
            SixLabors.ImageSharp.Rectangle coords4 = new(w, h, wUneven, hUneven);

            List<Task> tasks = new();
            tasks.Add(Task.Run(() => filter.Apply(ImageObject, strength, coords1)));
            tasks.Add(Task.Run(() => filter.Apply(ImageObject, strength, coords2)));
            tasks.Add(Task.Run(() => filter.Apply(ImageObject, strength, coords3)));
            tasks.Add(Task.Run(() => filter.Apply(ImageObject, strength, coords4)));

            await Task.WhenAll(tasks);
        }

        public void Dispose()
        {
            ImageObject.Dispose();
        }
    }
    
}
