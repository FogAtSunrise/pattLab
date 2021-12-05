using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab.Composite
{
    class CompositeUser : User
    {
        List<User> listUsers;

        public CompositeUser()
        { listUsers = new List<User>(); }
        public override void addUser(User a) { listUsers.Add(a); }
        public override void delUser(User a) { listUsers.Remove(a); }
        public override List<User> getCompositeUsers() { return listUsers; }
        public override void operation()
        {
            for (int i = 0; i < listUsers.Count; i++)
            {
                Console.Write("\n"+(i + 1) + ") ");
                listUsers[i].operation();
            }
            Console.WriteLine();
        }
    }
}
