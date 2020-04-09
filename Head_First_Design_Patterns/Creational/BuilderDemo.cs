using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Head_First_Design_Patterns.Creational
{
    class BuilderDemo
    {
        static void Main()
        {
            var user = new UserBuilder().Age(20).Name("Raj").Salary(10);

        }

        public class User
        {
            public User(UserBuilder builder)
            {
                this.Name = builder.name;
                this.Age = builder.age;
                this.Salary = builder.salary;
            }
            public string Name { get; set; }
            public int Age { get; set; }

            public float Salary { get; set; }
        }

        public class UserBuilder
        {
            public string name;
            public int age;
            public float salary;

            public UserBuilder Age(int age)
            {
                this.age = age;
                return this;
            }

            public UserBuilder Name(string name)
            {
                this.name = name;
                return this;
            }

            public UserBuilder Salary(float salary)
            {
                this.salary = salary;
                return this;
            }

            public User Build()
            {
                var user = new User(this);
                return user;
            }
        }
    }
}
