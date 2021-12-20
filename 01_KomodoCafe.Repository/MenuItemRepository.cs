using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_KomodoCafe.Repository
{
    // This is our database of menu items 
    public class MenuItemRepository
    {
        private readonly List<MenuItem> _menuItemsContext = new List<MenuItem>();
        private int _id;

        // Create - A Menu Item
        public bool AddAMenuItem(MenuItem menuItem)
        {
            
            if (menuItem == null)
            {
                return false;
            }
            else
            {
                _id++;
                menuItem.MealID = _id;
                _menuItemsContext.Add(menuItem);
                return true; 
            }
        }

        // Read - Return list of all menu items
        public List<MenuItem> GetAllMenuItems()
        {
            return _menuItemsContext;
        }


        // Delete - remove a MenuItem

        public bool DeleteExistingMenuItem(MenuItem existingMenuItem)
        {
            bool deleteMenuItem = _menuItemsContext.Remove(existingMenuItem);
            return deleteMenuItem;
        }


    }
}
