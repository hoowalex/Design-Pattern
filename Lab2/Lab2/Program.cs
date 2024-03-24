using FactoryMethod;
using AbstractFactory;
using AbstractFactory.Factory;
using Cloneable;
using Builder;


public class Program
{

    public static void Main()
    {
        //task1
        ISubscriptionFactory webSite = new WebSite();
        ISubscriptionFactory mobileApp = new MobileApp();
        ISubscriptionFactory managerCall = new ManagerCall();

        ISubscription domesticSubscription = webSite.CreateSubscription(1, 2, new List<string>());
        ISubscription educationalSubscription = mobileApp.CreateSubscription(3, 4, new List<string>());
        ISubscription premiumSubscription = managerCall.CreateSubscription(5, 6, new List<string>());

        Console.WriteLine(domesticSubscription.GetMonthlyFee());
        Console.WriteLine(educationalSubscription.GetMonthlyFee());
        Console.WriteLine(premiumSubscription.GetMonthlyFee());



        //task2
        IDeviceFactory iphoneFactory = new IphoneFactory();
        IDeviceFactory galaxyFactory = new SumsungFactory();
        IDeviceFactory xiaomiFactory = new XiaomiFactory();

        IDevice IphoneLaptop = iphoneFactory.CreateLaptop();
        IDevice IphoneNetbook = iphoneFactory.CreateNetbook();

        Console.WriteLine(IphoneLaptop);
        Console.WriteLine(IphoneNetbook);



        //task3
        Authenticator auth1 = Authenticator.GetInstance("value1");
        Authenticator auth2 = Authenticator.GetInstance("value2");

        Console.WriteLine(auth2.Equals(auth1));
        Console.WriteLine(auth2.value);



        //task4
        Virus mainvirus = new Virus(1, 1, "vir1", "v1");
        mainvirus.AddChild(new Virus(2, 2, "vir2", "v2"));
        mainvirus.AddChild(new Virus(3, 3, "vir3", "v3"));

        Virus clonedvirus = (Virus)mainvirus.Clone();
        Console.WriteLine(mainvirus);
        Console.WriteLine(clonedvirus);



        //task5
        Director director = new Director();
        Character hero = director.CreateCharacter(new HeroBuilder(), "Hoow", "Stront", "Bow");


        Character enemy = director.CreateCharacter(new EnemyBuilder(), "Hooxie", "Fast", "Sword");
        Console.WriteLine(enemy.GetName());
        Console.WriteLine(hero.GetName());

    }

}
