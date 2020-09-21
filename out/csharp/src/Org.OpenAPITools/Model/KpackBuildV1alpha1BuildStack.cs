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
    /// KpackBuildV1alpha1BuildStack
    /// </summary>
    [DataContract]
    public partial class KpackBuildV1alpha1BuildStack :  IEquatable<KpackBuildV1alpha1BuildStack>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KpackBuildV1alpha1BuildStack" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="runImage">runImage.</param>
        public KpackBuildV1alpha1BuildStack(string id = default(string), string runImage = default(string))
        {
            this.Id = id;
            this.RunImage = runImage;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets RunImage
        /// </summary>
        [DataMember(Name="runImage", EmitDefaultValue=false)]
        public string RunImage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KpackBuildV1alpha1BuildStack {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RunImage: ").Append(RunImage).Append("\n");
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
            return this.Equals(input as KpackBuildV1alpha1BuildStack);
        }

        /// <summary>
        /// Returns true if KpackBuildV1alpha1BuildStack instances are equal
        /// </summary>
        /// <param name="input">Instance of KpackBuildV1alpha1BuildStack to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KpackBuildV1alpha1BuildStack input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.RunImage == input.RunImage ||
                    (this.RunImage != null &&
                    this.RunImage.Equals(input.RunImage))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.RunImage != null)
                    hashCode = hashCode * 59 + this.RunImage.GetHashCode();
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