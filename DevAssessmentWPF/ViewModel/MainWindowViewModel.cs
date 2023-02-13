using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;
using Prism.Commands;
using DevAssessmentWPF.Model;
using System.Net.Http.Json;

namespace DevAssessmentWPF.ViewModel
{
    internal class MainWindowViewModel : BindableBase, INotifyPropertyChanged
    {
        const string baseURL = "https://gorest.co.in/public/v2/users";
        #region Properties  

        private List<Employee> _employees;

        public List<Employee> Employees
        {
            get { return _employees; }
            set { SetProperty(ref _employees, value); }
        }

        private Employee _selectedEmployee;

        public Employee SelectedEmployee
        {
            get { return _selectedEmployee; }
            set { SetProperty(ref _selectedEmployee, value); }
        }

        private bool _isLoadData;

        public bool IsLoadData
        {
            get { return _isLoadData; }
            set { SetProperty(ref _isLoadData, value); }
        }

        private string _responseMessage = "This is DevAssessment EMS with API interface!!";

        public string ResponseMessage
        {
            get { return _responseMessage; }
            set { SetProperty(ref _responseMessage, value); }
        }

        #region [Create Employee Properties]  

        private string _name;

        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }


        private string _gender;

        public string Gender
        {
            get { return _gender; }
            set { SetProperty(ref _gender, value); }
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }

        private string _status;

        public string Status
        {
            get { return _status; }
            set { SetProperty(ref _status, value); }
        }

        #endregion
        private bool _isShowForm;

        public bool IsShowForm
        {
            get { return _isShowForm; }
            set { SetProperty(ref _isShowForm, value); }
        }

        private string _showPostMessage = "Please fill the form to register an employee!";

        public string ShowPostMessage
        {
            get { return _showPostMessage; }
            set { SetProperty(ref _showPostMessage, value); }
        }
        #endregion

        #region ICommands  
        public DelegateCommand GetButtonClicked { get; set; }
        public DelegateCommand ShowRegistrationForm { get; set; }
        public DelegateCommand PostButtonClick { get; set; }
        public DelegateCommand<Employee> UpdateButtonClicked { get; set; }
        public DelegateCommand<Employee> DeleteButtonClicked { get; set; }
        #endregion

        #region Constructor  
        public MainWindowViewModel()
        {
            GetButtonClicked = new DelegateCommand(GetEmployeeDetails);
            UpdateButtonClicked = new DelegateCommand<Employee>(UpdateEmployeeDetails);
            DeleteButtonClicked = new DelegateCommand<Employee>(DeleteEmployeeDetails);
            PostButtonClick = new DelegateCommand(CreateNewEmployee);
            ShowRegistrationForm = new DelegateCommand(RegisterEmployee);
        }
        #endregion

        #region CRUD  
        private void RegisterEmployee()
        {
            IsShowForm = true;
        }

        private void GetEmployeeDetails()
        {
            var employeeDetails = WebAPI.GetData();
            if (employeeDetails.Result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Employees = employeeDetails.Result.Content.ReadFromJsonAsync<List<Employee>>().Result;
                IsLoadData = true;
            }
        }

        // Adds new employee  
        private void CreateNewEmployee()
        {
            Employee newEmployee = new Employee()
            {
                Name = Name,
                Gender = Gender,
                Email = Email,
                Status = "active"
            };
            var employeeDetails = WebAPI.PostData(newEmployee);
            if (employeeDetails.Result.StatusCode == System.Net.HttpStatusCode.Created)
            {
                ShowPostMessage = newEmployee.Name + "'s details successfully added!";
            }
            else
            {
                ShowPostMessage = "Failed to create " + newEmployee.Name + "'s details.";
            }
        }


        // Updates employee's record  
        private void UpdateEmployeeDetails(Employee employee)
        {
            var employeeDetails = WebAPI.PutData(baseURL + "/" + employee.Id, employee);
            if (employeeDetails.Result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                ResponseMessage = employee.Name + "'s details successfully updated!";
            }
            else
            {
                //ResponseMessage = "Failed to update " + employee.Name + "'s details.";
                ResponseMessage = employeeDetails.Result.ReasonPhrase.ToString();
            }
        }

        // Deletes employee's record  
        private void DeleteEmployeeDetails(Employee employee)
        {
            var employeeDetails = WebAPI.DeleteData(baseURL + "/" + employee.Id);
            if (employeeDetails.Result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                ResponseMessage = employee.Name + "'s details successfully deleted!";
            }
            else
            {
                ResponseMessage = "Failed to delete " + employee.Name + "'s details.";
            }
        }
        #endregion
    }
}
