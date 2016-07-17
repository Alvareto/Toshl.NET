using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace Toshl
{
    /// <summary>
    /// <para>
    ///     Accounts endpoint can be used to interact with users accounts.
    /// </para>
    /// 
    /// <para>
    ///     Savings goals are a special accounts that can be used to save up a desired amount with a deadline. 
    ///     They act the same as a regular account (you can perform transactions to it, create a repeating transaction) 
    ///     and can even contain a user uploaded image.
    /// </para>
    /// <remarks>
    ///     <i>Note</i>: Be advised that accounts are subject to free account limitation. If a user with a free account tries to add an account and goes over the alowed number of accounts, a 403 (Forbidden) error will be returned and the account will be discarded.
    /// </remarks>
    /// </summary>
    [JsonObject("account")]
    [Description("Account")]
    public class Account
    {

        public Account()
        {
        }
        /// <summary>
        /// Account id.
        /// </summary>
        [JsonProperty("id")]
        [Description("ID")]
        public string Id { get; set; }
        /// <summary>
        /// Parent account id.
        /// </summary>
        [JsonProperty("parent")]
        [Description("Parent ID")]
        public string parent { get; set; }
        /// <summary>
        /// Account name.
        /// <c>Max length: 100</c>
        /// </summary>
        [JsonProperty("name")]
        [Description("Name")]
        public string name { get; set; }
        /// <summary>
        /// Is true if name is overriden with a custom name.
        /// </summary>
        [JsonProperty("name")]
        [Description("Name")]
        public bool name_override { get; set; }

        /// <summary>
        /// Account balance.
        /// <remarks>Minimum: <code>> -1000000000000000</code>
        /// Maximum: <code>&#60; 1000000000000000</code></remarks>
        /// </summary>
        [JsonProperty("name")]
        [Description("Name")]
        public double balance { get; set; }
        /// <summary>
        /// Account balance.
        /// <c>Minimum: > -1000000000000000</c>
        /// <c>Maximum: &#60; 1000000000000000</c>
        /// <c>Default value: 0</c>
        /// </summary>
        [JsonProperty("name")]
        [Description("Name")]
        public double initial_balance { get; set; }

        /// <summary>
        /// Account currency object.
        /// </summary>
        //[JsonProperty("name")]
        //[Description("Name")]
        //public Currency currency { get; set; }

        /// <summary>
        /// Calculated median of daily sums of expenses and incomes.
        /// </summary>
        public DailySumMedian daily_sum_median { get; set; }

        /// <summary>
        /// Calculated median of daily sums of expenses and incomes.
        /// </summary>
        public class DailySumMedian
        {
            /// <summary>
            /// Median of daily sums of expenses.
            /// <c>Minimum: >= 0</c>
            /// <c>Maximum: &#60; 1000000000000000</c>
            /// <c>Default value: 0</c>
            /// </summary>
            public double expenses { get; set; }
            /// <summary>
            /// Median of daily sums of expenses.
            /// <c>Minimum: >= 0</c>
            /// <c>Maximum: &#60; 1000000000000000</c>
            /// <c>Default value: 0</c>
            /// </summary>
            public double incomes { get; set; }
        }

        /// <summary>
        /// Account status.
        /// Possible values: active, inactive, archived
        /// </summary>
        public string status { get; set; }
        /// <summary>
        /// Account order.
        /// Minimum: >= 0
        /// Maximum: =&#60; 255
        /// </summary>
        public int order { get; set; }
        /// <summary>
        /// Specifies when the account was last modified.
        /// </summary>
        public string modified { get; set; }

        /// <summary>
        /// If account is a savings goal this includes a savings goal object.
        /// </summary>
        public class Goal
        {
            /// <summary>
            /// Desired amount to save.
            /// Minimum: > 0
            /// Maximum: &#60; 1000000000000000
            /// </summary>
            public double amount { get; set; }
            /// <summary>
            /// Savings goal start date in YYYY-MM-DD format.
            /// Format: date
            /// </summary>
            public string start { get; set; }
            /// <summary>
            /// Savings goal end date in YYYY-MM-DD format.
            /// Format: date
            /// </summary>
            public string end { get; set; }
        }

        /// <summary>
        /// If account is connected to an institution connection (bank etc.) this object includes details about the connection
        /// </summary>
        public class Connection
        {
            /// <summary>
            /// Connection id
            /// </summary>
            public string id { get; set; }
            /// <summary>
            /// Connection name
            /// </summary>
            public string name { get; set; }
            /// <summary>
            /// Connection status
            /// <remarks>Possible values: connected, refreshing, inactive, disconnected, error</remarks>
            /// </summary>
            public string status { get; set; }
        }
        /// <summary>
        /// Number of times the account has been used.
        /// </summary>
        public int count { get; set; }
        /// <summary>
        /// Is object deleted
        /// </summary>
        public bool deleted { get; set; }
        /// <summary>
        /// Specifies when the transient data was created in UTC time.
        /// </summary>
        public string transient_created { get; set; }
        /// <summary>
        /// Specifies till when the transient data is valid in user’s timezone.
        /// </summary>
        public string transient_valid_till { get; set; }
        /// <summary>
        /// A custom JSON object that you can use to extend Toshl API. Whatever you save into this field you will get back whenever you fetch it later.
        /// </summary>
        public object extra { get; set; }
    }
}