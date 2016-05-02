
using System;
using Xamarin.Forms;

namespace SQLiteEx
{
    public partial class ShowEmplyee : ContentPage
    {
        Employee mSelEmployee;
        public ShowEmplyee(Employee aSelectedEmp)
        {
            InitializeComponent();
            mSelEmployee = aSelectedEmp;
            BindingContext = mSelEmployee;
        }

        public void OnEditClicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new EditEmployee(mSelEmployee));
        }
        public async void  OnDeleteClicked(object sender, EventArgs args)
        {
            bool accepted = await DisplayAlert("Confirm", "Are you Sure ?", "Yes", "No");
            if (accepted)
            {
                App.DAUtil.DeleteEmployee(mSelEmployee);
            }
            await Navigation.PushAsync(new ManageEmployee());
        }
    }
}
