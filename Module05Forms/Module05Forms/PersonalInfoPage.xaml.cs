using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Module05Forms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonalInfoPage : ContentPage
    {
        public PersonalInfoPage()
        {
            InitializeComponent();
        }

        private void OnToggle(object sender, ToggledEventArgs e)
        {
            MiddleName.IsEnabled = e.Value;
        }

        private void OnDateSelected(object sender, DateChangedEventArgs e)
        {
            var age = DateTime.Today.Year - e.NewDate.Year;
            Age.Text = $"Age: {age}";
        }
    }
}
