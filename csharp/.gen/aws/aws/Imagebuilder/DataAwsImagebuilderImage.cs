using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Imagebuilder
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/d/imagebuilder_image aws_imagebuilder_image}.</summary>
    [JsiiClass(nativeType: typeof(aws.Imagebuilder.DataAwsImagebuilderImage), fullyQualifiedName: "aws.imagebuilder.DataAwsImagebuilderImage", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.imagebuilder.DataAwsImagebuilderImageConfig\"}}]")]
    public class DataAwsImagebuilderImage : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/d/imagebuilder_image aws_imagebuilder_image} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsImagebuilderImage(Constructs.Construct scope, string id, aws.Imagebuilder.IDataAwsImagebuilderImageConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsImagebuilderImage(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsImagebuilderImage(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "imageTestsConfiguration", returnsJson: "{\"type\":{\"fqn\":\"aws.imagebuilder.DataAwsImagebuilderImageImageTestsConfiguration\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Imagebuilder.DataAwsImagebuilderImageImageTestsConfiguration ImageTestsConfiguration(string index)
        {
            return InvokeInstanceMethod<aws.Imagebuilder.DataAwsImagebuilderImageImageTestsConfiguration>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "outputResources", returnsJson: "{\"type\":{\"fqn\":\"aws.imagebuilder.DataAwsImagebuilderImageOutputResources\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Imagebuilder.DataAwsImagebuilderImageOutputResources OutputResources(string index)
        {
            return InvokeInstanceMethod<aws.Imagebuilder.DataAwsImagebuilderImageOutputResources>(new System.Type[]{typeof(string)}, new object[]{index})!;
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
        = GetStaticProperty<string>(typeof(aws.Imagebuilder.DataAwsImagebuilderImage))!;

        [JsiiProperty(name: "buildVersionArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BuildVersionArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dateCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DateCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "distributionConfigurationArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DistributionConfigurationArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enhancedImageMetadataEnabled", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object EnhancedImageMetadataEnabled
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "imageRecipeArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageRecipeArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "infrastructureConfigurationArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InfrastructureConfigurationArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "osVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OsVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "platform", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Platform
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "arnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? TagsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
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
