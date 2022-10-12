/*
 * Blockmate
 *
 * Blockmate API OpenAPI documentation
 *
 * The version of the OpenAPI document: 0.0.1
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
    /// Account provider
    /// </summary>
    [DataContract]
    public partial class AccountProvider :  IEquatable<AccountProvider>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Wallet for value: crypto_wallet
            /// </summary>
            [EnumMember(Value = "crypto_wallet")]
            Wallet = 1,

            /// <summary>
            /// Enum Exchange for value: crypto_exchange
            /// </summary>
            [EnumMember(Value = "crypto_exchange")]
            Exchange = 2,

            /// <summary>
            /// Enum Nft for value: crypto_nft
            /// </summary>
            [EnumMember(Value = "crypto_nft")]
            Nft = 3

        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountProvider" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccountProvider() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountProvider" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="url">url (required).</param>
        public AccountProvider(string name = default(string), TypeEnum type = default(TypeEnum), string url = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for AccountProvider and cannot be null");
            }
            else
            {
                this.Name = name;
            }

            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for AccountProvider and cannot be null");
            }
            else
            {
                this.Type = type;
            }

            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new InvalidDataException("url is a required property for AccountProvider and cannot be null");
            }
            else
            {
                this.Url = url;
            }

        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }


        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue=true)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountProvider {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as AccountProvider);
        }

        /// <summary>
        /// Returns true if AccountProvider instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountProvider to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountProvider input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
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