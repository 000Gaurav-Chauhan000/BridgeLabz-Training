using System;

namespace HospitalRouting
{
    class CircularLinkedList
    {
        private UnitNode head;

        public void AddUnit(string name, bool available = true)
        {
            UnitNode newNode = new UnitNode(name, available);

            if (head == null)
            {
                head = newNode;
                newNode.Next = head;
                return;
            }

            UnitNode temp = head;
            while (temp.Next != head)
                temp = temp.Next;

            temp.Next = newNode;
            newNode.Next = head;
        }

        public void RemoveUnit(string name)
        {
            if (head == null) return;

            UnitNode curr = head;
            UnitNode prev = null;

            do
            {
                if (curr.Name == name)
                {
                    if (prev != null)
                        prev.Next = curr.Next;
                    else
                    {
                        UnitNode last = head;
                        while (last.Next != head)
                            last = last.Next;

                        head = head.Next;
                        last.Next = head;
                    }

                    Console.WriteLine($"{name} removed (Maintenance)");
                    return;
                }

                prev = curr;
                curr = curr.Next;

            } while (curr != head);
        }

        public UnitNode GetHead() => head;
    }
}
