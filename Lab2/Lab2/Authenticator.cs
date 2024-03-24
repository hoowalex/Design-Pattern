public class Authenticator
{
    private static Authenticator? instance;
    public string value;

    private Authenticator(string value)
    {
        this.value = value;
    }

    public static Authenticator GetInstance(string value)
    {
        if (instance == null)
        {
            instance = new Authenticator(value);
        }
        return instance;
    }
}
