using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Toshl.QueryObjects
{
    public class AccountParams
    {
        /// <summary>
        /// Page to display, used for pagination.
        /// Minimum: <c>>= 0</c>
        /// Default value: <c>0</c>
        /// </summary>
        [JsonProperty(PropertyName = "page"), DefaultValue(0)]
        public int Page { get; set; }

        /// <summary>
        /// Number of resource objects to return.
        ///  Minimum: <c>>= 10</c>
        ///  Maximum: <c>=&#60; 500</c>
        /// Default value: <c>200</c>
        /// </summary>
        [JsonProperty(PropertyName = "per_page"), DefaultValue(200)]
        public int PerPage { get; set; }

        /// <summary>
        /// Return all accounts that were modified since timestamp.
        /// Format: <c>date-time</c>
        /// </summary>
        [JsonProperty(PropertyName = "since")]
        public string Since { get; set; }

        /// <summary>
        /// Return only accounts with a specific status.
        /// Possible values: <c>active</c>, <c>inactive</c>, <c>archived</c>
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Include deleted accounts.
        /// </summary>
        [JsonProperty(PropertyName = "include_deleted")]
        public bool IncludeDeleted { get; set; }
    }
}
