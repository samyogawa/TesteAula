using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjetoFiap
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            string[] valores = {
                "Perfil Arrojado",
                "Perfil Clássico",
                "Perfil Arriscado" };
            ListViewPerfis.ItemsSource = valores;

            BotaoGravar.Clicked += BotaoClicked;
        }


        public async void BotaoClicked(object o, EventArgs e)
        {

            var mensagemPerfil = "Nenhum perfil selecionado";
            if (ListViewPerfis.SelectedItem != null)
                mensagemPerfil = ListViewPerfis.SelectedItem.ToString();

            var mensagem = "Nome: " + EntryNome.Text + "\n" +
                "Descrição: " + EditorDescricao.Text + "\n" +
                "Idade: " + SliderIdade.Value.ToString() + "\n " +
                "Patrimônio: " + StepPatrimonio.Value.ToString() + "\n" +
                "Perfil: " + mensagemPerfil + " \n ";

            await DisplayAlert("Descrição",mensagem,"Ok");

            
        }
    }
}