using System;
using System.Collections.Generic;
using System.Text;

namespace FlatlineClassLibrary
{
    //Class to structure a domain setting.
    public class DomainSettingModel
    {
        public string UserAssignedName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Domain { get; set; }
        public string DomainProvider { get; set; }
        public string Enabled { get; set; }
    }
}
