namespace People
{
    using System;
    public class People
    {
        public static void Main()
        {
            var female = new Human();
            female = female.ConfigureHuman(25);
            var male = new Human();
            male = male.ConfigureHuman(26);
            Console.WriteLine(female);
            Console.WriteLine(male);
        }
    }
}