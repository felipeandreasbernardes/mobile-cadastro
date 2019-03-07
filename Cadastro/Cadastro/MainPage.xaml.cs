using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Cadastro
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            var model = new ViewModels.ViewModel();
            model.Navigation = Navigation;
            BindingContext = model;
		}
	}
}
