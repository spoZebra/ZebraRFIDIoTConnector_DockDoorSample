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
    /// Reader network information
    /// </summary>
    [DataContract]
    public partial class GetNetworkResponse : IEquatable<GetNetworkResponse>
    { 
        /// <summary>
        /// Host name of the reader
        /// </summary>
        /// <value>Host name of the reader</value>
        [Required]

        [DataMember(Name="hostName")]
        public string HostName { get; set; }

        /// <summary>
        /// IP address of the reader
        /// </summary>
        /// <value>IP address of the reader</value>
        [Required]

        [DataMember(Name="ipAddress")]
        public string IpAddress { get; set; }

        /// <summary>
        /// IP address of the gateway
        /// </summary>
        /// <value>IP address of the gateway</value>
        [Required]

        [DataMember(Name="gatewayAddress")]
        public string GatewayAddress { get; set; }

        /// <summary>
        /// Subnet mask for the network adapter
        /// </summary>
        /// <value>Subnet mask for the network adapter</value>
        [Required]

        [DataMember(Name="subnetMask")]
        public string SubnetMask { get; set; }

        /// <summary>
        /// IP address of the DNS server
        /// </summary>
        /// <value>IP address of the DNS server</value>
        [Required]

        [DataMember(Name="dnsAddress")]
        public string DnsAddress { get; set; }

        /// <summary>
        /// A value indicating DHCP configuration
        /// </summary>
        /// <value>A value indicating DHCP configuration</value>
        [Required]

        [DataMember(Name="dhcp")]
        public bool? Dhcp { get; set; }

        /// <summary>
        /// MAC address of the reader
        /// </summary>
        /// <value>MAC address of the reader</value>
        [Required]

        [DataMember(Name="macAddress")]
        public string MacAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetNetworkResponse {\n");
            sb.Append("  HostName: ").Append(HostName).Append("\n");
            sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  GatewayAddress: ").Append(GatewayAddress).Append("\n");
            sb.Append("  SubnetMask: ").Append(SubnetMask).Append("\n");
            sb.Append("  DnsAddress: ").Append(DnsAddress).Append("\n");
            sb.Append("  Dhcp: ").Append(Dhcp).Append("\n");
            sb.Append("  MacAddress: ").Append(MacAddress).Append("\n");
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
            return obj.GetType() == GetType() && Equals((GetNetworkResponse)obj);
        }

        /// <summary>
        /// Returns true if GetNetworkResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of GetNetworkResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetNetworkResponse other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    HostName == other.HostName ||
                    HostName != null &&
                    HostName.Equals(other.HostName)
                ) && 
                (
                    IpAddress == other.IpAddress ||
                    IpAddress != null &&
                    IpAddress.Equals(other.IpAddress)
                ) && 
                (
                    GatewayAddress == other.GatewayAddress ||
                    GatewayAddress != null &&
                    GatewayAddress.Equals(other.GatewayAddress)
                ) && 
                (
                    SubnetMask == other.SubnetMask ||
                    SubnetMask != null &&
                    SubnetMask.Equals(other.SubnetMask)
                ) && 
                (
                    DnsAddress == other.DnsAddress ||
                    DnsAddress != null &&
                    DnsAddress.Equals(other.DnsAddress)
                ) && 
                (
                    Dhcp == other.Dhcp ||
                    Dhcp != null &&
                    Dhcp.Equals(other.Dhcp)
                ) && 
                (
                    MacAddress == other.MacAddress ||
                    MacAddress != null &&
                    MacAddress.Equals(other.MacAddress)
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
                    if (HostName != null)
                    hashCode = hashCode * 59 + HostName.GetHashCode();
                    if (IpAddress != null)
                    hashCode = hashCode * 59 + IpAddress.GetHashCode();
                    if (GatewayAddress != null)
                    hashCode = hashCode * 59 + GatewayAddress.GetHashCode();
                    if (SubnetMask != null)
                    hashCode = hashCode * 59 + SubnetMask.GetHashCode();
                    if (DnsAddress != null)
                    hashCode = hashCode * 59 + DnsAddress.GetHashCode();
                    if (Dhcp != null)
                    hashCode = hashCode * 59 + Dhcp.GetHashCode();
                    if (MacAddress != null)
                    hashCode = hashCode * 59 + MacAddress.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(GetNetworkResponse left, GetNetworkResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(GetNetworkResponse left, GetNetworkResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
