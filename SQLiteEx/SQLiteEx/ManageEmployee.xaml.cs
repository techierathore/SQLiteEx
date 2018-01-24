using System;
using Xamarin.Forms;

namespace SQLiteEx
{
    public partial class ManageEmployee : ContentPage
    {
        public ManageEmployee()
        {
            InitializeComponent();
            var vList = App.DAUtil.GetAllEmployees();
            lstData.ItemsSource = vList;
        }

        void OnSelection(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return; 
                //ItemSelected is called on deselection, 
                //which results in SelectedItem being set to null
            }
            var vSelUser = (Employee)e.SelectedItem;
            Navigation.PushAsync(new ShowEmplyee(vSelUser));
        }
        public void OnNewClicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new AddEmployee());
        }
    }
}
