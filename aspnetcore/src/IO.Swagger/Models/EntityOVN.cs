/*
 * UTM DSS/USS API
 *
 * Interface to Discovery and Synchronization Service (DSS) and UAS Service Suppliers (USS) used by participating clients to discover and interoperate.  Unless otherwise specified, fields specified in a message but not declared in the API shall be ignored.
 *
 * OpenAPI spec version: 1.0.0-oas3
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// A token associated with a particular UTM Entity+version created by the DSS upon creation or modification of an Entity reference and provided to the client creating or modifying the Entity reference.  The EntityOVN is stored privately by the DSS and then compared against entries in a Key provided to mutate the airspace.  The EntityOVN is also provided by the client whenever that client transmits the full information of the Entity (either via GET, or via a subscription notification).
    /// </summary>
    [DataContract]
    public partial class EntityOVN : IEquatable<EntityOVN>
    { 
        /// <summary>
        /// This version increases each time an Entity is modified.  If a client ever receives a subscription update with an EntityOVN for a particular EntityUUID that is smaller than the cached EntityOVN for that EntityUUID, that subscription update should be ignored.
        /// </summary>
        /// <value>This version increases each time an Entity is modified.  If a client ever receives a subscription update with an EntityOVN for a particular EntityUUID that is smaller than the cached EntityOVN for that EntityUUID, that subscription update should be ignored.</value>
        [Required]
        [DataMember(Name="version")]
        public int? Version { get; set; }

        /// <summary>
        /// Unique value associated with a specific version of a specific Entity.  Token value may not be reused for any other Entity versions; it must change each time the Entity changes.
        /// </summary>
        /// <value>Unique value associated with a specific version of a specific Entity.  Token value may not be reused for any other Entity versions; it must change each time the Entity changes.</value>
        [Required]
        [DataMember(Name="token")]
        public AnyOfEntityOVNToken Token { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EntityOVN {\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((EntityOVN)obj);
        }

        /// <summary>
        /// Returns true if EntityOVN instances are equal
        /// </summary>
        /// <param name="other">Instance of EntityOVN to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EntityOVN other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Version == other.Version ||
                    Version != null &&
                    Version.Equals(other.Version)
                ) && 
                (
                    Token == other.Token ||
                    Token != null &&
                    Token.SequenceEqual(other.Token)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Version != null)
                    hashCode = hashCode * 59 + Version.GetHashCode();
                    if (Token != null)
                    hashCode = hashCode * 59 + Token.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(EntityOVN left, EntityOVN right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(EntityOVN left, EntityOVN right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}