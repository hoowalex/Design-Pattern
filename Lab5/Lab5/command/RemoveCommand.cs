using lightHtml;

namespace command
{
    public class RemoveCommand : ICommand
    {
        private LightElementNode parent;
        private LightNode child;

        public RemoveCommand(LightElementNode parent, LightNode child)
        {
            this.parent = parent;
            this.child = child;
        }

        public void Execute()
        {
            parent.Remove(child);
        }

        public void Cancel()
        {
            parent.Add(child);
        }
    }
}