namespace Checkpoint_2_Tamas_Vicze
{
    public class Company
    {
        private string _companyName;
        private int _employeeCount;

        public string CompanyName
        {
            get => _companyName;
            set => _companyName = value;
        }

        public int EmployeeCount
        {
            get => _employeeCount;
            set => _employeeCount = value;
        }

        public Company(string companyName, int employeeCount)
        {
            _companyName = companyName;
            _employeeCount = employeeCount;
        }
    }
}