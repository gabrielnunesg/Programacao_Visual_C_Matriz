namespace Matriz_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMatriz_Click(object sender, EventArgs e)
        {
            lstMatriz.Items.Clear();

            //variáveis para acessar as posições dos índices da matriz

            //i - representa linha
            //j - representa coluna

            int i, j;

            //declara a variável nomes omitindo o tamanho da variável e utilizando a lista inicializadora

            string[,] nomes = new string[,] { { "João", "Antonio" }, { "Maria", "Ana" } };

            for(i = 0; i < 2; i++) //percorre as linhas
            {
                for(j = 0; j < 2; j++) //percorre as colunas
                {
                    lstMatriz.Items.Add(nomes[i, j]);
                }
            }
        }
    }
}