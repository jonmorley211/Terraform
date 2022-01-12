using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Resourcegroups
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/d/resourcegroupstaggingapi_resources aws_resourcegroupstaggingapi_resources}.</summary>
    [JsiiClass(nativeType: typeof(aws.Resourcegroups.DataAwsResourcegroupstaggingapiResources), fullyQualifiedName: "aws.resourcegroups.DataAwsResourcegroupstaggingapiResources", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"aws.resourcegroups.DataAwsResourcegroupstaggingapiResourcesConfig\"}}]")]
    public class DataAwsResourcegroupstaggingapiResources : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/d/resourcegroupstaggingapi_resources aws_resourcegroupstaggingapi_resources} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsResourcegroupstaggingapiResources(Constructs.Construct scope, string id, aws.Resourcegroups.IDataAwsResourcegroupstaggingapiResourcesConfig? config = null): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsResourcegroupstaggingapiResources(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsResourcegroupstaggingapiResources(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetExcludeCompliantResources")]
        public virtual void ResetExcludeCompliantResources()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIncludeComplianceDetails")]
        public virtual void ResetIncludeComplianceDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceArnList")]
        public virtual void ResetResourceArnList()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceTypeFilters")]
        public virtual void ResetResourceTypeFilters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTagFilter")]
        public virtual void ResetTagFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resourceTagMappingList", returnsJson: "{\"type\":{\"fqn\":\"aws.resourcegroups.DataAwsResourcegroupstaggingapiResourcesResourceTagMappingList\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Resourcegroups.DataAwsResourcegroupstaggingapiResourcesResourceTagMappingList ResourceTagMappingList(string index)
        {
            return InvokeInstanceMethod<aws.Resourcegroups.DataAwsResourcegroupstaggingapiResourcesResourceTagMappingList>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.Resourcegroups.DataAwsResourcegroupstaggingapiResources))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "excludeCompliantResourcesInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ExcludeCompliantResourcesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "includeComplianceDetailsInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IncludeComplianceDetailsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceArnListInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ResourceArnListInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceTypeFiltersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ResourceTypeFiltersInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagFilterInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.resourcegroups.DataAwsResourcegroupstaggingapiResourcesTagFilter\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Resourcegroups.IDataAwsResourcegroupstaggingapiResourcesTagFilter[]? TagFilterInput
        {
            get => GetInstanceProperty<aws.Resourcegroups.IDataAwsResourcegroupstaggingapiResourcesTagFilter[]?>();
        }

        [JsiiProperty(name: "excludeCompliantResources", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object ExcludeCompliantResources
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "includeComplianceDetails", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object IncludeComplianceDetails
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceArnList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ResourceArnList
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceTypeFilters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ResourceTypeFilters
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tagFilter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.resourcegroups.DataAwsResourcegroupstaggingapiResourcesTagFilter\"},\"kind\":\"array\"}}")]
        public virtual aws.Resourcegroups.IDataAwsResourcegroupstaggingapiResourcesTagFilter[] TagFilter
        {
            get => GetInstanceProperty<aws.Resourcegroups.IDataAwsResourcegroupstaggingapiResourcesTagFilter[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
