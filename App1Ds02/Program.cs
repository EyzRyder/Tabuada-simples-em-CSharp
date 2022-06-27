using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1Ds02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual tabuada que vc quer ver? ");
            int tab = Convert.ToInt16(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{tab} x {i} = {tab*i}      {tab+1} x {i} = {(tab+1) * i}      {tab+2} x {i} = {(tab+2) * i}");
            }
            Console.ReadLine();
        }
    }
}
