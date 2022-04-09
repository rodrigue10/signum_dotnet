namespace Signum.NET
{
    public interface IBaseRequest
    {

        public int RequestProcessingTime { get; }
        public int ErrorCode { get; }
        public string? ErrorDescription { get; }
        public bool IsValidRequest { get; }
    }
}