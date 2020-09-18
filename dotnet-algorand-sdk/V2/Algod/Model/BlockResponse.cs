/* 
 * Algod REST API.
 *
 * API endpoint for algod operations.
 *
 * OpenAPI spec version: 0.0.1
 * Contact: contact@algorand.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = Algorand.V2.Algod.Client.SwaggerDateConverter;

namespace Algorand.V2.Algod.Model
{
    /// <summary>
    /// BlockResponse
    /// </summary>
    [DataContract]
    public partial class BlockResponse :  IEquatable<BlockResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BlockResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BlockResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BlockResponse" /> class.
        /// </summary>
        /// <param name="block">Block header data. (required).</param>
        /// <param name="cert">Optional certificate object. This is only included when the format is set to message pack..</param>
        public BlockResponse(Object block = default(Object), Object cert = default(Object))
        {
            // to ensure "block" is required (not null)
            if (block == null)
            {
                throw new InvalidDataException("block is a required property for BlockResponse and cannot be null");
            }
            else
            {
                this.Block = block;
            }
            this.Cert = cert;
        }
        
        /// <summary>
        /// Block header data.
        /// </summary>
        /// <value>Block header data.</value>
        [DataMember(Name="block", EmitDefaultValue=false)]
        public Object Block { get; set; }

        /// <summary>
        /// Optional certificate object. This is only included when the format is set to message pack.
        /// </summary>
        /// <value>Optional certificate object. This is only included when the format is set to message pack.</value>
        [DataMember(Name="cert", EmitDefaultValue=false)]
        public Object Cert { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BlockResponse {\n");
            sb.Append("  Block: ").Append(Block).Append("\n");
            sb.Append("  Cert: ").Append(Cert).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as BlockResponse);
        }

        /// <summary>
        /// Returns true if BlockResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of BlockResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BlockResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Block == input.Block ||
                    (this.Block != null &&
                    this.Block.Equals(input.Block))
                ) && 
                (
                    this.Cert == input.Cert ||
                    (this.Cert != null &&
                    this.Cert.Equals(input.Cert))
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
                if (this.Block != null)
                    hashCode = hashCode * 59 + this.Block.GetHashCode();
                if (this.Cert != null)
                    hashCode = hashCode * 59 + this.Cert.GetHashCode();
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
