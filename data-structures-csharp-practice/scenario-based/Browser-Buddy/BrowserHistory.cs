using System;

namespace Browser_Buddy
{
    internal class BrowserHistory
    {
        private HistoryNode head;
        private HistoryNode current;

        public void Visit(string url)
        {
            HistoryNode newNode = new HistoryNode(url);

            if (head == null)
            {
                head = current = newNode;
            }
            else
            {
                current.Next = newNode;
                newNode.Prev = current;
                current = newNode;
            }

            Console.WriteLine($"Visited: {url}");
        }

        public void Back()
        {
            if (current != null && current.Prev != null)
            {
                current = current.Prev;
                Console.WriteLine($"Back to: {current.Url}");
            }
            else
            {
                Console.WriteLine("No previous page.");
            }
        }

        public void Forward()
        {
            if (current != null && current.Next != null)
            {
                current = current.Next;
                Console.WriteLine($"Forward to: {current.Url}");
            }
            else
            {
                Console.WriteLine("No forward page.");
            }
        }

        public string GetCurrentPage()
        {
            return current != null ? current.Url : "Empty Tab";
        }
    }
}
