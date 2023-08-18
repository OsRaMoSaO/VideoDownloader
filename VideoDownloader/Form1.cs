using YoutubeExplode;
using YoutubeExplode.Videos;
using YoutubeExplode.Videos.Streams;
using YoutubeExtractor;


namespace VideoDownloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pathText.Text = @"C:\Users\" + Environment.UserName + @"\Downloads";
        }

        private async void downloadBtn_Click(object sender, EventArgs e)
        {
            string url = linkBox.Text;
            string outputDirectory = pathText.Text;

            await DownloadYouTubeVideo(url, outputDirectory);

            outText.Text = "Done!";
        }



        static async Task DownloadYouTubeVideo(string videoUrl, string outputDirectory)
        {

            var youtube = new YoutubeClient();

            var video = await youtube.Videos.GetAsync(videoUrl);

            // Sanitize the video title to remove invalid characters from the file name
            string sanitizedTitle = string.Join("_", video.Title.Split(Path.GetInvalidFileNameChars()));

            // Get all available muxed streams
            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(video.Id);
            var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
            //var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();


            try
            {
                var stream = await youtube.Videos.Streams.GetAsync(streamInfo);
                using var httpClient = new HttpClient();
                var datetime = DateTime.Now;



                await youtube.Videos.Streams.GetAsync(streamInfo);

                string outputFilePath = Path.Combine(outputDirectory, $"{sanitizedTitle}.{streamInfo.Container}");
                using var outputStream = File.Create(outputFilePath);
                await stream.CopyToAsync(outputStream);

                Console.WriteLine("Download completed!");
                Console.WriteLine($"Video saved as: {outputFilePath}{datetime}");
            }
            catch
            {
                Console.WriteLine($"No suitable video stream found for {video.Title}.");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog diag = new FolderBrowserDialog();
            if (diag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pathText.Text = diag.SelectedPath;
            }
            else
            {
                pathText.Text = @"C:\Users\" + Environment.UserName + @"\Downloads";
            }
        }
    }
}