﻿namespace Buylist.Domain
{
    public class Compra
    {
        public Compra()
        {
            Itens = new List<Item>();
        }
        public int CompraId { get; set; }
        public string? Descricao { get; set; }
        public DateTime Data { get; set; }
        public bool Finalizada { get; set; }

        public decimal? Total { get; set; }
        public int LocalId { get; set; }
        public virtual Local? Local { get; set; }
        public ICollection<Item>? Itens { get; set; }
        
    }
}