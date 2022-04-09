using Microsoft.VisualStudio.TestTools.UnitTesting;
using Signum.NET;
using System.Net.Http;
using System;
using System.Text;

namespace Signum.NET.Tests
{
    [TestClass]
    public class ServerInfoTests
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public TestContext TestContext { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.



        [TestMethod]
        public void GetTime_NoError()
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
            IGetTime? getTime = signumAPI.GetTime().Result;

            
            Assert.IsNotNull(getTime);
            Assert.IsTrue(getTime.IsValidRequest);
            Assert.IsNotNull(getTime.Time);

            TestContext.WriteLine($"Configured URI: {uri}");
            TestContext.WriteLine($"UTC Time: {getTime.Time}");

            TestContext.WriteLine(DateTime.UtcNow.ToString());
            var time = getTime.Time.FromSignumEpochToUtc();

            TestContext.WriteLine(time.ToString());
            TestContext.WriteLine(time.ToLocalTime().ToString());

            TestContext.WriteLine(TestExtensions.WriteInterfaceData(getTime)); 




    }


        [TestMethod]
        public void GetState()
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
            
            IGetState? getState = signumAPI.GetState().Result;
            Assert.IsNotNull(getState);            
            
            Assert.IsTrue(getState.IsValidRequest);

            
            TestContext.WriteLine($"Configured URI: {uri}");
            TestContext.WriteLine(TestExtensions.WriteInterfaceData(getState));
           
                       
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

            TestContext.WriteLine($"Configured URI: {uri}");
            TestContext.WriteLine(TestExtensions.WriteInterfaceData(getState));


        }


    }
}