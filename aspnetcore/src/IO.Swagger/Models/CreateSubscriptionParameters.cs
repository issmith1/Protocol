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
    /// Parameters for a request to create a subscription in the DSS.
    /// </summary>
    [DataContract]
    public partial class CreateSubscriptionParameters : IEquatable<CreateSubscriptionParameters>
    { 
        /// <summary>
        /// The spacetime extents of the volume to subscribe to.  This subscription will automatically be deleted after its end time if it has not been refreshed by then.  If end time is not specified, the value will be chosen automatically by the DSS.  Note that some Entities triggering notifications may lie entirely outside the requested area.
        /// </summary>
        /// <value>The spacetime extents of the volume to subscribe to.  This subscription will automatically be deleted after its end time if it has not been refreshed by then.  If end time is not specified, the value will be chosen automatically by the DSS.  Note that some Entities triggering notifications may lie entirely outside the requested area.</value>
        [Required]
        [DataMember(Name="extents")]
        public AnyOfCreateSubscriptionParametersExtents Extents { get; set; }

        /// <summary>
        /// Gets or Sets Callbacks
        /// </summary>
        [Required]
        [DataMember(Name="callbacks")]
        public SubscriptionCallbacks Callbacks { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSubscriptionParameters {\n");
            sb.Append("  Extents: ").Append(Extents).Append("\n");
            sb.Append("  Callbacks: ").Append(Callbacks).Append("\n");
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
            return obj.GetType() == GetType() && Equals((CreateSubscriptionParameters)obj);
        }

        /// <summary>
        /// Returns true if CreateSubscriptionParameters instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateSubscriptionParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateSubscriptionParameters other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Extents == other.Extents ||
                    Extents != null &&
                    Extents.SequenceEqual(other.Extents)
                ) && 
                (
                    Callbacks == other.Callbacks ||
                    Callbacks != null &&
                    Callbacks.Equals(other.Callbacks)
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
                    if (Extents != null)
                    hashCode = hashCode * 59 + Extents.GetHashCode();
                    if (Callbacks != null)
                    hashCode = hashCode * 59 + Callbacks.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CreateSubscriptionParameters left, CreateSubscriptionParameters right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CreateSubscriptionParameters left, CreateSubscriptionParameters right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}