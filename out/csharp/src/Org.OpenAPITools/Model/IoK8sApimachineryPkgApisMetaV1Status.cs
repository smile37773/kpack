/* 
 * kpack
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v0.1.3
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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Status is a return value for calls that don&#39;t return other objects.
    /// </summary>
    [DataContract]
    public partial class IoK8sApimachineryPkgApisMetaV1Status :  IEquatable<IoK8sApimachineryPkgApisMetaV1Status>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoK8sApimachineryPkgApisMetaV1Status" /> class.
        /// </summary>
        /// <param name="apiVersion">APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources.</param>
        /// <param name="code">Suggested HTTP return code for this status, 0 if not set..</param>
        /// <param name="details">details.</param>
        /// <param name="kind">Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds.</param>
        /// <param name="message">A human-readable description of the status of this operation..</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="reason">A machine-readable description of why this operation is in the \&quot;Failure\&quot; status. If this value is empty there is no information available. A Reason clarifies an HTTP status code but does not override it..</param>
        /// <param name="status">Status of the operation. One of: \&quot;Success\&quot; or \&quot;Failure\&quot;. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status.</param>
        public IoK8sApimachineryPkgApisMetaV1Status(string apiVersion = default(string), int code = default(int), IoK8sApimachineryPkgApisMetaV1StatusDetails details = default(IoK8sApimachineryPkgApisMetaV1StatusDetails), string kind = default(string), string message = default(string), IoK8sApimachineryPkgApisMetaV1ListMeta metadata = default(IoK8sApimachineryPkgApisMetaV1ListMeta), string reason = default(string), string status = default(string))
        {
            this.ApiVersion = apiVersion;
            this.Code = code;
            this.Details = details;
            this.Kind = kind;
            this.Message = message;
            this.Metadata = metadata;
            this.Reason = reason;
            this.Status = status;
        }
        
        /// <summary>
        /// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources
        /// </summary>
        /// <value>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</value>
        [DataMember(Name="apiVersion", EmitDefaultValue=false)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Suggested HTTP return code for this status, 0 if not set.
        /// </summary>
        /// <value>Suggested HTTP return code for this status, 0 if not set.</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public int Code { get; set; }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public IoK8sApimachineryPkgApisMetaV1StatusDetails Details { get; set; }

        /// <summary>
        /// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds
        /// </summary>
        /// <value>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</value>
        [DataMember(Name="kind", EmitDefaultValue=false)]
        public string Kind { get; set; }

        /// <summary>
        /// A human-readable description of the status of this operation.
        /// </summary>
        /// <value>A human-readable description of the status of this operation.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public IoK8sApimachineryPkgApisMetaV1ListMeta Metadata { get; set; }

        /// <summary>
        /// A machine-readable description of why this operation is in the \&quot;Failure\&quot; status. If this value is empty there is no information available. A Reason clarifies an HTTP status code but does not override it.
        /// </summary>
        /// <value>A machine-readable description of why this operation is in the \&quot;Failure\&quot; status. If this value is empty there is no information available. A Reason clarifies an HTTP status code but does not override it.</value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }

        /// <summary>
        /// Status of the operation. One of: \&quot;Success\&quot; or \&quot;Failure\&quot;. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status
        /// </summary>
        /// <value>Status of the operation. One of: \&quot;Success\&quot; or \&quot;Failure\&quot;. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IoK8sApimachineryPkgApisMetaV1Status {\n");
            sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  Kind: ").Append(Kind).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as IoK8sApimachineryPkgApisMetaV1Status);
        }

        /// <summary>
        /// Returns true if IoK8sApimachineryPkgApisMetaV1Status instances are equal
        /// </summary>
        /// <param name="input">Instance of IoK8sApimachineryPkgApisMetaV1Status to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IoK8sApimachineryPkgApisMetaV1Status input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApiVersion == input.ApiVersion ||
                    (this.ApiVersion != null &&
                    this.ApiVersion.Equals(input.ApiVersion))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Details == input.Details ||
                    (this.Details != null &&
                    this.Details.Equals(input.Details))
                ) && 
                (
                    this.Kind == input.Kind ||
                    (this.Kind != null &&
                    this.Kind.Equals(input.Kind))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.ApiVersion != null)
                    hashCode = hashCode * 59 + this.ApiVersion.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                if (this.Kind != null)
                    hashCode = hashCode * 59 + this.Kind.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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
