using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance
{
    public enum SexType
    {
        Male,
        Female
    }

    public class User
    {
        
        public string Name { get; set; }

        public string Sex { get; set; }

        public TimeSpan Time { get; set; }

        public bool IsAttended { get; set; }

        

    }
}
