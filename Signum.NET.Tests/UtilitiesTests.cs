using Microsoft.VisualStudio.TestTools.UnitTesting;
using Signum.NET;
using System.Net.Http;
using System;
using System.Text;

namespace Signum.NET.Tests
{
    [TestClass]
    public class UtilitiesTests
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public TestContext TestContext { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.



        [TestMethod]
        public void SuggestFees_Test()
        {
            var property = TestContext.Properties["webAppUrl"];
            Assert.IsNotNull(property);

            string? uri = property.ToString();
            Assert.IsNotNull(uri);

            HttpClient client = new()
            {
                BaseAddress = new Uri(uri)
            };


            ISignumAPIService signumAPI = new SignumAPIService(client);
            ISuggestFee? suggestFee = signumAPI.SuggestFee().Result;

            
            Assert.IsNotNull(suggestFee);
            Assert.IsTrue(suggestFee.IsValidRequest);

            Assert.IsNotNull(suggestFee.Cheap);
            Assert.IsNotNull(suggestFee.Standard);
            Assert.IsNotNull(suggestFee.Priority);

            TestContext.WriteLine($"Configured URI: {uri}");
  
            TestContext.WriteLine(TestExtensions.WriteInterfaceData(suggestFee)); 




    }


        [TestMethod]
        public void RS_Convert_Numeric_to_RS()
        {


            var property = TestContext.Properties["webAppUrl"];
            var accountID = TestContext.Properties["accountID"];
            var accountRS = TestContext.Properties["accountRS"];

            Assert.IsNotNull(property);
            Assert.IsNotNull(accountID);
            Assert.IsNotNull(accountRS);

            string? uri = property.ToString();
            string? accountIDs = accountID.ToString();
            string? accountRSs = accountRS.ToString();

            Assert.IsNotNull(uri);
            Assert.IsNotNull(accountIDs);
            Assert.IsNotNull(accountRSs);

            HttpClient client = new()
            {
                BaseAddress = new Uri(uri)
            };

            ISignumAPIService signumAPI = new SignumAPIService(client);

            IRSConvert? rSConvert = signumAPI.RSConvert(accountIDs).Result;

            Assert.IsNotNull(rSConvert);

            Assert.IsTrue(rSConvert.IsValidRequest);

            Assert.AreEqual(rSConvert.Account, accountIDs);
            Assert.AreEqual(rSConvert.AccountRS, accountRSs);

            TestContext.WriteLine($"Configured URI: {uri}");
            TestContext.WriteLine(TestExtensions.WriteInterfaceData(rSConvert));


        }

        [TestMethod]
        public void RS_Convert_RS_to_Numeric()
        {


            var property = TestContext.Properties["webAppUrl"];
            var accountID = TestContext.Properties["accountID"];
            var accountRS = TestContext.Properties["accountRS"];

            Assert.IsNotNull(property);
            Assert.IsNotNull(accountID);
            Assert.IsNotNull(accountRS);

            string? uri = property.ToString();
            string? accountIDs = accountID.ToString();
            string? accountRSs = accountRS.ToString();

            Assert.IsNotNull(uri);
            Assert.IsNotNull(accountIDs);
            Assert.IsNotNull(accountRSs);

            HttpClient client = new()
            {
                BaseAddress = new Uri(uri)
            };

            ISignumAPIService signumAPI = new SignumAPIService(client);

            IRSConvert? rSConvert = signumAPI.RSConvert(accountRSs).Result;

            Assert.IsNotNull(rSConvert);

            Assert.IsTrue(rSConvert.IsValidRequest);

            Assert.AreEqual(rSConvert.Account, accountIDs);
            Assert.AreEqual(rSConvert.AccountRS, accountRSs);

            TestContext.WriteLine($"Configured URI: {uri}");
            TestContext.WriteLine(TestExtensions.WriteInterfaceData(rSConvert));


        }

        [TestMethod]
        public void RS_Convert_BadAccount()
        {


            var property = TestContext.Properties["webAppUrl"];
            var accountID = TestContext.Properties["badaccountID"];


            Assert.IsNotNull(property);
            Assert.IsNotNull(accountID);

            string? uri = property.ToString();
            string? accountIDs = accountID.ToString();

            Assert.IsNotNull(uri);
            Assert.IsNotNull(accountIDs);

            HttpClient client = new()
            {
                BaseAddress = new Uri(uri)
            };

            ISignumAPIService signumAPI = new SignumAPIService(client);

            IRSConvert? rSConvert = signumAPI.RSConvert(accountIDs).Result;

            Assert.IsNotNull(rSConvert);

            Assert.IsFalse(rSConvert.IsValidRequest);


            TestContext.WriteLine($"Configured URI: {uri}");
            TestContext.WriteLine(TestExtensions.WriteInterfaceData(rSConvert));


        }

        [TestMethod]
        public void LongConver_FromLong()
        {

            var property = TestContext.Properties["webAppUrl"];
            var longId = TestContext.Properties["longId"];
            var stringId = TestContext.Properties["stringId"];

            Assert.IsNotNull(property);
            Assert.IsNotNull(longId);
            Assert.IsNotNull(stringId);


            string? uri = property.ToString();
            string? longIdstr = longId.ToString();
            string? stringIdstr = stringId.ToString(); 

            Assert.IsNotNull(uri);
            Assert.IsNotNull(longIdstr);
            Assert.IsNotNull(stringIdstr);


            HttpClient client = new()
            {
                BaseAddress = new Uri(uri)
            };

            ISignumAPIService signumAPI = new SignumAPIService(client);

            ILongConvert? longConvert = signumAPI.LongConvert(longIdstr).Result;

            Assert.IsNotNull(longConvert);

            Assert.IsTrue(longConvert.IsValidRequest);

            Assert.AreEqual(longConvert.StringId, stringIdstr);
            Assert.AreEqual(longConvert.LongId, longIdstr);


            TestContext.WriteLine($"Configured URI: {uri}");
            TestContext.WriteLine(TestExtensions.WriteInterfaceData(longConvert));


        }

        [TestMethod]
        public void LongConver_FromString()
        {

            var property = TestContext.Properties["webAppUrl"];
            var longId = TestContext.Properties["longId"];
            var stringId = TestContext.Properties["stringId"];

            Assert.IsNotNull(property);
            Assert.IsNotNull(longId);
            Assert.IsNotNull(stringId);


            string? uri = property.ToString();
            string? longIdstr = longId.ToString();
            string? stringIdstr = stringId.ToString();

            Assert.IsNotNull(uri);
            Assert.IsNotNull(longIdstr);
            Assert.IsNotNull(stringIdstr);


            HttpClient client = new()
            {
                BaseAddress = new Uri(uri)
            };

            ISignumAPIService signumAPI = new SignumAPIService(client);

            ILongConvert? longConvert = signumAPI.LongConvert(stringIdstr).Result;

            Assert.IsNotNull(longConvert);

            Assert.IsTrue(longConvert.IsValidRequest);

            Assert.AreEqual(longConvert.StringId, stringIdstr);
            Assert.AreEqual(longConvert.LongId, longIdstr);


            TestContext.WriteLine($"Configured URI: {uri}");
            TestContext.WriteLine(TestExtensions.WriteInterfaceData(longConvert));


        }



    }
}