namespace TestDotNet
{
    class UserData
    {
        public void SetUserName(string user_name)
        {
            m_user_name = user_name; 
        }

        public string GetUserName()
        {
            return m_user_name;
        }

        private string m_user_name;
    }
}
