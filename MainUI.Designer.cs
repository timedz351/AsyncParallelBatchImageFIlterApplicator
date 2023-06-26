namespace Projekt
{
    partial class MainUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.LoadImagesButton = new System.Windows.Forms.Button();
            this.loadImagesLabel = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.filterSelectBox = new System.Windows.Forms.ComboBox();
            this.applyFilterButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.statusText = new System.Windows.Forms.Label();
            this.trackBarValueLabel = new System.Windows.Forms.Label();
            this.chooseFilterLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.previewPicBox = new System.Windows.Forms.PictureBox();
            this.tablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.origImgLabel = new System.Windows.Forms.Label();
            this.editedImgLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewPicBox)).BeginInit();
            this.tablePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoadImagesButton
            // 
            this.LoadImagesButton.Location = new System.Drawing.Point(21, 68);
            this.LoadImagesButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.LoadImagesButton.Name = "LoadImagesButton";
            this.LoadImagesButton.Size = new System.Drawing.Size(238, 60);
            this.LoadImagesButton.TabIndex = 0;
            this.LoadImagesButton.Text = "Load Images";
            this.LoadImagesButton.UseVisualStyleBackColor = true;
            this.LoadImagesButton.Click += new System.EventHandler(this.LoadImageButton_Click);
            // 
            // loadImagesLabel
            // 
            this.loadImagesLabel.AutoSize = true;
            this.loadImagesLabel.Location = new System.Drawing.Point(19, 26);
            this.loadImagesLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.loadImagesLabel.Name = "loadImagesLabel";
            this.loadImagesLabel.Size = new System.Drawing.Size(433, 30);
            this.loadImagesLabel.TabIndex = 1;
            this.loadImagesLabel.Text = "Select images you would like to apply filter to";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFilesDialog";
            this.openFileDialog.InitialDirectory = "\"../../../BigDataSet\"";
            this.openFileDialog.Multiselect = true;
            // 
            // filterSelectBox
            // 
            this.filterSelectBox.CausesValidation = false;
            this.filterSelectBox.DisplayMember = "Name";
            this.filterSelectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterSelectBox.FormattingEnabled = true;
            this.filterSelectBox.Location = new System.Drawing.Point(22, 184);
            this.filterSelectBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.filterSelectBox.Name = "filterSelectBox";
            this.filterSelectBox.Size = new System.Drawing.Size(235, 38);
            this.filterSelectBox.TabIndex = 3;
            this.filterSelectBox.SelectedIndexChanged += new System.EventHandler(this.FilterTypeBox_SelectedIndexChanged);
            // 
            // applyFilterButton
            // 
            this.applyFilterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.applyFilterButton.BackColor = System.Drawing.Color.Transparent;
            this.applyFilterButton.Location = new System.Drawing.Point(22, 856);
            this.applyFilterButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.applyFilterButton.Name = "applyFilterButton";
            this.applyFilterButton.Size = new System.Drawing.Size(238, 66);
            this.applyFilterButton.TabIndex = 5;
            this.applyFilterButton.Text = "Apply";
            this.applyFilterButton.UseVisualStyleBackColor = false;
            this.applyFilterButton.Click += new System.EventHandler(this.ApplyFilterButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(310, 874);
            this.progressBar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(667, 36);
            this.progressBar.TabIndex = 8;
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.InitialDirectory = "\"../../../BigDataSet\"";
            // 
            // trackBar
            // 
            this.trackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar.LargeChange = 25;
            this.trackBar.Location = new System.Drawing.Point(283, 168);
            this.trackBar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.trackBar.Maximum = 100;
            this.trackBar.Minimum = -100;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(667, 80);
            this.trackBar.SmallChange = 5;
            this.trackBar.TabIndex = 9;
            this.trackBar.Scroll += new System.EventHandler(this.TrackBar_Scroll);
            this.trackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TrackBar_MouseUp);
            // 
            // statusText
            // 
            this.statusText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.statusText.AutoSize = true;
            this.statusText.Location = new System.Drawing.Point(22, 954);
            this.statusText.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(216, 30);
            this.statusText.TabIndex = 10;
            this.statusText.Text = "X images were loaded";
            // 
            // trackBarValueLabel
            // 
            this.trackBarValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarValueLabel.AutoSize = true;
            this.trackBarValueLabel.Location = new System.Drawing.Point(960, 176);
            this.trackBarValueLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.trackBarValueLabel.Name = "trackBarValueLabel";
            this.trackBarValueLabel.Size = new System.Drawing.Size(24, 30);
            this.trackBarValueLabel.TabIndex = 11;
            this.trackBarValueLabel.Text = "0";
            // 
            // chooseFilterLabel
            // 
            this.chooseFilterLabel.AutoSize = true;
            this.chooseFilterLabel.Location = new System.Drawing.Point(21, 148);
            this.chooseFilterLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.chooseFilterLabel.Name = "chooseFilterLabel";
            this.chooseFilterLabel.Size = new System.Drawing.Size(130, 30);
            this.chooseFilterLabel.TabIndex = 12;
            this.chooseFilterLabel.Text = "Choose filter";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(486, 553);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // previewPicBox
            // 
            this.previewPicBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewPicBox.Image = ((System.Drawing.Image)(resources.GetObject("previewPicBox.Image")));
            this.previewPicBox.Location = new System.Drawing.Point(501, 6);
            this.previewPicBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.previewPicBox.Name = "previewPicBox";
            this.previewPicBox.Size = new System.Drawing.Size(486, 553);
            this.previewPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.previewPicBox.TabIndex = 14;
            this.previewPicBox.TabStop = false;
            // 
            // tablePanel
            // 
            this.tablePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePanel.ColumnCount = 2;
            this.tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanel.Controls.Add(this.pictureBox1, 0, 0);
            this.tablePanel.Controls.Add(this.previewPicBox, 1, 0);
            this.tablePanel.Location = new System.Drawing.Point(21, 288);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.RowCount = 1;
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanel.Size = new System.Drawing.Size(992, 565);
            this.tablePanel.TabIndex = 15;
            // 
            // origImgLabel
            // 
            this.origImgLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.origImgLabel.AutoSize = true;
            this.origImgLabel.Location = new System.Drawing.Point(21, 244);
            this.origImgLabel.Name = "origImgLabel";
            this.origImgLabel.Size = new System.Drawing.Size(155, 30);
            this.origImgLabel.TabIndex = 16;
            this.origImgLabel.Text = "Original Image:";
            // 
            // editedImgLabel
            // 
            this.editedImgLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.editedImgLabel.AutoSize = true;
            this.editedImgLabel.Location = new System.Drawing.Point(522, 244);
            this.editedImgLabel.Name = "editedImgLabel";
            this.editedImgLabel.Size = new System.Drawing.Size(169, 30);
            this.editedImgLabel.TabIndex = 17;
            this.editedImgLabel.Text = "Image with filter:";
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 1021);
            this.Controls.Add(this.origImgLabel);
            this.Controls.Add(this.editedImgLabel);
            this.Controls.Add(this.tablePanel);
            this.Controls.Add(this.chooseFilterLabel);
            this.Controls.Add(this.trackBarValueLabel);
            this.Controls.Add(this.statusText);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.applyFilterButton);
            this.Controls.Add(this.filterSelectBox);
            this.Controls.Add(this.loadImagesLabel);
            this.Controls.Add(this.LoadImagesButton);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MinimumSize = new System.Drawing.Size(1080, 1085);
            this.Name = "MainUI";
            this.Text = "Batch Image Filter Applicator";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewPicBox)).EndInit();
            this.tablePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button LoadImagesButton;
        private Label loadImagesLabel;
        private OpenFileDialog openFileDialog;
        private ComboBox filterSelectBox;
        private Button applyFilterButton;
        private ProgressBar progressBar;
        private FolderBrowserDialog folderBrowserDialog;
        private TrackBar trackBar;
        private Label statusText;
        private Label trackBarValueLabel;
        private Label chooseFilterLabel;
        private PictureBox pictureBox1;
        private PictureBox previewPicBox;
        private TableLayoutPanel tablePanel;
        private Label origImgLabel;
        private Label editedImgLabel;
    }
}