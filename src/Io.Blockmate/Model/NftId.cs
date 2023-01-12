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
    /// NftId
    /// </summary>
    [DataContract]
    public partial class NftId :  IEquatable<NftId>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NftId" /> class.
        /// </summary>
        /// <param name="tokenId">String - The ID of the token. Can be in hex or decimal format..</param>
        /// <param name="tokenMetadata">tokenMetadata.</param>
        public NftId(string tokenId = default(string), NftIdTokenMetadata tokenMetadata = default(NftIdTokenMetadata))
        {
            this.TokenId = tokenId;
            this.TokenMetadata = tokenMetadata;
        }

        /// <summary>
        /// String - The ID of the token. Can be in hex or decimal format.
        /// </summary>
        /// <value>String - The ID of the token. Can be in hex or decimal format.</value>
        [DataMember(Name="tokenId", EmitDefaultValue=false)]
        public string TokenId { get; set; }

        /// <summary>
        /// Gets or Sets TokenMetadata
        /// </summary>
        [DataMember(Name="tokenMetadata", EmitDefaultValue=false)]
        public NftIdTokenMetadata TokenMetadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NftId {\n");
            sb.Append("  TokenId: ").Append(TokenId).Append("\n");
            sb.Append("  TokenMetadata: ").Append(TokenMetadata).Append("\n");
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
            return this.Equals(input as NftId);
        }

        /// <summary>
        /// Returns true if NftId instances are equal
        /// </summary>
        /// <param name="input">Instance of NftId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NftId input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TokenId == input.TokenId ||
                    (this.TokenId != null &&
                    this.TokenId.Equals(input.TokenId))
                ) && 
                (
                    this.TokenMetadata == input.TokenMetadata ||
                    (this.TokenMetadata != null &&
                    this.TokenMetadata.Equals(input.TokenMetadata))
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
                if (this.TokenId != null)
                    hashCode = hashCode * 59 + this.TokenId.GetHashCode();
                if (this.TokenMetadata != null)
                    hashCode = hashCode * 59 + this.TokenMetadata.GetHashCode();
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
