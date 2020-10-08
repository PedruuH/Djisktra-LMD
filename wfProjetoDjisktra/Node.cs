using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfProjetoDjisktra
{
    class Node
    {
        public string nome { get; set; }
        public int? rotulagem { get; set; }
        public int vtrabalho { get; set; }

        public Node(string _nome)
        {
            nome = _nome;
            rotulagem = null;
            vtrabalho = int.MaxValue;
        }
    }
}
