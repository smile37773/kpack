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
    /// KpackBuildV1alpha1ImageSpec
    /// </summary>
    [DataContract]
    public partial class KpackBuildV1alpha1ImageSpec :  IEquatable<KpackBuildV1alpha1ImageSpec>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KpackBuildV1alpha1ImageSpec" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KpackBuildV1alpha1ImageSpec() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KpackBuildV1alpha1ImageSpec" /> class.
        /// </summary>
        /// <param name="build">build.</param>
        /// <param name="builder">builder.</param>
        /// <param name="cacheSize">Quantity is a fixed-point representation of a number. It provides convenient marshaling/unmarshaling in JSON and YAML, in addition to String() and Int64() accessors.  The serialization format is:  &lt;quantity&gt;        ::&#x3D; &lt;signedNumber&gt;&lt;suffix&gt;   (Note that &lt;suffix&gt; may be empty, from the \&quot;\&quot; case in &lt;decimalSI&gt;.) &lt;digit&gt;           ::&#x3D; 0 | 1 | ... | 9 &lt;digits&gt;          ::&#x3D; &lt;digit&gt; | &lt;digit&gt;&lt;digits&gt; &lt;number&gt;          ::&#x3D; &lt;digits&gt; | &lt;digits&gt;.&lt;digits&gt; | &lt;digits&gt;. | .&lt;digits&gt; &lt;sign&gt;            ::&#x3D; \&quot;+\&quot; | \&quot;-\&quot; &lt;signedNumber&gt;    ::&#x3D; &lt;number&gt; | &lt;sign&gt;&lt;number&gt; &lt;suffix&gt;          ::&#x3D; &lt;binarySI&gt; | &lt;decimalExponent&gt; | &lt;decimalSI&gt; &lt;binarySI&gt;        ::&#x3D; Ki | Mi | Gi | Ti | Pi | Ei   (International System of units; See: http://physics.nist.gov/cuu/Units/binary.html) &lt;decimalSI&gt;       ::&#x3D; m | \&quot;\&quot; | k | M | G | T | P | E   (Note that 1024 &#x3D; 1Ki but 1000 &#x3D; 1k; I didn&#39;t choose the capitalization.) &lt;decimalExponent&gt; ::&#x3D; \&quot;e\&quot; &lt;signedNumber&gt; | \&quot;E\&quot; &lt;signedNumber&gt;  No matter which of the three exponent forms is used, no quantity may represent a number greater than 2^63-1 in magnitude, nor may it have more than 3 decimal places. Numbers larger or more precise will be capped or rounded up. (E.g.: 0.1m will rounded up to 1m.) This may be extended in the future if we require larger or smaller quantities.  When a Quantity is parsed from a string, it will remember the type of suffix it had, and will use the same type again when it is serialized.  Before serializing, Quantity will be put in \&quot;canonical form\&quot;. This means that Exponent/suffix will be adjusted up or down (with a corresponding increase or decrease in Mantissa) such that:   a. No precision is lost   b. No fractional digits will be emitted   c. The exponent (or suffix) is as large as possible. The sign will be omitted unless the number is negative.  Examples:   1.5 will be serialized as \&quot;1500m\&quot;   1.5Gi will be serialized as \&quot;1536Mi\&quot;  Note that the quantity will NEVER be internally represented by a floating point number. That is the whole point of this exercise.  Non-canonical values will still parse as long as they are well formed, but will be re-emitted in their canonical form. (So always use canonical form, or don&#39;t diff.)  This format is intended to make it difficult to use these numbers without writing some sort of special handling code in the hopes that that will cause implementors to also use a fixed point implementation..</param>
        /// <param name="failedBuildHistoryLimit">failedBuildHistoryLimit.</param>
        /// <param name="imageTaggingStrategy">imageTaggingStrategy.</param>
        /// <param name="serviceAccount">serviceAccount.</param>
        /// <param name="source">source (required).</param>
        /// <param name="successBuildHistoryLimit">successBuildHistoryLimit.</param>
        /// <param name="tag">tag (required).</param>
        public KpackBuildV1alpha1ImageSpec(KpackBuildV1alpha1ImageBuild build = default(KpackBuildV1alpha1ImageBuild), IoK8sApiCoreV1ObjectReference builder = default(IoK8sApiCoreV1ObjectReference), string cacheSize = default(string), long failedBuildHistoryLimit = default(long), string imageTaggingStrategy = default(string), string serviceAccount = default(string), KpackBuildV1alpha1SourceConfig source = default(KpackBuildV1alpha1SourceConfig), long successBuildHistoryLimit = default(long), string tag = default(string))
        {
            // to ensure "source" is required (not null)
            if (source == null)
            {
                throw new InvalidDataException("source is a required property for KpackBuildV1alpha1ImageSpec and cannot be null");
            }
            else
            {
                this.Source = source;
            }
            
            // to ensure "tag" is required (not null)
            if (tag == null)
            {
                throw new InvalidDataException("tag is a required property for KpackBuildV1alpha1ImageSpec and cannot be null");
            }
            else
            {
                this.Tag = tag;
            }
            
            this.Build = build;
            this.Builder = builder;
            this.CacheSize = cacheSize;
            this.FailedBuildHistoryLimit = failedBuildHistoryLimit;
            this.ImageTaggingStrategy = imageTaggingStrategy;
            this.ServiceAccount = serviceAccount;
            this.SuccessBuildHistoryLimit = successBuildHistoryLimit;
        }
        
        /// <summary>
        /// Gets or Sets Build
        /// </summary>
        [DataMember(Name="build", EmitDefaultValue=false)]
        public KpackBuildV1alpha1ImageBuild Build { get; set; }

        /// <summary>
        /// Gets or Sets Builder
        /// </summary>
        [DataMember(Name="builder", EmitDefaultValue=false)]
        public IoK8sApiCoreV1ObjectReference Builder { get; set; }

        /// <summary>
        /// Quantity is a fixed-point representation of a number. It provides convenient marshaling/unmarshaling in JSON and YAML, in addition to String() and Int64() accessors.  The serialization format is:  &lt;quantity&gt;        ::&#x3D; &lt;signedNumber&gt;&lt;suffix&gt;   (Note that &lt;suffix&gt; may be empty, from the \&quot;\&quot; case in &lt;decimalSI&gt;.) &lt;digit&gt;           ::&#x3D; 0 | 1 | ... | 9 &lt;digits&gt;          ::&#x3D; &lt;digit&gt; | &lt;digit&gt;&lt;digits&gt; &lt;number&gt;          ::&#x3D; &lt;digits&gt; | &lt;digits&gt;.&lt;digits&gt; | &lt;digits&gt;. | .&lt;digits&gt; &lt;sign&gt;            ::&#x3D; \&quot;+\&quot; | \&quot;-\&quot; &lt;signedNumber&gt;    ::&#x3D; &lt;number&gt; | &lt;sign&gt;&lt;number&gt; &lt;suffix&gt;          ::&#x3D; &lt;binarySI&gt; | &lt;decimalExponent&gt; | &lt;decimalSI&gt; &lt;binarySI&gt;        ::&#x3D; Ki | Mi | Gi | Ti | Pi | Ei   (International System of units; See: http://physics.nist.gov/cuu/Units/binary.html) &lt;decimalSI&gt;       ::&#x3D; m | \&quot;\&quot; | k | M | G | T | P | E   (Note that 1024 &#x3D; 1Ki but 1000 &#x3D; 1k; I didn&#39;t choose the capitalization.) &lt;decimalExponent&gt; ::&#x3D; \&quot;e\&quot; &lt;signedNumber&gt; | \&quot;E\&quot; &lt;signedNumber&gt;  No matter which of the three exponent forms is used, no quantity may represent a number greater than 2^63-1 in magnitude, nor may it have more than 3 decimal places. Numbers larger or more precise will be capped or rounded up. (E.g.: 0.1m will rounded up to 1m.) This may be extended in the future if we require larger or smaller quantities.  When a Quantity is parsed from a string, it will remember the type of suffix it had, and will use the same type again when it is serialized.  Before serializing, Quantity will be put in \&quot;canonical form\&quot;. This means that Exponent/suffix will be adjusted up or down (with a corresponding increase or decrease in Mantissa) such that:   a. No precision is lost   b. No fractional digits will be emitted   c. The exponent (or suffix) is as large as possible. The sign will be omitted unless the number is negative.  Examples:   1.5 will be serialized as \&quot;1500m\&quot;   1.5Gi will be serialized as \&quot;1536Mi\&quot;  Note that the quantity will NEVER be internally represented by a floating point number. That is the whole point of this exercise.  Non-canonical values will still parse as long as they are well formed, but will be re-emitted in their canonical form. (So always use canonical form, or don&#39;t diff.)  This format is intended to make it difficult to use these numbers without writing some sort of special handling code in the hopes that that will cause implementors to also use a fixed point implementation.
        /// </summary>
        /// <value>Quantity is a fixed-point representation of a number. It provides convenient marshaling/unmarshaling in JSON and YAML, in addition to String() and Int64() accessors.  The serialization format is:  &lt;quantity&gt;        ::&#x3D; &lt;signedNumber&gt;&lt;suffix&gt;   (Note that &lt;suffix&gt; may be empty, from the \&quot;\&quot; case in &lt;decimalSI&gt;.) &lt;digit&gt;           ::&#x3D; 0 | 1 | ... | 9 &lt;digits&gt;          ::&#x3D; &lt;digit&gt; | &lt;digit&gt;&lt;digits&gt; &lt;number&gt;          ::&#x3D; &lt;digits&gt; | &lt;digits&gt;.&lt;digits&gt; | &lt;digits&gt;. | .&lt;digits&gt; &lt;sign&gt;            ::&#x3D; \&quot;+\&quot; | \&quot;-\&quot; &lt;signedNumber&gt;    ::&#x3D; &lt;number&gt; | &lt;sign&gt;&lt;number&gt; &lt;suffix&gt;          ::&#x3D; &lt;binarySI&gt; | &lt;decimalExponent&gt; | &lt;decimalSI&gt; &lt;binarySI&gt;        ::&#x3D; Ki | Mi | Gi | Ti | Pi | Ei   (International System of units; See: http://physics.nist.gov/cuu/Units/binary.html) &lt;decimalSI&gt;       ::&#x3D; m | \&quot;\&quot; | k | M | G | T | P | E   (Note that 1024 &#x3D; 1Ki but 1000 &#x3D; 1k; I didn&#39;t choose the capitalization.) &lt;decimalExponent&gt; ::&#x3D; \&quot;e\&quot; &lt;signedNumber&gt; | \&quot;E\&quot; &lt;signedNumber&gt;  No matter which of the three exponent forms is used, no quantity may represent a number greater than 2^63-1 in magnitude, nor may it have more than 3 decimal places. Numbers larger or more precise will be capped or rounded up. (E.g.: 0.1m will rounded up to 1m.) This may be extended in the future if we require larger or smaller quantities.  When a Quantity is parsed from a string, it will remember the type of suffix it had, and will use the same type again when it is serialized.  Before serializing, Quantity will be put in \&quot;canonical form\&quot;. This means that Exponent/suffix will be adjusted up or down (with a corresponding increase or decrease in Mantissa) such that:   a. No precision is lost   b. No fractional digits will be emitted   c. The exponent (or suffix) is as large as possible. The sign will be omitted unless the number is negative.  Examples:   1.5 will be serialized as \&quot;1500m\&quot;   1.5Gi will be serialized as \&quot;1536Mi\&quot;  Note that the quantity will NEVER be internally represented by a floating point number. That is the whole point of this exercise.  Non-canonical values will still parse as long as they are well formed, but will be re-emitted in their canonical form. (So always use canonical form, or don&#39;t diff.)  This format is intended to make it difficult to use these numbers without writing some sort of special handling code in the hopes that that will cause implementors to also use a fixed point implementation.</value>
        [DataMember(Name="cacheSize", EmitDefaultValue=false)]
        public string CacheSize { get; set; }

        /// <summary>
        /// Gets or Sets FailedBuildHistoryLimit
        /// </summary>
        [DataMember(Name="failedBuildHistoryLimit", EmitDefaultValue=false)]
        public long FailedBuildHistoryLimit { get; set; }

        /// <summary>
        /// Gets or Sets ImageTaggingStrategy
        /// </summary>
        [DataMember(Name="imageTaggingStrategy", EmitDefaultValue=false)]
        public string ImageTaggingStrategy { get; set; }

        /// <summary>
        /// Gets or Sets ServiceAccount
        /// </summary>
        [DataMember(Name="serviceAccount", EmitDefaultValue=false)]
        public string ServiceAccount { get; set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name="source", EmitDefaultValue=true)]
        public KpackBuildV1alpha1SourceConfig Source { get; set; }

        /// <summary>
        /// Gets or Sets SuccessBuildHistoryLimit
        /// </summary>
        [DataMember(Name="successBuildHistoryLimit", EmitDefaultValue=false)]
        public long SuccessBuildHistoryLimit { get; set; }

        /// <summary>
        /// Gets or Sets Tag
        /// </summary>
        [DataMember(Name="tag", EmitDefaultValue=true)]
        public string Tag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KpackBuildV1alpha1ImageSpec {\n");
            sb.Append("  Build: ").Append(Build).Append("\n");
            sb.Append("  Builder: ").Append(Builder).Append("\n");
            sb.Append("  CacheSize: ").Append(CacheSize).Append("\n");
            sb.Append("  FailedBuildHistoryLimit: ").Append(FailedBuildHistoryLimit).Append("\n");
            sb.Append("  ImageTaggingStrategy: ").Append(ImageTaggingStrategy).Append("\n");
            sb.Append("  ServiceAccount: ").Append(ServiceAccount).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  SuccessBuildHistoryLimit: ").Append(SuccessBuildHistoryLimit).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
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
            return this.Equals(input as KpackBuildV1alpha1ImageSpec);
        }

        /// <summary>
        /// Returns true if KpackBuildV1alpha1ImageSpec instances are equal
        /// </summary>
        /// <param name="input">Instance of KpackBuildV1alpha1ImageSpec to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KpackBuildV1alpha1ImageSpec input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Build == input.Build ||
                    (this.Build != null &&
                    this.Build.Equals(input.Build))
                ) && 
                (
                    this.Builder == input.Builder ||
                    (this.Builder != null &&
                    this.Builder.Equals(input.Builder))
                ) && 
                (
                    this.CacheSize == input.CacheSize ||
                    (this.CacheSize != null &&
                    this.CacheSize.Equals(input.CacheSize))
                ) && 
                (
                    this.FailedBuildHistoryLimit == input.FailedBuildHistoryLimit ||
                    (this.FailedBuildHistoryLimit != null &&
                    this.FailedBuildHistoryLimit.Equals(input.FailedBuildHistoryLimit))
                ) && 
                (
                    this.ImageTaggingStrategy == input.ImageTaggingStrategy ||
                    (this.ImageTaggingStrategy != null &&
                    this.ImageTaggingStrategy.Equals(input.ImageTaggingStrategy))
                ) && 
                (
                    this.ServiceAccount == input.ServiceAccount ||
                    (this.ServiceAccount != null &&
                    this.ServiceAccount.Equals(input.ServiceAccount))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.SuccessBuildHistoryLimit == input.SuccessBuildHistoryLimit ||
                    (this.SuccessBuildHistoryLimit != null &&
                    this.SuccessBuildHistoryLimit.Equals(input.SuccessBuildHistoryLimit))
                ) && 
                (
                    this.Tag == input.Tag ||
                    (this.Tag != null &&
                    this.Tag.Equals(input.Tag))
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
                if (this.Build != null)
                    hashCode = hashCode * 59 + this.Build.GetHashCode();
                if (this.Builder != null)
                    hashCode = hashCode * 59 + this.Builder.GetHashCode();
                if (this.CacheSize != null)
                    hashCode = hashCode * 59 + this.CacheSize.GetHashCode();
                if (this.FailedBuildHistoryLimit != null)
                    hashCode = hashCode * 59 + this.FailedBuildHistoryLimit.GetHashCode();
                if (this.ImageTaggingStrategy != null)
                    hashCode = hashCode * 59 + this.ImageTaggingStrategy.GetHashCode();
                if (this.ServiceAccount != null)
                    hashCode = hashCode * 59 + this.ServiceAccount.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.SuccessBuildHistoryLimit != null)
                    hashCode = hashCode * 59 + this.SuccessBuildHistoryLimit.GetHashCode();
                if (this.Tag != null)
                    hashCode = hashCode * 59 + this.Tag.GetHashCode();
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