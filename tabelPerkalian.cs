﻿using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Class1
{
	public Class1()
	{
        static void Main(string[] args)
        {
            Console.WriteLine("=== TABEL PERKALIAN 1 - 10 ===\n");

            for (int i = 1; i <= 10; i++) 
            {
                for (int j = 1; j <= 10; j++) 
                {
                    Console.Write($"{i * j,4}"); 
                }
                Console.WriteLine(); 
            }

            Console.WriteLine("\nTekan ENTER untuk keluar...");
            Console.ReadLine();
        }

    }
}
