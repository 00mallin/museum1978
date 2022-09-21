internal class Program
{
    private static void Main(string[] args)
    {
        // Welcome screen
        Console.Clear();
        Console.WriteLine("Welcome to the TOBACCO AND SALT MUSEUM!" + Environment.NewLine);
        Console.WriteLine("Use your up and down arrow keys to navigate.");
        Console.Write("Press any key to enter the museum...");
        Console.ReadKey();

        // Move user to the entrance area
        Entrance();
    }

    private static void Entrance() 
    {
        Console.Clear();
        Console.WriteLine("You are at the entrance of the museum. " + Environment.NewLine + "What would you like to do?" + Environment.NewLine);
        
        Console.WriteLine("- Go to Exhibtion hall 1"); // Option 1
        Console.WriteLine("- Go to Exhibtion hall 2"); // Option 2
        Console.WriteLine("- Go to Café (Leads to Gift Shop)"); // Option 3
        Console.WriteLine("- Go to Bathroom"); // Option 4
        Console.WriteLine("- EXIT the museum" + Environment.NewLine); // Option 5
        // Gap position 6
        Console.WriteLine("- Look at the Salt Sculpture"); // Option 6
        Console.WriteLine("- Look at the Cigars"); // Option 7

        // MenuSelector(Number of menu options, Gap position, Y position)
        int menuSelection = MenuSelector(7, 6, 3);

        // Move user depening on menu selection
        switch (menuSelection)
        {
            case 1:
                ExhibitionHall1();
                break;
            case 2:
                ExhibitionHall2();
                break;
            case 3:
                Cafe();
                break;
            case 4:
                Bathroom();
                break;
            case 5:
                // Exit message
                Console.Clear();
                Console.WriteLine("Thanks for visiting the museum. Hope to see you soon!");
                Console.Write("Press any key to exit...");
                Console.ReadKey();
                Console.Clear();
                Environment.Exit(0);
                break;
            case 6:
                EntranceSaltSculpture();
                break;
            case 7:
                EntranceCigars();
                break;
            default:
                break;
        }
    }

    private static void EntranceSaltSculpture()
    {
        Console.WriteLine("The Salt Sculpture was built in the yearly 1600s." + Environment.NewLine);

        Console.Write("Press any key to return...");
        Console.ReadKey();
        Entrance();
    }

    private static void EntranceCigars()
    {
        Console.WriteLine("These cigars are manufactured in Colombia." + Environment.NewLine);

        Console.Write("Press any key to return...");
        Console.ReadKey();
        Entrance();
    }
    
private static void ExhibitionHall1() 
    {
        Console.Clear();
        Console.WriteLine("You are at Exhibition Hall 1. " + Environment.NewLine + "Here you can watch saltwater evaporate. :D" + Environment.NewLine);
        
        Console.WriteLine("- Watch the saltwater" + Environment.NewLine);

        Console.WriteLine("- Go to the Café (Leads to Gift Shop)");
        Console.WriteLine("- Return to the entrance");

        int menuSelection = MenuSelector(3, 2, 3);

        // Move user depening on menu selection
        switch (menuSelection)
        {
            case 1:
                ExhibitionHall1Saltwater();
                break;
            case 2:
                Cafe();
                break;
            case 3:
                Entrance();
                break;
            default:
                break;
        }        
    }

    private static void ExhibitionHall1Saltwater()
    {
        Console.WriteLine("Wow, the saltwater is really evaporating quickly." + Environment.NewLine);

        Console.Write("Press any key to return...");
        Console.ReadKey();
        ExhibitionHall1();
    }

    private static void ExhibitionHall2() 
    {
        Console.Clear();
        Console.WriteLine("You are at Exhibition Hall 2. " + Environment.NewLine + "Here you can view the pipes or pictures of Himalaya!" + Environment.NewLine);
        
        Console.WriteLine("- Look at the pipes");
        Console.WriteLine("- Look at pictures of Himalaya" + Environment.NewLine);

        Console.WriteLine("- Return to the entrance");

        int menuSelection = MenuSelector(3, 3, 3);

        // Move user depening on menu selection
        switch (menuSelection)
        {
            case 1:
                ExhibitionHall2Pipes();
                break;
            case 2:
                ExhibitionHall2Himalaya();
                break;
            case 3:
                Entrance();
                break;
            default:
                break;
        }        
    }

    private static void ExhibitionHall2Pipes()
    {
        Console.WriteLine("Cool pipes." + Environment.NewLine);

        Console.Write("Press any key to return...");
        Console.ReadKey();
        ExhibitionHall2();
    }

    private static void ExhibitionHall2Himalaya()
    {
        Console.WriteLine("Beautiful pictures of Hamalaya." + Environment.NewLine);

        Console.Write("Press any key to return...");
        Console.ReadKey();
        ExhibitionHall2();
    }

    private static void Cafe() 
    {
        Console.Clear();
        Console.WriteLine("You are at the Café. " + Environment.NewLine + "Get something to drink or head over to the Gift Shop!" + Environment.NewLine);
        
        Console.WriteLine("- Get a free drink" + Environment.NewLine);

        Console.WriteLine("- Go to Gift Shop");
        Console.WriteLine("- Go to Exhibition Hall 1");
        Console.WriteLine("- Return to the entrance");

        int menuSelection = MenuSelector(4, 2, 3);

        // Move user depening on menu selection
        switch (menuSelection)
        {
            case 1:
                CafeDrink();
                break;
            case 2:
                GiftShop();
                break;
            case 3:
                ExhibitionHall1();
                break;
            case 4:
                Entrance();
                break;
            default:
                break;
        }        
    }

    private static void CafeDrink()
    {
        Console.WriteLine("Here is a glass of water. :)" + Environment.NewLine);

        Console.Write("Press any key to return...");
        Console.ReadKey();
        Cafe();
    }

    private static void GiftShop() 
    {
        Console.Clear();
        Console.WriteLine("You are at the Gift Shop. " + Environment.NewLine + "Buy a gift for yourself or someone you like. :)" + Environment.NewLine);
        
        Console.WriteLine("- Buy a gift" + Environment.NewLine);

        Console.WriteLine("- Return to the Café");

        int menuSelection = MenuSelector(2, 2, 3);

        // Move user depening on menu selection
        switch (menuSelection)
        {
            case 1:
                GiftShopBuy();
                break;
            case 2:
                Cafe();
                break;
            default:
                break;
        }        
    }

    private static void GiftShopBuy()
    {
        Console.WriteLine("That's a fun gift! :D" + Environment.NewLine);

        Console.Write("Press any key to return...");
        Console.ReadKey();
        GiftShop();
    }

    private static void Bathroom() 
    {
        Console.WriteLine("Enjoy your bathroom break." + Environment.NewLine);

        Console.Write("Press any key to return...");
        Console.ReadKey();
        Entrance();
    }

    /// <summary>
    /// Moves the menu selector through a specified menu
    /// </summary>
    /// <param name="numberOfMenuItems">Number of selectable menu options</param>
    /// <param name="menuGapPosition">Position of the seperating gap in the menu. Set to 0 for no gap</param>
    /// <param name="startPosition">Y position of the first menu option</param>
    /// <returns>Selected menu option</returns>
    private static int MenuSelector(int numberOfMenuItems, int menuGapPosition, int startPosition)
    {
        int menuSelection = 1;
        int cursorPositionInMenu = 0;

        Console.SetCursorPosition(0, startPosition);

        while (true)
        {
            // Register what key is pressed
            // Check the selection is within the given range
            switch (Console.ReadKey(true).Key)
            {
                // Move selection up
                case ConsoleKey.UpArrow:
                    if (menuSelection > 1)
                    {
                        menuSelection--;         
                    }
                    break;
                // Move selection down
                case ConsoleKey.DownArrow:
                    if (menuSelection < numberOfMenuItems)
                    {
                        menuSelection++;
                    }
                    break;
                // Return selected option
                case ConsoleKey.Enter:
                    Console.Clear();
                    return menuSelection; 
            }

            // Moves selection past gap in menu
            if(menuSelection < menuGapPosition || menuGapPosition == 0)
            {
                cursorPositionInMenu = startPosition + menuSelection - 1;
            }
            else
            {
                cursorPositionInMenu = startPosition + menuSelection;
            }

            // Moves selector in the menu
            Console.SetCursorPosition(0, cursorPositionInMenu);
        }
    }
}