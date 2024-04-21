namespace strategy
{
    public class Image
    {
        private readonly IImageLoadingStrategy loadingStrategy;

        public Image(IImageLoadingStrategy loadingStrategy)
        {
            this.loadingStrategy = loadingStrategy;
        }

        public void Load(string href)
        {
            loadingStrategy.LoadImage(href);
        }
    }
}