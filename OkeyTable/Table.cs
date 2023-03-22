using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkeyTable
{
    class Table
    {
        private int bahis;
        public int Bahis { get => bahis; set { if (value < 200 || value > 5000) throw new ArgumentOutOfRangeException(); else bahis = value; } }

        private TableType masaTipi;
        public TableType MasaTipi { get => masaTipi; set => masaTipi = value; }

    }
}
