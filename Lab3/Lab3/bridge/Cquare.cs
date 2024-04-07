namespace bridge
{
    class Square : Shape
    {
        public Square(IDraw drawAPI) : base(drawAPI) { }

        public override void Draw()
        {
            Console.Write("Square: ");
            drawAPI.DrawShape();
        }
    }
}