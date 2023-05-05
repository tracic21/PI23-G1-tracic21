using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation_manager {
    public abstract class Person {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public override string ToString() {
            return FirstName + " " + LastName; 
        }
    }
}
