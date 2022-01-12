using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_intelligent_tiering_configuration aws_s3_bucket_intelligent_tiering_configuration}.</summary>
    [JsiiClass(nativeType: typeof(aws.S3.S3BucketIntelligentTieringConfiguration), fullyQualifiedName: "aws.s3.S3BucketIntelligentTieringConfiguration", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.s3.S3BucketIntelligentTieringConfigurationConfig\"}}]")]
    public class S3BucketIntelligentTieringConfiguration : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_intelligent_tiering_configuration aws_s3_bucket_intelligent_tiering_configuration} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public S3BucketIntelligentTieringConfiguration(Constructs.Construct scope, string id, aws.S3.IS3BucketIntelligentTieringConfigurationConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketIntelligentTieringConfiguration(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketIntelligentTieringConfiguration(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3.S3BucketIntelligentTieringConfigurationFilter\"}}]")]
        public virtual void PutFilter(aws.S3.IS3BucketIntelligentTieringConfigurationFilter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3.IS3BucketIntelligentTieringConfigurationFilter)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetFilter")]
        public virtual void ResetFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStatus")]
        public virtual void ResetStatus()
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
        = GetStaticProperty<string>(typeof(aws.S3.S3BucketIntelligentTieringConfiguration))!;

        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"aws.s3.S3BucketIntelligentTieringConfigurationFilterOutputReference\"}")]
        public virtual aws.S3.S3BucketIntelligentTieringConfigurationFilterOutputReference Filter
        {
            get => GetInstanceProperty<aws.S3.S3BucketIntelligentTieringConfigurationFilterOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bucketInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BucketInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"fqn\":\"aws.s3.S3BucketIntelligentTieringConfigurationFilter\"}", isOptional: true)]
        public virtual aws.S3.IS3BucketIntelligentTieringConfigurationFilter? FilterInput
        {
            get => GetInstanceProperty<aws.S3.IS3BucketIntelligentTieringConfigurationFilter?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "statusInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StatusInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tieringInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3.S3BucketIntelligentTieringConfigurationTiering\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.S3.IS3BucketIntelligentTieringConfigurationTiering[]? TieringInput
        {
            get => GetInstanceProperty<aws.S3.IS3BucketIntelligentTieringConfigurationTiering[]?>();
        }

        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Bucket
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tiering", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3.S3BucketIntelligentTieringConfigurationTiering\"},\"kind\":\"array\"}}")]
        public virtual aws.S3.IS3BucketIntelligentTieringConfigurationTiering[] Tiering
        {
            get => GetInstanceProperty<aws.S3.IS3BucketIntelligentTieringConfigurationTiering[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
