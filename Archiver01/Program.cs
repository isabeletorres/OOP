﻿using System;
using System.IO;

namespace Archive01
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\file1.txt";
           
            StreamReader sr = null;

            try
            {
                sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                sr?.Close();
               
            }
        }
    }
}
