using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        string[] array1 = new string[8] { "7", "3", "4", "6", "9", "1", "4", "3" };
        string[] array2 = new string[4] { "2", "3", "8", "7" };
        List<string> list = new List<string>();

        Console.Write("array1 is: ");
        ShowArray(array1);
        Console.Write("list is: ");
        ShowList(list);

        AddArrayToList(array1, list);
        Console.Write("array1 + list is: ");
        ShowList(list);
        Console.WriteLine();

        Console.Write("array2 is: ");
        ShowArray(array2);

        AddArrayToList(array2, list);
        Console.Write("array2 + list is: ");
        ShowList(list);
    }

    static void AddArrayToList(string[] array, List<string> list)
    {
        for (int i = 0; i < array.Length; i++)
        {
            bool isRepit = false;

            for (int j = 0; j < i; j++)
            {
                if (array[i] == array[j])
                    isRepit = true;
            }

            if (isRepit == false)
            {
                foreach (var element in list)
                {
                    if (element == array[i])
                        isRepit = true;
                }

                if ((isRepit == false))
                    list.Add(array[i]);
            }
        }
    }

    static void ShowArray(string[] array)
    {
        for (int i = 0; i < array.Length; i++)
            Console.Write(array[i] + " ");

        Console.WriteLine();
    }

    static void ShowList(List<string> list)
    {
        foreach (var element in list)
            Console.Write(element + " ");

        Console.WriteLine();
    }
}