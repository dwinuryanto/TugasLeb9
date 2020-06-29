using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tugas8
{ 
    public class KaryawanHarian : Karyawan
    {
        public double UpahPerJam { get; set; }
        public double JumJamKerja { get; set; }
        public override double Gaji()
        {
            return JumJamKerja * UpahPerJam;
        }
    }
}
