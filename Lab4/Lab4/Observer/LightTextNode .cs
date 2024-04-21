namespace observer
{
    public class LightTextNode : LightNode
    {
        public string Text { get; }

        public LightTextNode(string text)
        {
            Text = text;
        }

        public override string InnerHTML()
        {
            return Text;
        }

        public override string OuterHTML()
        {
            return Text;
        }
    }
}