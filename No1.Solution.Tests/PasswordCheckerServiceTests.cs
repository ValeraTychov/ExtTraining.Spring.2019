using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace No1.Solution.Tests
{
    [TestFixture]
    class PasswordCheckerServiceTests
    {
        IPasswordCheckerService service = new PasswordCheckerService();

        [Test]
        public void VerifyPassword_PasswordIsNull_ThrowsArgumentException() =>
            Assert.Throws<ArgumentException>(() =>
                service.VerifyPassword(null, out string message));

        [Test]
        public void VerifyPassword_PasswordIsEmpty_ReturnsFalse() =>
            Assert.IsFalse(service.VerifyPassword(string.Empty, out string message));

        [Test]
        public void VerifyPassword_PasswordIsEmpty_MessageOuts()
        {
            service.VerifyPassword(string.Empty, out string message);
            Assert.NotNull(message);
        }

        [Test]
        public void VerifyPassword_PasswordLengthIsLessThanSeven_ReturnsFalse() =>
            Assert.IsFalse(service.VerifyPassword("123456", out string message));

        [Test]
        public void VerifyPassword_PasswordLengthIsLessThanSeven_MessageOuts()
        {
            service.VerifyPassword("123456", out string message);
            Assert.NotNull(message);
        }

        [Test]
        public void VerifyPassword_ValidPassword_ReturnsTrue() =>
            Assert.IsTrue(service.VerifyPassword("123456abcd", out string message));

    }
}
