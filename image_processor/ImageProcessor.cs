using System;
using System.IO;
using System.Drawing;
using System.Threading;

public class ImageProcessor
{
    ///<summary>Collection of methods for image manipulation</summary>

    public static void Inverse(string[] filenames)
    {
        ///<summary>inverts the colorscale of images</summary>
        foreach (string file in filenames)
            CreateInverse(file);
        //Thread[] threads = new Thread[filenames.Length];
        //Console.WriteLine($"Files: {filenames.Length}, Threads: {threads.Length}");
        //for (int i = 0; i < filenames.Length; i++)
        //{
        //    Console.WriteLine($"i = {i}");
        //    threads[i] = new Thread(() => CreateInverse(filenames[i]));
        //    threads[i].Start();
        //}
        //for (int i = 0; i < threads.Length; i++)
        //{
        //    threads[i].Join();
        //}
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

    public static void Grayscale(string[] filenames)
    {
        ///<summary>Recreates an image in grayscale</summary>
        foreach (string file in filenames)
        {
            CreateGrayscale(file);
        }
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

    public static void BlackWhite(string[] filenames, double threshold)
    {
        ///<summary>Reproduces image with only black and white pixels based on set threshold</summary>
        foreach (string file in filenames)
        {
            CreateBlackWhite(file, threshold);
        }
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

    public static void Thumbnail(string[] filenames, int height)
    {
        ///<summary>Creates a thumbnail of an image at the specified height</summary>
        foreach (string file in filenames)
        {
            CreateThumbnail(file, height);
        }
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