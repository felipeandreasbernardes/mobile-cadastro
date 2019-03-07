using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Cadastro.ViewModels
{
    public class ViewModel : INotifyPropertyChanged
    {
        public INavigation Navigation;

        public async Task ProximaPaginaAsync()
        {
            await this.Navigation.PushModalAsync(new Page2());
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private bool mostrarErroNome;

        public bool MostrarErroNome
        {
            get { return mostrarErroNome; }
            set
            {
                if (mostrarErroNome != value)
                {
                    mostrarErroNome = value;
                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs("MostrarErroNome"));
                }
            }
        }

        private bool mostrarErroSobrenome;

        public bool MostrarErroSobrenome
        {
            get { return mostrarErroSobrenome; }
            set
            {
                if (mostrarErroSobrenome != value)
                {
                    mostrarErroSobrenome = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("MostrarErroSobrenome"));
                }
            }
        }

        private bool mostrarErroEmail;

        public bool MostrarErroEmail
        {
            get { return mostrarErroEmail; }
            set
            {
                if (mostrarErroEmail != value)
                {
                    mostrarErroEmail = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("MostrarErroEmail"));
                }
            }
        }

        private bool mostrarErroSenha;

        public bool MostrarErroSenha
        {
            get { return mostrarErroSenha; }
            set
            {
                if (mostrarErroSenha != value)
                {
                    mostrarErroSenha = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("MostrarErroSenha"));
                }
            }
        }

        private string nome;

        public string Nome
        {
            get { return nome; }
            set
            {
                if (nome != value)
                {
                    nome = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Nome"));
                }
            }
        }

        private string sobrenome;

        public string Sobrenome
        {
            get { return sobrenome; }
            set
            {
                if (sobrenome != value)
                {
                    sobrenome = value;
                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs("Sobrenome"));
                }
            }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set
            {
                if (email != value)
                {
                    email = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Email"));
                }
            }
        }

        private string senha;

        public string Senha
        {
            get { return senha; }
            set
            {
                if (senha != value)
                {
                    senha = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Senha"));
                }
            }
        }

        public ICommand CadastrarCommand { get; set; }

        public ViewModel()
        {
            CadastrarCommand = new Command(() => Validar());
            //CadastrarCommand = new Command(async () => await ProximaPaginaAsync());
        }

        private bool Validar()
        {
            bool valido = true;
            if (Nome == null || Nome == "")
            {
                MostrarErroNome = true;
                valido = false;
            }
            else
            {
                MostrarErroNome = false;
            }

            if (Sobrenome == null || Sobrenome == "")
            {
                MostrarErroSobrenome = true;
                valido = false;
            }
            else
            {
                MostrarErroSobrenome = false;
            }

            if (Email == null || Email == "")
            {
                MostrarErroEmail = true;
                valido = false;
            }
            else
            {
                MostrarErroEmail = false;
            }

            if (Senha == null || Senha == "")
            {
                MostrarErroSenha = true;
                valido = false;
            }
            else
            {
                MostrarErroSenha = false;
            }

            return valido;
        }
    }
}
