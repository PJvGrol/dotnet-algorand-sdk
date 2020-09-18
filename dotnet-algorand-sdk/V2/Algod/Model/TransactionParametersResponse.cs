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
    /// TransactionParams contains the parameters that help a client construct a new transaction.
    /// </summary>
    [DataContract]
    public partial class TransactionParametersResponse :  IEquatable<TransactionParametersResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionParametersResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionParametersResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionParametersResponse" /> class.
        /// </summary>
        /// <param name="consensusVersion">ConsensusVersion indicates the consensus protocol version as of LastRound. (required).</param>
        /// <param name="fee">Fee is the suggested transaction fee Fee is in units of micro-Algos per byte. Fee may fall to zero but transactions must still have a fee of at least MinTxnFee for the current network protocol. (required).</param>
        /// <param name="genesisHash">GenesisHash is the hash of the genesis block. (required).</param>
        /// <param name="genesisId">GenesisID is an ID listed in the genesis block. (required).</param>
        /// <param name="lastRound">LastRound indicates the last round seen (required).</param>
        /// <param name="minFee">The minimum transaction fee (not per byte) required for the txn to validate for the current network protocol. (required).</param>
        public TransactionParametersResponse(string consensusVersion = default(string), long? fee = default, byte[] genesisHash = default(byte[]), string genesisId = default(string), long? lastRound = default, long? minFee = default)
        {
            // to ensure "consensusVersion" is required (not null)
            if (consensusVersion == null)
            {
                throw new InvalidDataException("consensusVersion is a required property for TransactionParametersResponse and cannot be null");
            }
            else
            {
                this.ConsensusVersion = consensusVersion;
            }
            // to ensure "fee" is required (not null)
            if (fee == null)
            {
                throw new InvalidDataException("fee is a required property for TransactionParametersResponse and cannot be null");
            }
            else
            {
                this.Fee = fee;
            }
            // to ensure "genesisHash" is required (not null)
            if (genesisHash == null)
            {
                throw new InvalidDataException("genesisHash is a required property for TransactionParametersResponse and cannot be null");
            }
            else
            {
                this.GenesisHash = genesisHash;
            }
            // to ensure "genesisId" is required (not null)
            if (genesisId == null)
            {
                throw new InvalidDataException("genesisId is a required property for TransactionParametersResponse and cannot be null");
            }
            else
            {
                this.GenesisId = genesisId;
            }
            // to ensure "lastRound" is required (not null)
            if (lastRound == null)
            {
                throw new InvalidDataException("lastRound is a required property for TransactionParametersResponse and cannot be null");
            }
            else
            {
                this.LastRound = lastRound;
            }
            // to ensure "minFee" is required (not null)
            if (minFee == null)
            {
                throw new InvalidDataException("minFee is a required property for TransactionParametersResponse and cannot be null");
            }
            else
            {
                this.MinFee = minFee;
            }
        }
        
        /// <summary>
        /// ConsensusVersion indicates the consensus protocol version as of LastRound.
        /// </summary>
        /// <value>ConsensusVersion indicates the consensus protocol version as of LastRound.</value>
        [DataMember(Name="consensus-version", EmitDefaultValue=false)]
        public string ConsensusVersion { get; set; }

        /// <summary>
        /// Fee is the suggested transaction fee Fee is in units of micro-Algos per byte. Fee may fall to zero but transactions must still have a fee of at least MinTxnFee for the current network protocol.
        /// </summary>
        /// <value>Fee is the suggested transaction fee Fee is in units of micro-Algos per byte. Fee may fall to zero but transactions must still have a fee of at least MinTxnFee for the current network protocol.</value>
        [DataMember(Name="fee", EmitDefaultValue=false)]
        public long? Fee { get; set; }

        /// <summary>
        /// GenesisHash is the hash of the genesis block.
        /// </summary>
        /// <value>GenesisHash is the hash of the genesis block.</value>
        [DataMember(Name="genesis-hash", EmitDefaultValue=false)]
        public byte[] GenesisHash { get; set; }

        /// <summary>
        /// GenesisID is an ID listed in the genesis block.
        /// </summary>
        /// <value>GenesisID is an ID listed in the genesis block.</value>
        [DataMember(Name="genesis-id", EmitDefaultValue=false)]
        public string GenesisId { get; set; }

        /// <summary>
        /// LastRound indicates the last round seen
        /// </summary>
        /// <value>LastRound indicates the last round seen</value>
        [DataMember(Name="last-round", EmitDefaultValue=false)]
        public long? LastRound { get; set; }

        /// <summary>
        /// The minimum transaction fee (not per byte) required for the txn to validate for the current network protocol.
        /// </summary>
        /// <value>The minimum transaction fee (not per byte) required for the txn to validate for the current network protocol.</value>
        [DataMember(Name="min-fee", EmitDefaultValue=false)]
        public long? MinFee { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionParametersResponse {\n");
            sb.Append("  ConsensusVersion: ").Append(ConsensusVersion).Append("\n");
            sb.Append("  Fee: ").Append(Fee).Append("\n");
            sb.Append("  GenesisHash: ").Append(GenesisHash).Append("\n");
            sb.Append("  GenesisId: ").Append(GenesisId).Append("\n");
            sb.Append("  LastRound: ").Append(LastRound).Append("\n");
            sb.Append("  MinFee: ").Append(MinFee).Append("\n");
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
            return this.Equals(input as TransactionParametersResponse);
        }

        /// <summary>
        /// Returns true if TransactionParametersResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionParametersResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionParametersResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConsensusVersion == input.ConsensusVersion ||
                    (this.ConsensusVersion != null &&
                    this.ConsensusVersion.Equals(input.ConsensusVersion))
                ) && 
                (
                    this.Fee == input.Fee ||
                    (this.Fee != null &&
                    this.Fee.Equals(input.Fee))
                ) && 
                (
                    this.GenesisHash == input.GenesisHash ||
                    (this.GenesisHash != null &&
                    this.GenesisHash.Equals(input.GenesisHash))
                ) && 
                (
                    this.GenesisId == input.GenesisId ||
                    (this.GenesisId != null &&
                    this.GenesisId.Equals(input.GenesisId))
                ) && 
                (
                    this.LastRound == input.LastRound ||
                    (this.LastRound != null &&
                    this.LastRound.Equals(input.LastRound))
                ) && 
                (
                    this.MinFee == input.MinFee ||
                    (this.MinFee != null &&
                    this.MinFee.Equals(input.MinFee))
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
                if (this.ConsensusVersion != null)
                    hashCode = hashCode * 59 + this.ConsensusVersion.GetHashCode();
                if (this.Fee != null)
                    hashCode = hashCode * 59 + this.Fee.GetHashCode();
                if (this.GenesisHash != null)
                    hashCode = hashCode * 59 + this.GenesisHash.GetHashCode();
                if (this.GenesisId != null)
                    hashCode = hashCode * 59 + this.GenesisId.GetHashCode();
                if (this.LastRound != null)
                    hashCode = hashCode * 59 + this.LastRound.GetHashCode();
                if (this.MinFee != null)
                    hashCode = hashCode * 59 + this.MinFee.GetHashCode();
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
