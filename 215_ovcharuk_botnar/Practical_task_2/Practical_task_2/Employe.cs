using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_task_2
{
    class Employe:Person
    {

        string company;
        public string Company { get => company; set => company = value; }

        string job;
            
        public string Job { get => job; set => job = value; }

        public Employe() { }

        public Employe(int age,string name,string surname,string company,string job):base(age,name,surname)
        {
            this.company = company;
            this.job = job;
        }

        public void Print
    }
}
