using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace wfProjetoDjisktra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void go_btn_Click(object sender, EventArgs e)
        {
            var Grupiara = new Node("Grupiara");
            var Estrela_do_Sul = new Node("Estrela do Sul");
            var Romaria = new Node("Romaria");
            var Sao_Juliana = new Node("São Juliana");
            var Indianopolis = new Node("Indianópolis");
            var CascalhoRico = new Node("Cascalho Rico");
            var Araguari = new Node("Araguari");
            var Uberlândia = new Node("Uberlândia");
            var Tupaciguara = new Node("Tupaciguara");
            var Monte_Alegre_de_Minas = new Node("Monte Alegre de Minas");
            var Douradinhos = new Node("Douradinhos");
            var Itumbiara = new Node("Itumbiara");
            var Centralina = new Node("Centralina");
            var Ituiutaba = new Node("Ituiutaba");
            var Capinópolis = new Node("Capinópolis");
            var aux = new Node("auxiliar");
            Node partida = aux;
            Node destino = aux;
            Node[] nós = new Node[] { Grupiara, Estrela_do_Sul, Romaria, Sao_Juliana, Indianopolis, CascalhoRico, Araguari, Uberlândia, 
                                        Tupaciguara, Monte_Alegre_de_Minas, Douradinhos, Itumbiara, Centralina, Ituiutaba, Capinópolis };
            
            Path[] caminhos = new Path[44];
            caminhos[0] = new Path(Grupiara, CascalhoRico, 32);
            caminhos[1] = new Path(CascalhoRico, Grupiara, 32);
            caminhos[2] = new Path(Grupiara, Estrela_do_Sul, 38);
            caminhos[3] = new Path(Estrela_do_Sul, Grupiara, 38);
            caminhos[4] = new Path(CascalhoRico, Araguari, 28);
            caminhos[5] = new Path(Araguari, CascalhoRico, 28);
            caminhos[6] = new Path(Araguari, Estrela_do_Sul, 34);
            caminhos[7] = new Path(Estrela_do_Sul, Araguari, 34);
            caminhos[8] = new Path(Estrela_do_Sul, Romaria, 27);
            caminhos[9] = new Path(Romaria, Estrela_do_Sul, 27);
            caminhos[10] = new Path(Araguari, Uberlândia, 30);
            caminhos[11] = new Path(Uberlândia, Araguari, 30);
            caminhos[12] = new Path(Romaria, Sao_Juliana, 28);
            caminhos[13] = new Path(Sao_Juliana, Romaria, 28);
            caminhos[14] = new Path(Uberlândia, Romaria, 78);
            caminhos[15] = new Path(Romaria, Uberlândia, 78);
            caminhos[16] = new Path(Sao_Juliana, Indianopolis, 40);
            caminhos[17] = new Path(Indianopolis, Sao_Juliana, 40);
            caminhos[18] = new Path(Uberlândia, Indianopolis, 45);
            caminhos[19] = new Path(Indianopolis, Uberlândia, 45);
            caminhos[20] = new Path(Uberlândia, Tupaciguara, 60);
            caminhos[21] = new Path(Tupaciguara, Uberlândia, 60);
            caminhos[22] = new Path(Uberlândia, Monte_Alegre_de_Minas, 60);
            caminhos[23] = new Path(Monte_Alegre_de_Minas, Uberlândia, 60);
            caminhos[24] = new Path(Uberlândia, Douradinhos, 63);
            caminhos[25] = new Path(Douradinhos, Uberlândia, 63);
            caminhos[26] = new Path(Tupaciguara, Itumbiara, 55);
            caminhos[27] = new Path(Itumbiara, Tupaciguara, 55);
            caminhos[28] = new Path(Tupaciguara, Monte_Alegre_de_Minas, 44);
            caminhos[29] = new Path(Monte_Alegre_de_Minas, Tupaciguara, 44);
            caminhos[30] = new Path(Monte_Alegre_de_Minas, Douradinhos, 28);
            caminhos[31] = new Path(Douradinhos, Monte_Alegre_de_Minas, 28);
            caminhos[32] = new Path(Monte_Alegre_de_Minas, Ituiutaba, 85);
            caminhos[33] = new Path(Ituiutaba, Monte_Alegre_de_Minas, 85);
            caminhos[34] = new Path(Monte_Alegre_de_Minas, Centralina, 75);
            caminhos[35] = new Path(Centralina, Monte_Alegre_de_Minas, 75);
            caminhos[36] = new Path(Douradinhos, Ituiutaba, 90);
            caminhos[37] = new Path(Ituiutaba, Douradinhos, 90);
            caminhos[38] = new Path(Ituiutaba, Capinópolis, 30);
            caminhos[39] = new Path(Capinópolis, Ituiutaba, 30);
            caminhos[40] = new Path(Capinópolis, Centralina, 40);
            caminhos[41] = new Path(Centralina, Capinópolis, 40);
            caminhos[42] = new Path(Centralina, Itumbiara, 20);
            caminhos[43] = new Path(Itumbiara, Centralina, 20);

            switch (cb_partida.SelectedIndex)
                {
                    case 0:
                        partida = Araguari;
                        break;
                    case 1:
                        partida = Capinópolis;
                        break;
                    case 2:
                        partida = CascalhoRico;
                        break;
                    case 3:
                        partida = Centralina;
                        break;
                    case 4:
                        partida = Douradinhos;
                        break;
                    case 5:
                        partida = Estrela_do_Sul;
                        break;
                    case 6:
                        partida = Grupiara;
                        break;
                    case 7:
                        partida = Indianopolis;
                        break;
                    case 8:
                        partida = Ituiutaba;
                        break;
                    case 9:
                        partida = Itumbiara;
                        break;
                    case 10:
                        partida = Monte_Alegre_de_Minas;
                        break;
                    case 11:
                        partida = Romaria;
                        break;
                    case 12:
                        partida = Sao_Juliana;
                        break;
                    case 13:
                        partida = Tupaciguara;
                        break;
                    case 14:
                        partida = Uberlândia;
                        break;
                }
                switch (cb_destino.SelectedIndex)
                {
                    case 0:
                        destino = Araguari;
                        break;
                    case 1:
                        destino = Capinópolis;
                        break;
                    case 2:
                        destino = CascalhoRico;
                        break;
                    case 3:
                        destino = Centralina;
                        break;
                    case 4:
                        destino = Douradinhos;
                        break;
                    case 5:
                        destino = Estrela_do_Sul;
                        break;
                    case 6:
                        destino = Grupiara;
                        break;
                    case 7:
                        destino = Indianopolis;
                        break;
                    case 8:
                        destino = Ituiutaba;
                        break;
                    case 9:
                        destino = Itumbiara;
                        break;
                    case 10:
                        destino = Monte_Alegre_de_Minas;
                        break;
                    case 11:
                        destino = Romaria;
                        break;
                    case 12:
                        destino = Sao_Juliana;
                        break;
                    case 13:
                        destino = Tupaciguara;
                        break;
                    case 14:
                        destino = Uberlândia;
                        break;
                }            

            Node nóatual = partida;
            nóatual.vtrabalho = 0;
            nóatual.rotulagem = 1;

            
            int lcontador = 2;
            int Contador_nós = nós.Count();
            bool op = true;
            

            while (op)
            {
                foreach (Path path in caminhos)
                    if (path.nóOrigem == nóatual)
                        if (path.nóDestino.vtrabalho > (nóatual.vtrabalho + path.pesoCaminho))
                            path.nóDestino.vtrabalho = nóatual.vtrabalho + path.pesoCaminho;
                
                int valorMinimoTrabalho = int.MaxValue;
                Node proximoNó = nóatual;
                foreach (Node nó in nós)
                {
                    if (nó.vtrabalho < valorMinimoTrabalho && nó.rotulagem == null)
                    {
                        valorMinimoTrabalho = nó.vtrabalho;
                        proximoNó = nó;
                    }
                }
                nóatual = proximoNó;
                proximoNó.rotulagem = lcontador;
                if (lcontador == Contador_nós)
                    op = false;
                lcontador++;
            }
            ObtemCaminho(nós, caminhos, partida, destino);
            
        }
        private void ObtemCaminho(Node[] nodes, Path[] paths, Node start, Node end)
        {
            try
            {
                Node currentNode = end;
                bool op = true;
                List<Node> finalPath = new List<Node>();
                finalPath.Add(currentNode);
                int totalWeight = 0;

                while (op)
                {
                    List<Node> relatedPaths = new List<Node>();
                    bool found = false;
                    int pathCount = 0;
                    while (!found)
                    {
                        Path currentPath = paths[pathCount];
                        if (currentPath.nóDestino == currentNode)
                        {
                            if (currentNode.vtrabalho - currentPath.pesoCaminho == currentPath.nóOrigem.vtrabalho)
                            {
                                finalPath.Add(currentPath.nóOrigem);
                                totalWeight += currentPath.pesoCaminho;
                                currentNode = currentPath.nóOrigem;
                                found = true;
                            }
                            else
                            {
                                pathCount++;
                            }
                        }
                        else
                        {
                            pathCount++;
                        }
                    }
                    if (currentNode == start)
                    {
                        op = false;
                    }
                }
                finalPath.Reverse();


                string[] finalPathStrings = new string[finalPath.Count];
                for (int n = 0; n < finalPath.Count; n++)
                {
                    finalPathStrings[n] = finalPath[n].nome;

                }
                MessageBox.Show("Rota percorrida: " + string.Join(", ", finalPathStrings) + "\nTotal caminhado: " + totalWeight.ToString());
                for (int i = 0; i < finalPathStrings.Count(); i++)
                {
                    switch (finalPathStrings[i])
                    {
                        case "Uberlândia":
                            pbUberlandia.Visible = true;
                            break;
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Escolha o caminho de partida e destino distintos");


            }

        }
        private void plotCamino(string[] caminho)
        {
            for (int i = 0; i <= caminho.Count(); i++)
            {
                switch (caminho[i])
                { 
                    case "Uberlândia":
                        pbUberlandia.Visible = true;
                        break;
                }
            }
                        
        }
    }
}
