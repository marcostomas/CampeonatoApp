using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WTowerAndroidAPI.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WTowerAndroidAPI.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PrincipalPage : ContentPage
	{
        PrincipalViewModel vm = new PrincipalViewModel();

        public PrincipalPage ()
		{
            InitializeComponent();
            this.BindingContext = vm;
        }
    }
}