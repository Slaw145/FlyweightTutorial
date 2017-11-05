using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Cache
{
    class ImagesFactory
    {
        public readonly Dictionary<string, Images> imagesList = new Dictionary<string, Images>();

        Images images = null;

        Regex regex1 = new Regex(@".[^.]*$");
        Regex regex2 = new Regex(@".*(?=\.)");

        Match result1;
        Match result2;

        public int NumberRepeatingImages;

        public Images SaveImage(string GiveImages)
        {
            result1 = regex1.Match(GiveImages);
            result2 = regex2.Match(GiveImages);

            if (imagesList.Keys.Contains(GiveImages))
            {
                NumberRepeatingImages++;
                images = imagesList[GiveImages];
            }
            else
            {
                switch (result1.ToString())
                {
                    case ".png":
                        images = new Imagepng(result2.ToString());
                        break;
                    case ".jpg":
                        images = new Imagejpg(result2.ToString());
                        break;
                    case ".jpeg":
                        images = new Imagejpeg(result2.ToString());
                        break;
                }
                imagesList.Add(GiveImages, images);
            }

            return images;
        }
    }
}
