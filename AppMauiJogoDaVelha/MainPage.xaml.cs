
namespace AppMauiJogoDaVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "O";

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button disparador = (Button)sender;

            disparador.IsEnabled = false;

            if(vez == "O")
            {
                disparador.Text = "O";
                vez = "X";
            } else
            {
                disparador.Text = "X";
                vez = "O";
            }//FECHA IF

            //Verificando  se o X ganhou na 1 linha
            if (btn10.Text == "X" &&
                btn11.Text == "X" &&
                btn12.Text == "X")
            {
                DisplayAlert("Parabéns!", "O X ganhou", "Fechar");
            }
            //Verificando  se a O ganhou na 1 linha
            else if (btn10.Text == "O" &&
                     btn11.Text == "O" &&
                     btn12.Text == "O")
            {
                DisplayAlert("Parabéns!", "A O ganhou", "Fechar");
            }

            //Verificando  se o X ganhou na 2 linha
            if (btn20.Text == "X" &&
                btn21.Text == "X" &&
                btn22.Text == "X")
            {
                DisplayAlert("Parabéns!", "O X ganhou", "Fechar");
            }

            //Verificando  se o X ganhou na 3 linha
            if (btn30.Text == "X" &&
                btn31.Text == "X" &&
                btn32.Text == "X")
            {
                DisplayAlert("Parabéns!", "O X ganhou", "Fechar");
            }

            //Verificando  se o X ganhou na D linha
            if (btn10.Text == "X" &&
                btn21.Text == "X" &&
                btn32.Text == "X")
            {
                DisplayAlert("Parabéns!", "O X ganhou", "Fechar");
            }

            //Verificando  se o X ganhou na D2 linha
            if (btn12.Text == "X" &&
                btn21.Text == "X" &&
                btn30.Text == "X")
            {
                DisplayAlert("Parabéns!", "O X ganhou", "Fechar");
            }

            //Verificando  se o X ganhou na 1 coluna
            if (btn10.Text == "X" &&
                btn20.Text == "X" &&
                btn30.Text == "X")
            {
                DisplayAlert("Parabéns!", "O X ganhou", "Fechar");
            }

            //Verificando  se o X ganhou na 2 coluna
            if (btn11.Text == "X" &&
                btn21.Text == "X" &&
                btn22.Text == "X")
            {
                DisplayAlert("Parabéns!", "O X ganhou", "Fechar");
            }

            //Verificando  se o X ganhou na 3 Coluna
            if (btn12.Text == "X" &&
                btn22.Text == "X" &&
                btn32.Text == "X")
            {
                DisplayAlert("Parabéns!", "O X ganhou", "Fechar");
            }

        }// Fecha Button_Clicked

        
    }

}
