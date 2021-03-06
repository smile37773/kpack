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
    /// ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.
    /// </summary>
    [DataContract]
    public partial class IoK8sApimachineryPkgApisMetaV1ObjectMeta :  IEquatable<IoK8sApimachineryPkgApisMetaV1ObjectMeta>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoK8sApimachineryPkgApisMetaV1ObjectMeta" /> class.
        /// </summary>
        /// <param name="annotations">Annotations is an unstructured key value map stored with a resource that may be set by external tools to store and retrieve arbitrary metadata. They are not queryable and should be preserved when modifying objects. More info: http://kubernetes.io/docs/user-guide/annotations.</param>
        /// <param name="clusterName">The name of the cluster which the object belongs to. This is used to distinguish resources with same name and namespace in different clusters. This field is not set anywhere right now and apiserver is going to ignore it if set in create or update request..</param>
        /// <param name="creationTimestamp">Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers..</param>
        /// <param name="deletionGracePeriodSeconds">Number of seconds allowed for this object to gracefully terminate before it will be removed from the system. Only set when deletionTimestamp is also set. May only be shortened. Read-only..</param>
        /// <param name="deletionTimestamp">Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers..</param>
        /// <param name="finalizers">Must be empty before the object is deleted from the registry. Each entry is an identifier for the responsible component that will remove the entry from the list. If the deletionTimestamp of the object is non-nil, entries in this list can only be removed..</param>
        /// <param name="generateName">GenerateName is an optional prefix, used by the server, to generate a unique name ONLY IF the Name field has not been provided. If this field is used, the name returned to the client will be different than the name passed. This value will also be combined with a unique suffix. The provided value has the same validation rules as the Name field, and may be truncated by the length of the suffix required to make the value unique on the server.  If this field is specified and the generated name exists, the server will NOT return a 409 - instead, it will either return 201 Created or 500 with Reason ServerTimeout indicating a unique name could not be found in the time allotted, and the client should retry (optionally after the time indicated in the Retry-After header).  Applied only if Name is not specified. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#idempotency.</param>
        /// <param name="generation">A sequence number representing a specific generation of the desired state. Populated by the system. Read-only..</param>
        /// <param name="initializers">initializers.</param>
        /// <param name="labels">Map of string keys and values that can be used to organize and categorize (scope and select) objects. May match selectors of replication controllers and services. More info: http://kubernetes.io/docs/user-guide/labels.</param>
        /// <param name="managedFields">ManagedFields maps workflow-id and version to the set of fields that are managed by that workflow. This is mostly for internal housekeeping, and users typically shouldn&#39;t need to set or understand this field. A workflow can be the user&#39;s name, a controller&#39;s name, or the name of a specific apply path like \&quot;ci-cd\&quot;. The set of fields is always in the version that the workflow used when modifying the object.  This field is alpha and can be changed or removed without notice..</param>
        /// <param name="name">Name must be unique within a namespace. Is required when creating resources, although some resources may allow a client to request the generation of an appropriate name automatically. Name is primarily intended for creation idempotence and configuration definition. Cannot be updated. More info: http://kubernetes.io/docs/user-guide/identifiers#names.</param>
        /// <param name="_namespace">Namespace defines the space within each name must be unique. An empty namespace is equivalent to the \&quot;default\&quot; namespace, but \&quot;default\&quot; is the canonical representation. Not all objects are required to be scoped to a namespace - the value of this field for those objects will be empty.  Must be a DNS_LABEL. Cannot be updated. More info: http://kubernetes.io/docs/user-guide/namespaces.</param>
        /// <param name="ownerReferences">List of objects depended by this object. If ALL objects in the list have been deleted, this object will be garbage collected. If this object is managed by a controller, then an entry in this list will point to this controller, with the controller field set to true. There cannot be more than one managing controller..</param>
        /// <param name="resourceVersion">An opaque value that represents the internal version of this object that can be used by clients to determine when objects have changed. May be used for optimistic concurrency, change detection, and the watch operation on a resource or set of resources. Clients must treat these values as opaque and passed unmodified back to the server. They may only be valid for a particular resource or set of resources.  Populated by the system. Read-only. Value must be treated as opaque by clients and . More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#concurrency-control-and-consistency.</param>
        /// <param name="selfLink">SelfLink is a URL representing this object. Populated by the system. Read-only..</param>
        /// <param name="uid">UID is the unique in time and space value for this object. It is typically generated by the server on successful creation of a resource and is not allowed to change on PUT operations.  Populated by the system. Read-only. More info: http://kubernetes.io/docs/user-guide/identifiers#uids.</param>
        public IoK8sApimachineryPkgApisMetaV1ObjectMeta(Dictionary<string, string> annotations = default(Dictionary<string, string>), string clusterName = default(string), DateTime creationTimestamp = default(DateTime), long deletionGracePeriodSeconds = default(long), DateTime deletionTimestamp = default(DateTime), List<string> finalizers = default(List<string>), string generateName = default(string), long generation = default(long), IoK8sApimachineryPkgApisMetaV1Initializers initializers = default(IoK8sApimachineryPkgApisMetaV1Initializers), Dictionary<string, string> labels = default(Dictionary<string, string>), List<IoK8sApimachineryPkgApisMetaV1ManagedFieldsEntry> managedFields = default(List<IoK8sApimachineryPkgApisMetaV1ManagedFieldsEntry>), string name = default(string), string _namespace = default(string), List<IoK8sApimachineryPkgApisMetaV1OwnerReference> ownerReferences = default(List<IoK8sApimachineryPkgApisMetaV1OwnerReference>), string resourceVersion = default(string), string selfLink = default(string), string uid = default(string))
        {
            this.Annotations = annotations;
            this.ClusterName = clusterName;
            this.CreationTimestamp = creationTimestamp;
            this.DeletionGracePeriodSeconds = deletionGracePeriodSeconds;
            this.DeletionTimestamp = deletionTimestamp;
            this.Finalizers = finalizers;
            this.GenerateName = generateName;
            this.Generation = generation;
            this.Initializers = initializers;
            this.Labels = labels;
            this.ManagedFields = managedFields;
            this.Name = name;
            this.Namespace = _namespace;
            this.OwnerReferences = ownerReferences;
            this.ResourceVersion = resourceVersion;
            this.SelfLink = selfLink;
            this.Uid = uid;
        }
        
        /// <summary>
        /// Annotations is an unstructured key value map stored with a resource that may be set by external tools to store and retrieve arbitrary metadata. They are not queryable and should be preserved when modifying objects. More info: http://kubernetes.io/docs/user-guide/annotations
        /// </summary>
        /// <value>Annotations is an unstructured key value map stored with a resource that may be set by external tools to store and retrieve arbitrary metadata. They are not queryable and should be preserved when modifying objects. More info: http://kubernetes.io/docs/user-guide/annotations</value>
        [DataMember(Name="annotations", EmitDefaultValue=false)]
        public Dictionary<string, string> Annotations { get; set; }

        /// <summary>
        /// The name of the cluster which the object belongs to. This is used to distinguish resources with same name and namespace in different clusters. This field is not set anywhere right now and apiserver is going to ignore it if set in create or update request.
        /// </summary>
        /// <value>The name of the cluster which the object belongs to. This is used to distinguish resources with same name and namespace in different clusters. This field is not set anywhere right now and apiserver is going to ignore it if set in create or update request.</value>
        [DataMember(Name="clusterName", EmitDefaultValue=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers.
        /// </summary>
        /// <value>Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers.</value>
        [DataMember(Name="creationTimestamp", EmitDefaultValue=false)]
        public DateTime CreationTimestamp { get; set; }

        /// <summary>
        /// Number of seconds allowed for this object to gracefully terminate before it will be removed from the system. Only set when deletionTimestamp is also set. May only be shortened. Read-only.
        /// </summary>
        /// <value>Number of seconds allowed for this object to gracefully terminate before it will be removed from the system. Only set when deletionTimestamp is also set. May only be shortened. Read-only.</value>
        [DataMember(Name="deletionGracePeriodSeconds", EmitDefaultValue=false)]
        public long DeletionGracePeriodSeconds { get; set; }

        /// <summary>
        /// Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers.
        /// </summary>
        /// <value>Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers.</value>
        [DataMember(Name="deletionTimestamp", EmitDefaultValue=false)]
        public DateTime DeletionTimestamp { get; set; }

        /// <summary>
        /// Must be empty before the object is deleted from the registry. Each entry is an identifier for the responsible component that will remove the entry from the list. If the deletionTimestamp of the object is non-nil, entries in this list can only be removed.
        /// </summary>
        /// <value>Must be empty before the object is deleted from the registry. Each entry is an identifier for the responsible component that will remove the entry from the list. If the deletionTimestamp of the object is non-nil, entries in this list can only be removed.</value>
        [DataMember(Name="finalizers", EmitDefaultValue=false)]
        public List<string> Finalizers { get; set; }

        /// <summary>
        /// GenerateName is an optional prefix, used by the server, to generate a unique name ONLY IF the Name field has not been provided. If this field is used, the name returned to the client will be different than the name passed. This value will also be combined with a unique suffix. The provided value has the same validation rules as the Name field, and may be truncated by the length of the suffix required to make the value unique on the server.  If this field is specified and the generated name exists, the server will NOT return a 409 - instead, it will either return 201 Created or 500 with Reason ServerTimeout indicating a unique name could not be found in the time allotted, and the client should retry (optionally after the time indicated in the Retry-After header).  Applied only if Name is not specified. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#idempotency
        /// </summary>
        /// <value>GenerateName is an optional prefix, used by the server, to generate a unique name ONLY IF the Name field has not been provided. If this field is used, the name returned to the client will be different than the name passed. This value will also be combined with a unique suffix. The provided value has the same validation rules as the Name field, and may be truncated by the length of the suffix required to make the value unique on the server.  If this field is specified and the generated name exists, the server will NOT return a 409 - instead, it will either return 201 Created or 500 with Reason ServerTimeout indicating a unique name could not be found in the time allotted, and the client should retry (optionally after the time indicated in the Retry-After header).  Applied only if Name is not specified. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#idempotency</value>
        [DataMember(Name="generateName", EmitDefaultValue=false)]
        public string GenerateName { get; set; }

        /// <summary>
        /// A sequence number representing a specific generation of the desired state. Populated by the system. Read-only.
        /// </summary>
        /// <value>A sequence number representing a specific generation of the desired state. Populated by the system. Read-only.</value>
        [DataMember(Name="generation", EmitDefaultValue=false)]
        public long Generation { get; set; }

        /// <summary>
        /// Gets or Sets Initializers
        /// </summary>
        [DataMember(Name="initializers", EmitDefaultValue=false)]
        public IoK8sApimachineryPkgApisMetaV1Initializers Initializers { get; set; }

        /// <summary>
        /// Map of string keys and values that can be used to organize and categorize (scope and select) objects. May match selectors of replication controllers and services. More info: http://kubernetes.io/docs/user-guide/labels
        /// </summary>
        /// <value>Map of string keys and values that can be used to organize and categorize (scope and select) objects. May match selectors of replication controllers and services. More info: http://kubernetes.io/docs/user-guide/labels</value>
        [DataMember(Name="labels", EmitDefaultValue=false)]
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// ManagedFields maps workflow-id and version to the set of fields that are managed by that workflow. This is mostly for internal housekeeping, and users typically shouldn&#39;t need to set or understand this field. A workflow can be the user&#39;s name, a controller&#39;s name, or the name of a specific apply path like \&quot;ci-cd\&quot;. The set of fields is always in the version that the workflow used when modifying the object.  This field is alpha and can be changed or removed without notice.
        /// </summary>
        /// <value>ManagedFields maps workflow-id and version to the set of fields that are managed by that workflow. This is mostly for internal housekeeping, and users typically shouldn&#39;t need to set or understand this field. A workflow can be the user&#39;s name, a controller&#39;s name, or the name of a specific apply path like \&quot;ci-cd\&quot;. The set of fields is always in the version that the workflow used when modifying the object.  This field is alpha and can be changed or removed without notice.</value>
        [DataMember(Name="managedFields", EmitDefaultValue=false)]
        public List<IoK8sApimachineryPkgApisMetaV1ManagedFieldsEntry> ManagedFields { get; set; }

        /// <summary>
        /// Name must be unique within a namespace. Is required when creating resources, although some resources may allow a client to request the generation of an appropriate name automatically. Name is primarily intended for creation idempotence and configuration definition. Cannot be updated. More info: http://kubernetes.io/docs/user-guide/identifiers#names
        /// </summary>
        /// <value>Name must be unique within a namespace. Is required when creating resources, although some resources may allow a client to request the generation of an appropriate name automatically. Name is primarily intended for creation idempotence and configuration definition. Cannot be updated. More info: http://kubernetes.io/docs/user-guide/identifiers#names</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Namespace defines the space within each name must be unique. An empty namespace is equivalent to the \&quot;default\&quot; namespace, but \&quot;default\&quot; is the canonical representation. Not all objects are required to be scoped to a namespace - the value of this field for those objects will be empty.  Must be a DNS_LABEL. Cannot be updated. More info: http://kubernetes.io/docs/user-guide/namespaces
        /// </summary>
        /// <value>Namespace defines the space within each name must be unique. An empty namespace is equivalent to the \&quot;default\&quot; namespace, but \&quot;default\&quot; is the canonical representation. Not all objects are required to be scoped to a namespace - the value of this field for those objects will be empty.  Must be a DNS_LABEL. Cannot be updated. More info: http://kubernetes.io/docs/user-guide/namespaces</value>
        [DataMember(Name="namespace", EmitDefaultValue=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// List of objects depended by this object. If ALL objects in the list have been deleted, this object will be garbage collected. If this object is managed by a controller, then an entry in this list will point to this controller, with the controller field set to true. There cannot be more than one managing controller.
        /// </summary>
        /// <value>List of objects depended by this object. If ALL objects in the list have been deleted, this object will be garbage collected. If this object is managed by a controller, then an entry in this list will point to this controller, with the controller field set to true. There cannot be more than one managing controller.</value>
        [DataMember(Name="ownerReferences", EmitDefaultValue=false)]
        public List<IoK8sApimachineryPkgApisMetaV1OwnerReference> OwnerReferences { get; set; }

        /// <summary>
        /// An opaque value that represents the internal version of this object that can be used by clients to determine when objects have changed. May be used for optimistic concurrency, change detection, and the watch operation on a resource or set of resources. Clients must treat these values as opaque and passed unmodified back to the server. They may only be valid for a particular resource or set of resources.  Populated by the system. Read-only. Value must be treated as opaque by clients and . More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#concurrency-control-and-consistency
        /// </summary>
        /// <value>An opaque value that represents the internal version of this object that can be used by clients to determine when objects have changed. May be used for optimistic concurrency, change detection, and the watch operation on a resource or set of resources. Clients must treat these values as opaque and passed unmodified back to the server. They may only be valid for a particular resource or set of resources.  Populated by the system. Read-only. Value must be treated as opaque by clients and . More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#concurrency-control-and-consistency</value>
        [DataMember(Name="resourceVersion", EmitDefaultValue=false)]
        public string ResourceVersion { get; set; }

        /// <summary>
        /// SelfLink is a URL representing this object. Populated by the system. Read-only.
        /// </summary>
        /// <value>SelfLink is a URL representing this object. Populated by the system. Read-only.</value>
        [DataMember(Name="selfLink", EmitDefaultValue=false)]
        public string SelfLink { get; set; }

        /// <summary>
        /// UID is the unique in time and space value for this object. It is typically generated by the server on successful creation of a resource and is not allowed to change on PUT operations.  Populated by the system. Read-only. More info: http://kubernetes.io/docs/user-guide/identifiers#uids
        /// </summary>
        /// <value>UID is the unique in time and space value for this object. It is typically generated by the server on successful creation of a resource and is not allowed to change on PUT operations.  Populated by the system. Read-only. More info: http://kubernetes.io/docs/user-guide/identifiers#uids</value>
        [DataMember(Name="uid", EmitDefaultValue=false)]
        public string Uid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IoK8sApimachineryPkgApisMetaV1ObjectMeta {\n");
            sb.Append("  Annotations: ").Append(Annotations).Append("\n");
            sb.Append("  ClusterName: ").Append(ClusterName).Append("\n");
            sb.Append("  CreationTimestamp: ").Append(CreationTimestamp).Append("\n");
            sb.Append("  DeletionGracePeriodSeconds: ").Append(DeletionGracePeriodSeconds).Append("\n");
            sb.Append("  DeletionTimestamp: ").Append(DeletionTimestamp).Append("\n");
            sb.Append("  Finalizers: ").Append(Finalizers).Append("\n");
            sb.Append("  GenerateName: ").Append(GenerateName).Append("\n");
            sb.Append("  Generation: ").Append(Generation).Append("\n");
            sb.Append("  Initializers: ").Append(Initializers).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("  ManagedFields: ").Append(ManagedFields).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  OwnerReferences: ").Append(OwnerReferences).Append("\n");
            sb.Append("  ResourceVersion: ").Append(ResourceVersion).Append("\n");
            sb.Append("  SelfLink: ").Append(SelfLink).Append("\n");
            sb.Append("  Uid: ").Append(Uid).Append("\n");
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
            return this.Equals(input as IoK8sApimachineryPkgApisMetaV1ObjectMeta);
        }

        /// <summary>
        /// Returns true if IoK8sApimachineryPkgApisMetaV1ObjectMeta instances are equal
        /// </summary>
        /// <param name="input">Instance of IoK8sApimachineryPkgApisMetaV1ObjectMeta to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IoK8sApimachineryPkgApisMetaV1ObjectMeta input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Annotations == input.Annotations ||
                    this.Annotations != null &&
                    input.Annotations != null &&
                    this.Annotations.SequenceEqual(input.Annotations)
                ) && 
                (
                    this.ClusterName == input.ClusterName ||
                    (this.ClusterName != null &&
                    this.ClusterName.Equals(input.ClusterName))
                ) && 
                (
                    this.CreationTimestamp == input.CreationTimestamp ||
                    (this.CreationTimestamp != null &&
                    this.CreationTimestamp.Equals(input.CreationTimestamp))
                ) && 
                (
                    this.DeletionGracePeriodSeconds == input.DeletionGracePeriodSeconds ||
                    (this.DeletionGracePeriodSeconds != null &&
                    this.DeletionGracePeriodSeconds.Equals(input.DeletionGracePeriodSeconds))
                ) && 
                (
                    this.DeletionTimestamp == input.DeletionTimestamp ||
                    (this.DeletionTimestamp != null &&
                    this.DeletionTimestamp.Equals(input.DeletionTimestamp))
                ) && 
                (
                    this.Finalizers == input.Finalizers ||
                    this.Finalizers != null &&
                    input.Finalizers != null &&
                    this.Finalizers.SequenceEqual(input.Finalizers)
                ) && 
                (
                    this.GenerateName == input.GenerateName ||
                    (this.GenerateName != null &&
                    this.GenerateName.Equals(input.GenerateName))
                ) && 
                (
                    this.Generation == input.Generation ||
                    (this.Generation != null &&
                    this.Generation.Equals(input.Generation))
                ) && 
                (
                    this.Initializers == input.Initializers ||
                    (this.Initializers != null &&
                    this.Initializers.Equals(input.Initializers))
                ) && 
                (
                    this.Labels == input.Labels ||
                    this.Labels != null &&
                    input.Labels != null &&
                    this.Labels.SequenceEqual(input.Labels)
                ) && 
                (
                    this.ManagedFields == input.ManagedFields ||
                    this.ManagedFields != null &&
                    input.ManagedFields != null &&
                    this.ManagedFields.SequenceEqual(input.ManagedFields)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
                ) && 
                (
                    this.OwnerReferences == input.OwnerReferences ||
                    this.OwnerReferences != null &&
                    input.OwnerReferences != null &&
                    this.OwnerReferences.SequenceEqual(input.OwnerReferences)
                ) && 
                (
                    this.ResourceVersion == input.ResourceVersion ||
                    (this.ResourceVersion != null &&
                    this.ResourceVersion.Equals(input.ResourceVersion))
                ) && 
                (
                    this.SelfLink == input.SelfLink ||
                    (this.SelfLink != null &&
                    this.SelfLink.Equals(input.SelfLink))
                ) && 
                (
                    this.Uid == input.Uid ||
                    (this.Uid != null &&
                    this.Uid.Equals(input.Uid))
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
                if (this.Annotations != null)
                    hashCode = hashCode * 59 + this.Annotations.GetHashCode();
                if (this.ClusterName != null)
                    hashCode = hashCode * 59 + this.ClusterName.GetHashCode();
                if (this.CreationTimestamp != null)
                    hashCode = hashCode * 59 + this.CreationTimestamp.GetHashCode();
                if (this.DeletionGracePeriodSeconds != null)
                    hashCode = hashCode * 59 + this.DeletionGracePeriodSeconds.GetHashCode();
                if (this.DeletionTimestamp != null)
                    hashCode = hashCode * 59 + this.DeletionTimestamp.GetHashCode();
                if (this.Finalizers != null)
                    hashCode = hashCode * 59 + this.Finalizers.GetHashCode();
                if (this.GenerateName != null)
                    hashCode = hashCode * 59 + this.GenerateName.GetHashCode();
                if (this.Generation != null)
                    hashCode = hashCode * 59 + this.Generation.GetHashCode();
                if (this.Initializers != null)
                    hashCode = hashCode * 59 + this.Initializers.GetHashCode();
                if (this.Labels != null)
                    hashCode = hashCode * 59 + this.Labels.GetHashCode();
                if (this.ManagedFields != null)
                    hashCode = hashCode * 59 + this.ManagedFields.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Namespace != null)
                    hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.OwnerReferences != null)
                    hashCode = hashCode * 59 + this.OwnerReferences.GetHashCode();
                if (this.ResourceVersion != null)
                    hashCode = hashCode * 59 + this.ResourceVersion.GetHashCode();
                if (this.SelfLink != null)
                    hashCode = hashCode * 59 + this.SelfLink.GetHashCode();
                if (this.Uid != null)
                    hashCode = hashCode * 59 + this.Uid.GetHashCode();
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
