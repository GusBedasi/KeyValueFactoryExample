using System;
using System.Collections.Generic;

namespace KeyValueTest
{
    class AntifraudResponseFactory
    {
        private Dictionary<string, Dictionary<string, AntiFraudResponse>>  _antiFraudResponses;

        public AntifraudResponseFactory()
        {
            _antiFraudResponses = new Dictionary<string, Dictionary<string, AntiFraudResponse>>()
            {
                {"acquirer", new Dictionary<string, AntiFraudResponse>()
                    {
                        { "refused", null },
                        { "authorized", null },
                        { "pending_review", null }
                    }
                },
                {"antifraud", new Dictionary<string, AntiFraudResponse>()
                    {
                        { "refused", new AntiFraudResponse(100, "pagarme", "refused") },
                        { "authorized", new AntiFraudResponse(0, "pagarme", "approved") },
                        { "analyzing", new AntiFraudResponse(0, "pagarme", "pending")},
                        { "pending_review", new AntiFraudResponse(0, "pagarme", "pending") }
                    }
                },
            };
        }
        public AntiFraudResponse GetAntifraudResponseBasedOnStatus(string transactionStatus, string statusReason)
        {
            if (!_antiFraudResponses.ContainsKey(statusReason))
            {
                throw new NotImplementedException("Reason status not implemented");
            }

            return _antiFraudResponses[statusReason][transactionStatus];
        }
    }
}
