using System;
using System.Collections.Generic;
using System.Text;

namespace Enkapsulacja
{
    class RequestStart
    {
        public BrokerOfferRequest BrokerRequest { get; set; }

        private void generateRequest(BrokerOfferRequest br)
        {
            br = new BrokerOfferRequest
            {
                nameRequest = "test name",
                numberRequest = 123456,
                codeRequest = "aaabbb-acds",
                loanReason = "Na glupoty"

            };
        }

        public RequestStart()
        {
           generateRequest(this.BrokerRequest);
           Console.Write("broker request created");
        }
    }
}
