using System;
using LearningCSharp;
using static System.Console;
namespace LearningCSharp
{
    class Program
    {
        public static void swap(ref int x ,ref int  y)
        {
            int temp = x;
            x=y;
            y = temp;
        }

        static void Main(string[] args)
        {
            //bai 1
            //int a, b;
            //Console.Write("Nhap vao so thu nhat :");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Nhap vao so thu hai :");
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("-----------------");
            //int sum = a + b;
            //int minus = a - b;
            //int mul = a * b;
            //float th = (float)a / (float)b;
            //Console.WriteLine("Tong cua hai so la : " + sum);
            //Console.WriteLine("Tich cua hai so la : " + mul);
            //Console.WriteLine("Hieu cua hai so la : " + minus);
            //Console.WriteLine("Thuong cua hai so la : " + th);
            //bai 2
            //int x, y;
            //x = 1;
            //y = 2;
            //Console.WriteLine("Gia tri cua x truoc khi thay doi : " + x);
            //Console.WriteLine("Gia tri cua y truoc khi thay doi : " + y);
            //swap(ref x, ref y);
            //Console.WriteLine("Gia tri cua x sau khi thay doi : " + x);
            //Console.WriteLine("Gia tri cua y sau khi thay doi : " + y);
            //bai 3 
            //Console.WriteLine("Nhap vao so input : ");

            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Bang nhan cua so la : ");
            //for (int i = 1; i <10 ; i++)
            //{
            //    Console.WriteLine(num * i);
            //}
            //bai 4
            //Console.WriteLine("Nhap vao 4 so :");
            //decimal a = Convert.ToDecimal(Console.ReadLine());
            //decimal b = Convert.ToDecimal(Console.ReadLine());
            //decimal c = Convert.ToDecimal(Console.ReadLine());
            //decimal d = Convert.ToDecimal(Console.ReadLine());

            //decimal tb = (a + b + c + d) / 4;
            //Console.WriteLine("Trung binh cong cua bon so la : " + tb);
            Console.WriteLine("Hello Motherfucker");
            //bai 5
            decimal dof;
            decimal doc;
            Console.WriteLine("Ban muon doi do F sang C hay C sang F ? Nhap 1 neu F=> C, nhap 2 neu C=>F :");
            int choice = Convert.ToInt32(Console.ReadLine());
            while (choice != 1 && choice != 2)
            {
                Console.WriteLine("Ban nhap sai so roi, hay nhap lai :");
                choice = Convert.ToInt32(Console.ReadLine());
            }
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Nhap vao do F : ");

                    dof = Convert.ToDecimal(Console.ReadLine());
                    doc = (dof-32) * (5 / 9);
                    Console.WriteLine("Do C la  : "+doc);
                    break;
                case 2:
                    Console.WriteLine("Nhap vao do C : ");

                    doc = Convert.ToDecimal(Console.ReadLine());
                    dof = (doc  * (9 / 5))+ 32;
                    Console.WriteLine("Do F la  : " + dof);
                    break;
                default:
                    Console.WriteLine("Ko vao day dau, viet cho du kien truc cua switch case thoi ");
                    break;

            }
        }


    }
}
