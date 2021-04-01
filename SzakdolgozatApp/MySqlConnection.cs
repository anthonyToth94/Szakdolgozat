using System;
using System.Data;

namespace SzakdolgozatApp
{
    internal class Sqlconnection
    {
        private string kapcsolatString;

        public Sqlconnection(string kapcsolatString)
        {
            this.kapcsolatString = kapcsolatString;
        }

        public ConnectionState State { get; internal set; }

        internal void Open()
        {
            throw new NotImplementedException();
        }

        internal void Close()
        {
            throw new NotImplementedException();
        }
    }
}