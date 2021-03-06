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
    /// EnvVarSource represents a source for the value of an EnvVar.
    /// </summary>
    [DataContract]
    public partial class IoK8sApiCoreV1EnvVarSource :  IEquatable<IoK8sApiCoreV1EnvVarSource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoK8sApiCoreV1EnvVarSource" /> class.
        /// </summary>
        /// <param name="configMapKeyRef">configMapKeyRef.</param>
        /// <param name="fieldRef">fieldRef.</param>
        /// <param name="resourceFieldRef">resourceFieldRef.</param>
        /// <param name="secretKeyRef">secretKeyRef.</param>
        public IoK8sApiCoreV1EnvVarSource(IoK8sApiCoreV1ConfigMapKeySelector configMapKeyRef = default(IoK8sApiCoreV1ConfigMapKeySelector), IoK8sApiCoreV1ObjectFieldSelector fieldRef = default(IoK8sApiCoreV1ObjectFieldSelector), IoK8sApiCoreV1ResourceFieldSelector resourceFieldRef = default(IoK8sApiCoreV1ResourceFieldSelector), IoK8sApiCoreV1SecretKeySelector secretKeyRef = default(IoK8sApiCoreV1SecretKeySelector))
        {
            this.ConfigMapKeyRef = configMapKeyRef;
            this.FieldRef = fieldRef;
            this.ResourceFieldRef = resourceFieldRef;
            this.SecretKeyRef = secretKeyRef;
        }
        
        /// <summary>
        /// Gets or Sets ConfigMapKeyRef
        /// </summary>
        [DataMember(Name="configMapKeyRef", EmitDefaultValue=false)]
        public IoK8sApiCoreV1ConfigMapKeySelector ConfigMapKeyRef { get; set; }

        /// <summary>
        /// Gets or Sets FieldRef
        /// </summary>
        [DataMember(Name="fieldRef", EmitDefaultValue=false)]
        public IoK8sApiCoreV1ObjectFieldSelector FieldRef { get; set; }

        /// <summary>
        /// Gets or Sets ResourceFieldRef
        /// </summary>
        [DataMember(Name="resourceFieldRef", EmitDefaultValue=false)]
        public IoK8sApiCoreV1ResourceFieldSelector ResourceFieldRef { get; set; }

        /// <summary>
        /// Gets or Sets SecretKeyRef
        /// </summary>
        [DataMember(Name="secretKeyRef", EmitDefaultValue=false)]
        public IoK8sApiCoreV1SecretKeySelector SecretKeyRef { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IoK8sApiCoreV1EnvVarSource {\n");
            sb.Append("  ConfigMapKeyRef: ").Append(ConfigMapKeyRef).Append("\n");
            sb.Append("  FieldRef: ").Append(FieldRef).Append("\n");
            sb.Append("  ResourceFieldRef: ").Append(ResourceFieldRef).Append("\n");
            sb.Append("  SecretKeyRef: ").Append(SecretKeyRef).Append("\n");
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
            return this.Equals(input as IoK8sApiCoreV1EnvVarSource);
        }

        /// <summary>
        /// Returns true if IoK8sApiCoreV1EnvVarSource instances are equal
        /// </summary>
        /// <param name="input">Instance of IoK8sApiCoreV1EnvVarSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IoK8sApiCoreV1EnvVarSource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConfigMapKeyRef == input.ConfigMapKeyRef ||
                    (this.ConfigMapKeyRef != null &&
                    this.ConfigMapKeyRef.Equals(input.ConfigMapKeyRef))
                ) && 
                (
                    this.FieldRef == input.FieldRef ||
                    (this.FieldRef != null &&
                    this.FieldRef.Equals(input.FieldRef))
                ) && 
                (
                    this.ResourceFieldRef == input.ResourceFieldRef ||
                    (this.ResourceFieldRef != null &&
                    this.ResourceFieldRef.Equals(input.ResourceFieldRef))
                ) && 
                (
                    this.SecretKeyRef == input.SecretKeyRef ||
                    (this.SecretKeyRef != null &&
                    this.SecretKeyRef.Equals(input.SecretKeyRef))
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
                if (this.ConfigMapKeyRef != null)
                    hashCode = hashCode * 59 + this.ConfigMapKeyRef.GetHashCode();
                if (this.FieldRef != null)
                    hashCode = hashCode * 59 + this.FieldRef.GetHashCode();
                if (this.ResourceFieldRef != null)
                    hashCode = hashCode * 59 + this.ResourceFieldRef.GetHashCode();
                if (this.SecretKeyRef != null)
                    hashCode = hashCode * 59 + this.SecretKeyRef.GetHashCode();
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
