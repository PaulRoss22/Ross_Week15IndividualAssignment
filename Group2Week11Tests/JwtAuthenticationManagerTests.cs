using Microsoft.VisualStudio.TestTools.UnitTesting;
using Group2Week11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Group2Week11.Controllers;

namespace Group2Week11.Tests
{
    [TestClass()]
    public class JwtAuthenticationManagerTests
    {
        [TestMethod()]
        public void AuthenticateTest()
        {
            JwtAuthenticationManager manager = new JwtAuthenticationManager("fakekeynotlegit11111!");

            User user = new User
            {
                username = "testsss",
                password = "passwordsss"
            };

            var ret = manager.Authenticate(user.username, user.password);

            Assert.IsNull(ret);
        }
    }
}