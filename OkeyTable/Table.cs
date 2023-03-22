namespace OkeyTable
{
    class Table
    {
        private int bahis;
        public int Bahis { get => bahis; set { if (value < 200 || value > 5000) throw new ArgumentOutOfRangeException(); else bahis = value; } }

        private TableType masaTipi;
        public TableType MasaTipi { get => masaTipi; set { if (value < (TableType)0 || value > (TableType)7) throw new ArgumentOutOfRangeException(); else masaTipi = value; } }

    }
}
