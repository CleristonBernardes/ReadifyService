using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using static ClientBusiness.Tools.Enums;
using static ClientServices.RedPillClient;

namespace ClientServices
{
    [ServiceBehavior(AddressFilterMode = AddressFilterMode.Any, Namespace = RedPillClient.ReadifyNameSpace)]
    public class RedPill : IRedPill
    {
        public RedPill()
        {
        }

        //[WebGet(UriTemplate = "WhatIsYourToken")]
        public Guid WhatIsYourToken()
        {
            return RedPillClient.WhatIsYourToken();
        }

        //[WebGet(UriTemplate = "FibonacciNumber?n={n}")]
        public long FibonacciNumber(long n)
        {
            return RedPillClient.FibonacciNumber(n);
        }
        
        public TriangleType WhatShapeIsThis(int a, int b, int c)
        {   
            return RedPillClient.WhatShapeIsThis(a, b, c);
        }

        //[WebGet(UriTemplate = "ReverseWords?s={s}")]
        public string ReverseWords(string s)
        {
            return RedPillClient.ReverseWords(s);
        }

    }
}
