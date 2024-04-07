namespace bridge
{
    class Triangle : Shape
    {
        public Triangle(IDraw drawAPI) : base(drawAPI) { }

        public override void Draw()
        {
            Console.Write("Triangle: ");
            drawAPI.DrawShape();
        }
    }
}