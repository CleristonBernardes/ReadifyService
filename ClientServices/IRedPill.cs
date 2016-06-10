using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using static ClientBusiness.Tools.Enums;

namespace ClientServices
{
    [ServiceContract(Namespace = RedPillClient.ReadifyNameSpace)]
    public interface IRedPill
    {
        [OperationContract]
        Guid WhatIsYourToken();

        [OperationContract]
        long FibonacciNumber(long n);
        
        [OperationContract]
        TriangleType WhatShapeIsThis(int a, int b, int c);

        [OperationContract]
        string ReverseWords(string s);


    }
    
}
