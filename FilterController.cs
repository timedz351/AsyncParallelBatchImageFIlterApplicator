using Projekt.Filters;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;


namespace Projekt
{
    public class FilterController
    {
        public List<FilterImageObject> imgObjects = new();
        public FilterController() { }
        public string WorkingDirectory { get; } = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;

        public async Task InitLoadAsync(string[] filePaths)
        {
            for (int i = 0; i < filePaths.Length; i++)
            {
                var imgObject = new FilterImageObject(filePaths[i]);
                imgObjects.Add(imgObject);
            }

            await LoadImagesParallelAsync();
        }

        private async Task LoadImagesParallelAsync()
        {
            List<Task<Image<Rgba32>>> tasks = new();

            foreach (var img in imgObjects)
            {
                tasks.Add(Task.Run(() => img.LoadAsync()));
            }
            await Task.WhenAll(tasks);
            tasks.Clear();
        }

        public async Task SaveImagesParallelAsync(string outputPath, string format = ".png")
        {
            List<Task> tasks = new();
            foreach (var image in imgObjects)
            {
                tasks.Add(Task.Run(() => image.SaveAsync(outputPath + "/" + image.Name + "_edit" + format)));
            }

            await Task.WhenAll(tasks);

        }

        public async Task ProcessImagesAsync(int strength, IFilter filter, IProgress<ProgressModel> progress)
        {
            List<Task> tasks = new();
            int nChunks = imgObjects.Count;

            if (nChunks >= 10)
            {
                nChunks /= 10;
            }
            var chunks = imgObjects.Chunk(nChunks);

            ProgressModel progressReport = new();

            foreach (var chunk in chunks)
            {
                foreach (var img in chunk)
                {
                    tasks.Add(Task.Run(() => img.ApplyFilterParallelAsync(filter, strength)));
                }
                await Task.WhenAll(tasks);

                progressReport.CurrentPercantage += 100 / (float)chunks.Count();
                progress.Report(progressReport);

            }
        }

        public async Task<SixLabors.ImageSharp.Image> ProcessPreview(string path, IFilter filter, int strength)
        {
            var previewImg = new FilterImageObject(path);
            await previewImg.LoadAsync();
            Task.Run(() => previewImg.ApplyFilterParallelAsync(filter, strength)).Wait();
            return previewImg.ImageObject;
        }
        public void Dispose()
        {
            foreach (var img in imgObjects)
            {
                img.Dispose();
            }
            imgObjects.Clear();
        }
    }
}
