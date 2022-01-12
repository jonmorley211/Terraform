using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Imagebuilder
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/imagebuilder_image_pipeline aws_imagebuilder_image_pipeline}.</summary>
    [JsiiClass(nativeType: typeof(aws.Imagebuilder.ImagebuilderImagePipeline), fullyQualifiedName: "aws.imagebuilder.ImagebuilderImagePipeline", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.imagebuilder.ImagebuilderImagePipelineConfig\"}}]")]
    public class ImagebuilderImagePipeline : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/imagebuilder_image_pipeline aws_imagebuilder_image_pipeline} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ImagebuilderImagePipeline(Constructs.Construct scope, string id, aws.Imagebuilder.IImagebuilderImagePipelineConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ImagebuilderImagePipeline(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ImagebuilderImagePipeline(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putImageTestsConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.imagebuilder.ImagebuilderImagePipelineImageTestsConfiguration\"}}]")]
        public virtual void PutImageTestsConfiguration(aws.Imagebuilder.IImagebuilderImagePipelineImageTestsConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Imagebuilder.IImagebuilderImagePipelineImageTestsConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSchedule", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.imagebuilder.ImagebuilderImagePipelineSchedule\"}}]")]
        public virtual void PutSchedule(aws.Imagebuilder.IImagebuilderImagePipelineSchedule @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Imagebuilder.IImagebuilderImagePipelineSchedule)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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

        [JsiiMethod(name: "resetSchedule")]
        public virtual void ResetSchedule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStatus")]
        public virtual void ResetStatus()
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
        = GetStaticProperty<string>(typeof(aws.Imagebuilder.ImagebuilderImagePipeline))!;

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

        [JsiiProperty(name: "dateLastRun", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DateLastRun
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dateNextRun", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DateNextRun
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dateUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DateUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "imageTestsConfiguration", typeJson: "{\"fqn\":\"aws.imagebuilder.ImagebuilderImagePipelineImageTestsConfigurationOutputReference\"}")]
        public virtual aws.Imagebuilder.ImagebuilderImagePipelineImageTestsConfigurationOutputReference ImageTestsConfiguration
        {
            get => GetInstanceProperty<aws.Imagebuilder.ImagebuilderImagePipelineImageTestsConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "platform", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Platform
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "schedule", typeJson: "{\"fqn\":\"aws.imagebuilder.ImagebuilderImagePipelineScheduleOutputReference\"}")]
        public virtual aws.Imagebuilder.ImagebuilderImagePipelineScheduleOutputReference Schedule
        {
            get => GetInstanceProperty<aws.Imagebuilder.ImagebuilderImagePipelineScheduleOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
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
        [JsiiProperty(name: "imageTestsConfigurationInput", typeJson: "{\"fqn\":\"aws.imagebuilder.ImagebuilderImagePipelineImageTestsConfiguration\"}", isOptional: true)]
        public virtual aws.Imagebuilder.IImagebuilderImagePipelineImageTestsConfiguration? ImageTestsConfigurationInput
        {
            get => GetInstanceProperty<aws.Imagebuilder.IImagebuilderImagePipelineImageTestsConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "infrastructureConfigurationArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InfrastructureConfigurationArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scheduleInput", typeJson: "{\"fqn\":\"aws.imagebuilder.ImagebuilderImagePipelineSchedule\"}", isOptional: true)]
        public virtual aws.Imagebuilder.IImagebuilderImagePipelineSchedule? ScheduleInput
        {
            get => GetInstanceProperty<aws.Imagebuilder.IImagebuilderImagePipelineSchedule?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "statusInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StatusInput
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

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
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
