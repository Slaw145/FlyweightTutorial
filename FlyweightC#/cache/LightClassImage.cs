using System;
using System.Collections.Generic;
using System.Text;

namespace Cache
{
    class Imagepng: Images
    {
        public Imagepng(string NameImage) : base(NameImage, ".png") { }
    }

    class Imagejpeg : Images
    {
        public Imagejpeg(string NameImage) : base(NameImage, ".jpeg") { }
    }

    class Imagejpg : Images
    {
        public Imagejpg(string NameImage) : base(NameImage, ".jpg") { }
    }
}
