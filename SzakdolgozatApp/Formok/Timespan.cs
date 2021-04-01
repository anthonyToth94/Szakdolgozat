namespace SzakdolgozatApp
{
    internal class Timespan
    {
        private object hour;
        private object minute;
        private object second;

        public Timespan(object hour, object minute, object second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }
    }
}