using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chen_vi_tri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] bang = new int[10];
            for (int i = 0; i < bang.Length; i++)
            {
                Console.WriteLine("nhap cac gia tri vao bang ");
                bang[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("nhap gia tri can chen: ");
            int giatri = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap vi tri can chen: ");
            int vitri = int.Parse(Console.ReadLine());
            for (int j = bang.Length; j < vitri; j--)
            {
                bang[j] = bang[j+1];
            }
            bang[vitri] = giatri;
            Console.WriteLine("mang sau khi chen gia tri: ");
                for (int i = 0;i < bang.Length; i++)
            {
                Console.Write(" " + bang[i] + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
