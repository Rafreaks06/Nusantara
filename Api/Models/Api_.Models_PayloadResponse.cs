using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Nusantara.Api.Models
{
    public class CoopApiResponse
    {
        public string? CoopCode { get; set; }
        public string ResponseCode { get; set; } = "99";
        public string ResponseMessage { get; set; } = "Fail";
        public DateTime ResponseTime { get; set; }

        [JsonPropertyName("coopList")]
        public List<CoopAcross> CoopList { get; set; } = new();
    }

    public class MemberApiResponse
    {
        public string? MemberCode { get; set; }
        public string ResponseCode { get; set; } = "99";
        public string ResponseMessage { get; set; } = "Fail";
        public DateTime ResponseTime { get; set; }

        [JsonPropertyName("memberList")]
        public List<MemberAcross> MemberList { get; set; } = new();
    }

    public class BalanceApiResponse
    {
        public string ResponseCode { get; set; } = "99";
        public string ResponseMessage { get; set; } = "Fail";
        public DateTime ResponseTime { get; set; }
        public string? MemberCode { get; set; }
        public string? CoopCode { get; set; }

        [JsonPropertyName("balanceList")]
        public List<BalanceAcross> BalanceList { get; set; } = new();
    }

    public class TransferApiResponse
    {
        public string ResponseCode { get; set; } = "99";
        public string ResponseMessage { get; set; } = "Fail";
        public DateTime ResponseTime { get; set; }
        public string? TransferCode { get; set; }
        public string? Transfer { get; set; }

        [JsonPropertyName("memberList")]
        public List<TransferAcross> TransferList { get; set; } = new();
    }
}
