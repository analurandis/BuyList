using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buylist.Domain
{
    public class Local
    {
        public int LocalId { get; set; }
        public string Nome { get; set; }
        public string? Localizacao { get; set; }

        public virtual ICollection<Compra>? Compras { get; set; }
    }

}

