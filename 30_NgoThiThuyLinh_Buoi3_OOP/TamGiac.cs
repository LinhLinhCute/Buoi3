using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Math;

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
                else if (value + mb < mc || value + mc < mb || value > mb + mc)
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
                else if (value + ma < mc || value + mc < ma || value > ma + mc)
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
                else if (value + mb < ma || value + ma < mb || value > mb + ma)
                    value = 0;
            }
        }
        //constructor khong tham so
        public TamGiac()
        {
            ma = 1;
            mb = 1;
            mc = 1;
        }
        //constructor co tham so
        public TamGiac(int ma, int mb, int mc)
        {
            MA = ma;
            MB = mb;
            MC = mc;
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
        public string ToString()
        {
            if (ma == mb && mb == mc && ma==mc)
                return "Tam Giac Deu";
            else if(ma == mb || mb == mc || ma==mc)
        }
    }
}
