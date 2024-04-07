namespace bridge
{
    class Circle : Shape
    {
        public Circle(IDraw drawAPI) : base(drawAPI) { }

        public override void Draw()
        {
            Console.Write("Circle: ");
            drawAPI.DrawShape();
        }
    }
}