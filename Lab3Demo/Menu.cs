using FoodLibrary;
using Spectre.Console;
namespace Lab3Demo
{
	partial class Program
    {
       static void Main()
        {

            bool show = true;
            while (show)
            {
                PrintMenu();
                int input;
                bool correctInput = int.TryParse(Console.ReadLine(),out input);
                if (correctInput)
                {
                    switch (input)
                    {
                        case 1:
                            {
                                Console.WriteLine("Here Is Your Five Random Dishes : ");
                                ReadFiveRandomDishes();
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("What we need first is the name of the dish you would like to add :");
                                string dishName = Console.ReadLine();
                                Console.WriteLine("What we need now is a short description of the dish : ");
                                string dishDescription = Console.ReadLine();
                                Console.WriteLine("And last we need the ingredients, and please separate every ingredient with | thank you");
                                string ingredients = Console.ReadLine();
                                AddDataFromUserInput(dishName,dishDescription,ingredients);
                                break;
                            }
                        case 3:
                            {
                                PrintFavorites();
                                Message();
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                        case 4:
                            {
                                UpdateData(); 
                                break;
                            }
                        case 5:
                            {
                                PrintAllFromTableDishName();
                                break;
                            }
                        case 6:
                            {
                                PrintDataBase();
                                Message();
                                Console.ReadLine();
                                Console.Clear();
                                break;
                            }
                        case 7:
                            {
                                SelectDataToDeleteFromFavorites();
                                break;
                            }
                        case 8:
                            {
                                Console.WriteLine("Bye");
                                show = false;
                                break;
                            }


                    }
                }
                else
                {
                    Console.WriteLine("Please Enter A Valid Number Represented In The Menu : ");
                    Message();
                    Console.ReadKey();
                    Console.Clear();
                }
 
            }
        }
    }
}


