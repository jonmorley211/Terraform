using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/d/ec2_managed_prefix_list aws_ec2_managed_prefix_list}.</summary>
    [JsiiClass(nativeType: typeof(aws.Ec2.DataAwsEc2ManagedPrefixList), fullyQualifiedName: "aws.ec2.DataAwsEc2ManagedPrefixList", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"aws.ec2.DataAwsEc2ManagedPrefixListConfig\"}}]")]
    public class DataAwsEc2ManagedPrefixList : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/d/ec2_managed_prefix_list aws_ec2_managed_prefix_list} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsEc2ManagedPrefixList(Constructs.Construct scope, string id, aws.Ec2.IDataAwsEc2ManagedPrefixListConfig? config = null): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsEc2ManagedPrefixList(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsEc2ManagedPrefixList(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "entries", returnsJson: "{\"type\":{\"fqn\":\"aws.ec2.DataAwsEc2ManagedPrefixListEntries\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Ec2.DataAwsEc2ManagedPrefixListEntries Entries(string index)
        {
            return InvokeInstanceMethod<aws.Ec2.DataAwsEc2ManagedPrefixListEntries>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "resetFilter")]
        public virtual void ResetFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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
        = GetStaticProperty<string>(typeof(aws.Ec2.DataAwsEc2ManagedPrefixList))!;

        [JsiiProperty(name: "addressFamily", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AddressFamily
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maxEntries", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxEntries
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "ownerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OwnerId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Version
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.DataAwsEc2ManagedPrefixListFilter\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Ec2.IDataAwsEc2ManagedPrefixListFilter[]? FilterInput
        {
            get => GetInstanceProperty<aws.Ec2.IDataAwsEc2ManagedPrefixListFilter[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? TagsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "filter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.DataAwsEc2ManagedPrefixListFilter\"},\"kind\":\"array\"}}")]
        public virtual aws.Ec2.IDataAwsEc2ManagedPrefixListFilter[] Filter
        {
            get => GetInstanceProperty<aws.Ec2.IDataAwsEc2ManagedPrefixListFilter[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}")]
        public virtual object Tags
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }
    }
}
