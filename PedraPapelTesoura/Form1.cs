using System.Diagnostics.Eventing.Reader;

namespace PedraPapelTesoura
{
    public partial class Form1 : Form
    {
        private string escolhaUsuario;
        private string escolhaMaquina;
        private string[] opcoes =
        {
            "PEDRA",
            "PAPEL",
            "TESOURA"
        };
        private int pontosUsuario, pontosMaquina;


        public Form1()
        {
            InitializeComponent();

        }

        private void SalvaSelecao(string selecao)
        {
            escolhaUsuario = selecao;
            text_usuario.Text = escolhaUsuario;

            SorteiaSelecaoCompurador();

            comparacao();

        }
        private void SorteiaSelecaoCompurador()
        {
            Random rand = new Random();
            int sorteio = rand.Next(opcoes.Length);
            escolhaMaquina = opcoes[sorteio];
            text_maquina.Text = escolhaMaquina;
        }
        private void comparacao()
        {
            if (escolhaUsuario == escolhaMaquina)
            {
                resultado.Text = "Deu Empate!!!!";
            }
            else if (escolhaUsuario == opcoes[0] && escolhaMaquina == opcoes[2])
            {
                pontosUsuario++;
                resultado.Text = "Você Venceu!";
            }
            else if (escolhaUsuario == opcoes[1] && escolhaMaquina == opcoes[0])
            {
                pontosUsuario++;
                resultado.Text = "Você Venceu!";
            }
            else if (escolhaUsuario == opcoes[2] && escolhaMaquina == opcoes[1])
            {
                pontosUsuario++;
                resultado.Text = "Você Venceu!";
            }
            else
            {
                pontosMaquina++;
                resultado.Text = "Você Perdeu!!";
            }
                placarMaquina.Text = pontosMaquina.ToString();
            placarUsuario.Text = pontosUsuario.ToString();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void text_maquina_TextChanged(object sender, EventArgs e)
        {

        }

        private void bnt_pedra_Click(object sender, EventArgs e)
        {
            SalvaSelecao(opcoes[0]);

        }

        private void bnt_papel_Click(object sender, EventArgs e)
        {
            SalvaSelecao(opcoes[1]);
        }

        private void bnt_tesoura_Click(object sender, EventArgs e)
        {
            SalvaSelecao(opcoes[2]);
        }

        private void text_usuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}