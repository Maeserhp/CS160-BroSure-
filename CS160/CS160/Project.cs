using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS160
{
    class Project
    {
        private string activity;
        private string client;
        private string hours;
        private int number;
        private string notes;

        public Project (string activity, string client, string hours, int number, string notes)
        {
            this.activity = activity;
            this.client = client;
            this.hours = hours;
            this.number = number;
            this.notes = notes;
        }

    }


}
