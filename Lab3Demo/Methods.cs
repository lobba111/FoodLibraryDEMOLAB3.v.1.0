using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodLibrary;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Spectre.Console;

namespace Lab3Demo
{
    partial class Program
    {
       /// <summary>
       /// Genererar 5 st random maträtter
       /// Samt möjlighet att spara resultet i favorites
       /// </summary>
        public static void ReadFiveRandomDishes()
        {
            var context = new DishContext();
            var dishes = context.Dishes
                .OrderBy(c => Guid.NewGuid())
                .Take(5)
                .ToList();
            dishes.ForEach(d => Console.WriteLine($"{d.DishName} : {d.DishDescription}"));
            string yes = "Yes";
            string no = "No";
            string result;
            result = SaveYesOrNo(yes, no);  
            
            if (result == "Yes")
            {
                foreach (var d in dishes)
                {
                    var fav = new Favorite()
                    {
                        DishDescription = d.DishDescription,
                        DishName = d.DishName
                    };
                    context.Favorites.Add(fav);
                    context.SaveChanges();

                }
                Console.WriteLine("The menu has been added to your favorites");
            }
            Message();
            Console.ReadKey();
            Console.Clear();
             
            
        }
        
        
           
        /// <summary>
        /// metod för att generera en lista med de maträtter som finns i databasen
        /// samt välja vad det är man vill ändra på
        /// </summary>
        public static void UpdateData()
        {
            string dishName;
            string dishDescription; 
            var context = new DishContext();
            var printAllDishNames = context.Dishes.Select(x => x.DishName).ToList();
            var allDishesSelection = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .Title("[red]Here is all the dishes inside the database[/]")
                .PageSize(10)
                .MoreChoicesText("[red](Move up and down to choose the dish you want to update)[/]")
                .AddChoices(printAllDishNames));
            AnsiConsole.Write(allDishesSelection);
            
            var dishNameOrDescprition = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .Title("[red]Do you want to update the name of the dish or the description?[/]")
                .PageSize(4)
                .MoreChoicesText("[red](Move up and down to choose what you want to update)[/]")
                .AddChoices(new[] {"DishName", "DishDescription" }));
            AnsiConsole.Markup("[red][b]You have chosen[/][/]\n");
            AnsiConsole.Write(dishNameOrDescprition);
            if (dishNameOrDescprition == "DishName")
            {
                UpdateDishName(allDishesSelection);
                Console.WriteLine("The dish is now updated");

            }
            else if (dishNameOrDescprition == "DishDescription")
            {
                UpdateDishDescription(allDishesSelection);
                Console.WriteLine("The desciption is up to date");
                   
            }
            Message();
            Console.ReadKey();
            Console.Clear();
            

        }
        /// <summary>
        /// Metod för att ta bort en maträtt baserat på vad användaren har valt för maträtt att ta bort.
        /// </summary>
        /// <param name="userInputDishName"></param>
        public static void DeleteData(string userInputDishName)
        {
            using (var context = new DishContext())
            {
                
                try
                {
                    var dishDelete = context.Dishes.Where(d => d.DishName == userInputDishName).First();
                    context.Dishes.Remove(dishDelete);
                    context.SaveChanges();
                    Console.WriteLine("The dish has been succesfully deleted!");
                }
                catch (Exception)
                {

                    
                }
                 
                
            }
           
            
            
        }
        /// <summary>
        /// Metod för att kunna lägga till en maträtt i databasen
        /// </summary>
        /// <param name="dishName"></param>
        /// <param name="dishDescription"></param>
        /// <param name="ingredients"></param>
        public static void AddDataFromUserInput(string dishName,string dishDescription,string ingredients)
        {
            using (var context = new DishContext())
            {

                var dish = new Dish()
                {
                    DishName = dishName,
                    DishDescription = dishDescription,
                    Ingredients = ingredients
                };

                
                bool result;
                result = CheckUserInput(dishName);
                if (result == false)
                {
                    context.Dishes.Add(dish);
                    context.SaveChanges();
                    Console.WriteLine("Your dish has been added to the database");
                    Message();
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (result == true)
                {
                    Console.WriteLine("Sorry the dish you have enterd already exists in the database");
                    Message();
                    Console.ReadKey();
                    Console.Clear();
                }
                



            }
        }
        /// <summary>
        /// Stöd metod till att kunna lägga till en maträtt i databasen, den söker igenom databasen 
        /// efter det som användaren för söker att lägga till och retunerar antingen true eller false
        /// </summary>
        /// <param name="dishName"></param>
        /// <returns></returns>
        private static bool CheckUserInput(string dishName)
        {
            var context = new DishContext();
            var check = context.Dishes
                .Where(a => a.DishName == dishName)
                .ToList();
            return check.Any();
        }
        /// <summary>
        /// Metod för ett enkelt meddelande som återanvänds i appen på många ställen
        /// </summary>
        public static void Message()
        {
            AnsiConsole.Markup("[red][b]Press Enter To Continue...[/][/]\n");

        }
        /// <summary>
        /// Metod för att skriva ut huvudmenyn
        /// </summary>
        public static void PrintMenu()
        {
            var table = new Table();
            table.AddColumn("[red][b]Menu[/][/]");
            table.AddRow("[turquoise4]Press [/][deepskyblue3]1[/] To Generate Five Random Dishes: ");
            table.AddRow("[turquoise4]Press [/][deepskyblue3]2[/] To Add a Dish To The DataBase : ");
            table.AddRow("[turquoise4]Press [/][deepskyblue3]3[/] To Print Favorites : ");
            table.AddRow("[turquoise4]Press [/][deepskyblue3]4[/] To Update Dish : ");
            table.AddRow("[turquoise4]Press [/][deepskyblue3]5[/] To Delete Dish From Database : ");
            table.AddRow("[turquoise4]Press [/][deepskyblue3]6[/] To Print All Dishes In The Database : ");
            table.AddRow("[turquoise4]Press [/][deepskyblue3]7[/] To Delete Dish From Favorites : ");
            table.AddRow("[turquoise4]Press [/][deepskyblue3]8[/] To Exit The Program : ");
            table.Border(TableBorder.Double);
            table.Expand();
            AnsiConsole.Write(table);
        }
        /// <summary>
        /// Metod för att skriva ut, välja ut, samt delete.
        /// </summary>
        public static void PrintAllFromTableDishName()
        {
            var context = new DishContext();
            var printAllDishNames = context.Dishes.Select(x => x.DishName).ToList();
            var allDishesSelection = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .Title("[red]Here is all the dishes inside the database[/]")
                .PageSize(10)
                .MoreChoicesText("[red](Move up and down to choose the dish you want to delete)[/]")
                .AddChoices(printAllDishNames));  
            AnsiConsole.Write(allDishesSelection);
            Console.WriteLine("");
            DeleteData(allDishesSelection);
            Message();
            Console.ReadKey();
            Console.Clear();

        }
        /// <summary>
        /// Metod för att uppdatera den maträtt man har valt och ändra på namnet på den maträtten
        /// </summary>
        /// <param name="allDishesSelection"></param>
        public static void UpdateDishName(string allDishesSelection)
        {
            using(var context = new DishContext())
            {
                Console.WriteLine("Please enter the new name for the dish : ");
                string userInputNewName = Console.ReadLine();
                var dishNameUpdate = context.Dishes.Where(n => n.DishName == allDishesSelection).First();
                dishNameUpdate.DishName = userInputNewName;
                context.SaveChanges();

            }  
        }
        /// <summary>
        /// Metod för att uppdatera den maträtt man har valt och ändra på beskrivning av den
        /// </summary>
        /// <param name="allDishesSelection"></param>
        public static void UpdateDishDescription(string allDishesSelection)
        {
            using (var context = new DishContext())
            {
                Console.WriteLine("Please enter the new description for the dish : ");
                string userInputNewDishDescription = Console.ReadLine();
                var dishNameUpdate = context.Dishes.Where(n => n.DishName == allDishesSelection).First();
                dishNameUpdate.DishDescription = userInputNewDishDescription;
                context.SaveChanges();

            }
        }
        /// <summary>
        /// Metoden hänger ihop med generera femmaträtter, ger användaren ett val att antingen spara
        /// i favoriter eller inte
        /// </summary>
        /// <param name="Yes"></param>
        /// <param name="No"></param>
        /// <returns></returns>
        public static string SaveYesOrNo(string Yes, string No)
        {
            
            var saveToFavorieAnswer = AnsiConsole.Prompt(
               new SelectionPrompt<string>()
               .Title("[red]Would you like to save this menu to favorites? [/]")
               .PageSize(10)
               .MoreChoicesText("[red](Move up and down to choose )[/]")
               .AddChoices(new[] {"Yes", "No"}));
            if (saveToFavorieAnswer == "Yes")
            {
                
                return "Yes";
            }
            else  
            {
                return "No";
            }

            

            
            

        }
        /// <summary>
        /// Metod för att skriva ut resultatet Från GetDishesAsync
        /// </summary>
        private static void PrintDataBase()
        {
            var query = GetDishesAsync();
            var fav = query.Result;
            foreach (var item in fav)
            {
                Console.WriteLine($"{item.DishName} | {item.DishDescription}");
            }


        }
        /// <summary>
        /// Metod för att hämta in innehållet i favorites async och retunera en lista med det resultatet
        /// </summary>
        /// <returns></returns>
        public static async Task<List<Favorite>> GetFavoritesAsync()
        {
            using(var context = new DishContext())
            {
                var favoritesQuery = from f in context.Favorites select f;
                return await favoritesQuery.ToListAsync();
            }  
        }
        /// <summary>
        /// Metod för att hämta in innehållet i dishes async och returnera en lista med det resultatet
        /// </summary>
        /// <returns></returns>
        public static async Task<List<Dish>> GetDishesAsync()
        {
            using(var context = new DishContext())
            {
                var dishesQuery = from a in context.Dishes select a;
                return await dishesQuery.ToListAsync();
            }
        }
        /// <summary>
        /// Metod för att skriva ut den lista som returneras ifrån GetFavoritesAsync
        /// </summary>
        public static void PrintFavorites()
        {
            var query = GetFavoritesAsync();
            var fav = query.Result;
            foreach (var item in fav)
            {
                Console.WriteLine($"{item.DishName} | {item.DishDescription}");
            }
        }
        /// <summary>
        /// Metod för att skriva ut det innehållet ifavorites, välja det man vill ta bort.
        /// </summary>
        public static void SelectDataToDeleteFromFavorites()
        {
            
            var context = new DishContext();
            var printAllDishNames = context.Favorites.Select(x => x.DishName).ToList();
            var allDishesSelection = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .Title("[red]Here is all the dishes inside favorites[/]")
                .PageSize(10)
                .MoreChoicesText("[red](Move up and down to choose the dish you want to delete)[/]")
                .AddChoices(printAllDishNames));
            AnsiConsole.Write(allDishesSelection);
            Console.WriteLine("");
            DeleteDataFromFavorites(allDishesSelection);
            Message();
            Console.ReadKey();
            Console.Clear();
        }
        /// <summary>
        /// Metod för att ta bort i favorites baserat på det valet man gör i metoden SelectDataFromFavorites
        /// </summary>
        /// <param name="userInputDishNameFav"></param>
        public static void DeleteDataFromFavorites(string userInputDishNameFav)
        {
            using(var context = new DishContext())
            {
                var dishDelete = context.Favorites.Where(d => d.DishName == userInputDishNameFav).First();
                context.Favorites.Remove(dishDelete);
                context.SaveChanges();
                Console.WriteLine("The dish has been succesfully deleted!");
            }
        }
    }
}
