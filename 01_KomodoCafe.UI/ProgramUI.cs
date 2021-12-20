﻿using _01_KomodoCafe.Repository;
using _01_KomodoCafe.UI.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_KomodoCafe.UI
{
    public class ProgramUI
    {

        //add links to existing repositories
        private readonly MenuItemRepository _menuItemRepo = new MenuItemRepository();
        
        public void Run()  // everything except Run() is private so it can't be accessed
        {
            RunApplication();
        }

        private void RunApplication()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Welcom to Komodo Cafe!\n" +
                    "1. Add a Menu Item\n" +
                    "2. Delete a Menu Item\n" +
                    "3. See all Menu Items\n");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        AddMenuItem();
                        break;
                    case "2":
                        DeleteMenuItem();
                        break;
                    case "3":
                        ViewAllMenuItems();
                        break;
                    default:
                        Console.WriteLine("Invalid Selection");
                        WaitForKeypress();
                        break;
                }
                Console.Clear();
            }
        }

        private void AddMenuItem()
        {
            Console.Clear();  // clear the Console
            MenuItem menuItem = new MenuItem(); // declare the variable

            Console.Write("Please Enter Meal Name: ");
            string mealName = Console.ReadLine();
            menuItem.MealName = mealName;

            Console.Write("Please Enter Meal Description: ");
            string mealDescription = Console.ReadLine();
            menuItem.MealDescription = mealDescription;

            List<string> mealIngredients = new List<string>(); 

            bool hasAddedAllIngredients = false;
            while (hasAddedAllIngredients == false)
            {
                Console.Write("Please Enter Meal Ingredient: ");
                string mealIngredient = Console.ReadLine();
                mealIngredients.Add(mealIngredient);
                Console.WriteLine("Do you want to add another ingredient? Y/N");
                string userInput = Console.ReadLine();
                if (userInput == "Y".ToLower())
                {
                    continue;
                }
                else
                {
                    hasAddedAllIngredients = true;
                    menuItem.MealIngredient = mealIngredients;
                }

            }


            Console.Write("Please Enter Meal Price: ");
            decimal mealPrice = Convert.ToDecimal(Console.ReadLine());
            menuItem.MealPrice = mealPrice;

            _menuItemRepo.AddAMenuItem(menuItem);

        }

        private void DeleteMenuItem()
        {
            Console.Clear();
            Console.WriteLine("Which Menu Item would you like to remove?");

            int index = 1;
            List<MenuItem> menuItems = _menuItemRepo.GetAllMenuItems();

            foreach (MenuItem item in menuItems)
            {
                Console.WriteLine($"{index}. {item.MealName}");
                index++;
            }
            string optionString = Console.ReadLine();
            int option = Convert.ToInt32(optionString);

            MenuItem itemToDelete = menuItems[option - 1];

            Console.WriteLine("Are you sure you want to delete this? (y or n)");
            DisplayContentListItem(itemToDelete);

            if (Console.ReadLine() == "y")
            {
                _menuItemRepo.DeleteExistingMenuItem(itemToDelete);
                Console.WriteLine("Item deleted!");
            }
            else
            {
                Console.WriteLine("Canceled");
            }
            WaitForKeypress();
        }


        
        private void ViewAllMenuItems()
        {
            Console.Clear();
            Console.WriteLine("List of Menu Items: ");
            List<MenuItem> menuItems = _menuItemRepo.GetAllMenuItems();
            foreach (MenuItem item in menuItems)
            {
                DisplayContentListItem(item); 
            }
            WaitForKeypress();
        }

        private void DisplayContentListItem(MenuItem menuItem)
        {
            Console.WriteLine($"Meal Number: {menuItem.MealID}\n" +
                $"Name: {menuItem.MealName}\n" +
                $"Description: {menuItem.MealDescription}\n" +
                $"Price: {menuItem.MealPrice}\n" +                
                $"============================\n");
            Console.WriteLine("Ingredients:");
            foreach (var item in menuItem.MealIngredient)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n" +
                "******************************");
        }


        private void WaitForKeypress()
        {
            Console.ReadKey();
        }

       

    }
}
