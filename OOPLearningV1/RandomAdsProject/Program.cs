using System;

namespace RandomAdsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many ads do u want to generate?");
            int count = int.Parse(Console.ReadLine());
            for(int i =0; i<count;i++)
            {
                Ads randomAds = new Ads();
                randomAds.GenerateRandomAds();
            }
        }
    }
}
