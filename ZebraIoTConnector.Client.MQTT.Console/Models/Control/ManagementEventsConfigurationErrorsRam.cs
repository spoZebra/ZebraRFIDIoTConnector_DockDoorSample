/*
 * RAW MQTT Payloads
 *
 *  
 *
 * OpenAPI spec version: 1.0.0
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
    /// RAM Usage Error Alerts
    /// </summary>
    [DataContract]
    public partial class ManagementEventsConfigurationErrorsRam : IEquatable<ManagementEventsConfigurationErrorsRam>
    { 
        /// <summary>
        /// Error RAM usage limit
        /// </summary>
        /// <value>Error RAM usage limit</value>
        [Required]

        [Range(1, 99)]
        [DataMember(Name="threshold")]
        public decimal? Threshold { get; set; }

        /// <summary>
        /// Error Report Interval in seconds.
        /// </summary>
        /// <value>Error Report Interval in seconds.</value>

        [DataMember(Name="reportIntervalInSec")]
        public decimal? ReportIntervalInSec { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ManagementEventsConfigurationErrorsRam {\n");
            sb.Append("  Threshold: ").Append(Threshold).Append("\n");
            sb.Append("  ReportIntervalInSec: ").Append(ReportIntervalInSec).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ManagementEventsConfigurationErrorsRam)obj);
        }

        /// <summary>
        /// Returns true if ManagementEventsConfigurationErrorsRam instances are equal
        /// </summary>
        /// <param name="other">Instance of ManagementEventsConfigurationErrorsRam to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ManagementEventsConfigurationErrorsRam other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Threshold == other.Threshold ||
                    Threshold != null &&
                    Threshold.Equals(other.Threshold)
                ) && 
                (
                    ReportIntervalInSec == other.ReportIntervalInSec ||
                    ReportIntervalInSec != null &&
                    ReportIntervalInSec.Equals(other.ReportIntervalInSec)
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
                    if (Threshold != null)
                    hashCode = hashCode * 59 + Threshold.GetHashCode();
                    if (ReportIntervalInSec != null)
                    hashCode = hashCode * 59 + ReportIntervalInSec.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ManagementEventsConfigurationErrorsRam left, ManagementEventsConfigurationErrorsRam right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ManagementEventsConfigurationErrorsRam left, ManagementEventsConfigurationErrorsRam right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
