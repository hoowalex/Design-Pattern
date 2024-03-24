namespace Cloneable
{
    public class Virus : ICloneable
    {
        private double weight;
        private int age;
        private string name;
        private string species;
        private List<Virus> children;

        public Virus(double weight, int age, string name, string species)
        {
            this.weight = weight;
            this.age = age;
            this.name = name;
            this.species = species;
            this.children = new List<Virus>();
        }

        public void AddChild(Virus child)
        {
            children.Add(child);
        }

        public object Clone()
        {
            try
            {
                Virus cloned = (Virus)this.MemberwiseClone();
                cloned.children = new List<Virus>(); 
                foreach (var child in this.children)
                {
                    cloned.children.Add((Virus)child.Clone()); 
                    return cloned;
                }
                return cloned;
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong");
                return "";
            }
        }

        public int GetAge()
        {
            return age;
        }
    }
}
