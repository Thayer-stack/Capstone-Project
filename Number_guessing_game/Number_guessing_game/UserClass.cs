using System;
namespace UserInfo
{
    public class UserClass
    {
        private int _id;
        private int _userScore;
        private string _userName;
        private string _userPass;
        private string _dataPath;

        public int Id
        { 
            get { return _id; }
            set { _id = value; }
        }

        public int UserScore
        {
            get { return _userScore; }
            set { _userScore = value; }
        }

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        public string UserPass
        { 
            get { return _userPass; }
            set { _userPass = value; }
        }
        
        public string DataPath
        {
            get { return _dataPath; }
            set { _dataPath = value; }
        }

        public UserClass(int id, int userScore, string userName, string userPass, string dataPath)
        {
            _id = id;
            _userScore = userScore;
            _userName = userName;
            _userPass = UserPass;
            _dataPath = dataPath;
        }

    }
}
