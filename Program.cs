﻿using Newtonsoft.Json;
using System.Linq;

namespace jsonCRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //listOfFood = new List<FoodGeneralInfo>();
            Console.WriteLine("Please Insert the path of the json file: ");
            string fileName = Console.ReadLine();
            List<FoodGeneralInfo> listOfFood = GetDataFromJson(fileName);
            //

            PrinciplMenu();
            string operation = Console.ReadLine();
            List<FoodGeneralInfo> SelectedItems = new List<FoodGeneralInfo>();
            switch (operation)
            {
                case "1": SelectedItems = SelectElement(listOfFood); break;
                case "2": break;
                case "3": break;
                case "4": break;
                case "5": break;
                default: break;
            }



           // List<FoodGeneralInfo> SelectedItems =  SelectElement(listOfFood);
            
            foreach(var item in SelectedItems)
            {
                Console.WriteLine($"{item.ItalianName} \n{item.EnglishName} \n{item.FoodCode}\n{item.Category} \n ---------------------------------------------------------");
            }

            Console.WriteLine("The search result has "+SelectedItems.Count + " Elements");

           
        }
        #region selection Method
        public static List<FoodGeneralInfo> SelectElement(List<FoodGeneralInfo> list)
        {
            Console.WriteLine("Please select from the menu the option:\n1-ItalianName\n2-EnglishName\n3-ScientificName\n4-Category\n5-FoodCode");
            string command = string.Empty;
            do {
                Console.WriteLine("Please Choose from the Menu (1-5): ");
                command = Console.ReadLine().Trim();

            } while ( Convert.ToInt32(command) < 0 || Convert.ToInt32(command) > 5 );
            Console.WriteLine("Please Insert The searchKey: ");
            string searchKey = Console.ReadLine();

            switch (command)
            {
                case "1": return list.Where(x => x.ItalianName.Contains(searchKey,StringComparison.CurrentCultureIgnoreCase)).ToList();
                case "2": return list.Where(x => x.EnglishName.Contains(searchKey,StringComparison.CurrentCultureIgnoreCase)).ToList();
                case "3": return list.Where(x => x.ScientificName.Contains(searchKey,StringComparison.CurrentCultureIgnoreCase)).ToList();
                case "4": return list.Where(x => x.Category.Contains(searchKey,StringComparison.CurrentCultureIgnoreCase)).ToList();
                case "5": return list.Where(x => x.FoodCode == searchKey).ToList();
                default:
                    Console.WriteLine("Please insert a number between 1 - 5 ");
                    return new List<FoodGeneralInfo>();
            }

        }

        #endregion

        public static void PrinciplMenu()
        {
            Console.WriteLine("Welcome to the Best Json browser in the world! :)))))))))))\n\n");
            Console.WriteLine("Please Choose From the Menu Your Operation:\n\n\n1-Select\n2-Add\n3-Delete\n4-Update\n5-DownLoad");
        }

        public static List<FoodGeneralInfo> GetDataFromJson(string path)
        {
            
            string jsonString = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<List<FoodGeneralInfo>>(jsonString);
        }
    }
}