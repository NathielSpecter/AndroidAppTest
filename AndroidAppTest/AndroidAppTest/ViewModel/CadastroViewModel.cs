using AndroidAppTest.Model;
using AndroidAppTest.ViewModel.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AndroidAppTest.ViewModel
{
    public class CadastroViewModel : ViewModelBase
    {

        private WebApiBase webBase = new WebApiBase();
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string sobrenome;

        public string Sobrenome
        {
            get { return sobrenome; }
            set { sobrenome = value; }
        }

        private string idade;

        public string Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public bool TemCamposVazios { get {
                return string.IsNullOrEmpty(Nome) || string.IsNullOrEmpty(Sobrenome) || string.IsNullOrEmpty(Idade) ||
string.IsNullOrEmpty(Email);
            } }

        public ICommand CadastrarCommand { get; set; }

        private readonly IMessageService _messageService;

        public CadastroViewModel()
        {
            CadastrarCommand = new Command(Cadastrar);
            _messageService = DependencyService.Get<IMessageService>();
        }

        private void Cadastrar()
        {
            if(TemCamposVazios)
            {
                _messageService.MessageBox("Preencha todos os campos!");
            }
            else
            {
                Cad();
            }
        }

        public async void Cad()
        {
            var estudantes = new Estudantes()
            {
                Nome = Nome,
                Sobrenome = Sobrenome,
                Email = Email,
                Idade = Idade
            };

            try
            {
                var response = await webBase.POST(estudantes);
                if(response.IsSuccessStatusCode)
                {
                    await _messageService.MessageBox("Cadastro Efetuado com Sucesso");
                }
                else
                {
                    await _messageService.MessageBox( "ERRO");
                }
            }
            catch (Exception ex)
            {
                await _messageService.MessageBox("Erro ao conectar com o servidor");
            }
        }
    }
}
