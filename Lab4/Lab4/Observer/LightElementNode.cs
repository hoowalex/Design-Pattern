namespace observer
{
    public class LightElementNode : LightNode
    {
        public string TagName { get; }
        public string DisplayType { get; }
        public string ClosingType { get; }
        public List<string> Classes { get; }
        public List<LightNode> Children { get; }
        private Dictionary<string, List<Action>> EventListeners { get; }

        public LightElementNode(string tagName, string displayType, string closingType, List<string> classes, List<LightNode> children)
        {
            TagName = tagName;
            DisplayType = displayType;
            ClosingType = closingType;
            Classes = classes;
            Children = children;
            EventListeners = new Dictionary<string, List<Action>>();
        }

        public void AddEventListener(string eventName, Action callback)
        {
            if (!EventListeners.ContainsKey(eventName))
            {
                EventListeners[eventName] = new List<Action>();
            }
            EventListeners[eventName].Add(callback);
        }

        public void TriggerEvent(string eventName)
        {
            if (EventListeners.ContainsKey(eventName))
            {
                foreach (var callback in EventListeners[eventName])
                {
                    callback();
                }
            }
        }

        public override string InnerHTML()
        {
            return string.Join("", Children.ConvertAll(child => child.OuterHTML()));
        }

        public override string OuterHTML()
        {
            string classAttr = Classes.Count > 0 ? $" class=\"{string.Join(" ", Classes)}\"" : "";
            string openTag = $"<{TagName}{classAttr}>";
            string closeTag = ClosingType == "double" ? $"</{TagName}>" : "";
            return $"{openTag}{InnerHTML()}{closeTag}";
        }
    }

}