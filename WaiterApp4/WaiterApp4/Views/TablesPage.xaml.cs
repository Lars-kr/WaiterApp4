using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WaiterApp4.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TablesPage : ContentPage
    {
        public TablesPage()
        {
            InitializeComponent();
        }

        private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}