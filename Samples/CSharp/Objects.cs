using System.Collections.Generic;
using Newtonsoft.Json;
using System;

namespace MedApiSample
{
    class LicenseSummary
    {
        public string Fid { get; set; }
        public int Count { get; set; }

        public override string ToString()
        {
            return "Fid: " + Fid + ", Count: " + Count;
        }
    }

    class AccessToken
    {
        [JsonProperty("access_Token")]
        public string Token { get; set; }

        [JsonProperty("expires_in")]
        public int ExpiresIn { get; set; }

        [JsonProperty("token_type")]
        public string TokenType { get; set; }
    }

    public class MedicalProfessionalIdentity
    {
        public string Fid { get; set; }
    }

    public class PdcPractitioner
    {
        public string Fid { get; set; }
        public IEnumerable<BoardOrder> Orders { get; set; }
        public IEnumerable<License> Licenses { get; set; }
    }

    public class BoardOrder
    {
        public string Category { get; set; }
        public IEnumerable<CodedDescription> Actions { get; set; }
    }

    public class License
    {
        public string IssuerName { get; set; }
        public string IssuerShortName { get; set; }
        public string LicenseNumber { get; set; }
    }

    public class CodedDescription
    {
        [JsonProperty("actionCode")]
        public string Code { get; set; }

        [JsonProperty("actionDescription")]
        public string Description { get; set; }
    }
}
