using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjectDemo
{

    class Student
    {
        public int rno;
        public string name;
        public double per;
        public void getdata()
        {
            Console.WriteLine("Enter rno");
            rno=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name");
            name =Console.ReadLine();
            Console.WriteLine("Enter Per");
            per = Convert.ToDouble(Console.ReadLine());
        }
        public void show()
        { 
            Console.WriteLine("Rno="  +rno);
            Console.WriteLine("Name=" + name);
            Console.WriteLine("Per=" + per);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s=new Student();
            s.getdata();
            s.show();
            Console.ReadLine();
        }
    }

}
