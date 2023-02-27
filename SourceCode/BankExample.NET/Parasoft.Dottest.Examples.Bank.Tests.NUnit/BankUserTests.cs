using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parasoft.Dottest.Examples.Bank.Tests.NUnit
{
    [TestFixture]
    public class BankUserTests
    {
        private static IEnumerable<string> Mails = new List<string> { "foo.bar", "", null, "@one.com", "foo.bar@foo.com.com" };

        [Test]
        [TestCaseSource("Mails")]
        public void Test(string sourceMail)
        {
            var name = "John";
            var sirName = "White";
            var mail = sourceMail;
            var pass = "$tr0ngp4$$;)";
            var user = new BankUser(name, sirName, mail, pass);

            Assert.AreEqual(user.Name, name);
            Assert.AreEqual(user.SirName, sirName);
            Assert.AreEqual(user.Login, mail);
            Assert.AreEqual(user.Password, pass);

            Assert.IsFalse(user.CheckEmail());
        }
    }
}
