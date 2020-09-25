using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();
            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEyeFilter;

            processor.Process("Photo.jpg", filterHandler);
        }

        //allows for developers to add custom filters 
        static void RemoveRedEyeFilter(Photo photo) 
        {
            Console.WriteLine("Apply remove red eye");
        }
    }
}
