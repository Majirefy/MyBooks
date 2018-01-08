using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyBooks.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewBookPage : ContentPage
    {
        public NewBookPage ()
        {
            InitializeComponent ();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Success", "We have handled the click event.", "Great!");
        }
    }
}