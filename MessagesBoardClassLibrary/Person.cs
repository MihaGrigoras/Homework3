using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace MessagesBoardClassLibrary
{
    public class Person
    {
        // properties
        public String FirstName { get; private set; }
        public String LastName { get; private set; }
        public String Email { get; private set; }
        public DateTime BirthDate{ get; private set; }

        // additional properties we could use in addition to those requested in the requirements
        public int Id { get; private set; }
        public virtual string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }

        public double Age
        {
            get
            {
                return (DateTime.Now - this.BirthDate).TotalDays / 365.2425;
            }
        }

        // constructor 
        public Person(int id, string firstName, string lastName, string email, DateTime birthDate)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.BirthDate = birthDate;
        }

        // methods

        // C - create
        public void CreateAccount()
        {
        }

        // additional methods we could use in addition to those requested in the requirements

        // R - read
        public void GetAccountInfoById(int Id)
        {
            
        }

        // U- update
        public void UpdateAccountInfo()
        {

        }

        // D - delete
        public void RemoveAccount()
        {

        }

    }
}

