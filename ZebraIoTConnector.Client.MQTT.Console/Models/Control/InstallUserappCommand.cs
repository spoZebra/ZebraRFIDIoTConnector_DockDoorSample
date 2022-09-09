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
    /// Install userapp debian package
    /// </summary>
    [DataContract]
    public partial class InstallUserappCommand : IEquatable<InstallUserappCommand>
    { 
        /// <summary>
        /// http or https file server url
        /// </summary>
        /// <value>http or https file server url</value>
        [Required]

        [DataMember(Name="url")]
        public string Url { get; set; }

        /// <summary>
        /// userapp filename in file server
        /// </summary>
        /// <value>userapp filename in file server</value>
        [Required]

        [DataMember(Name="filename")]
        public string Filename { get; set; }

        /// <summary>
        /// file server authentication type
        /// </summary>
        /// <value>file server authentication type</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum AuthenticationTypeEnum
        {
            /// <summary>
            /// Enum NONEEnum for NONE
            /// </summary>
            [EnumMember(Value = "NONE")]
            NONEEnum = 0,
            /// <summary>
            /// Enum BASICEnum for BASIC
            /// </summary>
            [EnumMember(Value = "BASIC")]
            BASICEnum = 1        }

        /// <summary>
        /// file server authentication type
        /// </summary>
        /// <value>file server authentication type</value>
        [Required]

        [DataMember(Name="authenticationType")]
        public AuthenticationTypeEnum? AuthenticationType { get; set; }

        /// <summary>
        /// Gets or Sets Options
        /// </summary>

        [DataMember(Name="options")]
        public InstallUserappCommandOptions Options { get; set; }

        /// <summary>
        /// verify file server certificate
        /// </summary>
        /// <value>verify file server certificate</value>

        [DataMember(Name="verifyPeer")]
        public bool? VerifyPeer { get; set; }

        /// <summary>
        /// verify file server hostname
        /// </summary>
        /// <value>verify file server hostname</value>

        [DataMember(Name="verifyHost")]
        public bool? VerifyHost { get; set; }

        /// <summary>
        /// CA file location to be used for server authentication
        /// </summary>
        /// <value>CA file location to be used for server authentication</value>

        [DataMember(Name="CACertificateFileLocation")]
        public string CACertificateFileLocation { get; set; }

        /// <summary>
        /// CA certificate file content to be used for server authentication
        /// </summary>
        /// <value>CA certificate file content to be used for server authentication</value>

        [DataMember(Name="CACertificateFileContent")]
        public string CACertificateFileContent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstallUserappCommand {\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Filename: ").Append(Filename).Append("\n");
            sb.Append("  AuthenticationType: ").Append(AuthenticationType).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  VerifyPeer: ").Append(VerifyPeer).Append("\n");
            sb.Append("  VerifyHost: ").Append(VerifyHost).Append("\n");
            sb.Append("  CACertificateFileLocation: ").Append(CACertificateFileLocation).Append("\n");
            sb.Append("  CACertificateFileContent: ").Append(CACertificateFileContent).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InstallUserappCommand)obj);
        }

        /// <summary>
        /// Returns true if InstallUserappCommand instances are equal
        /// </summary>
        /// <param name="other">Instance of InstallUserappCommand to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstallUserappCommand other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Url == other.Url ||
                    Url != null &&
                    Url.Equals(other.Url)
                ) && 
                (
                    Filename == other.Filename ||
                    Filename != null &&
                    Filename.Equals(other.Filename)
                ) && 
                (
                    AuthenticationType == other.AuthenticationType ||
                    AuthenticationType != null &&
                    AuthenticationType.Equals(other.AuthenticationType)
                ) && 
                (
                    Options == other.Options ||
                    Options != null &&
                    Options.Equals(other.Options)
                ) && 
                (
                    VerifyPeer == other.VerifyPeer ||
                    VerifyPeer != null &&
                    VerifyPeer.Equals(other.VerifyPeer)
                ) && 
                (
                    VerifyHost == other.VerifyHost ||
                    VerifyHost != null &&
                    VerifyHost.Equals(other.VerifyHost)
                ) && 
                (
                    CACertificateFileLocation == other.CACertificateFileLocation ||
                    CACertificateFileLocation != null &&
                    CACertificateFileLocation.Equals(other.CACertificateFileLocation)
                ) && 
                (
                    CACertificateFileContent == other.CACertificateFileContent ||
                    CACertificateFileContent != null &&
                    CACertificateFileContent.Equals(other.CACertificateFileContent)
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
                    if (Url != null)
                    hashCode = hashCode * 59 + Url.GetHashCode();
                    if (Filename != null)
                    hashCode = hashCode * 59 + Filename.GetHashCode();
                    if (AuthenticationType != null)
                    hashCode = hashCode * 59 + AuthenticationType.GetHashCode();
                    if (Options != null)
                    hashCode = hashCode * 59 + Options.GetHashCode();
                    if (VerifyPeer != null)
                    hashCode = hashCode * 59 + VerifyPeer.GetHashCode();
                    if (VerifyHost != null)
                    hashCode = hashCode * 59 + VerifyHost.GetHashCode();
                    if (CACertificateFileLocation != null)
                    hashCode = hashCode * 59 + CACertificateFileLocation.GetHashCode();
                    if (CACertificateFileContent != null)
                    hashCode = hashCode * 59 + CACertificateFileContent.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InstallUserappCommand left, InstallUserappCommand right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InstallUserappCommand left, InstallUserappCommand right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
