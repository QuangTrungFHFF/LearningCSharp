using System;
using System.Collections.Generic;

namespace RandomAdsProject
{
    internal class Ads
    {
        private readonly List<string> laudatoryPhrases = new List<string> { "The product is excellent.", "This is a great product.", "I use this product constantly.", "This is the best product from this category." };
        private readonly List<string> laudatoryStories = new List<string> { "Now I feel better.", "I managed to change.", "It made some miracle.", "I can’t believe it, but now I am feeling great.", "You should try it, too. I am very satisfied." };
        private readonly List<string> firstName = new List<string> { "Dayan", "Stella", "Hellen", "Kate" };
        private readonly List<string> lastName = new List<string> { "Johnson", "Peterson", "Charls" };
        private readonly List<string> cities = new List<string> { "London", "Paris", "Berlin", "New York", "Madrid" };

        public void GenerateRandomAds()
        {
            Random ran = new Random();
            string lauPh = this.laudatoryPhrases[ran.Next(0, laudatoryPhrases.Count)];
            string lauSt = this.laudatoryStories[ran.Next(0, laudatoryStories.Count)] + " -- ";
            string firstN = this.firstName[ran.Next(0, firstName.Count)];
            string lastN = this.lastName[ran.Next(0, lastName.Count)]+ ", ";
            string city = this.cities[ran.Next(0, cities.Count)];
            string[] ads = new string[] {lauPh,lauSt,firstN,lastN,city };
            string randomAds = string.Join(" ",ads);
            Console.WriteLine(randomAds);
        }
    }
}