﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MobileApp.Models
{
    class Account
    {
        public int ID { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string Username { get; set; }
        public string EmailAddress { get; set; }
        public string HashedPassword { get; set; }

    }
}
