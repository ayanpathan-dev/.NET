namespace CogniAttribute
{
    public class CognizantAttribute : Attribute
    {
        private string _company_name;
        public string CompanyName
        {
            get { return _company_name; }
            set { _company_name = value; }
        }

        private string _developer_name;
        public string DeveloperName
        {
            get { return _developer_name; }
            set { _developer_name = value; }
        }
    }
}
