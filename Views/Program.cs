using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace View
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // Solicitando o login dentro da MAIN
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Instância do formulário login
            Login frm = new Login();
            // Se o resultado do dialogo for ok ou seja se o usuario e login constarem no bd
            if (frm.ShowDialog() == DialogResult.OK)
            {
                // Abro o formulário principal
                Application.Run(new Menu());
            }
            else
            {
                // Senão mostro a mensagem e reabro a tela de login
                MessageBox.Show("Usuário e/ou Senha inválido.");
                Application.Run(new Login());
            }
        }
        public class Login : Form
        {
            // public bool logado = false;
            // public static string usuarioConectado;
            Library.PictureBox pb_Imagem;

            Library.GroupBox lbl_DadosUsuario;

            Library.Label lbl_Usuario;
            Library.Label lbl_SenhaUsuario;

            Library.TextBox txt_Usuario;
            Library.TextBox txt_SenhaUsuario;
            
            Library.Button btn_Proximo;
            Library.Button btn_Sair;

            // Dados de entrada do Login do Usuário
            public Login()
            {
                // Parêmetros da janela de login
                this.Text = "Login";
                this.BackColor = Color.LightGray;
                this.Font = new Font(this.Font, FontStyle.Bold);
                this.Size = new Size(400, 270);

                // Componentes da Janela
                this.pb_Imagem = new Library.PictureBox();
                this.pb_Imagem.Load("./Views/assets/image.png");
                this.Controls.Add(pb_Imagem);

                this.lbl_Usuario = new Library.Label();
                this.lbl_Usuario.Text = "Usuário:";
                this.lbl_Usuario.Location = new Point(90, 40);
                this.Controls.Add(lbl_Usuario);

                this.txt_Usuario = new Library.TextBox();
                this.txt_Usuario.Location = new Point(90, 60);
                this.Controls.Add(txt_Usuario);

                this.lbl_SenhaUsuario = new Library.Label();
                this.lbl_SenhaUsuario.Text = "Senha :";
                this.lbl_SenhaUsuario.Location = new Point(90, 100);
                this.Controls.Add(lbl_SenhaUsuario);

                this.txt_SenhaUsuario = new Library.TextBox();
                this.txt_SenhaUsuario.Location = new Point(90, 120);
                this.Controls.Add(txt_SenhaUsuario);

                this.btn_Proximo = new Library.Button();
                this.btn_Proximo.Text = "Próximo";
                this.btn_Proximo.Location = new Point(50, 160);
                this.btn_Proximo.BackColor = Color.Green;
                this.btn_Proximo.ForeColor = Color.Black;
                this.btn_Proximo.Click += new EventHandler(this.btn_ProximoClick);
                this.Controls.Add(btn_Proximo);

                this.btn_Sair = new Library.Button();
                this.btn_Sair.Text = "Sair";
                this.btn_Sair.Location = new Point(210, 160);
                this.btn_Sair.BackColor = Color.Red;
                this.btn_Sair.ForeColor = Color.Black;
                this.btn_Sair.Click += new EventHandler(this.btn_SairClick);
                this.Controls.Add(btn_Sair);

                this.lbl_DadosUsuario = new Library.GroupBox();
                this.lbl_DadosUsuario.Location = new Point(10, 10);
                this.lbl_DadosUsuario.Text = "Dados do Usuário";
                this.Controls.Add(lbl_DadosUsuario);
            }

            // Botão de confirmação do Login
            private void btn_ProximoClick(object sender, EventArgs e)
            {
                // Método que testa o retorno com os parâmetros (true)
                if (ValidaUsuario(txt_Usuario.Text, txt_SenhaUsuario.Text))
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                }
            }

            //Método de validação do Usuário (2 strings - Login e Senha)
            private bool ValidaUsuario(string LoginUsuario, string SenhaUsuario)
            {
                // Acesso ao método Campos Preenchidos Obrigatorio
                bool resultado = Controllers.UsuarioController.CampoLogin(LoginUsuario, SenhaUsuario);
                if (resultado)
                {
                    // Variável para teste de retorno
                    int retorno = -1;
                    // Instância da conexão
                    MySqlConnection conn = new MySqlConnection(@"Server=localhost;User Id=root;Database=socialdev;");
                    // Comando sql COUNT para buscar Login e Senha
                    string comando = "SELECT COUNT(*) FROM usuarios WHERE LoginUsuario=@LoginUsuario AND SenhaUsuario=@SenhaUsuario";
                    // Instância do comando
                    MySqlCommand cmd = new MySqlCommand(comando, conn);
                    // Preenchimento dos parâmetros
                    cmd.Parameters.AddWithValue("@LoginUsuario", LoginUsuario);
                    cmd.Parameters.AddWithValue("@SenhaUsuario", SenhaUsuario);
                    // Abre a conexão
                    conn.Open();
                    // Retorno recebe o resultado do execute "scalar"
                    retorno = Convert.ToInt32(cmd.ExecuteScalar());
                    //var reader = cmd.ExecuteReader(); 

                    // Busca pela coluna "CidadeUsuario" dentro do BD
                    // if (retorno > 0)
                    // {

                    //     logado = true;
                    //     usuarioConectado = reader ["CidadeUsuario"].ToString();
                    //     this.Dispose();
                    // }
                    // else
                    // {
                    //     logado = false;
                    //     MessageBox.Show("Usuário e/ou Senha inválido.");
                    // }

                    // Fecho a conexão
                    conn.Close();
                    // Retorno true se retorno for maior que zero
                    return retorno > 0;
                }
                else
                {
                    return false;
                }
            }

            // Botão Sair do Login
            private void btn_SairClick(object sender, EventArgs e)
            {
                this.Close();
            }
        }
    }
}