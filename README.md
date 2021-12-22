# Gold Badge Challenges

This is a Repository to showcase what I learned in the Gold Badge section of the Software Development course through multiple challenges.

I completed three of the available challenges in three days.

## Challenge 1 - Komodo Cafe

- In this challenge the developer is tasked with:
   ```
   Your Task:

    Create a Menu Class with properties, constructors, and fields.
    Create a MenuRepository Class that has methods needed.
    Create a Test Class for your repository methods. (You don't need to test your constructors or objects, just your methods)
    Create a Program file that allows the cafe manager to add, delete, and see all items in the menu list.
   ```
    - This challenge mainly consisted of three key files

    1. [MenuItem.cs](./01_KomodoCafe.Repository/MenuItem.cs) This contains the POCOS.
    2. [MenuItemRepository.cs](./01_KomodoCafe.Repository/MenuItemRepository.cs) This contains the CRUD methods.
    3. [ProgramUI.cs](./01_KomodoCafe.UI/ProgramUI.cs) This contains the console code.
    

## Challenge 3 - Komodo Badges

- In this challenge the developer is tasked with:

    ```
        Your task will be to create the following:

            A badge class that has the following properties:

                BadgeID
                List of door names for access

 
        A badge repository that will have methods that do the following:

                Create a dictionary of badges.
                The key for the dictionary will be the BadgeID.
                The value for the dictionary will be the List of Door Names.

 
        The Program will allow a security staff member to do the following:

                create a new badge
                update doors on an existing badge.
                delete all doors from an existing badge.
                show a list with all badge numbers and door access
    ```

- This challenge mainly consisted of three key files

    1. [Badge.cs](./03_KomodoBadge_Repository/Badge.cs) This contains the POCOS.
    2. [BadgeRepository.cs](./03_KomodoBadge_Repository/BadgeRepository.cs) This contains the CRUD methods.
    3. [ProgramUI.cs](./03_KomodoBadges.UI/ProgramUI.cs) This is the console code.

- The main challenge in this project was working with Dictionaries as the Badge ID and Door Numbers are a key/value pair.

## Challenge 4 - Komodo Outings

- In this challenge the developer is tasked with:

        ```
        Komodo accountants need a list of all outings, the cost of all outings combined, and the cost of all types of outings combined.
        Here are the parts of an outing:

            Event Type:   Golf, Bowling, Amusement Park, Concert
            Number of people that attended
            Date
            Total cost per person for the event
            Total cost for the event

 
        Here's what they'd like:

            Display a list of all outings.
            Add individual outings to a list(don't need to worry about delete yet)
            Calculations:
                They'd like to see a display for the combined cost for all outings.
                They'd like to see a display of outing costs by type.
                    For example, all bowling outings for the year were $2000.00. All Concert outings cost $5000.00
        ```

- This challenge mainly consisted of three key files

    1. [Outing.cs](./04_KomodoOutings.Repository/Outing.cs) This contains the POCOS.
    2. [BadgeRepository.cs](./04_KomodoOutings.Repository/Outing.cs) This contains the CRUD methods.
    3. [ProgramUI.cs](./04_KomodoOutings.UI/ProgramUI.cs) This is the console code.

- The main challenge of this task was to perform calculations to return the total outing costs and create methods to return costs only by a certain type of event.