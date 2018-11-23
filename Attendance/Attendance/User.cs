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
        private string _name;
        public string Name {
            get => _name+"님";
            set => _name = value;
        }

        public SexType Sex { get; set; }

        public TimeSpan Time { get; set; }

        public bool IsAttended { get; set; }

        

    }
}
