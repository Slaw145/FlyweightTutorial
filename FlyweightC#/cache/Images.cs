using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Cache
{
    abstract class Images
    {
        public string NameImage;
        public string TypeImage;

        public Images(string NameImage, string TypeImage)
        {
            this.NameImage = NameImage;
            this.TypeImage = TypeImage;
        }
        
        public void DisplayTextImage()
        {
            Console.WriteLine("Obrazek nazywa sie: "+ NameImage + " o formacie" + TypeImage);
        }
    }
}
