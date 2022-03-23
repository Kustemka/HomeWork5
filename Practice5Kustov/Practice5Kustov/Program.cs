using System;
using System.Collections.Generic;

namespace Practice5Kustov
{
    class Program
    {
       
        static string[] SplitOnWords(string text)
        {
            string[] words;
            words = text.Split(' ');
            return words;
        }
       
        static string[] Print(string[] text)
        {
            string[] arr = text;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.WriteLine(arr[i]);
                
            }
            return arr;
        }
        static void Delay()
        {
        Console.ReadKey();
        }

         
        static string[] Reverse(string text)
        {
            string[] words;
            words = SplitOnWords(text);
            for (int i = words.Length - 1; i >= 0; i--)
            {
                Console.Write($"{words[i]} ");
            }
            return words;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст через пробел для разделения слов:");
            string sentence = Console.ReadLine();
            SplitOnWords(sentence);
            Print(SplitOnWords(sentence));
            Delay();
            Console.WriteLine("\nВведите текст через пробел для того, чтобы перевернуть предложение:");
            string secondSentence = Console.ReadLine();
            Reverse(secondSentence);
            Delay();
        }
    }
    }
