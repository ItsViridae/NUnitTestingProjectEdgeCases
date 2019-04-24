using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

namespace RequestValidators
{
    public class CreatePetDto
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Species { get; set; }
    }

    public class Response
    {
        public bool IsValid { get; set; } 
        public List<Error> Errors { get; set; } = new List<Error>();
        //Creates a list of Error(Type)       With Propery name: Errors         instantiate: List(ofType) <Error>
    }

    public class Error
    {
        public string ErrorMessage { get; set; }
        public string Property { get; set; }
    }

    public class CreatePetValidator
    {
        public Response Validate(CreatePetDto createDto) //Name Age Species
        {
            //create new instance of Response
            var response = new Response();

            //object->Age IsLessThanOrEqualTo 0
            if(createDto.Age <= 0)
            {
                var error = new Error();
                error.ErrorMessage = "Age must be greater than 0";
                error.Property = "Age";

                //Add the error to the Response.Error List
                response.Errors.Add(error);
            }

            //if object's Name is NULL   OR   EmptyString ""
            if(createDto.Name == null || createDto.Name == "")
            {
                var error = new Error();
                error.ErrorMessage = "Name is required";
                error.Property = "Name";

                //Adds the response to the List of Errors       ===>    List<Error> 
                //to hold information about the error
                response.Errors.Add(error);
            }

            //if object->Species is NOT "Dog"   OR        NOT "Cat"
            if(createDto.Species != "Dog" || createDto.Species != "Cat")
            {
                var error = new Error();
                error.ErrorMessage = "Species must be either Cat or Dog";
                error.Property = "Species";

                //create a response and add that response to the list of errors
                response.Errors.Add(error);
            }

            //assign any of the response Error IN List<Error> THEN The bool response.IsValid = True
            response.IsValid = response.Errors.Any();

            //return the response
            return response;
        }
    }

    public class User
    {
        public string FirstName { get; set; }
    }

    public class DataContext : IDataContext
    {
        public List<User> Users { get; set; }
    }

    public interface IDataContext
    {
        List<User> Users { get; set; }
    }

    public class Foo
    {
        private readonly IDataContext _context;

        public Foo(IDataContext context)
        {
            _context = new DataContext();

            _context.Users.Add(new User { FirstName = "Matthew" });
            _context.Users.Add(new User { FirstName = "Joe" });
            _context.Users.Add(new User { FirstName = "Matthew" });
            _context.Users.Add(new User { FirstName = "Matthew" });
            _context.Users.Add(new User { FirstName = "Matthew" });
        }

        // firstNameFilter = "Matthew"
        public int GetCountOfAllUsers(string firstNameFilter)
        {
            var usersToReturn = _context.Users.Where(x => x.FirstName == firstNameFilter);
            return usersToReturn.Count();
        }

        // x = 3, y = 4
        // ALWAYS return 7
        public static int AddTwoNumbers(int x, int y)
        {
            return x + y;
        }
    }
}
