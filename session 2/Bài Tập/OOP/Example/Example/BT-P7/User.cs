using System;
using System.Collections.Generic;
using System.Text;

namespace Example.BT_P7
{
    public class User : IUser
    {
        protected int id;
        protected string name;
        protected string password;
        public List<int?> phonelist = new List<int?>();
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }

        public string Display()
        {
            return $"ID: {Id}  Name: {Name} PassWord: {Password} " +
                    $"PhoneNumber: {string.Join(",", phonelist)}";
        }
    }
}
