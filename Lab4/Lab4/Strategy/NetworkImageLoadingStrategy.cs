namespace strategy
{
    public class NetworkImageLoadingStrategy : IImageLoadingStrategy
    {
        public void LoadImage(string href)
        {
            Console.WriteLine($"Loading image from network: {href}");

            Console.WriteLine("Image loaded successfully!");
        }
    }
}