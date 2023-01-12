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
    /// NftIdTokenMetadata
    /// </summary>
    [DataContract]
    public partial class NftIdTokenMetadata :  IEquatable<NftIdTokenMetadata>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NftIdTokenMetadata" /> class.
        /// </summary>
        /// <param name="tokenType">String - &#39;ERC721&#39; or &#39;ERC1155&#39;.</param>
        public NftIdTokenMetadata(string tokenType = default(string))
        {
            this.TokenType = tokenType;
        }

        /// <summary>
        /// String - &#39;ERC721&#39; or &#39;ERC1155&#39;
        /// </summary>
        /// <value>String - &#39;ERC721&#39; or &#39;ERC1155&#39;</value>
        [DataMember(Name="tokenType", EmitDefaultValue=false)]
        public string TokenType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NftIdTokenMetadata {\n");
            sb.Append("  TokenType: ").Append(TokenType).Append("\n");
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
            return this.Equals(input as NftIdTokenMetadata);
        }

        /// <summary>
        /// Returns true if NftIdTokenMetadata instances are equal
        /// </summary>
        /// <param name="input">Instance of NftIdTokenMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NftIdTokenMetadata input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TokenType == input.TokenType ||
                    (this.TokenType != null &&
                    this.TokenType.Equals(input.TokenType))
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
                if (this.TokenType != null)
                    hashCode = hashCode * 59 + this.TokenType.GetHashCode();
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
