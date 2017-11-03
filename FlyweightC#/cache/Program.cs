using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Threading;

namespace Cache
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wyswietl strone devman.pl");

            Console.WriteLine("Zapisz dane do pamieci cache");

            string image1 = "obrazek1.jpg";
            string image2 = "obrazek2.png";
            string image3 = "obrazek3.png";
            string image4 = "obrazek4.jpeg";
            string image5 = "obrazek2.png";
            string image6 = "obrazek3.jpg";

            string[] images = new string[] { image1, image2, image3, image4, image5, image6 };

            ImagesFactory factoryimages = new ImagesFactory();

            for (int i = 0; i < images.Length; i++)
            {
                Images letter = factoryimages.SaveImage(images[i]);
                letter.DisplayTextImage();
            }

            Console.WriteLine("Zamknij strone devman.pl");

            Console.WriteLine("Wyswietl ponownie strone devman.pl");

            Console.WriteLine("Na stronie sa takie obrazki");

            foreach (Images imagesTypes in factoryimages.imagesList.Values)
            {
                Console.WriteLine(imagesTypes.NameImage+" typ formatu obrazka "+ imagesTypes.TypeImage);
            }

            Console.WriteLine("Liczba obrazkow o takich samych nazwach i koncowkach "+ factoryimages.NumberRepeatingImages);

            Console.ReadKey();
        }
    }
}
