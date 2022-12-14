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
    /// AddressRiskReport
    /// </summary>
    [DataContract]
    public partial class AddressRiskReport :  IEquatable<AddressRiskReport>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressRiskReport" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddressRiskReport() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressRiskReport" /> class.
        /// </summary>
        /// <param name="caseId">caseId.</param>
        /// <param name="requestDatetime">requestDatetime.</param>
        /// <param name="responseDatetime">responseDatetime.</param>
        /// <param name="address">address (required).</param>
        /// <param name="chain">chain (required).</param>
        /// <param name="risk">risk (required).</param>
        /// <param name="details">details (required).</param>
        public AddressRiskReport(string caseId = default(string), string requestDatetime = default(string), string responseDatetime = default(string), string address = default(string), string chain = default(string), int risk = default(int), AddressRiskReportDetails details = default(AddressRiskReportDetails))
        {
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new InvalidDataException("address is a required property for AddressRiskReport and cannot be null");
            }
            else
            {
                this.Address = address;
            }

            // to ensure "chain" is required (not null)
            if (chain == null)
            {
                throw new InvalidDataException("chain is a required property for AddressRiskReport and cannot be null");
            }
            else
            {
                this.Chain = chain;
            }

            // to ensure "risk" is required (not null)
            if (risk == null)
            {
                throw new InvalidDataException("risk is a required property for AddressRiskReport and cannot be null");
            }
            else
            {
                this.Risk = risk;
            }

            // to ensure "details" is required (not null)
            if (details == null)
            {
                throw new InvalidDataException("details is a required property for AddressRiskReport and cannot be null");
            }
            else
            {
                this.Details = details;
            }

            this.CaseId = caseId;
            this.RequestDatetime = requestDatetime;
            this.ResponseDatetime = responseDatetime;
        }

        /// <summary>
        /// Gets or Sets CaseId
        /// </summary>
        [DataMember(Name="case_id", EmitDefaultValue=false)]
        public string CaseId { get; set; }

        /// <summary>
        /// Gets or Sets RequestDatetime
        /// </summary>
        [DataMember(Name="request_datetime", EmitDefaultValue=false)]
        public string RequestDatetime { get; set; }

        /// <summary>
        /// Gets or Sets ResponseDatetime
        /// </summary>
        [DataMember(Name="response_datetime", EmitDefaultValue=false)]
        public string ResponseDatetime { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=true)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets Chain
        /// </summary>
        [DataMember(Name="chain", EmitDefaultValue=true)]
        public string Chain { get; set; }

        /// <summary>
        /// Gets or Sets Risk
        /// </summary>
        [DataMember(Name="risk", EmitDefaultValue=true)]
        public int Risk { get; set; }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name="details", EmitDefaultValue=true)]
        public AddressRiskReportDetails Details { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddressRiskReport {\n");
            sb.Append("  CaseId: ").Append(CaseId).Append("\n");
            sb.Append("  RequestDatetime: ").Append(RequestDatetime).Append("\n");
            sb.Append("  ResponseDatetime: ").Append(ResponseDatetime).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Chain: ").Append(Chain).Append("\n");
            sb.Append("  Risk: ").Append(Risk).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
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
            return this.Equals(input as AddressRiskReport);
        }

        /// <summary>
        /// Returns true if AddressRiskReport instances are equal
        /// </summary>
        /// <param name="input">Instance of AddressRiskReport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddressRiskReport input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CaseId == input.CaseId ||
                    (this.CaseId != null &&
                    this.CaseId.Equals(input.CaseId))
                ) && 
                (
                    this.RequestDatetime == input.RequestDatetime ||
                    (this.RequestDatetime != null &&
                    this.RequestDatetime.Equals(input.RequestDatetime))
                ) && 
                (
                    this.ResponseDatetime == input.ResponseDatetime ||
                    (this.ResponseDatetime != null &&
                    this.ResponseDatetime.Equals(input.ResponseDatetime))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Chain == input.Chain ||
                    (this.Chain != null &&
                    this.Chain.Equals(input.Chain))
                ) && 
                (
                    this.Risk == input.Risk ||
                    (this.Risk != null &&
                    this.Risk.Equals(input.Risk))
                ) && 
                (
                    this.Details == input.Details ||
                    (this.Details != null &&
                    this.Details.Equals(input.Details))
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
                if (this.CaseId != null)
                    hashCode = hashCode * 59 + this.CaseId.GetHashCode();
                if (this.RequestDatetime != null)
                    hashCode = hashCode * 59 + this.RequestDatetime.GetHashCode();
                if (this.ResponseDatetime != null)
                    hashCode = hashCode * 59 + this.ResponseDatetime.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Chain != null)
                    hashCode = hashCode * 59 + this.Chain.GetHashCode();
                if (this.Risk != null)
                    hashCode = hashCode * 59 + this.Risk.GetHashCode();
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
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
