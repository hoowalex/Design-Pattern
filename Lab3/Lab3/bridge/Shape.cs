namespace bridge
{
    abstract class Shape
    {
        protected IDraw drawAPI;

        protected Shape(IDraw drawAPI)
        {
            this.drawAPI = drawAPI;
        }

        public abstract void Draw();
    }
}