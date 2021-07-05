namespace Checkpoint_2_Tamas_Vicze
{
    class Company
    {
        private string _companyName;
        private string _employeeCount;

        public string CompanyName
        {
            get => _companyName;
            set => _companyName = value;
        }

        public string EmployeeCount
        {
            get => _employeeCount;
            set => _employeeCount = value;
        }
    }
}