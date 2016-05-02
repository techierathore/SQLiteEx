using System;
using Xamarin.Forms;

namespace SQLiteEx
{
    public partial class EditEmployee : ContentPage
    {
        Employee mSelEmployee;
        public EditEmployee(Employee aSelectedEmp)
        {
            InitializeComponent();
            mSelEmployee = aSelectedEmp;
            BindingContext = mSelEmployee;
        }

        public void OnSaveClicked(object sender, EventArgs args)
        {
            mSelEmployee.EmpName = txtEmpName.Text;
            mSelEmployee.Department = txtDepartment.Text;
            mSelEmployee.Designation = txtDesign.Text;
            mSelEmployee.Qualification = txtQualification.Text;
            App.DAUtil.EditEmployee(mSelEmployee);
            Navigation.PushAsync(new ManageEmployee());
        }
    }
}
