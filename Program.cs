using System;
using System.IO;
using System.Globalization;


namespace Sales
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"D:\Projetos Visual Studio\Sales\Sale.csv";
            string targetPath = @"D:\Projetos Visual Studio\Sales\Summary.csv";

            try
            {
                using (StreamReader sr = File.OpenText(sourcePath))
                {
                    Sale[] mat = new Sale[(int)sr.BaseStream.Length];
                    int n = 0;
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string product = line[0];
                        double price = double.Parse(line[1], CultureInfo.InvariantCulture);
                        int qty = int.Parse(line[2]);
                        mat[n] = new Sale(product, price, qty);
                        Console.WriteLine(mat[n].ToString());

                        using (StreamWriter sw = File.AppendText(targetPath))
                        {
                            sw.WriteLine(mat[n]);
                        }
                        n++;
                    }
                }


            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
