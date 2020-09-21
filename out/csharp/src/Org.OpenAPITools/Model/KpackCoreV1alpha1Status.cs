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
    /// Status shows how we expect folks to embed Conditions in their Status field. WARNING: Adding fields to this struct will add them to all Knative resources.
    /// </summary>
    [DataContract]
    public partial class KpackCoreV1alpha1Status :  IEquatable<KpackCoreV1alpha1Status>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KpackCoreV1alpha1Status" /> class.
        /// </summary>
        /// <param name="conditions">Conditions the latest available observations of a resource&#39;s current state..</param>
        /// <param name="observedGeneration">ObservedGeneration is the &#39;Generation&#39; of the Service that was last processed by the controller..</param>
        public KpackCoreV1alpha1Status(List<KpackCoreV1alpha1Condition> conditions = default(List<KpackCoreV1alpha1Condition>), long observedGeneration = default(long))
        {
            this.Conditions = conditions;
            this.ObservedGeneration = observedGeneration;
        }
        
        /// <summary>
        /// Conditions the latest available observations of a resource&#39;s current state.
        /// </summary>
        /// <value>Conditions the latest available observations of a resource&#39;s current state.</value>
        [DataMember(Name="conditions", EmitDefaultValue=false)]
        public List<KpackCoreV1alpha1Condition> Conditions { get; set; }

        /// <summary>
        /// ObservedGeneration is the &#39;Generation&#39; of the Service that was last processed by the controller.
        /// </summary>
        /// <value>ObservedGeneration is the &#39;Generation&#39; of the Service that was last processed by the controller.</value>
        [DataMember(Name="observedGeneration", EmitDefaultValue=false)]
        public long ObservedGeneration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KpackCoreV1alpha1Status {\n");
            sb.Append("  Conditions: ").Append(Conditions).Append("\n");
            sb.Append("  ObservedGeneration: ").Append(ObservedGeneration).Append("\n");
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
            return this.Equals(input as KpackCoreV1alpha1Status);
        }

        /// <summary>
        /// Returns true if KpackCoreV1alpha1Status instances are equal
        /// </summary>
        /// <param name="input">Instance of KpackCoreV1alpha1Status to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KpackCoreV1alpha1Status input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Conditions == input.Conditions ||
                    this.Conditions != null &&
                    input.Conditions != null &&
                    this.Conditions.SequenceEqual(input.Conditions)
                ) && 
                (
                    this.ObservedGeneration == input.ObservedGeneration ||
                    (this.ObservedGeneration != null &&
                    this.ObservedGeneration.Equals(input.ObservedGeneration))
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
                if (this.Conditions != null)
                    hashCode = hashCode * 59 + this.Conditions.GetHashCode();
                if (this.ObservedGeneration != null)
                    hashCode = hashCode * 59 + this.ObservedGeneration.GetHashCode();
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
