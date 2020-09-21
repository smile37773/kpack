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
    /// KpackBuildV1alpha1SourceResolverStatus
    /// </summary>
    [DataContract]
    public partial class KpackBuildV1alpha1SourceResolverStatus :  IEquatable<KpackBuildV1alpha1SourceResolverStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KpackBuildV1alpha1SourceResolverStatus" /> class.
        /// </summary>
        /// <param name="conditions">Conditions the latest available observations of a resource&#39;s current state..</param>
        /// <param name="observedGeneration">ObservedGeneration is the &#39;Generation&#39; of the Service that was last processed by the controller..</param>
        /// <param name="source">source.</param>
        public KpackBuildV1alpha1SourceResolverStatus(List<KpackCoreV1alpha1Condition> conditions = default(List<KpackCoreV1alpha1Condition>), long observedGeneration = default(long), KpackBuildV1alpha1ResolvedSourceConfig source = default(KpackBuildV1alpha1ResolvedSourceConfig))
        {
            this.Conditions = conditions;
            this.ObservedGeneration = observedGeneration;
            this.Source = source;
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
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public KpackBuildV1alpha1ResolvedSourceConfig Source { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KpackBuildV1alpha1SourceResolverStatus {\n");
            sb.Append("  Conditions: ").Append(Conditions).Append("\n");
            sb.Append("  ObservedGeneration: ").Append(ObservedGeneration).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
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
            return this.Equals(input as KpackBuildV1alpha1SourceResolverStatus);
        }

        /// <summary>
        /// Returns true if KpackBuildV1alpha1SourceResolverStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of KpackBuildV1alpha1SourceResolverStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KpackBuildV1alpha1SourceResolverStatus input)
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
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
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
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
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
