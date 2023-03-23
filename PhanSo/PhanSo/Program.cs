using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
namespace Appp1
{
    class PhanSo
    {
        //cac truong luu du lieu cua bien
        private int tuSo;
        private int mauSo;
        //query and update
        public int TuSo
        {
            get { return tuSo; }
            set
            {
                if (mauSo != 0)
                {
                    tuSo = value;
                }
            }
        }
        public int MauSo
        {
            get { return mauSo; }
            set
            {
                if (mauSo != 0)
                {
                    mauSo = value;
                }
            }
        }
        //thiet lap ban dau 
        public PhanSo(int ts = 0, int ms = 0)
        {
            this.tuSo = ts;
            this.mauSo = ms;
        }
        //phuong thuc Nhap
        public void Nhap()
        {
            Console.Write("Nhap tu so : ");
            tuSo = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau so : ");
            mauSo = int.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.Write("\nPhan so vua nhap :{0}/{1} \n ", tuSo, mauSo);
        }
        public double GetValue()
        {
            return (double)tuSo / mauSo;
        }
        public void ToiGian()
        {
            int uc = UCLN.ucln(tuSo, mauSo);
            tuSo /= uc;
            mauSo /= uc;
        }
    }
    class DSPhanSo
    {
        int n; //so luong phan tu
        PhanSo[] ListPhanSo;
        public void Nhap()
        {
            Console.Write("Nhap so luong phan tu : ");
            n = int.Parse(Console.ReadLine());
            ListPhanSo = new PhanSo[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Phan so thu {0}", i + 1);
                ListPhanSo[i] = new PhanSo();
                ListPhanSo[i].Nhap();
            }
        }
        public void Xuat()
        {
            for (int i = 0; i < n; i++)
            {
                ListPhanSo[i].Xuat();
            }
        }
        public void ToiGian()
        {
            for (int i = 0; i < n; i++)
            {
                ListPhanSo[i].ToiGian();
                ListPhanSo[i].Xuat();
            }
        }
        public void PhanSoMax()
        {
            int index = 0;
            double max = ListPhanSo[0].GetValue();
            for (int i = 1; i < n; i++)
            {
                if (ListPhanSo[i].GetValue() > max)
                {
                    max = ListPhanSo[i].GetValue();
                }
            }
            Console.Write("Phan So Lon Nhat Cua Mang : {0}\n", max);
        }
        public void swap(double a, double b)
        {
            double temp = a;
            a = b;
            b = temp;
        }
        public void SapXep()
        {
            double max = ListPhanSo[0].GetValue();
            for (int i = 1; i < n; i++)
            {
                if (ListPhanSo[i].GetValue() > max)
                {
                    swap(ListPhanSo[i].GetValue(), max);
                }
            }
            Console.WriteLine("Mang sau khi duoc sap xep la : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(ListPhanSo[i].GetValue() + " ");
            }
        }
    }
    public static class UCLN
    {
        public static int ucln(int a, int b)
        {
            if (a == 0 || b == 0) return a + b;
            while (a != b)
            {
                if (a > b) a = a - b; else b = b - a;
            }
            return a;
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            PhanSo ps = new PhanSo();
            ps.Nhap();
            ps.Xuat();
            ps.GetValue();
            DSPhanSo dsps = new DSPhanSo();
            dsps.Nhap();
            dsps.Xuat();
            Console.WriteLine("\nPhan so sau khi toi gian");
            dsps.ToiGian();
            dsps.PhanSoMax();
            dsps.SapXep();
        }
    }
}