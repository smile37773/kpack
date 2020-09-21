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
    /// KpackBuildV1alpha1ClusterStoreStatus
    /// </summary>
    [DataContract]
    public partial class KpackBuildV1alpha1ClusterStoreStatus :  IEquatable<KpackBuildV1alpha1ClusterStoreStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KpackBuildV1alpha1ClusterStoreStatus" /> class.
        /// </summary>
        /// <param name="buildpacks">buildpacks.</param>
        /// <param name="conditions">Conditions the latest available observations of a resource&#39;s current state..</param>
        /// <param name="observedGeneration">ObservedGeneration is the &#39;Generation&#39; of the Service that was last processed by the controller..</param>
        public KpackBuildV1alpha1ClusterStoreStatus(List<KpackBuildV1alpha1StoreBuildpack> buildpacks = default(List<KpackBuildV1alpha1StoreBuildpack>), List<KpackCoreV1alpha1Condition> conditions = default(List<KpackCoreV1alpha1Condition>), long observedGeneration = default(long))
        {
            this.Buildpacks = buildpacks;
            this.Conditions = conditions;
            this.ObservedGeneration = observedGeneration;
        }
        
        /// <summary>
        /// Gets or Sets Buildpacks
        /// </summary>
        [DataMember(Name="buildpacks", EmitDefaultValue=false)]
        public List<KpackBuildV1alpha1StoreBuildpack> Buildpacks { get; set; }

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
            sb.Append("class KpackBuildV1alpha1ClusterStoreStatus {\n");
            sb.Append("  Buildpacks: ").Append(Buildpacks).Append("\n");
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
            return this.Equals(input as KpackBuildV1alpha1ClusterStoreStatus);
        }

        /// <summary>
        /// Returns true if KpackBuildV1alpha1ClusterStoreStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of KpackBuildV1alpha1ClusterStoreStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KpackBuildV1alpha1ClusterStoreStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Buildpacks == input.Buildpacks ||
                    this.Buildpacks != null &&
                    input.Buildpacks != null &&
                    this.Buildpacks.SequenceEqual(input.Buildpacks)
                ) && 
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
                if (this.Buildpacks != null)
                    hashCode = hashCode * 59 + this.Buildpacks.GetHashCode();
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
