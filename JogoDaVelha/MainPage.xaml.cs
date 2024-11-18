namespace JogoDaVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";
        public MainPage()
        {
            InitializeComponent();
        
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.IsEnabled = false;

            if (vez == "X")
            {
                btn.Text = "X";
                vez = "O";
            } else
            {
                btn.Text = "O";
                vez = "X";
            }

            /* Verificação se o X Ganhou na 1° linha */
            if (btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X")
            {
                DisplayAlert("PARABÉNS!!!", "O X ganhou!", "OK");
                Zerar();
            }

            /* Verificação se o O Ganhou na 1° linha */
            if (btn10.Text == "O" && btn11.Text == "O" && btn12.Text == "O")
            {
                DisplayAlert("PARABÉNS!!!", "O O ganhou!", "OK");
                Zerar();
            }

            /* Verificação se o X Ganhou na 2° linha */
            if (btn20.Text == "X" && btn21.Text == "X" && btn22.Text == "X")
            {
                DisplayAlert("PARABÉNS!!!", "O X ganhou!", "OK");
                Zerar();
            }

            /* Verificação se o O Ganhou na 2° linha */
            if (btn20.Text == "O" && btn21.Text == "O" && btn22.Text == "O")
            {
                DisplayAlert("PARABÉNS!!!", "O O ganhou!", "OK");
                Zerar();
            }

            /* Verificação se o X Ganhou na 3° linha */
            if (btn30.Text == "X" && btn31.Text == "X" && btn32.Text == "X")
            {
                DisplayAlert("PARABÉNS!!!", "O X ganhou!", "OK");
                Zerar();
            }

            /* Verificação se o O Ganhou na 3° linha */
            if (btn30.Text == "O" && btn31.Text == "O" && btn32.Text == "O")
            {
                DisplayAlert("PARABÉNS!!!", "O O ganhou!", "OK");
                Zerar();
            }

            /* Verificação se o X Ganhou na 1° coluna */
            if (btn10.Text == "X" && btn20.Text == "X" && btn30.Text == "X")
            {
                DisplayAlert("PARABÉNS!!!", "O X ganhou!", "OK");
                Zerar();
            }

            /* Verificação se o O Ganhou na 1° coluna */
            if (btn10.Text == "O" && btn20.Text == "O" && btn30.Text == "O")
            {
                DisplayAlert("PARABÉNS!!!", "O O ganhou!", "OK");
                Zerar();
            }

            /* Verificação se o X Ganhou na 2° coluna */
            if (btn11.Text == "X" && btn21.Text == "X" && btn31.Text == "X")
            {
                DisplayAlert("PARABÉNS!!!", "O X ganhou!", "OK");
                Zerar();
            }

            /* Verificação se o O Ganhou na 2° coluna */
            if (btn11.Text == "O" && btn21.Text == "O" && btn31.Text == "O")
            {
                DisplayAlert("PARABÉNS!!!", "O O ganhou!", "OK");
                Zerar();
            }

            /* Verificação se o X Ganhou na 3° coluna */
            if (btn12.Text == "X" && btn22.Text == "X" && btn32.Text == "X")
            {
                DisplayAlert("PARABÉNS!!!", "O X ganhou!", "OK");
                Zerar();
            }

            /* Verificação se o O Ganhou na 3° coluna */
            if (btn12.Text == "O" && btn22.Text == "O" && btn32.Text == "O")
            {
                DisplayAlert("PARABÉNS!!!", "O O ganhou!", "OK");
                Zerar();
            }

            /* Verificação se o X Ganhou na 1° diagonal */
            if (btn10.Text == "X" && btn21.Text == "X" && btn32.Text == "X")
            {
                DisplayAlert("PARABÉNS!!!", "O X ganhou!", "OK");
                Zerar();
            }

            /* Verificação se o O Ganhou na 1° diagonal */
            if (btn10.Text == "O" && btn21.Text == "O" && btn32.Text == "O")
            {
                DisplayAlert("PARABÉNS!!!", "O O ganhou!", "OK");
                Zerar();
            }

            /* Verificação se o X Ganhou na 2° diagonal */
            if (btn12.Text == "X" && btn21.Text == "X" && btn30.Text == "X")
            {
                DisplayAlert("PARABÉNS!!!", "O X ganhou!", "OK");
                Zerar();
            }

            /* Verificação se o O Ganhou na 2° diagonal */
            if (btn12.Text == "O" && btn21.Text == "O" && btn30.Text == "O")
            {
                DisplayAlert("PARABÉNS!!!", "O O ganhou!", "OK");
                Zerar();
            }



        } //fechamento do metodo

        void Zerar()
        {
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn20.Text = "";
            btn21.Text = "";
            btn22.Text = "";
            btn30.Text = "";
            btn31.Text = "";
            btn32.Text = "";

            btn10.IsEnabled = true;
            btn11.IsEnabled = true;
            btn12.IsEnabled = true;
            btn20.IsEnabled = true;
            btn21.IsEnabled = true;
            btn22.IsEnabled = true;
            btn30.IsEnabled = true;
            btn31.IsEnabled = true;
            btn32.IsEnabled = true;
        }

    } //fecha classe
} // fecha NameSpace
