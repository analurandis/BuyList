using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buylist.Domain
{
    public class Item : Base
    {
        public decimal Valor { get; set; }
        public int Quantidade { get; set; }
        public decimal Total { get; set; }
        
        public int CompraId { get; set; }
        public int ProdutoId { get; set; }
        public virtual Produto?Produto { get; set; }

        public virtual Compra? Compra { get; set; }
    }
}
