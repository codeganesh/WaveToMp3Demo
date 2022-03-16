using NAudio.Wave;
using NAudio.Lame;
using System.Diagnostics;

namespace WaveToMp3Demo
{
    public partial class Form1 : Form
    {
        private string inputFile;
        private string outputFile;
        public Form1()
        {
            InitializeComponent();
        }

        private void ChooseFileButton_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Wave files | *.wav";
            if (dialog.ShowDialog() != DialogResult.OK)
                return;
            inputFile = InputFileTextBox.Text = dialog.FileName;
        }

        private void SetOutputButton_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "MP3 files | *.mp3";
            if (dialog.ShowDialog() != DialogResult.OK)
                return;
            outputFile = OutputFileTextBox.Text = dialog.FileName;
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            if (inputFile == null || outputFile == null)
                return;

            using (var reader = new AudioFileReader(inputFile))
            using (var writer = new LameMP3FileWriter(outputFile, reader.WaveFormat, 128))
                reader.CopyTo(writer);

            var startInfo = new ProcessStartInfo
            {
                FileName = Path.GetDirectoryName(outputFile),
                UseShellExecute = true
            };

            Process.Start(startInfo);
        }
    }
}