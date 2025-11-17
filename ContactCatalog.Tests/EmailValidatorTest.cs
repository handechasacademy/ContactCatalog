using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ContactCatalog.Validators;

namespace ContactCatalog.Tests
{
    public class EmailValidatorTest
    {
        [Theory]
        [InlineData("hande@mail.com", true)]
        [InlineData("wroteit-wrong", false)]
        [InlineData("", false)]
        [InlineData("   ", false)]
        public void IsValidEmail_ShouldReturnExpectedResult(string email, bool expected)
        {
            bool result = EmailValidator.IsValidEmail(email);
            Assert.Equal(expected, result);
        }
    }
}
