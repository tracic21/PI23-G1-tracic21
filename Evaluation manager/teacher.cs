﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation_manager {
    public class Teacher : Person{

        public string Username { get; set; }

        public string Password { get; set; }

        public bool CheckPassword(string Password) {
            return Password != null && Password.Length > 0;
        }
    }
}
