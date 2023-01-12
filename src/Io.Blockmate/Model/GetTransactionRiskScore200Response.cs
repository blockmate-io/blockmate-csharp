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
    /// GetTransactionRiskScore200Response
    /// </summary>
    [DataContract]
    public partial class GetTransactionRiskScore200Response :  IEquatable<GetTransactionRiskScore200Response>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransactionRiskScore200Response" /> class.
        /// </summary>
        /// <param name="transaction">transaction.</param>
        /// <param name="risk">risk.</param>
        public GetTransactionRiskScore200Response(string transaction = default(string), int risk = default(int))
        {
            this.Transaction = transaction;
            this.Risk = risk;
        }

        /// <summary>
        /// Gets or Sets Transaction
        /// </summary>
        [DataMember(Name="transaction", EmitDefaultValue=false)]
        public string Transaction { get; set; }

        /// <summary>
        /// Gets or Sets Risk
        /// </summary>
        [DataMember(Name="risk", EmitDefaultValue=false)]
        public int Risk { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetTransactionRiskScore200Response {\n");
            sb.Append("  Transaction: ").Append(Transaction).Append("\n");
            sb.Append("  Risk: ").Append(Risk).Append("\n");
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
            return this.Equals(input as GetTransactionRiskScore200Response);
        }

        /// <summary>
        /// Returns true if GetTransactionRiskScore200Response instances are equal
        /// </summary>
        /// <param name="input">Instance of GetTransactionRiskScore200Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetTransactionRiskScore200Response input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Transaction == input.Transaction ||
                    (this.Transaction != null &&
                    this.Transaction.Equals(input.Transaction))
                ) && 
                (
                    this.Risk == input.Risk ||
                    (this.Risk != null &&
                    this.Risk.Equals(input.Risk))
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
                if (this.Transaction != null)
                    hashCode = hashCode * 59 + this.Transaction.GetHashCode();
                if (this.Risk != null)
                    hashCode = hashCode * 59 + this.Risk.GetHashCode();
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


            // Risk (int) maximum
            if(this.Risk > (int)100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Risk, must be a value less than or equal to 100.", new [] { "Risk" });
            }

            // Risk (int) minimum
            if(this.Risk < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Risk, must be a value greater than or equal to 0.", new [] { "Risk" });
            }

            yield break;
        }
    }

}
