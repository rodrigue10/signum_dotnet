using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace Signum.NET
{
    public class SignumAPIService : ISignumAPIService
    {

        private readonly HttpClient httpClient;

        public SignumAPIService(HttpClient _httpClient)
        {
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            httpClient = _httpClient;  

        }





        #region Assets

        public async Task<IGetAllAssets?> GetAllAssets(string firstIndex = "", string lastIndex = "")
        {


            string baseAPI = "/burst";
            string requestType = "?requestType=getAllAssets";


            List<KeyValuePair<string, string>> allIputParams = new()
            {
                // Converting Request Params to Key Value Pair.  
                new KeyValuePair<string, string>("&firstIndex=", firstIndex),
                new KeyValuePair<string, string>("&lastIndex=", lastIndex)
            };

            StringBuilder uri = new();

            uri.Append(baseAPI);
            uri.Append(requestType);

            foreach (var item in allIputParams)
            {
                uri.Append(item.Key);
                uri.Append(item.Value);

            }

            return await httpClient.GetFromJsonAsync<GetAllAssets>(uri.ToString());



        }

        public async Task<IGetAsset?> GetAsset(string assetId)
        {

            string baseAPI = "/burst";
            string requestType = "?requestType=getAsset";

            List<KeyValuePair<string, string>> allIputParams = new()
            {
                // Converting Request Params to Key Value Pair.  
                new KeyValuePair<string, string>("&asset=", assetId)
            };

            StringBuilder uri = new();

            uri.Append(baseAPI);
            uri.Append(requestType);

            foreach (var item in allIputParams)
            {
                uri.Append(item.Key);
                uri.Append(item.Value);

            }

            return await httpClient.GetFromJsonAsync<GetAsset>(uri.ToString());


        }

        public async Task<IGetAskOrders?> GetAskOrders(string assetId, string firstIndex = "", string lastIndex = "")
        {


            string baseAPI = "/burst";
            string requestType = "?requestType=getAskOrders";


            List<KeyValuePair<string, string>> allIputParams = new()
            {
                // Converting Request Params to Key Value Pair.  
                new KeyValuePair<string, string>("&asset=", assetId),
                new KeyValuePair<string, string>("&firstIndex=", firstIndex),
                new KeyValuePair<string, string>("&lastIndex=", lastIndex)
            };

            StringBuilder uri = new();

            uri.Append(baseAPI);
            uri.Append(requestType);

            foreach (var item in allIputParams)
            {
                uri.Append(item.Key);
                uri.Append(item.Value);

            }

            return await httpClient.GetFromJsonAsync<GetAskOrders>(uri.ToString());


        }

        public async Task<IGetBidOrders?> GetBidOrders(string assetId, string firstIndex = "", string lastIndex = "")
        {


            string baseAPI = "/burst";
            string requestType = "?requestType=getBidOrders";


            List<KeyValuePair<string, string>> allIputParams = new()
            {
                // Converting Request Params to Key Value Pair.  
                new KeyValuePair<string, string>("&asset=", assetId),
                new KeyValuePair<string, string>("&firstIndex=", firstIndex),
                new KeyValuePair<string, string>("&lastIndex=", lastIndex)
            };

            StringBuilder uri = new();

            uri.Append(baseAPI);
            uri.Append(requestType);

            foreach (var item in allIputParams)
            {
                uri.Append(item.Key);
                uri.Append(item.Value);

            }

            return await httpClient.GetFromJsonAsync<GetBidOrders>(uri.ToString());


        }

        public async Task<IGetTrades?> GetTrades(string assetId, string account = "", string includeAssetInfo = "", string firstIndex = "", string lastIndex = "")
        {



            string baseAPI = "/burst";
            string requestType = "?requestType=getTrades";


            List<KeyValuePair<string, string>> allIputParams = new()
            {
                // Converting Request Params to Key Value Pair.  
                new KeyValuePair<string, string>("&asset=", assetId),
                new KeyValuePair<string, string>("&account=", account),
                new KeyValuePair<string, string>("&includeAssetInfo=", includeAssetInfo),
                new KeyValuePair<string, string>("&firstIndex=", firstIndex),
                new KeyValuePair<string, string>("&lastIndex=", lastIndex)
            };

            StringBuilder uri = new();

            uri.Append(baseAPI);
            uri.Append(requestType);

            foreach (var item in allIputParams)
            {
                uri.Append(item.Key);
                uri.Append(item.Value);

            }

            return await httpClient.GetFromJsonAsync<GetTrades>(uri.ToString());


        }


        #endregion

        #region ATs
        public async Task<IGetAccountATs?> GetAccountATs(string account)
        {

            string baseAPI = "/burst?";
            string requestType = "requestType=getAccountATs";


            List<KeyValuePair<string, string>> allIputParams = new()
            {
                // Converting Request Params to Key Value Pair.  
                new KeyValuePair<string, string>("&account=", account)
            };

            StringBuilder uri = new();

            uri.Append(baseAPI);
            uri.Append(requestType);

            foreach (var item in allIputParams)
            {
                uri.Append(item.Key);
                uri.Append(item.Value);

            }

            return await httpClient.GetFromJsonAsync<GetAccountATs>(uri.ToString());


        }

        #endregion

        #region Block

        public async Task<IGetBlock?> GetBlock(string block, string height = "", string timestamp = "", string includeTransactions = "")
        {


            string baseAPI = "/burst?";
            string requestType = "requestType=getBlocks";


            List<KeyValuePair<string, string>> allIputParams = new()
            {
                // Converting Request Params to Key Value Pair.  
                new KeyValuePair<string, string>("&block=", block),
                new KeyValuePair<string, string>("&height=", height),
                new KeyValuePair<string, string>("&timestamp=", timestamp),
                new KeyValuePair<string, string>("&includeTransactions=", includeTransactions)
            };

            StringBuilder uri = new();

            uri.Append(baseAPI);
            uri.Append(requestType);

            foreach (var item in allIputParams)
            {
                uri.Append(item.Key);
                uri.Append(item.Value);

            }

            return await httpClient.GetFromJsonAsync<GetBlock>(uri.ToString());

        }

        public async Task<IGetBlocks?> GetBlocks(string firstIndex = "", string lastIndex = "", string includeTransactions = "")
        {


            string baseAPI = "/burst?";
            string requestType = "requestType=getBlocks";


            List<KeyValuePair<string, string>> allIputParams = new()
            {
                // Converting Request Params to Key Value Pair.  
                new KeyValuePair<string, string>("&firstIndex=", firstIndex),
                new KeyValuePair<string, string>("&lastIndex=", lastIndex),
                new KeyValuePair<string, string>("&includeTransactions=", includeTransactions)
            };

            StringBuilder uri = new();

            uri.Append(baseAPI);
            uri.Append(requestType);

            foreach (var item in allIputParams)
            {
                uri.Append(item.Key);
                uri.Append(item.Value);

            }

            return await httpClient.GetFromJsonAsync<GetBlocks>(uri.ToString());


        }

        public async Task<IGetBlockId?> GetBlockId(string height)
        {

            string baseAPI = "/burst?";
            string requestType = "requestType=getBlockId";


            List<KeyValuePair<string, string>> allIputParams = new()
            {
                // Converting Request Params to Key Value Pair.  
                new KeyValuePair<string, string>("&height=", height)
            };

            StringBuilder uri = new();

            uri.Append(baseAPI);
            uri.Append(requestType);

            foreach (var item in allIputParams)
            {
                uri.Append(item.Key);
                uri.Append(item.Value);

            }

            return await httpClient.GetFromJsonAsync<GetBlockId>(uri.ToString());


        }

        public async Task<IGetECBlock?> GetECBlock(string timestamp = "")
        {

            string baseAPI = "/burst?";
            string requestType = "requestType=getECBlock";


            List<KeyValuePair<string, string>> allIputParams = new()
            {
                // Converting Request Params to Key Value Pair.  
                new KeyValuePair<string, string>("&timestamp=", timestamp)
            };

            StringBuilder uri = new();

            uri.Append(baseAPI);
            uri.Append(requestType);

            foreach (var item in allIputParams)
            {
                uri.Append(item.Key);
                uri.Append(item.Value);

            }

            return await httpClient.GetFromJsonAsync<GetECBlock>(uri.ToString());


        }

        public async Task<IGetDGSGoods?> GetDGSGoods(string seller = "", string firstIndex = "", string lastIndex = "", string inStockOnly = "")
        {


            string baseAPI = "/burst?";
            string requestType = "requestType=getDGSGoods";


            List<KeyValuePair<string, string>> allIputParams = new()
            {
                // Converting Request Params to Key Value Pair.  
                new KeyValuePair<string, string>("&seller=", seller),
                new KeyValuePair<string, string>("&firstIndex=", firstIndex),
                new KeyValuePair<string, string>("&lastIndex=", lastIndex),
                new KeyValuePair<string, string>("&inStockOnly=", inStockOnly)
            };

            StringBuilder uri = new();

            uri.Append(baseAPI);
            uri.Append(requestType);

            foreach (var item in allIputParams)
            {
                uri.Append(item.Key);
                uri.Append(item.Value);

            }

            return await httpClient.GetFromJsonAsync<GetDGSGoods>(uri.ToString());


        }


        #endregion

        #region Messages
        #endregion


        #region Account
        public async Task<IGetAccount?> GetAccount(string accountID, string height = "", string commitAmount="", string commitEstimate="")
        {

            string baseAPI = "/burst";
            string requestType = "?requestType=getAccount";


            List<KeyValuePair<string, string>> allIputParams = new()
            {
                // Converting Request Params to Key Value Pair.  
                new KeyValuePair<string, string>("&account=", accountID),
                new KeyValuePair<string, string>("&height=", height),
                new KeyValuePair<string, string>("&getCommittedAmount=", commitAmount),
               new KeyValuePair<string, string>("&estimateCommitment=", commitEstimate)
            };

            StringBuilder uri = new();

            uri.Append(baseAPI);
            uri.Append(requestType);

            foreach (var item in allIputParams)
            {
                uri.Append(item.Key);
                uri.Append(item.Value);

            }

            try
            {
                return await httpClient.GetFromJsonAsync<GetAccount>(uri.ToString());
            }
            catch (HttpRequestException) // Non success
            {
                Console.WriteLine("An error occurred.");
            }
            catch (NotSupportedException) // When content type is not valid
            {
                Console.WriteLine("The content type is not supported.");
            }
            catch (JsonException) // Invalid JSON
            {
                Console.WriteLine("Invalid JSON.");
            }

            return null;

        }

        public async Task<IGetAccountAssets?> GetAccountAssets(string accountID, string firstIndex="", string lastIndex="")
        {

            string baseAPI = "/burst?";
            string requestType = "requestType=getAccountAssets";


            List<KeyValuePair<string, string>> allIputParams = new()
            {
                // Converting Request Params to Key Value Pair.  
                new KeyValuePair<string, string>("&account=", accountID),
                new KeyValuePair<string, string>("&firstIndex=", firstIndex),
                new KeyValuePair<string, string>("&lastIndex=", lastIndex)
            };

            StringBuilder uri = new();

            uri.Append(baseAPI);
            uri.Append(requestType);

            foreach (var item in allIputParams)
            {
                uri.Append(item.Key);
                uri.Append(item.Value);

            }
            return await httpClient.GetFromJsonAsync<GetAccountAssets>(uri.ToString());


        }

        public async Task<IGetAccountBlockIds?> GetAccountBlockIds(string accountId, string firstIndex = "", string lastIndex = "", string timestamp = "")
        {


            string baseAPI = "/burst?";
            string requestType = "requestType=getAccountBlockIds";


            List<KeyValuePair<string, string>> allIputParams = new()
            {
                // Converting Request Params to Key Value Pair.  
                new KeyValuePair<string, string>("&account=", accountId),
                new KeyValuePair<string, string>("&timestamp=", timestamp),
                new KeyValuePair<string, string>("&firstIndex=", firstIndex),
                new KeyValuePair<string, string>("&lastIndex=", lastIndex)
            };

            StringBuilder uri = new();

            uri.Append(baseAPI);
            uri.Append(requestType);

            foreach (var item in allIputParams)
            {
                uri.Append(item.Key);
                uri.Append(item.Value);

            }

                return await httpClient.GetFromJsonAsync<GetAccountBlockIds>(uri.ToString());

        }

        public async Task<IGetAccountBlocks?> GetAccountBlocks(string account, string firstIndex = "", string lastIndex = "", string timestamp = "")
        {
            string baseAPI = "/burst?";
            string requestType = "requestType=getAccountBlocks";


            List<KeyValuePair<string, string>> allIputParams = new()
            {
                // Converting Request Params to Key Value Pair.  
                new KeyValuePair<string, string>("&account=", account),
                new KeyValuePair<string, string>("&timestamp=", timestamp),
                new KeyValuePair<string, string>("&firstIndex=", firstIndex),
                new KeyValuePair<string, string>("&lastIndex=", lastIndex),
                new KeyValuePair<string, string>("&includeTransactions=", "false")
            };

            StringBuilder uri = new();

            uri.Append(baseAPI);
            uri.Append(requestType);

            foreach (var item in allIputParams)
            {
                uri.Append(item.Key);
                uri.Append(item.Value);

            }

            return await httpClient.GetFromJsonAsync<GetAccountBlocks>(uri.ToString());

        }

        public async Task<IGetAccountBlocksTrans?> GetAccountBlocksTrans(string account, string firstIndex = "", string lastIndex = "", string timestamp = "")
        {
            //will grab transaction array data instead of a list

            string baseAPI = "/burst?";
            string requestType = "requestType=getAccountBlocks";


            List<KeyValuePair<string, string>> allIputParams = new()
            {
                // Converting Request Params to Key Value Pair.  
                new KeyValuePair<string, string>("&account=", account),
                new KeyValuePair<string, string>("&timestamp=", timestamp),
                new KeyValuePair<string, string>("&firstIndex=", firstIndex),
                new KeyValuePair<string, string>("&lastIndex=", lastIndex),
                new KeyValuePair<string, string>("&includeTransactions=", "true")
            };

            StringBuilder uri = new();

            uri.Append(baseAPI);
            uri.Append(requestType);

            foreach (var item in allIputParams)
            {
                uri.Append(item.Key);
                uri.Append(item.Value);

            }

                return await httpClient.GetFromJsonAsync<GetAccountBlocksTrans>(uri.ToString());

        }

        public async Task<IGetAccountPublicKey?> GetAccountPublicKey(string account)
        {

            string baseAPI = "/burst?";
            string requestType = "requestType=getAccountPublicKey";


            List<KeyValuePair<string, string>> allIputParams = new()
            {
                // Converting Request Params to Key Value Pair.  
                new KeyValuePair<string, string>("&account=", account)
            };

            StringBuilder uri = new();

            uri.Append(baseAPI);
            uri.Append(requestType);

            foreach (var item in allIputParams)
            {
                uri.Append(item.Key);
                uri.Append(item.Value);

            }
            return await httpClient.GetFromJsonAsync<GetAccountPublicKey>(uri.ToString());

        }

        public async Task<IGetBalance?> GetBalance(string account)
        {

            string baseAPI = "/burst?";
            string requestType = "requestType=getBalance";


            List<KeyValuePair<string, string>> allIputParams = new()
            {
                // Converting Request Params to Key Value Pair.  
                new KeyValuePair<string, string>("&account=", account)
            };

            StringBuilder uri = new();

            uri.Append(baseAPI);
            uri.Append(requestType);

            foreach (var item in allIputParams)
            {
                uri.Append(item.Key);
                uri.Append(item.Value);

            }

            return await httpClient.GetFromJsonAsync<GetBalance>(uri.ToString());


        }


        #endregion

        #region Alias



        //Alias by ID or Name
        public async Task<IGetAlias?> GetAlias(string alias)
        {

            string baseAPI = "/burst?";
            string requestType = "requestType=getAlias";


            List<KeyValuePair<string, string>> allIputParams = new()
            {

                // Converting Request Params to Key Value Pair.  
                new KeyValuePair<string, string>("&alias=", alias)
            };

            StringBuilder uri = new();

            uri.Append(baseAPI);
            uri.Append(requestType);

            foreach (var item in allIputParams)
            {
                uri.Append(item.Key);
                uri.Append(item.Value);

            }

            try
            {
                return await httpClient.GetFromJsonAsync<GetAlias>(uri.ToString());
            }
            catch (HttpRequestException) // Non success
            {
                Console.WriteLine("An error occurred.");
            }
            catch (NotSupportedException) // When content type is not valid
            {
                Console.WriteLine("The content type is not supported.");
            }
            catch (JsonException) // Invalid JSON
            {
                Console.WriteLine("Invalid JSON.");
            }

            return null;
        }
        public async Task<IGetAlias?> GetAliasName(string aliasName)
        {

            string baseAPI = "/burst?";
            string requestType = "requestType=getAlias";


            List<KeyValuePair<string, string>> allIputParams = new()
            {

                // Converting Request Params to Key Value Pair.  
                new KeyValuePair<string, string>("&aliasName=", aliasName)
            };

            StringBuilder uri = new();

            uri.Append(baseAPI);
            uri.Append(requestType);

            foreach (var item in allIputParams)
            {
                uri.Append(item.Key);
                uri.Append(item.Value);

            }

            try
            {
                return await httpClient.GetFromJsonAsync<GetAlias>(uri.ToString());
            }
            catch (HttpRequestException) // Non success
            {
                Console.WriteLine("An error occurred.");
            }
            catch (NotSupportedException) // When content type is not valid
            {
                Console.WriteLine("The content type is not supported.");
            }
            catch (JsonException) // Invalid JSON
            {
                Console.WriteLine("Invalid JSON.");
            }

            return null;
        }

        public async Task<IGetAliases?> GetAliases(string account, string firstIndex = "", string lastIndex = "")
        {


            string baseAPI = "/burst?";
            string requestType = "requestType=getAliases";


            List<KeyValuePair<string, string>> allIputParams = new()
            {

                // Converting Request Params to Key Value Pair.  
                new KeyValuePair<string, string>("&account=", account),
                new KeyValuePair<string, string>("&firstIndex=", firstIndex),
                new KeyValuePair<string, string>("&lastIndex=", lastIndex)
            };


            StringBuilder uri = new();

            uri.Append(baseAPI);
            uri.Append(requestType);

            foreach (var item in allIputParams)
            {
                uri.Append(item.Key);
                uri.Append(item.Value);

            }
            return await httpClient.GetFromJsonAsync<GetAliases>(uri.ToString());


        }

        #endregion


        #region Utilities

        //GET Methods
        public async Task<ILongConvert?> LongConvert(string id)
        {
            StringBuilder uri = new();

            uri.Append(APIConstants.API_URL);
            uri.Append(APIConstants.API_REQUEST);
            uri.Append(RequestType.LONG_CONVERT);


            List<KeyValuePair<string, string>> allIputParams = new()
            {
                // Converting Request Params to Key Value Pair.  
                new KeyValuePair<string, string>("&id=", id)
            };


            foreach (var item in allIputParams)
            {
                uri.Append(item.Key);
                uri.Append(item.Value);

            }

            //Not monitoring or catching exceptions in this library
            return await httpClient.GetFromJsonAsync<LongConvert>(uri.ToString());

        }

        public async Task<IRSConvert?> RSConvert(string id)
        {

            StringBuilder uri = new();

            uri.Append(APIConstants.API_URL);
            uri.Append(APIConstants.API_REQUEST);
            uri.Append(RequestType.RS_CONVERT);



            List<KeyValuePair<string, string>> allIputParams = new()
            {
                // Converting Request Params to Key Value Pair.  
                new KeyValuePair<string, string>("&id=", id)
            };

            //Uncomment if paramaters needed
            foreach (var item in allIputParams)
            {
                uri.Append(item.Key);
                uri.Append(item.Value);

            }

            return await httpClient.GetFromJsonAsync<RSConvert>(uri.ToString());

            //try
            //{
            //    return await httpClient.GetFromJsonAsync<RSConvert>(uri.ToString());
            //}
            //catch (HttpRequestException) // Non success
            //{
            //    //Console.WriteLine("An error occurred.");
            //}
            //catch (NotSupportedException) // When content type is not valid
            //{
            //    //Console.WriteLine("The content type is not supported.");
            //}
            //catch (JsonException) // Invalid JSON
            //{
            //   // Console.WriteLine("Invalid JSON.");
            //}

            //return null;
        }

        public async Task<ISuggestFee?> SuggestFee()
        {

            StringBuilder uri = new();

            uri.Append(APIConstants.API_URL);
            uri.Append(APIConstants.API_REQUEST);
            uri.Append(RequestType.SUGGEST_FEE);

            return await httpClient.GetFromJsonAsync<SuggestFee>(uri.ToString());

        }


        #endregion



        #region ServerInfo

        #region Mining

        //GET type methods
        public async Task<IGetMiningInfo?> GetMiningInfo()
        {

            StringBuilder uri = new();

            uri.Append(APIConstants.API_URL);
            uri.Append(APIConstants.API_REQUEST);
            uri.Append(RequestType.GET_MINING_INFO);

            return await httpClient.GetFromJsonAsync<GetMiningInfo>(uri.ToString());


        }
        public async Task<IGetRewardRecipient?> GetRewardRecipient(string account)
        {

            StringBuilder uri = new();

            uri.Append(APIConstants.API_URL);
            uri.Append(APIConstants.API_REQUEST);
            uri.Append(RequestType.GET_REWARD_RECIPIENT);


            List<KeyValuePair<string, string>> allIputParams = new()
            {
                // Converting Request Params to Key Value Pair.  
                new KeyValuePair<string, string>("&account=", account)
            };


            //Uncomment if paramaters needed
            foreach (var item in allIputParams)
            {
                uri.Append(item.Key);
                uri.Append(item.Value);

            }

            return await httpClient.GetFromJsonAsync<GetRewardRecipient>(uri.ToString());

        }

        public async Task<IGetAccountsWithRewardRecipient?> GetAccountsWithRewardRecipient(string account)
        {

                StringBuilder uri = new();

                uri.Append(APIConstants.API_URL);
                uri.Append(APIConstants.API_REQUEST);
                uri.Append(RequestType.GET_ACCOUNTS_WITH_REWARD_RECIP);


                List<KeyValuePair<string, string>> allIputParams = new()
                {
                    // Converting Request Params to Key Value Pair.  
                    new KeyValuePair<string, string>("&account=", account)
                };


                //Uncomment if paramaters needed
                foreach (var item in allIputParams)
                {
                    uri.Append(item.Key);
                    uri.Append(item.Value);

                }

                return await httpClient.GetFromJsonAsync<GetAccountsWithRewardRecipient>(uri.ToString());


        }



        #endregion


        public async Task<IGetTime?> GetTime()
        {

            StringBuilder uri = new();

            uri.Append(APIConstants.API_URL);
            uri.Append(APIConstants.API_REQUEST);
            uri.Append(RequestType.GET_TIME);

            return await httpClient.GetFromJsonAsync<GetTime>(uri.ToString());


        }
        public async Task<IGetState?> GetState(string includeCounts = "", string apiKey = "")
        {
            StringBuilder uri = new();

            uri.Append(APIConstants.API_URL);
            uri.Append(APIConstants.API_REQUEST);
            uri.Append(RequestType.GET_STATE);

            if (!(apiKey == "") || !(includeCounts == ""))
            {
                List<KeyValuePair<string, string>> allIputParams = new()
                {
                    // Converting Request Params to Key Value Pair.  
                    new KeyValuePair<string, string>("&includeCounts=", includeCounts),
                    new KeyValuePair<string, string>("&apiKey=", apiKey)
                };

                foreach (var item in allIputParams)
                {
                    uri.Append(item.Key);
                    uri.Append(item.Value);

                }

            }

            return await httpClient.GetFromJsonAsync<GetState>(uri.ToString());


        }
        public async Task<IGetPeer?> GetPeer(string peer)
        {
            StringBuilder uri = new();

            uri.Append(APIConstants.API_URL);
            uri.Append(APIConstants.API_REQUEST);
            uri.Append(RequestType.GET_PEER);

            List<KeyValuePair<string, string>> allIputParams = new()
            {
                // Converting Request Params to Key Value Pair.  
                new KeyValuePair<string, string>("&peer=", peer)
            };

            foreach (var item in allIputParams)
            {
                uri.Append(item.Key);
                uri.Append(item.Value);

            }

            GetPeer? response = await httpClient.GetFromJsonAsync<GetPeer>(uri.ToString());

            if (response is null)
            {
                return null;
            }
            else
            {
                response.PublicIP = peer;

                return response;
            }

        }
        public async Task<IGetPeers?> GetPeers(string active = "", string state = "")
        {
            StringBuilder uri = new();

            uri.Append(APIConstants.API_URL);
            uri.Append(APIConstants.API_REQUEST);
            uri.Append(RequestType.GET_PEERS);


            if (!(active == "") || !(state == ""))
            {
                List<KeyValuePair<string, string>> allIputParams = new()
                {
                    // Converting Request Params to Key Value Pair.  
                    new KeyValuePair<string, string>("&active=", active),
                    new KeyValuePair<string, string>("&state=", state)
                };

                foreach (var item in allIputParams)
                {
                    uri.Append(item.Key);
                    uri.Append(item.Value);

                }

            }

            return await httpClient.GetFromJsonAsync<GetPeers>(uri.ToString());

  
        }

        public async Task<IGetMyInfo?> GetMyInfo()
        {
            StringBuilder uri = new();

            uri.Append(APIConstants.API_URL);
            uri.Append(APIConstants.API_REQUEST);
            uri.Append(RequestType.GET_MY_INFO);

            return await httpClient.GetFromJsonAsync<GetMyInfo>(uri.ToString());


        }

        public async Task<IGetBlockchainStatus?> GetBlockchainStatus()
        {
            StringBuilder uri = new();

            uri.Append(APIConstants.API_URL);
            uri.Append(APIConstants.API_REQUEST);
            uri.Append(RequestType.GET_BLOCKCHAIN_STATUS);

            return await httpClient.GetFromJsonAsync<GetBlockchainStatus>(uri.ToString());

        }

        public async Task<IGetConstants?> GetConstants()
        {
            StringBuilder uri = new();

            uri.Append(APIConstants.API_URL);
            uri.Append(APIConstants.API_REQUEST);
            uri.Append(RequestType.GET_CONSTANTS);

            return await httpClient.GetFromJsonAsync<GetConstants>(uri.ToString());


        }
        #endregion


    }
}
