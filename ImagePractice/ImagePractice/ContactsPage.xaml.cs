using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ImagePractice
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactsPage : ContentPage
    {
        public ContactsPage()
        {
            InitializeComponent();
            myList.ItemsSource = new List<String>
            {
                "Saurabh",
                "Vaibhav",
                "Shilpi",
                "Chetan",
                "Madhu"
            };
        }
    }
}