using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tugas8
{
    public class Sales : Karyawan
    {
        public int JumlahPenjualan { get; set; }
        public int Upah { get; set; }
        public override double Gaji()
        {
            return JumlahPenjualan * Upah;
        }
    }
}
