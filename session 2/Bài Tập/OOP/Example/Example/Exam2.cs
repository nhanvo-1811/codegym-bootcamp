using System;
using System.Collections.Generic;
using System.Text;
using Example.Ex2;//Ten project.folder
namespace Example
{
    class Exam2
    {
        static void Main()
        {
            var wedding = new PhotoAlbum();
            Console.WriteLine(wedding.GetNumberOfPages());
        
            var trip = new PhotoAlbum(30);
            Console.WriteLine(trip.GetNumberOfPages());

            var family = new BigPhotoAlbum();
            Console.WriteLine(family.GetNumberOfPages());

        }
    }
}
