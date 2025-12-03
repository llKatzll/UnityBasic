using System;
using UnityEditor.PackageManager;
using UnityEngine;

public class Main1 : MonoBehaviour
{
    //It took me ten years to find the answer to something, I forgot about it in 2 seconds, that's about it
    static void Swap(int a, int b)
    {
        int holder = a;
        a = b;
        b = holder;
    }

    static void Main()
    {
        int x = 10;
        int y = 20;
        Swap(x, y);
        Debug.Log($"{x},{y}");

        //지금 머만드는거징


    }


    //1+2+3+4+5+6 = 21 code? 지금 머 만드는거징
    static int Sum(int start, int end)
    {
        if (start > end)
            return 0;

        return start + Sum(start + 1, end);
        //머 만 드는 거 징 !? 재 귀 함 수!?
    }

    static int Sum2(int n, int o)
    {
        //이미 만든거 아닌감..
        int sum = 0;

        for (int i = n; i < o; i++)
        {
            sum += i;
        }

        return sum;
    }

    static void Add(int a, int b, int c = 0, int d = 0, int e = 1)
    {
        //흠..
        int result = a + b + c + d + e;
        Console.WriteLine($"합계: {result}");
    }
}

