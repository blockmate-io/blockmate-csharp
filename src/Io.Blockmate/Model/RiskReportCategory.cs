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
    /// RiskReportCategory
    /// </summary>
    [DataContract]
    public partial class RiskReportCategory :  IEquatable<RiskReportCategory>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RiskReportCategory" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RiskReportCategory() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RiskReportCategory" /> class.
        /// </summary>
        /// <param name="adress">adress.</param>
        /// <param name="name">name (required).</param>
        /// <param name="categoryName">categoryName (required).</param>
        /// <param name="risk">risk (required).</param>
        public RiskReportCategory(string adress = default(string), string name = default(string), string categoryName = default(string), int risk = default(int))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for RiskReportCategory and cannot be null");
            }
            else
            {
                this.Name = name;
            }

            // to ensure "categoryName" is required (not null)
            if (categoryName == null)
            {
                throw new InvalidDataException("categoryName is a required property for RiskReportCategory and cannot be null");
            }
            else
            {
                this.CategoryName = categoryName;
            }

            // to ensure "risk" is required (not null)
            if (risk == null)
            {
                throw new InvalidDataException("risk is a required property for RiskReportCategory and cannot be null");
            }
            else
            {
                this.Risk = risk;
            }

            this.Adress = adress;
        }

        /// <summary>
        /// Gets or Sets Adress
        /// </summary>
        [DataMember(Name="adress", EmitDefaultValue=false)]
        public string Adress { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets CategoryName
        /// </summary>
        [DataMember(Name="category_name", EmitDefaultValue=true)]
        public string CategoryName { get; set; }

        /// <summary>
        /// Gets or Sets Risk
        /// </summary>
        [DataMember(Name="risk", EmitDefaultValue=true)]
        public int Risk { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RiskReportCategory {\n");
            sb.Append("  Adress: ").Append(Adress).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CategoryName: ").Append(CategoryName).Append("\n");
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
            return this.Equals(input as RiskReportCategory);
        }

        /// <summary>
        /// Returns true if RiskReportCategory instances are equal
        /// </summary>
        /// <param name="input">Instance of RiskReportCategory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RiskReportCategory input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Adress == input.Adress ||
                    (this.Adress != null &&
                    this.Adress.Equals(input.Adress))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.CategoryName == input.CategoryName ||
                    (this.CategoryName != null &&
                    this.CategoryName.Equals(input.CategoryName))
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
                if (this.Adress != null)
                    hashCode = hashCode * 59 + this.Adress.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.CategoryName != null)
                    hashCode = hashCode * 59 + this.CategoryName.GetHashCode();
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
