using System.Collections.Generic;
using System.Threading.Tasks;


namespace Signum.NET
{
    public interface ISignumAPIService
    {



        #region Mining

        //GET Methods
        Task<IGetMiningInfo?> GetMiningInfo();
        Task<IGetRewardRecipient?> GetRewardRecipient(string account);
  
        Task<IGetAccountsWithRewardRecipient?> GetAccountsWithRewardRecipient(string account);



        //POST Methods

        //Task<SetRewardRecipient> setRewardRecipient(string account);

        #endregion

        #region Assets

        Task<IGetAllAssets?> GetAllAssets(string firstIndex = "", string lastIndex = "");

        Task<IGetAsset?> GetAsset(string assetId);

        Task<IGetAskOrders?> GetAskOrders(string assetId, string firstIndex = "", string lastIndex = "");
        Task<IGetBidOrders?> GetBidOrders(string assetId, string firstIndex = "", string lastIndex = "");

        Task<IGetTrades?> GetTrades(string assetId,string account = "", string includeAssetInfo = "", string firstIndex = "", string lastIndex = "");


        #endregion

        #region ATs

        Task<IGetAccountATs?> GetAccountATs(string id);



        #endregion

        #region Block

        Task<IGetBlock?> GetBlock(string block, string height = "", string timestamp = "", string includeTransactions = "");
        Task<IGetBlocks?> GetBlocks(string firstIndex = "", string lastIndex = "", string includeTransactions = "");
        Task<IGetBlockId?> GetBlockId(string height);
        Task<IGetECBlock?> GetECBlock(string timestamp = "");
        Task<IGetDGSGoods?> GetDGSGoods(string seller = "", string firstIndex = "", string lastIndex = "", string inStockOnly = "");


        #endregion

        #region Messages

        #endregion


        #region Account

            #region POST
            Task<ICreateTransactionResponse?> SetAccountInfo(SetAccountInfo setAccountInfo);

        #endregion

            #region GET

            Task<IGetAccount?> GetAccount(string accountID, string height = "", string commitAmount = "", string commitEstimate = "");
            Task<IGetAccountBlockIds?> GetAccountBlockIds(string accountId, string firstIndex = "", string lastIndex = "", string timestamp = "");
            Task<IGetAccountBlocks?> GetAccountBlocks(string account, string firstIndex = "", string lastIndex = "", string timestamp = "");
            Task<IGetAccountBlocksTrans?> GetAccountBlocksTrans(string account, string firstIndex = "", string lastIndex = "", string timestamp = "");
            Task<IGetAccountPublicKey?> GetAccountPublicKey(string account);
            Task<IGetBalance?> GetBalance(string account);

            Task<IGetAccountAssets?> GetAccountAssets(string accountID, string firstIndex="", string lastIndex="");
            #endregion

        #endregion

        #region Alias

        Task<IGetAlias?> GetAlias(string alias);
        Task<IGetAlias?> GetAliasName(string aliasName);
        Task<IGetAliases?> GetAliases(string account, string firstIndex = "", string lastIndex = "");


        #endregion



        #region Utilities

        Task<ILongConvert?> LongConvert(string id);
        Task<IRSConvert?> RSConvert(string id);
        Task<ISuggestFee?> SuggestFee();

        #endregion


        #region ServerInfo


        /// <summary>
        /// Get blockchain time
        /// </summary>
        /// <returns>Returns an IGetTime interface containing the relevant data</returns>
        Task<IGetTime?> GetTime();


        /// <summary>
        /// 
        /// </summary>
        /// <param name="includeCounts"></param>
        /// <param name="apiKey"></param>
        /// <returns></returns>
        Task<IGetState?> GetState(string includeCounts = "", string apiKey = "");

        /// <summary>
        /// 
        /// </summary>
        /// <param name="active"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        Task<IGetPeers?> GetPeers(string active = "", string state = "");

        /// <summary>
        /// 
        /// </summary>
        /// <param name="peer"></param>
        /// <returns></returns>
        Task<IGetPeer?> GetPeer(string peer);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<IGetMyInfo?> GetMyInfo();

        /// <summary>
        /// Get blockchain status.
        /// </summary>
        /// <returns>Blockchain status</returns>
        Task<IGetBlockchainStatus?> GetBlockchainStatus();

        /// <summary>
        /// Blockchain Constants
        /// </summary>
        /// <returns>Summarry of blockchain constants.  Including transaction types and costs</returns>
        Task<IGetConstants?> GetConstants();

        #endregion


    }
}
