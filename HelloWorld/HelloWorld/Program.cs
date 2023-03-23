using Microsoft.VisualBasic;
using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
namespace PeoPle
{
    public class InfoMaTion
    {
        //khai bao truong
        private string id;
        private string name;
        private int age;
        private string country;
        //query and update
        public string ID
        {
            get { return id; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    id = value;
                }
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                }
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (age != 0 && age > 0)
                {
                    age = value;
                }
            }
        }
        public string Country
        {
            get { return country; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    country = value;
                }
            }
        }
        //thiet lap ban dau 
        public InfoMaTion()
        {
            id = "2154545";
            name = "Nguyen van A";
            age = 1;
            country = "Phu yen";
        }
        //phuong thuc Nhap
        public void Nhap()
        {
            Console.Write("Import ID CCCD/CMD :  ");
            id = Convert.ToString(Console.ReadLine());
            Console.Write("Import Your Name : ");
            name = Convert.ToString(Console.ReadLine());
            Console.Write("Import Your Age : ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Import Your Country : ");
            country = Convert.ToString(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine(" Thong tin CCCD/CMND =  {0} + Họ và Tên =  {1} + Tuổi = {2} + Country = {3}", id, name, age, country);
        }
    }
    public class ListInfomation
    {
        int n; //So luong nguoi can nhap thong tin
        InfoMaTion[] Listinfo;
        public void Nhap()
        {
            Console.Write("Enter the number of person to fill in information :  ");
            n = int.Parse(Console.ReadLine());
            Listinfo = new InfoMaTion[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("PerSon {0} ", i + 1);
                Listinfo[i] = new InfoMaTion();
                Listinfo[i].Nhap();
            }
        }
        public void Xuat()
        {
            Console.WriteLine("Number of person entered :");
            for(int i = 0; i < n; i++)
            {
                Listinfo[i].Xuat();
            }
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            ListInfomation info = new ListInfomation();
            info.Nhap();
            info.Xuat();
        }
    }
}