using System;
using UnityEngine;

public class Main1 : MonoBehaviour
{
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
    }
}
