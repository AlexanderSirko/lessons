using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW04_classes_03
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("login", "Alex", "Sirko", 25, "today");
            Console.WriteLine("User data: login={0}, name={1}, name={2}, age={3}, date={4}", user1._login, user1._name, user1._surname, user1._age, user1._Date);
        }
    }

    class User
    {
        public string _login, _name, _surname;
        public int _age;
        public readonly string _Date;

        public User(string login, string name, string surname, int age, string date)
        {
            _login = login;
            _name = name;
            _surname = surname;
            _age = age;
            _Date = DateTime.Now.ToString();
        }
    }
}
