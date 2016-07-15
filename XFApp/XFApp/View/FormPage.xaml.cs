using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XFApp.ViewModel;

namespace XFApp.View
{
	public partial class FormPage : ContentPage
	{
		public FormPage ()
		{
			InitializeComponent ();

            this.BindingContext = new FormPageViewModel() ;

        }
	}
}
