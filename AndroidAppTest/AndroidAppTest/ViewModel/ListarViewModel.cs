using AndroidAppTest.Model;
using AndroidAppTest.ViewModel.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AndroidAppTest.ViewModel
{
    public class ListarViewModel : ViewModelBase
    {
        private WebApiBase webBase = new WebApiBase();
        private List<Estudantes> estudantesLista;

        public List<Estudantes> EstudantesLista
        {
            get { return estudantesLista; }
            set { estudantesLista = value; Notify("EstudantesLista"); }
        }

        private readonly IMessageService _messageService;

        public ListarViewModel()
        {
            _messageService = DependencyService.Get<IMessageService>();
            Listar();
        }

        public async void Listar()
        {
            try
            {
                var response = await webBase.GET();
                if(response.IsSuccessStatusCode)
                {
                    var result = JsonConvert.DeserializeObject<List<Estudantes>>(await response.Content.ReadAsStringAsync());
                    if(result == null)
                    {
                        await _messageService.MessageBox("Não existem itens em seu servidor");
                    }
                    else
                    {
                        EstudantesLista = new List<Estudantes>(result);
                    }
                }
                else
                {
                    await _messageService.MessageBox("Erro ao conectar com seu servidor!");
                }
            }
            catch (Exception ex)
            {
                await _messageService.MessageBox("Erro ao conectar com seu servidor!");
            }
        }
    }
}
