namespace Cache
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("View website devman.pl");

            Console.WriteLine("Save the data to the cache memory");

            string image1 = "image1.jpg";
            string image2 = "image2.png";
            string image3 = "image3.png";
            string image4 = "image4.jpeg";
            string image5 = "image2.png";
            string image6 = "image3.jpg";

            string[] images = new string[] { image1, image2, image3, image4, image5, image6 };

            ImagesFactory factoryimages = new ImagesFactory();

            for (int i = 0; i < images.Length; i++)
            {
                Images letter = factoryimages.SaveImage(images[i]);
                letter.DisplayTextImage();
            }

            Console.WriteLine("Close the devman.pl website");

            Console.WriteLine("Display the devman.pl page again");

            Console.WriteLine("There are such pictures on the site");

            foreach (Images imagesTypes in factoryimages.imagesList.Values)
            {
                Console.WriteLine(imagesTypes.NameImage + " type of image format " + imagesTypes.TypeImage);
            }

            Console.WriteLine("The number of pictures with the same names and endings: " + factoryimages.NumberRepeatingImages);

            Console.ReadKey();
        }
    }
}
