using System;

namespace Browser_Buddy
{
    class BrowserMenu
    {
        static void Main()
        {
            Tab currentTab = new Tab();
            TabStack closedTabs = new TabStack();

            int choice;
            do
            {
                Console.WriteLine("\n========= BrowserBuddy Menu =========");
                Console.WriteLine("1. Visit Website");
                Console.WriteLine("2. Back");
                Console.WriteLine("3. Forward");
                Console.WriteLine("4. Close Tab");
                Console.WriteLine("5. Restore Closed Tab");
                Console.WriteLine("6. Current Page");
                Console.WriteLine("7. Exit");
                Console.Write("Enter choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter URL: ");
                        currentTab.History.Visit(Console.ReadLine());
                        break;

                    case 2:
                        currentTab.History.Back();
                        break;

                    case 3:
                        currentTab.History.Forward();
                        break;

                    case 4:
                        closedTabs.Push(currentTab);
                        currentTab = new Tab();
                        Console.WriteLine("Tab closed.");
                        break;

                    case 5:
                        Tab restoredTab = closedTabs.Pop();
                        if (restoredTab != null)
                        {
                            currentTab = restoredTab;
                            Console.WriteLine("Tab restored.");
                        }
                        break;

                    case 6:
                        Console.WriteLine("Current Page: " + currentTab.History.GetCurrentPage());
                        break;

                    case 7:
                        Console.WriteLine("Exiting BrowserBuddy...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

            } while (choice != 7);
        }
    }
}
