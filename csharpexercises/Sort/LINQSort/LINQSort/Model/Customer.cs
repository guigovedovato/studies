using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSort.Model
{
    class Customer
    {
        private static int index = 0;

        public Customer()
        {
            this.Birth = this.GetBirth();
            this.Id = this.GetId();
        }

        public int Id { get; private set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birth { get; private set; }

        private int GetId()
        {
            return ++index;
        }

        private DateTime GetBirth()
        {
            DateTime start = new DateTime(1995, 1, 1);
            Random gen = new Random();
            int range = ((TimeSpan)(DateTime.Today - start)).Days;
            return start.AddDays(gen.Next(range));
        }
    }
}
