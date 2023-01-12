/*
 * Blockmate
 *
 * Blockmate API OpenAPI documentation
 *
 * The version of the OpenAPI document: 0.0.2
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Io.Blockmate.Client.OpenAPIDateConverter;

namespace Io.Blockmate.Model
{
    /// <summary>
    /// Transactions200Response
    /// </summary>
    [DataContract]
    public partial class Transactions200Response :  IEquatable<Transactions200Response>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Transactions200Response" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Transactions200Response() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Transactions200Response" /> class.
        /// </summary>
        /// <param name="pageCursor">Use this as &#x60;cursor&#x60; in the next request to get the next page. The &#x60;page_cursor&#x60; has a one hour validity..</param>
        /// <param name="accounts">accounts.</param>
        /// <param name="transactions">transactions (required).</param>
        public Transactions200Response(string pageCursor = default(string), List<Transactions200ResponseAccountsInner> accounts = default(List<Transactions200ResponseAccountsInner>), List<Transaction> transactions = default(List<Transaction>))
        {
            // to ensure "transactions" is required (not null)
            if (transactions == null)
            {
                throw new InvalidDataException("transactions is a required property for Transactions200Response and cannot be null");
            }
            else
            {
                this.Transactions = transactions;
            }

            this.PageCursor = pageCursor;
            this.Accounts = accounts;
        }

        /// <summary>
        /// Use this as &#x60;cursor&#x60; in the next request to get the next page. The &#x60;page_cursor&#x60; has a one hour validity.
        /// </summary>
        /// <value>Use this as &#x60;cursor&#x60; in the next request to get the next page. The &#x60;page_cursor&#x60; has a one hour validity.</value>
        [DataMember(Name="page_cursor", EmitDefaultValue=false)]
        public string PageCursor { get; set; }

        /// <summary>
        /// Gets or Sets Accounts
        /// </summary>
        [DataMember(Name="accounts", EmitDefaultValue=false)]
        public List<Transactions200ResponseAccountsInner> Accounts { get; set; }

        /// <summary>
        /// Gets or Sets Transactions
        /// </summary>
        [DataMember(Name="transactions", EmitDefaultValue=true)]
        public List<Transaction> Transactions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Transactions200Response {\n");
            sb.Append("  PageCursor: ").Append(PageCursor).Append("\n");
            sb.Append("  Accounts: ").Append(Accounts).Append("\n");
            sb.Append("  Transactions: ").Append(Transactions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Transactions200Response);
        }

        /// <summary>
        /// Returns true if Transactions200Response instances are equal
        /// </summary>
        /// <param name="input">Instance of Transactions200Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Transactions200Response input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PageCursor == input.PageCursor ||
                    (this.PageCursor != null &&
                    this.PageCursor.Equals(input.PageCursor))
                ) && 
                (
                    this.Accounts == input.Accounts ||
                    this.Accounts != null &&
                    input.Accounts != null &&
                    this.Accounts.SequenceEqual(input.Accounts)
                ) && 
                (
                    this.Transactions == input.Transactions ||
                    this.Transactions != null &&
                    input.Transactions != null &&
                    this.Transactions.SequenceEqual(input.Transactions)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.PageCursor != null)
                    hashCode = hashCode * 59 + this.PageCursor.GetHashCode();
                if (this.Accounts != null)
                    hashCode = hashCode * 59 + this.Accounts.GetHashCode();
                if (this.Transactions != null)
                    hashCode = hashCode * 59 + this.Transactions.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
