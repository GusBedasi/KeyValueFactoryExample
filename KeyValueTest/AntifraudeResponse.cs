namespace KeyValueTest
{
    class AntiFraudResponse 
    {
        public AntiFraudResponse(int score, string providerName, string status)
        {
            Score = score;
            ProviderName = providerName;
            Status = status;
        }
        
        public int? Score { get; private set; }
        public string ProviderName { get; private set; }
        public string Status { get; private set; }
    }
}
