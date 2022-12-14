using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signum.NET
{
    public static class APIConstants
    {
        public const string API_URL = "/api?";
        public const string API_REQUEST = "requestType=";
    }

    public static class RequestType
    {

        public const string ADD_ASSET_TREASURY_ACCOUNT = "addAssetTreasuryAccount";
        public const string ADD_COMMITMENT = "addCommitment";
        public const string BACKUP_DB = "backupDB";
        public const string BROADCAST_TRANSACTION = "broadcastTransaction";
        public const string BUY_ALIAS = "buyAlias";
        public const string CALCULATE_FULL_HASH = "calculateFullHash";
        public const string CANCEL_ASK_ORDER = "cancelAskOrder";
        public const string CANCEL_BID_ORDER = "cancelBidOrder";
        public const string CLEAR_UNCONFIRMED_TRANSACTIONS = "clearUnconfirmedTransactions";
        public const string CREATE_AT_PROGRAM = "createATProgram";
        public const string DECRYPT_FROM = "decryptFrom";
        public const string DGS_DELISTING = "dgsDelisting";
        public const string DGS_DELIVERY = "dgsDelivery";
        public const string DGS_FEEDBACK = "dgsFeedback";
        public const string DGS_LISTING = "dgsListing";
        public const string DGS_PRICE_CHANGE = "dgsPriceChange";
        public const string DGS_PURCHASE = "dgsPurchase";
        public const string DGS_QUANTITY_CHANGE = "dgsQuantityChange";
        public const string DGS_REFUND = "dgsRefund";
        public const string DISTRIBUTE_TO_ASSET_HOLDERS = "distributeToAssetHolders";
        public const string ENCRYPT_TO = "encryptTo";
        public const string ESCROW_SIGN = "escrowSign";
        public const string FULL_RESET = "fullReset";
        public const string GENERATE_DEEPLINK = "generateDeeplink";
        public const string GENERATE_DEEPLINK_QR_CODE = "generateDeeplinkQRCode";
        public const string GENERATE_SEND_TRANSACTION_QR_CODE = "generateSendTransactionQRCode";
        public const string GENERATE_TOKEN = "generateToken";
        public const string GET_AT = "getAT";
        public const string GET_AT_DETAILS = "getATDetails";
        public const string GET_AT_IDS = "getATIds";
        public const string GET_AT_LONG = "getATLong";
        public const string GET_ACCOUNT = "getAccount";
        public const string GET_ACCOUNT_ATS = "getAccountATs";
        public const string GET_ACCOUNT_ASSETS = "getAccountAssets";
        public const string GET_ACCOUNT_BLOCK_IDS = "getAccountBlockIds";
        public const string GET_ACCOUNT_BLOCKS = "getAccountBlocks";
        public const string GET_ACCOUNT_CURRENT_ASK_ORDER_IDS = "getAcountCurrentAskOrderIds";
        public const string GET_ACCOUNT_CURRENT_ASK_ORDERS = "getAccountCurrentAskOrders";
        public const string GET_ACCOUNT_CURRENT_BID_ORDER_IDS = "getAcountCurrentBidOrderIds";
        public const string GET_ACCOUNT_CURRENT_BID_ORDERS = "getAccountCurrentBidOrders";
        public const string GET_ACCOUNT_ESCROW_TRANSACTIONS = "getAccountEscrowTransactions";
        public const string GET_ACCOUNT_ID = "getAcountId";
        public const string GET_ACCOUNT_PUBLIC_KEY = "getAccountPublicKey";
        public const string GET_ACCOUNT_SUBSCRIPTIONS = "getAccountSubscriptions";
        public const string GET_ACCOUNT_TRANSACTION_IDS = "getAccountTransactionIds";
        public const string GET_ACCOUNT_TRANSACTIONS = "getAccountTransactions";
        public const string GET_ACCOUNTS_WITH_NAME = "getAccountsWithName";
        public const string GET_ACCOUNTS_WITH_REWARD_RECIPIENT = "getAccountsWithRewardRecipient";
        public const string GET_ALIAS = "getAlias";
        public const string GET_ALIASES = "getAliases";
        public const string GET_ALL_ASSETS = "getAllAssets";
        public const string GET_ALL_OPEN_ASK_ORDERS = "getAllOpenAskOrders";
        public const string GET_ALL_OPEN_BID_ORDERS = "getAllOpenBidOrders";
        public const string GET_ALL_TRADES = "getAllTrades";
        public const string GET_ASK_ORDER = "getAskOrder";
        public const string GET_ASK_ORDER_IDS = "getAskOrderIds";
        public const string GET_ASK_ORDERS = "getAskOrders";
        public const string GET_ASSET = "getAsset";
        public const string GET_ASSET_ACCOUNTS = "getAssetAccounts";
        public const string GET_ASSET_IDS = "getAssetIds";
        public const string GET_ASSET_TRANSFERS = "getAssetTransfers";
        public const string GET_ASSETS = "getAssets";
        public const string GET_ASSETS_BY_ISSUER = "getAssetsByIssuer";
        public const string GET_BALANCE = "getBalance";
        public const string GET_BID_ORDER = "getBidOrder";
        public const string GET_BID_ORDER_IDS = "getBidOrderIds";
        public const string GET_BID_ORDERS = "getBidOrders";
        public const string GET_BLOCK = "getBlock";
        public const string GET_BLOCK_ID = "getBlockId";
        public const string GET_BLOCKCHAIN_STATUS = "getBlockchainStatus";
        public const string GET_BLOCKS = "getBlocks";
        public const string GET_CONSTANTS = "getConstants";
        public const string GET_DGS_GOOD = "getDGSGood";
        public const string GET_DGS_GOODS = "getDGSGoods";
        public const string GET_DGS_PENDING_PURCHASES = "getDGSPendingPurchases";
        public const string GET_DGS_PURCHASE = "getDGSPurchase";
        public const string GET_DGS_PURCHASES = "getDGSPurchases";
        public const string GET_EC_BLOCK = "getECBlock";
        public const string GET_ESCROW_TRANSACTION = "getEscrowTransaction";
        public const string GET_MINING_INFO = "getMiningInfo";
        public const string GET_MY_INFO = "getMyInfo";
        public const string GET_MY_PEER_INFO = "getMyPeerInfo";
        public const string GET_PEER = "getPeer";
        public const string GET_PEERS = "getPeers";
        public const string GET_REWARD_RECIPIENT = "getRewardRecipient";
        public const string GET_STATE = "getState";
        public const string GET_SUBSCRIPTION = "getSubscription";
        public const string GET_SUBSCRIPTIONS_TO_ACCOUNT = "getSubscriptionsToAccount";
        public const string GET_TIME = "getTime";
        public const string GET_TRADES = "getTrades";
        public const string GET_TRANSACTION = "getTransaction";
        public const string GET_TRANSACTION_BYTES = "getTransactionBytes";
        public const string GET_TRANSACTION_IDS = "getTransactionIds";
        public const string GET_UNCONFIRMED_TRANSACTION_IDS = "getUnconfirmedTransactionIds";
        public const string GET_UNCONFIRMED_TRANSACTIONS = "getUnconfirmedTransactions";
        public const string ISSUE_ASSET = "issueAsset";
        public const string LONG_CONVERT = "longConvert";
        public const string MINT_ASSET = "mintAsset";
        public const string PARSE_TRANSACTION = "parseTransaction";
        public const string RS_CONVERT = "rsConvert";
        public const string REWARD_RECIPIENT = "rewardRecipient";
        public const string PLACE_ASK_ORDER = "placeAskOrder";
        public const string PLACE_BID_ORDER = "placeBidOrder";
        public const string POP_OFF = "popOff";
        public const string READ_MESSAGE = "readMessage";
        public const string REMOVE_COMMITMENT = "removeCommitment";
        public const string SELL_ALIAS = "sellAlias";
        public const string SEND_MESSAGE = "sendMessage";
        public const string SEND_MONEY = "sendMoney";
        public const string SEND_MONEY_ESCROW = "sendMoneyEscrow";
        public const string SEND_MONEY_MULTI = "sendMoneyMulti";
        public const string SEND_MONEY_MULTI_SAME = "sendMoneyMultiSame";
        public const string SEND_MONEY_SUBSCRIPTION = "sendMoneySubscription";
        public const string SET_ACCOUNT_INFO = "setAccountInfo";
        public const string SET_ALIAS = "setAlias";
        public const string SET_REWARD_RECIPIENT = "setRewardRecipient";
        public const string SIGN_TRANSACTION = "signTransaction";
        public const string SUBMIT_NONCE = "submitNonce";
        public const string SUBSCRIPTION_CANCEL = "subscriptionCancel";
        public const string SUGGEST_FEE = "suggestFee";
        public const string TRANSFER_ASSET = "transferAsset";



        

    }
}
