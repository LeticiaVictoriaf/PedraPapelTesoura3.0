namespace PedraPapelTesoura
{
    public partial class Form1 : Form
    {
        private string EscolhadoUsuario;
        private string EscolhadaMaquina;
        private string[] opcoes =
        {
            "PEDRA",
            "PAPEL",
            "TESOURA"

        };
        private int pontosUsuarios, pontosMaquina;
        public Form1()
        {
            InitializeComponent();
        }
        private void SalvaSelecao(string selecao)
        {
            EscolhadoUsuario = selecao;
            textBox4.Text = EscolhadoUsuario;

            SorteiaSelecaoComputador();

            Comparacao();
        }
        private void SorteiaSelecaoComputador()
        {
            Random rand = new Random();
            int sorteio = rand.Next(opcoes.Length);
            EscolhadaMaquina = opcoes[sorteio];
            textBox1.Text = EscolhadaMaquina;
        }
        private void Comparacao()
        {
            if (EscolhadoUsuario == EscolhadaMaquina)
            {
                Text_Resultado.Text = "Deu empate!!! Vamos";
            }
            else if (EscolhadoUsuario == opcoes[0] && EscolhadaMaquina == opcoes[2])
            {
                pontosUsuarios++;
                Text_Resultado.Text = "Você venceu!";
            }
            else if (EscolhadoUsuario == opcoes[1] && EscolhadaMaquina == opcoes[0])
            {
                pontosUsuarios++;
                Text_Resultado.Text = "Você venceu!";


            }
            else if (EscolhadoUsuario == opcoes[2] && EscolhadaMaquina == opcoes[1])
            {
                pontosUsuarios++;
                Text_Resultado.Text = "Você venceu!";
            } else
            {  
                    pontosUsuarios++;
                    Text_Resultado.Text = "Você venceu!";      
            }
             textBox2.Text = pontosUsuarios.ToString();
             textBox3.Text = pontosMaquina.ToString();
        }
    private void button1_Click(object sender, EventArgs e)
        {
            SalvaSelecao(opcoes[0]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SalvaSelecao(opcoes[2]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label_Usuario_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Papel_Click(object sender, EventArgs e)
        {
            SalvaSelecao(opcoes[1]);
        }
    }
}