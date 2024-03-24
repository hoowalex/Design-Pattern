namespace AbstractFactory
{
    public class Smartphone : IDevice{
        public new String GetType(){
            return "Smartphone";
        }
    }
}