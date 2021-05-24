namespace ManageAppleStore_DTO
{
    public class EmployeesDTOBase
    {
        private string _StrPassword;
        private string _StrEmployeeOfTypeID;
        private decimal _DecSalary;

        public string StrPassword { get => _StrPassword; set => _StrPassword = value; }
        public string StrEmployeeOfTypeID { get => _StrEmployeeOfTypeID; set => _StrEmployeeOfTypeID = value; }
        public decimal DecSalary { get => _DecSalary; set => _DecSalary = value; }
    }
}