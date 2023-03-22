using OkeyTable;

internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();
        Table table = new Table(); 
        List<Table> tables = CreateRandomTables(200);
      
        Console.WriteLine("---------------------Okey'e Hoşgeldiniz!---------------------\nLütfen tercih ettiğiniz masanın özelliklerini giriniz!");
        table = CreateNewTable();
        FilterTables(tables, table);


        void FilterTables(List<Table> tables, Table table)
        {
            List<Table> filteredTables = new List<Table>();

            foreach (Table t in tables)
            {
                if (t.Bahis <= table.Bahis && t.MasaTipi == table.MasaTipi)
                {
                    filteredTables.Add(t);
                }
            }

            Console.WriteLine($"Uygun {filteredTables.Count} masa bulundu:");

            for(int i = 0; i < filteredTables.Count; i++)
            {
                Console.WriteLine($"No: {i} Bahis: {filteredTables[i].Bahis} - Masa Tipi: {filteredTables[i].MasaTipi}");
            }
        }

        Table CreateNewTable()
        {
            Table table = new Table();
            try
            {
                Console.Write("Lütfen bahis miktarını girin (200-5000 arasında bir tam sayı): ");
                int bahis = int.Parse(s: Console.ReadLine());
                table.Bahis = bahis;

                Console.Write("Lütfen masa tipini girin\n(Hızlı için 1, Teketek için 2, Hızlı ve Teketek için 3, Rövanş için 4, Hızlı ve Rövanş için 5, Teketek ve Rövanş için 6, Hızlı Teketek ve Rövanş için 7): ");
                int masaTipi = int.Parse(s: Console.ReadLine());
                table.MasaTipi = (TableType)masaTipi;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); Console.Read(); }
            

            return table;
        }

        List<Table> CreateRandomTables(int n)
        {
            List<Table> tables = new List<Table>();

            for (int i = 0; i < n; i++)
            {
                tables.Add(new Table
                {
                    Bahis = random.Next(200, 5001),
                    MasaTipi = (TableType)random.Next(1, 8)
                });
            }
            return tables;
        }

        Console.ReadLine();
    }
}