using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _30_NgoThiThuyLinh_Buoi3_OOP
{
    class TamGiac
    {
        private int ma;
        private int mb;
        private int mc;
        public int MA
        {
            get { return ma; }
            set
            {
                if (value < 0)
                    value = 0;
            }
        }
        public int MB
        {
            get { return mb; }
            set
            {
                if (value < 0)
                    value = 0;
            }
        }
        public int MC
        {
            get { return mc; }
            set
            {
                if (value < 0)
                    value = 0;
            }
        }
        //constructor khong tham so
        public TamGiac()
        {
            ma = 0;
            mb = 0;
            mc = 0;
        }
        //constructor co tham so
        public TamGiac(int a, int b, int c)
        {
            ma = a;
            mb = b;
            mc = c;
        }
        public int ChuVi()
        {
            return ma + mb + mc;
        }
        public double DienTich()
        {
            double p = (ma + mb + mc) / 2;
            return Math.Sqrt(p * (p - ma) * (p - mb) * (p - mc));
        }
        public string LoaiTamGiac()
        {
            if (ma == mb && mb == mc && ma == mc)
                return "Tam Giac Deu";
            else if ((ma == mb && mc != ma && mb != mc) || (mb == mc && mc != ma && mb != ma) || (ma == mc && mb != ma && mb != mc))
                return "Tam Giac Can";
            else if (Math.Pow(mb, 2) + Math.Pow(mc, 2) == Math.Pow(ma, 2) || Math.Pow(ma, 2) + Math.Pow(mb, 2) == Math.Pow(mc, 2) || Math.Pow(ma, 2) + Math.Pow(mc, 2) == Math.Pow(mb, 2))
                return "Tam giac Vuong";
            return "Tam Giac Thuong";
        }
        public string Xuat()
        {
            return ma.ToString()+'\t'+mb.ToString()+'\t'+mc+'\t'+LoaiTamGiac()+'\t'+ChuVi()+'\t'+DienTich();
        }
    }
}
