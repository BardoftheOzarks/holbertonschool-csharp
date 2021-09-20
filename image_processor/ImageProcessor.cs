using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

///<summary>Collection of methods for image manipulation</summary>
public class ImageProcessor
{
    ///<summary>inverts the colorscale of images</summary>
    public static void Inverse(string[] filenames)
    {
        //foreach (string file in filenames)
        //    CreateInverse(file);

        //string[] current = Directory.GetFiles("./", "*.jpg");
        //string[] images = Directory.GetFiles("images/", "*.jpg");
        //int total = current.Length + images.Length;
        Parallel.ForEach (filenames, file => {
            CreateInverse(file);
        });
        //while (current.Length != total)
        //    current = Directory.GetFiles("./", "*.jpg");
    }

    private static void CreateInverse(string file)
    {
        Bitmap bmp = new Bitmap(file);
        BitmapData bitmapData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, bmp.PixelFormat);

        int bytesPerPixel = Bitmap.GetPixelFormatSize(bmp.PixelFormat) / 8;
        int byteCount = bitmapData.Stride * bmp.Height;
        byte[] pixels = new byte[byteCount];
        IntPtr ptrFirstPixel = bitmapData.Scan0;
        Marshal.Copy(ptrFirstPixel, pixels, 0, pixels.Length);
        int heightInPixels = bitmapData.Height;
        int widthInBytes = bitmapData.Width * bytesPerPixel;

        for (int y = 0; y < heightInPixels; y++)
        {
            int currentLine = y * bitmapData.Stride;
            for (int x = 0; x < widthInBytes; x = x + bytesPerPixel)
            {
                int oldBlue = pixels[currentLine + x];
                int oldGreen = pixels[currentLine + x + 1];
                int oldRed = pixels[currentLine + x + 2];

                // calculate new pixel value
                pixels[currentLine + x] = (byte)(255 - oldBlue);
                pixels[currentLine + x + 1] = (byte)(255 - oldGreen);
                pixels[currentLine + x + 2] = (byte)(255 - oldRed);
            }
        }
 
        // copy modified bytes back
        Marshal.Copy(pixels, 0, ptrFirstPixel, pixels.Length);
        bmp.UnlockBits(bitmapData);

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