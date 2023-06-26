using Projekt.Filters;
namespace Projekt
{
    public partial class MainUI : Form
    {
        private bool mouseUp = false;
        public FilterController filterControl = new();

        private SixLabors.ImageSharp.Image _previewImage;

        private SixLabors.ImageSharp.Image PreviewImage
        {
            get => _previewImage;
            set
            {
                previewPicBox.Image?.Dispose();
                _previewImage?.Dispose();

                _previewImage = value;
                previewPicBox.Image = value.ToSystemDrawing();
            }
        }
        private IFilter Filter => filterSelectBox.SelectedItem as IFilter;
        private IFilter[] AvailableFilters { get; } = typeof(Program).Assembly.GetTypes()
        .Where(x =>
                !x.IsAbstract &&
                typeof(IFilter).IsAssignableFrom(x) &&
                x.GetConstructor(Type.EmptyTypes) is not null)
            .Select(x => Activator.CreateInstance(x) as IFilter)
            .OrderBy(x => x.Name)
            .ToArray();


        public MainUI()
        {
            InitializeComponent();
            filterSelectBox.DataSource = AvailableFilters;
            HideElements();
        }

        private async void LoadImageButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog()
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;"

            };
            openFileDialog.Multiselect = true;

            while (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("No images selected, please select at least one.");

            }
            statusText.Show();
            LoadImagesButton.Enabled = false;
            statusText.Text = "Loading images...";
            await filterControl.InitLoadAsync(openFileDialog.FileNames);
            LoadImagesButton.Enabled = true;

            ShowElements();
            applyFilterButton.Enabled = true;

            int n = openFileDialog.FileNames.Length;
            if (n == 1)
            {
                statusText.Text = $"1 image was loaded";
            }
            else
            {
                statusText.Text = $"{n} images were loaded";
            }
        }


        private async void ApplyFilterButton_Click(object sender, EventArgs e)
        {
            applyFilterButton.Enabled = false;
            LoadImagesButton.Enabled = false;

            Progress<ProgressModel> progress = new();
            progress.ProgressChanged += ReportProgress;

            statusText.Text = "Applying filter...";
            LoadImagesButton.Enabled = false;
            await filterControl.ProcessImagesAsync(trackBar.Value, Filter, progress);

            string path;
            if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
            {
                path = filterControl.WorkingDirectory + "\\Output";
                MessageBox.Show($"Error while choosing save directory, images will be saved to {path}");
            } else
            {
                path = folderBrowserDialog.SelectedPath;
            }

            statusText.Show();
            statusText.Text = "Saving...";
            await filterControl.SaveImagesParallelAsync(path);

            MessageBox.Show($"Saved to: {path}");
            statusText.Hide();
            LoadImagesButton.Enabled = true;

            if (MessageBox.Show("Do you wish to apply another filter to loaded images?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                HideElements();
                filterControl.Dispose();
            } else
            {
                applyFilterButton.Enabled = true;
            }
            progressBar.Value = 0;
            LoadImagesButton.Enabled = true;
        }
        private async void FilterTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            applyFilterButton.Show();

            if (filterSelectBox.Text == "Grayscale")
            {
                trackBar.Hide();
                trackBarValueLabel.Hide();
                PreviewImage = await ChangePreview(Filter, trackBar.Value);

            }
            else if (filterSelectBox.Text == "Gamma")
            {
                trackBar.Show();
                trackBar.Minimum = 0;
                trackBar.Value = 0;
                trackBarValueLabel.Text = "0";
                trackBarValueLabel.Show();
            }
            else
            {
                trackBar.Value = 0;
                trackBarValueLabel.Text = "0";
                trackBar.Show();
                trackBar.Minimum = -100;
                trackBarValueLabel.Show();
            }

        }

        private void ReportProgress(object? sender, ProgressModel e)
        {
            progressBar.Value = (int)e.CurrentPercantage;
        }

        private void TrackBar_Scroll(object sender, EventArgs e)
        {
            mouseUp = true;
            trackBarValueLabel.Text = trackBar.Value.ToString();

        }

        private async void TrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            if (mouseUp)
            {
                mouseUp = false;
                PreviewImage = await ChangePreview(Filter, trackBar.Value);
            }
        }

        private async Task<SixLabors.ImageSharp.Image> ChangePreview(IFilter filter, int strength)
        {
            var result = await filterControl.ProcessPreview(filterControl.WorkingDirectory + "/previewImages/preview.jpg", Filter, strength);
            return result;
        }

        private void HideElements()
        {
            applyFilterButton.Hide();
            filterSelectBox.Hide();
            progressBar.Hide();
            statusText.Hide();
            trackBarValueLabel.Hide();
            trackBar.Hide();
            chooseFilterLabel.Hide();
            tablePanel.Hide();
            origImgLabel.Hide();
            editedImgLabel.Hide();
        }
        private void ShowElements()
        {
            filterSelectBox.Show();
            trackBar.Show();
            applyFilterButton.Show();
            tablePanel.Show();
            trackBarValueLabel.Show();
            trackBar.Show();
            chooseFilterLabel.Show();
            progressBar.Show();
            origImgLabel.Show();
            editedImgLabel.Show();
        }
    }
}