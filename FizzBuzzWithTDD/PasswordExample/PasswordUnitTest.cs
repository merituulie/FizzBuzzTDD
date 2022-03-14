using System;
using NUnit.Framework;

//Write a program that validates given password as string:
//  Password should be longer than 5 and shorter than 15 characters
//  Password should contain at least one number
//  Given invalid password validator should return false

namespace PasswordExample
{
    [TestFixture]
    public class PasswordUnitTest
    {
        [TestCase("moi")]
        public void CheckingPassword_GivenTooShortPassword_ReturnsFalse(string password)
        {
            throw new NotImplementedException();
        }

        [TestCase("nomoinytsittenvaan")]
        public void CheckingPassword_GivenTooLongPassword_ReturnsFalse(string password)
        {
            throw new NotImplementedException();
        }
    }
}

