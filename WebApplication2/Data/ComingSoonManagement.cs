using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Data
{
    public class ComingSoonManagement
    {
        List<string> products { get; set; }

        public ComingSoonManagement()
        {
            products = new List<string>() {"Açaí",
                                        "Ackee",
                                        "Apple",
                                        "Apricot",
                                        "Avocado",
                                        "Banana",
                                        "Bilberry",
                                        "Blackberry",
                                        "Blackcurrant",
                                        "Black sapote",
                                        "Blueberry",
                                        "Boysenberry",
                                        "Breadfruit",
                                        "Buddha's hand (fingered citron)",
                                        "Cactus pear",
                                        "Crab apple",
                                        "Currant",
                                        "Cherry",
                                        "Cherimoya (Custard Apple)",
                                        "Chico fruit",
                                        "Cloudberry",
                                        "Coconut",
                                        "Cranberry",
                                        "Damson",
                                        "Date",
                                        "Dragonfruit (or Pitaya)",
                                        "Durian",
                                        "Elderberry",
                                        "Feijoa",
                                        "Fig",
                                        "Goji berry",
                                        "Gooseberry",
                                        "Grape",
                                        "Honeyberry",
                                        "Huckleberry",
                                        "Jabuticaba",
                                        "Jackfruit",
                                        "Jambul",
                                        "Japanese plum",
                                        "Jostaberry",
                                        "Jujube",
                                        "Juniper berry",
                                        "Kiwano (horned melon)",
                                        "Kiwifruit",
                                        "Kumquat",
                                        "Lemon",
                                        "Lime",
                                        "Loganberry",
                                        "Loquat",
                                        "Bell pepper",
                                        "Chile pepper",
                                        "Corn kernel",
                                        "Cucumber",
                                        "Eggplant",
                                        "Jalapeño",
                                        "Olive",
                                        "Pea",
                                        "Pumpkin",
                                        "Squash",
                                        "Tomato",
                                        "Zucchini",
                                        "Longan",
                                        "Lychee",
                                        "Mango",
                                        "Mangosteen",
                                        "Marionberry",
                                        "Melon",
                                        "Cantaloupe",
                                        "Galia melon",
                                        "Honeydew",
                                        "Watermelon",
                                        "Miracle fruit",
                                        "Monstera Delisiousa",
                                        "Mulberry",
                                        "Nectarine",
                                        "Nance",
                                        "Orange",
                                        "Blood orange",
                                        "Clementine",
                                        "Mandarine",
                                        "Tangerine",
                                        "Papaya",
                                        "Passionfruit",
                                        "Peach",
                                        "Pear",
                                        "Persimmon",
                                        "Plantain",
                                        "Plum",
                                        "Prune (dried plum)",
                                        "Pineapple",
                                        "Pineberry",
                                        "Plumcot (or Pluot)",
                                        "Pomegranate",
                                        "Pomelo",
                                        "Purple mangosteen",
                                        "Quince",
                                        "Raspberry",
                                        "Salmonberry",
                                        "Rambutan (or Mamin Chino)",
                                        "Redcurrant",
                                        "Salal berry",
                                        "Salak",
                                        "Satsuma",
                                        "Soursop",
                                        "Star apple",
                                        "Star fruit",
                                        "Strawberry",
                                        "Surinam cherry",
                                        "Tamarillo",
                                        "Tamarind",
                                        "Tangelo",
                                        "Tayberry",
                                        "Ugli fruit",
                                        "White currant",
                                        "White sapote",
                                        "Yuzu" };
        }

        public List<string> GetComingSoonProducts()
        {
            Random random = new Random();
            int val = random.Next(3, 10);
            List<String> data = new List<string>();
            for (int i=0;i<val; i++)
            {
                Random random2 = new Random();
                int val2 = random.Next(0, this.products.Count - 1);
                data.Add(this.products[val2]);
            }

            return data;
        }
    }
}