using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HW_1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите колличество элементов массива:\t");
            int elementsCount = int.Parse(Console.ReadLine());
            int[] arr = new int[elementsCount];
            var rnd = new Random();
            int countA = 0;
            int countB = 0;
            int indexA = 0;
            int indexB = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 26);
                if (arr[i] % 2 == 0)
                {
                    countA++;
                }
                else countB++;
            }
            int[] arrA = new int[countA];
            int[] arrB = new int[countB];
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] % 2 == 0)
                {
                    arrA[indexA] = arr[i];
                    indexA++;
                }
                else
                {
                    arrB[indexB] = arr[i];
                    indexB++;
                }

            }
            List<char> list = new List<char>();
            for (char c = 'a'; c <= 'z'; ++c)
            {
                list.Add(c);
            }

            char[] alphabet = list.ToArray(); //English Alphabet
            char[] buchA = new char[countA];
            char[] buchB = new char[countB];
            char[] registr = new char[] { 'a', 'e', 'i', 'd', 'h', 'j' };
            int indexa = 0;
            int writeA = 0;
            for (int i = 0; i < arrA.Length; i++)
            {
                int elementary = arrA[i];
                buchA[indexa] = alphabet[elementary - 1];
                foreach (char ell in registr)
                {
                    if (buchA[indexa] == ell)
                    {
                        buchA[indexa] = char.ToUpper(buchA[indexa]);
                        writeA++;
                    }
                }
                indexa++;
            }
            int indexb = 0;
            int writeB = 0;
            for (int i = 0; i < arrB.Length; i++)
            {
                int elementary = arrB[i];
                buchB[indexb] = alphabet[elementary - 1];
                foreach (char ell in registr)
                {
                    if (buchB[indexb] == ell)
                    {
                        buchB[indexb] = char.ToUpper(buchB[indexb]);
                        writeB++;
                    }
                }
                indexb++;
            }
            if (writeA > writeB)
            {
                for (int i = 0; i < buchA.Length; i++)
                {
                    Console.WriteLine(buchA[i]);
                }
            }
            else
            {
                for (int i = 0; i < buchB.Length; i++)
                {
                    Console.WriteLine(buchB[i]);
                }

            }
            for (int i = 0; i < buchA.Length; i++)
            {
                Console.Write(buchA[i] + " ");
            }
            for (int i = 0; i < buchB.Length; i++)
            {
                Console.Write(buchB[i] + " ");
            }
        }
    }
}