using System.ComponentModel.DataAnnotations.Schema;

namespace Buylist.Domain
{
    public class Compra : Base
    {
       
        public string? Descricao { get; set; }
        public DateTime Data { get; set; }
        public bool Finalizada { get; set; }

        private decimal total { get; set; }

        public decimal Total
        {
            get => total;
            set
            {
                total = 0;          
                if (Itens != null)
                {
                    total = Itens.Sum(x => x.Total); ;
                }
               
            }
        }

        public int LocalId { get; set; }
        public virtual Local? Local { get; set; }
        public ICollection<Item>? Itens { get; set; }
        
    }
}