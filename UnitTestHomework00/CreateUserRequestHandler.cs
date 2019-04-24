using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestHomework00.Core
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    public class CreateUserRequest
    {
        //Newly added Id Property to pass Unit Test?
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    public class GetUserDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    public class CreateUserRequestHandler
    {
        public GetUserDto Handle(CreateUserRequest request)
        {
            var rnd = new Random();

            var userToCreate = new User
            {
                Id = rnd.Next(1, 10000),
                FirstName = request.FirstName,
                LastName = request.LastName,
                Age = request.Age
            };

            // Blah blah fake database stuff
            // Beep beep boop

            var userToReturn = new GetUserDto
            {
                Id = userToCreate.Id,
                FirstName = userToCreate.FirstName,
                LastName = userToCreate.LastName,
                Age = userToCreate.Age
            }; 

            return userToReturn;
        }
    }
}
