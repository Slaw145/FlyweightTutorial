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
            Console.WriteLine("The picture has name: " + NameImage + " about format " + TypeImage);
        }
    }
}
