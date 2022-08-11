using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation.Models
{
    class User
    {
        //fields
        private string _username;
        private string _password;



        // properties
        public string Username { 
            get 
            {
                return _username;
            }
            set 
            {
                if (value.Length > 5 && value.Length < 26)
                    _username = value;
            } 
        }

        public string Password {
            get 
            {
                return _password;
            }
            set 
            {
                if (HasDigit(value) && HasUpper(value) && HasLower(value))
                    _password = value;
            }
        }



        //methods
        private bool HasDigit(string Word)
        {
            for (int i = 0; i < Word.Length; i++)
            {
                if (Word[i] > 47 && Word[i] < 58)
                    return true;
            }
            return false;
        }

        private bool HasUpper(string Word)
        {
            for (int i = 0; i < Word.Length; i++)
            {
                if (Word[i] > 64 && Word[i] < 91)
                    return true;
            }
            return false;
        }

        private bool HasLower(string Word)
        {
            for (int i = 0; i < Word.Length; i++)
            {
                if (Word[i] > 96 && Word[i] < 123)
                    return true;
            }
            return false;
        }

        #region ctor
        //ctor
        public User(string Username)
        {
            this.Username = Username;
        }
        public User(string Username,string Password):this(Username)
        {
            this.Password = Password;
        }
        #endregion



    }
}
