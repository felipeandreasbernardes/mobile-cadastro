using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Cadastro.ViewModels
{
    public class Page2ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand VoltarPaginaCommand { get; set;}

        public INavigation Navigation { get; set; }

        public Page2ViewModel()
        {
            VoltarPaginaCommand = new Command(async () => await VoltarPaginaAsync());
        }

        private async Task VoltarPaginaAsync()
        {
            await this.Navigation.PopModalAsync(true);
        }

        private void AdicionarContatos()
        {
            for (int i = 0; i < 20; i++)
            {
                var item = new Contato();
                if (i % 2 == 0)
                {
                    item.Nome = "José";
                    item.Imagem = "jose.png";
                }
                else
                {
                    item.Nome = "Maria";
                    item.Imagem = "maria.png";
                }
                Contatos.Add(item);
            }
        }
    }
}
