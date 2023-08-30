using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _30_NgoThiThuyLinh_Buoi3_OOP
{
    class Vehicle
    {
        private string chuxe;
        private string loaixe;
        private double trigia;
        private int dungtich;

        public string ChuXe
        {
            get { return chuxe; }
            set{chuxe=value;}
        }
        public string LoaiXe
        {
            get { return loaixe; }
            set { loaixe = value; }
        }
        public double TriGia
        {
            get { return trigia; }
            set
            {
                if (value >= 0)
                    trigia = value;
            }
        }
        public int DungTich
        {
            get { return dungtich; }
            set { 
                if(value>=0)
                 dungtich = value; 
            }
        }
        public Vehicle()
        {
            chuxe = "";
            loaixe = "";
            trigia = 0;
            dungtich = 0;
        }
        public Vehicle(string chuxe, string loaixe, double trigia, int dungtich)
        {
            this.chuxe = chuxe;
            this.loaixe = loaixe;
            this.trigia = trigia;
            this.dungtich = dungtich;
        }
        public double TinhThue()
        {
            if (trigia < 100)
            {
                return trigia * 1 / 100;
            }
            else if (trigia >= 200)
                return trigia * 3 / 100;
            return trigia * 5 / 100;
        }
        public string Xuat()
        {
            return chuxe + '\t' + loaixe + '\t' + dungtich.ToString() + "\t\t" + trigia.ToString() + '\t' + TinhThue();
        }
    }
}
