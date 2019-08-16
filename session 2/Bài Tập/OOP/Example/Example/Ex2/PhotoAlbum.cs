using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Ex2
{
    class PhotoAlbum
    {
        private int numberOfPages;

        public PhotoAlbum()
        {
            numberOfPages = 16;
        }
        public PhotoAlbum(int number)
        {
            numberOfPages = number;
        }
        public int GetNumberOfPages()
        {
            return numberOfPages;
        }
    }
}
