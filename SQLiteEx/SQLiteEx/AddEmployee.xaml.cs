using System;
using Xamarin.Forms;

namespace SQLiteEx
{
    public partial class AddEmployee : ContentPage
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        public void OnSaveClicked(object sender, EventArgs args)
        {
            var vEmployee = new Employee()
            {
                EmpName = txtEmpName.Text,
                Company = txtCompany.Text,
                Department = txtDepartment.Text,
                Designation = txtDesign.Text,
                Qualification = txtQualification.Text
            };
            App.DAUtil.SaveEmployee(vEmployee);
            Navigation.PushAsync(new ManageEmployee());
        }
    }
}
