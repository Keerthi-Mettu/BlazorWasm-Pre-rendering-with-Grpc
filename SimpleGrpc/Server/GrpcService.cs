using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using GrpcDB;

namespace SimpleGrpc.Server
{
    public class GrpcService : DBservicesthroughGrpc.DBservicesthroughGrpcBase
    {
        public override Task<GetQuoteResponse> GetIndexQuoteDetails(QuoteRequest request, ServerCallContext context)
        {
            //return base.GetIndexQuoteDetails(request, context);
            var todayIndexQuote = new GetQuoteResponse()
            {
                FirstName = "john", //DbData.FirstName,
                MiddleName = "Doe", // DbData.MiddleName,
                LastName = "", // DbData.LastName,
                Quote = "this is dummy data retreived thru grpc"  //DbData.Quotation
            };

            return Task.FromResult(todayIndexQuote);
        }
    }
}
