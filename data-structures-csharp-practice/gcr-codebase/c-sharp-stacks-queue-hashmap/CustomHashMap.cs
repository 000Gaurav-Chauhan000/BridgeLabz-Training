class HashNode
{
    public int Key;
    public int Value;
    public HashNode Next;

    public HashNode(int key, int value)
    {
        Key = key;
        Value = value;
        Next = null;
    }
}
class CustomHashMap
{
    private int size = 10;
    private HashNode[] buckets;

    public CustomHashMap()
    {
        buckets = new HashNode[size];
    }

    private int GetIndex(int key)
    {
        return key % size;
    }

    public void Put(int key, int value)
    {
        int index = GetIndex(key);
        HashNode head = buckets[index];

        while (head != null)
        {
            if (head.Key == key)
            {
                head.Value = value;
                return;
            }
            head = head.Next;
        }

        HashNode newNode = new HashNode(key, value);
        newNode.Next = buckets[index];
        buckets[index] = newNode;
    }

    public int Get(int key)
    {
        int index = GetIndex(key);
        HashNode head = buckets[index];

        while (head != null)
        {
            if (head.Key == key)
                return head.Value;
            head = head.Next;
        }

        return -1;
    }

    public void Remove(int key)
    {
        int index = GetIndex(key);
        HashNode head = buckets[index];
        HashNode previous = null;

        while (head != null)
        {
            if (head.Key == key)
            {
                if (previous == null)
                    buckets[index] = head.Next;
                else
                    previous.Next = head.Next;
                return;
            }

            previous = head;
            head = head.Next;
        }
    }
}

class Program
{
    static void Main()
    {
        CustomHashMap map = new CustomHashMap();

        map.Put(1, 100);
        map.Put(2, 200);
        map.Put(11, 300);

        Console.WriteLine(map.Get(1));
        Console.WriteLine(map.Get(2));
        Console.WriteLine(map.Get(11));

        map.Remove(2);
        Console.WriteLine(map.Get(2));
    }
}
