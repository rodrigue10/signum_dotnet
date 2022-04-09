using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signum.NET
{
    public static class APIConstants
    {
        public const string API_URL = "/burst?";
        public const string API_REQUEST = "requestType=";
    }

    public static class RequestType
    {

        public const string GET_TIME = "getTime";
        public const string GET_STATE = "getState";
        public const string GET_PEERS = "getPeers";
        public const string GET_PEER = "getPeer";
        public const string GET_MY_INFO = "getMyInfo";
        public const string GET_BLOCKCHAIN_STATUS = "getBlockchainStatus";
        public const string GET_CONSTANTS = "getConstants";

        public const string LONG_CONVERT = "longConvert";
        public const string RS_CONVERT = "rsConvert";
        public const string SUGGEST_FEE = "suggestFee";

        public const string GET_ACCOUNTS_WITH_REWARD_RECIP = "getAccountsWithRewardRecipient";
        
        public const string GET_MINING_INFO = "getMiningInfo";
        public const string GET_REWARD_RECIPIENT = "getRewardRecipient";
        public const string REWARD_RECIPIENT = "rewardRecipient";

        public const string GET_BLOCK = "getBlock";
        public const string GET_BLOCK_ID = "getBlockId";
        public const string GET_BLOCKS = "getBlocks";

        public const string GET_ACCOUNT = "getAccount";

        

    }
}
