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
    /// Selects a key from a ConfigMap.
    /// </summary>
    [DataContract]
    public partial class IoK8sApiCoreV1ConfigMapKeySelector :  IEquatable<IoK8sApiCoreV1ConfigMapKeySelector>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoK8sApiCoreV1ConfigMapKeySelector" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IoK8sApiCoreV1ConfigMapKeySelector() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IoK8sApiCoreV1ConfigMapKeySelector" /> class.
        /// </summary>
        /// <param name="key">The key to select. (required).</param>
        /// <param name="name">Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names.</param>
        /// <param name="optional">Specify whether the ConfigMap or it&#39;s key must be defined.</param>
        public IoK8sApiCoreV1ConfigMapKeySelector(string key = default(string), string name = default(string), bool optional = default(bool))
        {
            // to ensure "key" is required (not null)
            if (key == null)
            {
                throw new InvalidDataException("key is a required property for IoK8sApiCoreV1ConfigMapKeySelector and cannot be null");
            }
            else
            {
                this.Key = key;
            }
            
            this.Name = name;
            this.Optional = optional;
        }
        
        /// <summary>
        /// The key to select.
        /// </summary>
        /// <value>The key to select.</value>
        [DataMember(Name="key", EmitDefaultValue=true)]
        public string Key { get; set; }

        /// <summary>
        /// Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
        /// </summary>
        /// <value>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Specify whether the ConfigMap or it&#39;s key must be defined
        /// </summary>
        /// <value>Specify whether the ConfigMap or it&#39;s key must be defined</value>
        [DataMember(Name="optional", EmitDefaultValue=false)]
        public bool Optional { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IoK8sApiCoreV1ConfigMapKeySelector {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Optional: ").Append(Optional).Append("\n");
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
            return this.Equals(input as IoK8sApiCoreV1ConfigMapKeySelector);
        }

        /// <summary>
        /// Returns true if IoK8sApiCoreV1ConfigMapKeySelector instances are equal
        /// </summary>
        /// <param name="input">Instance of IoK8sApiCoreV1ConfigMapKeySelector to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IoK8sApiCoreV1ConfigMapKeySelector input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Optional == input.Optional ||
                    (this.Optional != null &&
                    this.Optional.Equals(input.Optional))
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
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Optional != null)
                    hashCode = hashCode * 59 + this.Optional.GetHashCode();
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