namespace SzakdolgozatApp
{
    internal class Sqlcommand
    {
        private string insertParancs;

        public Sqlcommand(string insertParancs)
        {
            this.insertParancs = insertParancs;
        }

        public object Parameters { get; internal set; }
    }
}