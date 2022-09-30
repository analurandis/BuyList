namespace Buylist.Domain
{
    public class Compra
    {
        public Compra()
        {
            Itens = new List<Item>();
        }
        public int Id { get; set; }
        public string? Descricao { get; set; }
        public DateTime Data { get; set; }
        public bool Finalizada { get; set; }

        public decimal? Total { get; set; }

        public Local Local { get; set; }
        public List<Item> Itens { get; set; }
        
    }
}