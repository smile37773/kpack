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
    /// KpackBuildV1alpha1ResolvedGitSource
    /// </summary>
    [DataContract]
    public partial class KpackBuildV1alpha1ResolvedGitSource :  IEquatable<KpackBuildV1alpha1ResolvedGitSource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KpackBuildV1alpha1ResolvedGitSource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KpackBuildV1alpha1ResolvedGitSource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KpackBuildV1alpha1ResolvedGitSource" /> class.
        /// </summary>
        /// <param name="revision">revision (required).</param>
        /// <param name="subPath">subPath.</param>
        /// <param name="type">type (required).</param>
        /// <param name="url">url (required).</param>
        public KpackBuildV1alpha1ResolvedGitSource(string revision = default(string), string subPath = default(string), string type = default(string), string url = default(string))
        {
            // to ensure "revision" is required (not null)
            if (revision == null)
            {
                throw new InvalidDataException("revision is a required property for KpackBuildV1alpha1ResolvedGitSource and cannot be null");
            }
            else
            {
                this.Revision = revision;
            }
            
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for KpackBuildV1alpha1ResolvedGitSource and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            
            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new InvalidDataException("url is a required property for KpackBuildV1alpha1ResolvedGitSource and cannot be null");
            }
            else
            {
                this.Url = url;
            }
            
            this.SubPath = subPath;
        }
        
        /// <summary>
        /// Gets or Sets Revision
        /// </summary>
        [DataMember(Name="revision", EmitDefaultValue=true)]
        public string Revision { get; set; }

        /// <summary>
        /// Gets or Sets SubPath
        /// </summary>
        [DataMember(Name="subPath", EmitDefaultValue=false)]
        public string SubPath { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue=true)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KpackBuildV1alpha1ResolvedGitSource {\n");
            sb.Append("  Revision: ").Append(Revision).Append("\n");
            sb.Append("  SubPath: ").Append(SubPath).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as KpackBuildV1alpha1ResolvedGitSource);
        }

        /// <summary>
        /// Returns true if KpackBuildV1alpha1ResolvedGitSource instances are equal
        /// </summary>
        /// <param name="input">Instance of KpackBuildV1alpha1ResolvedGitSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KpackBuildV1alpha1ResolvedGitSource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Revision == input.Revision ||
                    (this.Revision != null &&
                    this.Revision.Equals(input.Revision))
                ) && 
                (
                    this.SubPath == input.SubPath ||
                    (this.SubPath != null &&
                    this.SubPath.Equals(input.SubPath))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.Revision != null)
                    hashCode = hashCode * 59 + this.Revision.GetHashCode();
                if (this.SubPath != null)
                    hashCode = hashCode * 59 + this.SubPath.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
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
