using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement
{
    class StaffManagement
    {
        public string name { get; set; }
        public string position { get; set; }
        public string staff_id { get; set; }
        public string staff_pw { get; set; }
        private StaffManagement(string name, string position, string staff_id, string staff_pw)
        {
            this.name = name;
            this.position = position;
            this.staff_id = staff_id;
            this.staff_pw = staff_pw;
        }
    }
}
