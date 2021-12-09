using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Drawing;

namespace Tivi
{
    public class User
    {
        //properties
        private string email;
        private string firstName;
        private string lastName;
        private string colour;

        public static Regex EMAIL_REGEX = new Regex("^[a-zA-Z0-9](?!.*[-_.]{2})[a-zA-Z0-9-_.]{0,15}@[a-zA-Z_.]{2,24}((.qc)?.ca|.com(.(br|us|uk|ca))?|.net|.info|.org)$");
        //(rx.IsMatch(input)) -> RETURNS TRUE IF MATCH FOUND

        //default constructor
        public User() : this("user@tivi.com", "noFName", "noLName", "White") { }

        //parameterized constructor
        public User(string email, string firstName, string lastName, string colour)
        {
            Email = email;
            LastName = lastName;
            FirstName = firstName;
            Colour = colour;
        }

        //copy constructor
        public User(User user) : this(user.email, user.firstName, user.lastName, user.colour) { } //fix this shit, something isn't working

        //properties

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = (EMAIL_REGEX.IsMatch(value)) ? value : $"{lastName}.{firstName}@tivi.ca";
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = (value != null && value != string.Empty) ? value : "noLName";
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = (value != null && value != string.Empty) ? value : "noFName";
            }
        }

        public string Colour
        {
            get
            {
                return colour;
            }
            set
            {
                colour = (value != null && value != string.Empty) ? value : "White";
            }
        }
    }
}