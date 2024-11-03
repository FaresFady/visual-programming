namespace Pictures
{
    public partial class Form1 : Form
    {
        private List<Image> images;
        private int currentIndex;

        public Form1()
        {
            InitializeComponent();
            LoadImages();
            DisplayImage();
        }

        private void LoadImages()
        {
            images = new List<Image>
            {
                Image.FromFile(@"E:\Wallpaper\Brain.jpg"),
                Image.FromFile(@"E:\Wallpaper\Itadori Yuji.jpg"),
                Image.FromFile(@"E:\Wallpaper\Tanjiro.jpg"),
                Image.FromFile(@"E:\Wallpaper\Sukuna 4.jpg"),
                Image.FromFile(@"E:\Wallpaper\Shingeki no kyojin.jpg"),
                Image.FromFile(@"E:\Wallpaper\Red Dead Redemption 2.jpg"),
            };
            currentIndex = 0;
        }

        private void DisplayImage()
        {
            if (images.Count > 0)
            {
                pictureBox2.Image = images[currentIndex];
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void previous_Click(object sender, EventArgs e)
        {
            if (images.Count > 0)
            {
                currentIndex = (currentIndex - 1 + images.Count) % images.Count;
                DisplayImage();
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (images.Count > 0)
            {
                currentIndex = (currentIndex + 1) % images.Count;
                DisplayImage();
            }
        }
    }
}