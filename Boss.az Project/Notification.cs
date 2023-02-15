using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss.az_Project
{
    internal class Notification
    {
        public Notification( string text)
        {
            this.text = text;

        }

        private string text = "";

        public string Text
        {
            get { return text; }
            set { text = value; }
        }
        public override string ToString()
        {
            return $"Notification  {Text}";
        }
    }
}
