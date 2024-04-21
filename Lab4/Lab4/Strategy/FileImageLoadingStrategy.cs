namespace strategy
{

    public class FileImageLoadingStrategy : IImageLoadingStrategy
    {
        public void LoadImage(string href)
        {
            Console.WriteLine($"Loading image from file system: {href}");

            Console.WriteLine("Image loaded successfully!");
        }
    }
}