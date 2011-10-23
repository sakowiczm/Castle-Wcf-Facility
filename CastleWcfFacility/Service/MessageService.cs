using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Contract;

namespace CastleWcfFacility.Service
{
    public class MessageService : IService
    {
        public GetMessageResponse GetMessage(GetMessageRequest request)
        {
            return new GetMessageResponse() { Message = "Hello " + request.Name };
        }
    }
}