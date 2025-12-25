using System;

class NumberCheckerV4{
    static int[] StoreDigits(int num){

        int len = num.ToString().Length;
        int[] d = new int[len];
        for (int i = len - 1; i >= 0; i--){
            d[i] = num % 10;
            num /= 10;
        }
        return d;
    }

    static int[] Reverse(int[] arr){
        int[] rev = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
            rev[i] = arr[arr.Length - 1 - i];
        return rev;
    }

    static bool IsPalindrome(int[] a){
        int[] r = Reverse(a);
        for (int i = 0; i < a.Length; i++)
            if (a[i] != r[i]) return false;
        return true;
    }

    static bool IsDuck(int[] digits){
        foreach (int d in digits)
            if (d != 0) return true;
        return false;
    }

    static void Main(){

        Console.Write("enter number : ");
        int num = int.Parse(Console.ReadLine());

        int[] digits = StoreDigits(num);

        Console.WriteLine("palindrome : " + IsPalindrome(digits));
        Console.WriteLine("duck number : " + IsDuck(digits));
    }
}
