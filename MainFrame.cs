using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomMealApp
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadData();
        }

        private async void LoadData()
        {
            Recipe vRecipe = await ApiCaller.GetRandomMealAsync();
            name.Text = vRecipe.Name;
            instructions.Text = vRecipe.Instructions;

            var request = WebRequest.Create(vRecipe.Thumbnail);

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                thumbnail.Image = ResizeImage(Bitmap.FromStream(stream), thumbnail.Width, thumbnail.Height);
            }

            categoryTxt.Text = vRecipe.Category;
            areaTxt.Text = vRecipe.Area;
            tagsTxt.Text = vRecipe.Tags;

            StringBuilder vIngredientList = new StringBuilder();

            foreach (KeyValuePair<string, string> ingredient in vRecipe.Ingredients)
            {
                vIngredientList.AppendLine("*" + ingredient.Key + " - " + ingredient.Value);
            }

            ingredientsTxt.Text = vIngredientList.ToString();

            string vVideoId = vRecipe.YoutubeLink;
            vVideoId = vVideoId.Replace("https://www.youtube.com/watch?v=", "");

            var vEmbed = "<html><head>" +
            "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
            "</head><body>" +
            "<iframe width=\"700\" height=\"400\" src=\"{0}\"" +
            "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
            "</body></html>";
            this.youtube.DocumentText = string.Format(vEmbed, "https://www.youtube.com/embed/" + vVideoId);
        }

        private void GetMealButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
    }
}
