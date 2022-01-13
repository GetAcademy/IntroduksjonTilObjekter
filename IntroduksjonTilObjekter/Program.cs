using System;

namespace IntroduksjonTilObjekter
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var s = "Terje";
            /*
                model = {
                    users: [
                        {
                                    name: 'Per',
                                    age: 20,
                                    email: 'per@mail.com',
                                    hasConfirmedEmail: true,
                                },
                        {
                                    name: 'Pål',
                                    age: 19,
                                    email: 'paal@mail.com',
                                    hasConfirmedEmail: false,
                                },
                    ],
                }             
             */
            var users = new Person[2];
            users[0] = new Person
            {
                Name = "Per",
                Age = 20,
                Email = "per@mail.com",
                HasConfirmedEmail = true
            };
            users[1] =  new Person
            {
                Name = "Pål",
                Age = 19,
                Email = "paal@mail.com",
                HasConfirmedEmail = false
            };
            var model = new Model();
            model.Users = users;

            var model2 = new Model
            {
                Users = new Person[]
                {
                    new Person
                    {
                        Name = "Per",
                        Age = 20,
                        Email = "per@mail.com",
                        HasConfirmedEmail = true
                    },
                    new Person
                    {
                        Name = "Pål",
                        Age = 19,
                        Email = "paal@mail.com",
                        HasConfirmedEmail = false
                    }
                }
            };
        }
        
        static void Demo1()
        {
            /*
             JS:
                var person = {
                    name: 'Per',
                    age: 20,
                    email: 'per@mail.com',
                    hasConfirmedEmail: true,
                }

                var person = {};
                person.name = 'Per';

             */
            /*
                var person = new Person
                {
                    Name = "Per",
                    Age = 20,
                    Email = "per@mail.com",
                    HasConfirmedEmail = true
                };             
             */
            var person = new Person();
            person.Name = "Per";
            person.Age = 20;
            person.Email = "per@mail.com";
            person.HasConfirmedEmail = true;

        }
    }
}
