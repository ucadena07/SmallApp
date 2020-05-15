using System;
namespace SmallApp
{
    public abstract class Writer : IVlogger
    {
        public Writer()
        {
        }

        public abstract void Vlog();
        

        public abstract void Write();
    }
}
