using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using System;
using System.Text;

namespace Signum.NET.Tests
{
    [TestClass]
    public class MiningTests
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public TestContext TestContext { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.


        [TestMethod]
        public void GetMiningInfo()
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
            IGetMiningInfo? getMiningInfo = signumAPI.GetMiningInfo().Result;

            
            Assert.IsNotNull(getMiningInfo);
            Assert.IsTrue(getMiningInfo.IsValidRequest);

            TestContext.WriteLine(TestExtensions.WriteInterfaceData(getMiningInfo)); 




    }


        [TestMethod]
        public void GetRewardRecipient_ValidAccount()
        {            
            
            var property = TestContext.Properties["webAppUrl"];
            Assert.IsNotNull(property);

            var accountIdobj = TestContext.Properties["accountID"];
            Assert.IsNotNull(accountIdobj);


            var poolAccountId = TestContext.Properties["poolAccountID"];
            Assert.IsNotNull(poolAccountId);



            string? uri = property.ToString();
            string? accountID = accountIdobj.ToString();
            string? poolAccount = poolAccountId.ToString();
            Assert.IsNotNull(uri);
            Assert.IsNotNull(poolAccount);
            Assert.IsNotNull(accountID);

            HttpClient client = new()
            {
                BaseAddress = new Uri(uri)
            };
            
            ISignumAPIService signumAPI = new SignumAPIService(client);
            
            IGetRewardRecipient? getRewardRecipient = signumAPI.GetRewardRecipient(account: accountID).Result;
            Assert.IsNotNull(getRewardRecipient);            
            
            Assert.IsTrue(getRewardRecipient.IsValidRequest);

            Assert.AreEqual<string>(getRewardRecipient.RewardRecipient, poolAccount);
            
            TestContext.WriteLine($"Configured URI: {uri}");

            TestContext.WriteLine(TestExtensions.WriteInterfaceData(getRewardRecipient));
           
                       
        }

        [TestMethod]
        public void GetRewardRecipient_InValidAccount()
        {

            var property = TestContext.Properties["webAppUrl"];
            Assert.IsNotNull(property);

            var accountIdobj = TestContext.Properties["badaccountID"];
            Assert.IsNotNull(accountIdobj);


            var poolAccountId = TestContext.Properties["poolAccountID"];
            Assert.IsNotNull(poolAccountId);



            string? uri = property.ToString();
            string? accountID = accountIdobj.ToString();
            string? poolAccount = poolAccountId.ToString();
            Assert.IsNotNull(uri);
            Assert.IsNotNull(poolAccount);
            Assert.IsNotNull(accountID);

            HttpClient client = new()
            {
                BaseAddress = new Uri(uri)
            };

            ISignumAPIService signumAPI = new SignumAPIService(client);

            IGetRewardRecipient? getRewardRecipient = signumAPI.GetRewardRecipient(account: accountID).Result;
            Assert.IsNotNull(getRewardRecipient);

            Assert.IsFalse(getRewardRecipient.IsValidRequest);

            TestContext.WriteLine($"Configured URI: {uri}");

            TestContext.WriteLine(TestExtensions.WriteInterfaceData(getRewardRecipient));


        }


        [TestMethod]
        public void GetStateIncludeCounts_NotAllowed()
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

            IGetState? getState = signumAPI.GetState(includeCounts:true.ToString(), apiKey:"").Result;
            Assert.IsNotNull(getState);

            Assert.IsFalse(getState.IsValidRequest);

            TestContext.WriteLine(TestExtensions.WriteInterfaceData(getState));


        }

        //[TestMethod]
        //public void GetStateIncludeCounts()
        //{

        //    var property = TestContext.Properties["webAppUrl"];
        //    var apiKey = TestContext.Properties["apiKey"];
        //    Assert.IsNotNull(property);
        //    Assert.IsNotNull(apiKey);

        //    string? uri = property.ToString();
        //    string? apiKeySecret = apiKey.ToString();
        //    Assert.IsNotNull(uri);
        //    Assert.IsNotNull(apiKeySecret);

        //    HttpClient client = new()
        //    {
        //        BaseAddress = new Uri(uri)
        //    };

        //    ISignumAPIService signumAPI = new SignumAPIService(client);

        //    IGetState? getState = signumAPI.GetState(includeCounts: true.ToString(), apiKey: apiKeySecret).Result;
        //    Assert.IsNotNull(getState);

        //    Assert.IsFalse(getState.IsValidRequest);

        //    TestContext.WriteLine($"Configured URI: {uri}");
        //    TestContext.WriteLine(WriteInterfaceData(getState));


        //}
    }
}