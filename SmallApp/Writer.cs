using System;
namespace SmallApp
{
    public abstract class Writer : IVlogger
    {
        private string _firstName;
        private string _lastName;

        public string AuthorBio
        {
            get
            {
                return string.Format($"My name is {this._firstName} {this._lastName}");
            }
            set
            {

            }
        }

        public Writer(string firstName, string lastName)
        {
            this._firstName = firstName;
            this._firstName = lastName;
        }

        public abstract void Vlog();
        

        public abstract void Write();
    }
}
