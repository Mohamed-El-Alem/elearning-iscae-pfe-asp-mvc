using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ISCAE.Data.Repositories;
using System.Collections;
using ISCAE.Data;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Linq;

namespace ISCAE.Tests
{
    [TestClass]
    public class AdministrateurServiceTests
    {
        
        

        [TestMethod]
        public void Should_GetUserByAuth_Return_Single()
        {
            string password = "bbahieda";
            Console.WriteLine(Hash("iscae" + password));
        }
        private static string Hash(string input)
        {
            var hash = (new SHA1Managed()).ComputeHash(Encoding.UTF8.GetBytes(input));
            return string.Join("", hash.Select(b => b.ToString("x2")).ToArray());
        }
    }
}
