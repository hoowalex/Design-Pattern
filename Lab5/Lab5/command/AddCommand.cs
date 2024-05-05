using lightHtml;

namespace command
{
    public class AddCommand : ICommand
    {
        private LightElementNode parent;
        private LightNode child;

        public AddCommand(LightElementNode parent, LightNode child)
        {
            this.parent = parent;
            this.child = child;
        }

        public void Execute()
        {
            parent.Add(child);
        }

        public void Cancel()
        {
            parent.Remove(child);
        }
    }
}