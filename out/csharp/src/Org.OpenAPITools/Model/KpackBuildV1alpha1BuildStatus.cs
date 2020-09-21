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
    /// KpackBuildV1alpha1BuildStatus
    /// </summary>
    [DataContract]
    public partial class KpackBuildV1alpha1BuildStatus :  IEquatable<KpackBuildV1alpha1BuildStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KpackBuildV1alpha1BuildStatus" /> class.
        /// </summary>
        /// <param name="buildMetadata">buildMetadata.</param>
        /// <param name="conditions">Conditions the latest available observations of a resource&#39;s current state..</param>
        /// <param name="latestImage">latestImage.</param>
        /// <param name="observedGeneration">ObservedGeneration is the &#39;Generation&#39; of the Service that was last processed by the controller..</param>
        /// <param name="podName">podName.</param>
        /// <param name="stack">stack.</param>
        /// <param name="stepStates">stepStates.</param>
        /// <param name="stepsCompleted">stepsCompleted.</param>
        public KpackBuildV1alpha1BuildStatus(List<KpackBuildV1alpha1BuildpackMetadata> buildMetadata = default(List<KpackBuildV1alpha1BuildpackMetadata>), List<KpackCoreV1alpha1Condition> conditions = default(List<KpackCoreV1alpha1Condition>), string latestImage = default(string), long observedGeneration = default(long), string podName = default(string), KpackBuildV1alpha1BuildStack stack = default(KpackBuildV1alpha1BuildStack), List<IoK8sApiCoreV1ContainerState> stepStates = default(List<IoK8sApiCoreV1ContainerState>), List<string> stepsCompleted = default(List<string>))
        {
            this.BuildMetadata = buildMetadata;
            this.Conditions = conditions;
            this.LatestImage = latestImage;
            this.ObservedGeneration = observedGeneration;
            this.PodName = podName;
            this.Stack = stack;
            this.StepStates = stepStates;
            this.StepsCompleted = stepsCompleted;
        }
        
        /// <summary>
        /// Gets or Sets BuildMetadata
        /// </summary>
        [DataMember(Name="buildMetadata", EmitDefaultValue=false)]
        public List<KpackBuildV1alpha1BuildpackMetadata> BuildMetadata { get; set; }

        /// <summary>
        /// Conditions the latest available observations of a resource&#39;s current state.
        /// </summary>
        /// <value>Conditions the latest available observations of a resource&#39;s current state.</value>
        [DataMember(Name="conditions", EmitDefaultValue=false)]
        public List<KpackCoreV1alpha1Condition> Conditions { get; set; }

        /// <summary>
        /// Gets or Sets LatestImage
        /// </summary>
        [DataMember(Name="latestImage", EmitDefaultValue=false)]
        public string LatestImage { get; set; }

        /// <summary>
        /// ObservedGeneration is the &#39;Generation&#39; of the Service that was last processed by the controller.
        /// </summary>
        /// <value>ObservedGeneration is the &#39;Generation&#39; of the Service that was last processed by the controller.</value>
        [DataMember(Name="observedGeneration", EmitDefaultValue=false)]
        public long ObservedGeneration { get; set; }

        /// <summary>
        /// Gets or Sets PodName
        /// </summary>
        [DataMember(Name="podName", EmitDefaultValue=false)]
        public string PodName { get; set; }

        /// <summary>
        /// Gets or Sets Stack
        /// </summary>
        [DataMember(Name="stack", EmitDefaultValue=false)]
        public KpackBuildV1alpha1BuildStack Stack { get; set; }

        /// <summary>
        /// Gets or Sets StepStates
        /// </summary>
        [DataMember(Name="stepStates", EmitDefaultValue=false)]
        public List<IoK8sApiCoreV1ContainerState> StepStates { get; set; }

        /// <summary>
        /// Gets or Sets StepsCompleted
        /// </summary>
        [DataMember(Name="stepsCompleted", EmitDefaultValue=false)]
        public List<string> StepsCompleted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KpackBuildV1alpha1BuildStatus {\n");
            sb.Append("  BuildMetadata: ").Append(BuildMetadata).Append("\n");
            sb.Append("  Conditions: ").Append(Conditions).Append("\n");
            sb.Append("  LatestImage: ").Append(LatestImage).Append("\n");
            sb.Append("  ObservedGeneration: ").Append(ObservedGeneration).Append("\n");
            sb.Append("  PodName: ").Append(PodName).Append("\n");
            sb.Append("  Stack: ").Append(Stack).Append("\n");
            sb.Append("  StepStates: ").Append(StepStates).Append("\n");
            sb.Append("  StepsCompleted: ").Append(StepsCompleted).Append("\n");
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
            return this.Equals(input as KpackBuildV1alpha1BuildStatus);
        }

        /// <summary>
        /// Returns true if KpackBuildV1alpha1BuildStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of KpackBuildV1alpha1BuildStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KpackBuildV1alpha1BuildStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BuildMetadata == input.BuildMetadata ||
                    this.BuildMetadata != null &&
                    input.BuildMetadata != null &&
                    this.BuildMetadata.SequenceEqual(input.BuildMetadata)
                ) && 
                (
                    this.Conditions == input.Conditions ||
                    this.Conditions != null &&
                    input.Conditions != null &&
                    this.Conditions.SequenceEqual(input.Conditions)
                ) && 
                (
                    this.LatestImage == input.LatestImage ||
                    (this.LatestImage != null &&
                    this.LatestImage.Equals(input.LatestImage))
                ) && 
                (
                    this.ObservedGeneration == input.ObservedGeneration ||
                    (this.ObservedGeneration != null &&
                    this.ObservedGeneration.Equals(input.ObservedGeneration))
                ) && 
                (
                    this.PodName == input.PodName ||
                    (this.PodName != null &&
                    this.PodName.Equals(input.PodName))
                ) && 
                (
                    this.Stack == input.Stack ||
                    (this.Stack != null &&
                    this.Stack.Equals(input.Stack))
                ) && 
                (
                    this.StepStates == input.StepStates ||
                    this.StepStates != null &&
                    input.StepStates != null &&
                    this.StepStates.SequenceEqual(input.StepStates)
                ) && 
                (
                    this.StepsCompleted == input.StepsCompleted ||
                    this.StepsCompleted != null &&
                    input.StepsCompleted != null &&
                    this.StepsCompleted.SequenceEqual(input.StepsCompleted)
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
                if (this.BuildMetadata != null)
                    hashCode = hashCode * 59 + this.BuildMetadata.GetHashCode();
                if (this.Conditions != null)
                    hashCode = hashCode * 59 + this.Conditions.GetHashCode();
                if (this.LatestImage != null)
                    hashCode = hashCode * 59 + this.LatestImage.GetHashCode();
                if (this.ObservedGeneration != null)
                    hashCode = hashCode * 59 + this.ObservedGeneration.GetHashCode();
                if (this.PodName != null)
                    hashCode = hashCode * 59 + this.PodName.GetHashCode();
                if (this.Stack != null)
                    hashCode = hashCode * 59 + this.Stack.GetHashCode();
                if (this.StepStates != null)
                    hashCode = hashCode * 59 + this.StepStates.GetHashCode();
                if (this.StepsCompleted != null)
                    hashCode = hashCode * 59 + this.StepsCompleted.GetHashCode();
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
