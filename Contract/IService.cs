using System.Runtime.Serialization;
using System.ServiceModel;

namespace Contract
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        GetMessageResponse GetMessage(GetMessageRequest request);
    }

    [DataContract]
    public class GetMessageRequest
    {
        [DataMember]
        public string Name { get; set; }
    }

    [DataContract]
    public class GetMessageResponse
    {
        [DataMember]
        public string Message { get; set; }
    }
}
