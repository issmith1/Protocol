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
    /// Response to DSS request for the ConstraintReference with the given ID.
    /// </summary>
    [DataContract]
    public partial class GetConstraintReferenceResponse : IEquatable<GetConstraintReferenceResponse>
    { 
        /// <summary>
        /// Gets or Sets ConstraintReference
        /// </summary>
        [Required]
        [DataMember(Name="constraint_reference")]
        public ConstraintReference ConstraintReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetConstraintReferenceResponse {\n");
            sb.Append("  ConstraintReference: ").Append(ConstraintReference).Append("\n");
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
            return obj.GetType() == GetType() && Equals((GetConstraintReferenceResponse)obj);
        }

        /// <summary>
        /// Returns true if GetConstraintReferenceResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of GetConstraintReferenceResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetConstraintReferenceResponse other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ConstraintReference == other.ConstraintReference ||
                    ConstraintReference != null &&
                    ConstraintReference.Equals(other.ConstraintReference)
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
                    if (ConstraintReference != null)
                    hashCode = hashCode * 59 + ConstraintReference.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(GetConstraintReferenceResponse left, GetConstraintReferenceResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(GetConstraintReferenceResponse left, GetConstraintReferenceResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}