using System;

namespace Browser_Buddy
{
    internal class TabStack
    {
        private Tab[] stack = new Tab[10];
        private int top = -1;

        public void Push(Tab tab)
        {
            stack[++top] = tab;
        }

        public Tab Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("No closed tabs to restore.");
                return null;
            }
            return stack[top--];
        }
    }
}