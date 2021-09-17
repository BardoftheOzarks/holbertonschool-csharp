using System;
using System.IO;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;

///<summary>Collection of methods for image manipulation</summary>
public class ImageProcessor
{
    ///<summary>inverts the colorscale of images</summary>
    public static void Inverse(string[] filenames)
    {
        //foreach (string file in filenames)
        //    CreateInverse(file);
        
        string[] current = Directory.GetFiles("./", "*.jpg");
        string[] images = Directory.GetFiles("images/", "*.jpg");
        int total = current.Length + images.Length;
        Parallel.ForEach (filenames, file => {
            CreateInverse(file);
        });
        while (current.Length != total)
            current = Directory.GetFiles("./", "*.jpg");
    }

    private static void CreateInverse(string file)
    {
        //read image
        Bitmap bmp = new Bitmap(file);

        //get image dimensions
        int width = bmp.Width;
        int height = bmp.Height;

        //change each pixel to inverse
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                //get pixel values
                Color pixel = bmp.GetPixel(x, y);

                //extract specific values
                int red = pixel.R;
                int green = pixel.G;
                int blue = pixel.B;

                //invert values
                red = 255 - red;
                green = 255 - green;
                blue = 255 - blue;

                //set new values to pixel
                bmp.SetPixel(x, y, Color.FromArgb(red, green, blue));
            }
        }
        //create new file name
        string name = string.Format("{0}_inverse{1}",
                                    Path.GetFileNameWithoutExtension(file),
                                    Path.GetExtension(file));
        //save new image
        bmp.Save(name);
    }

    ///<summary>Recreates an image in grayscale</summary>
    public static void Grayscale(string[] filenames)
    {
        //foreach (string file in filenames)
        //{
        //    CreateGrayscale(file);
        //}
        string[] current = Directory.GetFiles("./", "*.jpg");
        string[] images = Directory.GetFiles("images/", "*.jpg");
        int total = current.Length + images.Length;
        Parallel.ForEach (filenames, file => {
            CreateGrayscale(file);
        });
        //while (current.Length != total)
        //    current = Directory.GetFiles("./", "*.jpg");
    }

    private static void CreateGrayscale(string file)
    {
        //read image
        Bitmap bmp = new Bitmap(file);

        //get image dimensions
        int width = bmp.Width;
        int height = bmp.Height;

        //change each pixel to inverse
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                //get pixel values
                Color pixel = bmp.GetPixel(x, y);

                //extract specific values
                int red = pixel.R;
                int green = pixel.G;
                int blue = pixel.B;

                //get average
                int avg = (red + green + blue) / 3;

                //set new values to pixel
                bmp.SetPixel(x, y, Color.FromArgb(avg, avg, avg));
            }
        }
        //create new file name
        string name = string.Format("{0}_grayscale{1}",
                                    Path.GetFileNameWithoutExtension(file),
                                    Path.GetExtension(file));
        //save new image
        bmp.Save(name);
    }

    ///<summary>Reproduces image with only black and white pixels based on set threshold</summary>
    public static void BlackWhite(string[] filenames, double threshold)
    {
        //foreach (string file in filenames)
        //{
        //    CreateBlackWhite(file, threshold);
        //}
        string[] current = Directory.GetFiles("./", "*.jpg");
        string[] images = Directory.GetFiles("images/", "*.jpg");
        int total = current.Length + images.Length;
        Parallel.ForEach (filenames, file => {
            CreateBlackWhite(file, threshold);
        });
        while (current.Length != total)
            current = Directory.GetFiles("./", "*.jpg");
    }
    
    private static void CreateBlackWhite(string file, double threshold)
    {
        //read image
        Bitmap bmp = new Bitmap(file);

        //get image dimensions
        int width = bmp.Width;
        int height = bmp.Height;

        //change each pixel to inverse
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                //get pixel values
                Color pixel = bmp.GetPixel(x, y);

                //extract specific value
                int red = pixel.R;
                int green = pixel.G;
                int blue = pixel.B;

                //obtain average
                int avg = (red + green + blue) / 3;

                //divide black and white pixels
                if (avg >= threshold)
                {
                    avg = 255;
                }
                else
                {
                    avg = 0;
                }

                //set new values to pixel
                bmp.SetPixel(x, y, Color.FromArgb(avg, avg, avg));
            }
        }
        //create new file name
        string name = string.Format("{0}_bw{1}",
                                    Path.GetFileNameWithoutExtension(file),
                                    Path.GetExtension(file));
        //save new image
        bmp.Save(name);
    }

    ///<summary>Creates a thumbnail of an image at the specified height</summary>
    public static void Thumbnail(string[] filenames, int height)
    {
        //foreach (string file in filenames)
        //{
        //    CreateThumbnail(file, height);
        //}
        string[] current = Directory.GetFiles("./", "*.jpg");
        string[] images = Directory.GetFiles("images/", "*.jpg");
        int total = current.Length + images.Length;
        Parallel.ForEach (filenames, file => {
            CreateThumbnail(file, height);
        });
        while (current.Length != total)
            current = Directory.GetFiles("./", "*.jpg");
    }

    private static void CreateThumbnail(string file, int newHeight)
    {
        //read image
        Bitmap bmp = new Bitmap(file);

        //get image dimensions
        int width = bmp.Width;
        int height = bmp.Height;

        //determine new width
        int newWidth = (width * newHeight) / height;

        //create new image
        Image thumb = bmp.GetThumbnailImage(newWidth, newHeight, null, IntPtr.Zero);

        //create new file name
        string name = string.Format("{0}_th{1}",
                                    Path.GetFileNameWithoutExtension(file),
                                    Path.GetExtension(file));
        //save new image
        thumb.Save(name);
    }
}