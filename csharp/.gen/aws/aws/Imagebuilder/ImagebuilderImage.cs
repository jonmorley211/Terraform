using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Imagebuilder
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/imagebuilder_image aws_imagebuilder_image}.</summary>
    [JsiiClass(nativeType: typeof(aws.Imagebuilder.ImagebuilderImage), fullyQualifiedName: "aws.imagebuilder.ImagebuilderImage", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.imagebuilder.ImagebuilderImageConfig\"}}]")]
    public class ImagebuilderImage : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/imagebuilder_image aws_imagebuilder_image} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ImagebuilderImage(Constructs.Construct scope, string id, aws.Imagebuilder.IImagebuilderImageConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ImagebuilderImage(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ImagebuilderImage(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "outputResources", returnsJson: "{\"type\":{\"fqn\":\"aws.imagebuilder.ImagebuilderImageOutputResources\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Imagebuilder.ImagebuilderImageOutputResources OutputResources(string index)
        {
            return InvokeInstanceMethod<aws.Imagebuilder.ImagebuilderImageOutputResources>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "putImageTestsConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.imagebuilder.ImagebuilderImageImageTestsConfiguration\"}}]")]
        public virtual void PutImageTestsConfiguration(aws.Imagebuilder.IImagebuilderImageImageTestsConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Imagebuilder.IImagebuilderImageImageTestsConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.imagebuilder.ImagebuilderImageTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.Imagebuilder.IImagebuilderImageTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Imagebuilder.IImagebuilderImageTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDistributionConfigurationArn")]
        public virtual void ResetDistributionConfigurationArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnhancedImageMetadataEnabled")]
        public virtual void ResetEnhancedImageMetadataEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetImageTestsConfiguration")]
        public virtual void ResetImageTestsConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTagsAll")]
        public virtual void ResetTagsAll()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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
        = GetStaticProperty<string>(typeof(aws.Imagebuilder.ImagebuilderImage))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dateCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DateCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "imageTestsConfiguration", typeJson: "{\"fqn\":\"aws.imagebuilder.ImagebuilderImageImageTestsConfigurationOutputReference\"}")]
        public virtual aws.Imagebuilder.ImagebuilderImageImageTestsConfigurationOutputReference ImageTestsConfiguration
        {
            get => GetInstanceProperty<aws.Imagebuilder.ImagebuilderImageImageTestsConfigurationOutputReference>()!;
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

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.imagebuilder.ImagebuilderImageTimeoutsOutputReference\"}")]
        public virtual aws.Imagebuilder.ImagebuilderImageTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.Imagebuilder.ImagebuilderImageTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "distributionConfigurationArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DistributionConfigurationArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enhancedImageMetadataEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnhancedImageMetadataEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageRecipeArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ImageRecipeArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageTestsConfigurationInput", typeJson: "{\"fqn\":\"aws.imagebuilder.ImagebuilderImageImageTestsConfiguration\"}", isOptional: true)]
        public virtual aws.Imagebuilder.IImagebuilderImageImageTestsConfiguration? ImageTestsConfigurationInput
        {
            get => GetInstanceProperty<aws.Imagebuilder.IImagebuilderImageImageTestsConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "infrastructureConfigurationArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InfrastructureConfigurationArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsAllInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? TagsAllInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? TagsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.imagebuilder.ImagebuilderImageTimeouts\"}", isOptional: true)]
        public virtual aws.Imagebuilder.IImagebuilderImageTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.Imagebuilder.IImagebuilderImageTimeouts?>();
        }

        [JsiiProperty(name: "distributionConfigurationArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DistributionConfigurationArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enhancedImageMetadataEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object EnhancedImageMetadataEnabled
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "imageRecipeArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageRecipeArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "infrastructureConfigurationArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InfrastructureConfigurationArn
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

        [JsiiProperty(name: "tagsAll", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}")]
        public virtual object TagsAll
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }
    }
}
