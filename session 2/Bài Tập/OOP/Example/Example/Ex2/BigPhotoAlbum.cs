using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Ex2
{
    class BigPhotoAlbum
    {
        public int numberOfPages;
        public BigPhotoAlbum()
        {
            numberOfPages = 64;
        }
        public int GetNumberOfPages()
        {
            return numberOfPages;
        }
    }
}
