using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfProjetoDjisktra
{
    class Path
    {
        public Node nóOrigem { get; set; }
        public Node nóDestino { get; set; }

        public int pesoCaminho { get; set; }

        public string fromNode
        {   get {return nóOrigem.nome;} }

        public string toNode
        { get { return nóDestino.nome; } }


        public Path(Node _nóOrigem, Node _nóDestino, int _pesoCaminho)
        {
            nóOrigem = _nóOrigem;
            nóDestino = _nóDestino;
            pesoCaminho = _pesoCaminho;
        }

        
    }
}
