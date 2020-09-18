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
    /// An catchpoint start response.
    /// </summary>
    [DataContract]
    public partial class CatchpointStartResponse :  IEquatable<CatchpointStartResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CatchpointStartResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CatchpointStartResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CatchpointStartResponse" /> class.
        /// </summary>
        /// <param name="catchupMessage">Catchup start response string (required).</param>
        public CatchpointStartResponse(string catchupMessage = default(string))
        {
            // to ensure "catchupMessage" is required (not null)
            if (catchupMessage == null)
            {
                throw new InvalidDataException("catchupMessage is a required property for InlineResponse2008 and cannot be null");
            }
            else
            {
                this.CatchupMessage = catchupMessage;
            }
        }
        
        /// <summary>
        /// Catchup start response string
        /// </summary>
        /// <value>Catchup start response string</value>
        [DataMember(Name="catchup-message", EmitDefaultValue=false)]
        public string CatchupMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2008 {\n");
            sb.Append("  CatchupMessage: ").Append(CatchupMessage).Append("\n");
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
            return this.Equals(input as CatchpointStartResponse);
        }

        /// <summary>
        /// Returns true if InlineResponse2008 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse2008 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CatchpointStartResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CatchupMessage == input.CatchupMessage ||
                    (this.CatchupMessage != null &&
                    this.CatchupMessage.Equals(input.CatchupMessage))
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
                if (this.CatchupMessage != null)
                    hashCode = hashCode * 59 + this.CatchupMessage.GetHashCode();
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