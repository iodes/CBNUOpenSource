using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance
{
   public class UserManager
    {
        public ObservableCollection<User> Users = new ObservableCollection<User>();

        public UserManager()
        {
            //생성자

            var myUser = new User
            {
                Name = "AndyLee",
                Sex = SexType.Male,
                IsAttended = true
            };
            var myUser2 = new User
            {
                Name = "HongHong",
                Sex = SexType.Female,
                IsAttended = false
            };

            Users.Add(myUser);
            Users.Add(myUser2);

        }

    }
}
