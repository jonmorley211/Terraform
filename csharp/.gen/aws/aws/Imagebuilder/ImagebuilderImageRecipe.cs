using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Imagebuilder
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/imagebuilder_image_recipe aws_imagebuilder_image_recipe}.</summary>
    [JsiiClass(nativeType: typeof(aws.Imagebuilder.ImagebuilderImageRecipe), fullyQualifiedName: "aws.imagebuilder.ImagebuilderImageRecipe", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.imagebuilder.ImagebuilderImageRecipeConfig\"}}]")]
    public class ImagebuilderImageRecipe : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/imagebuilder_image_recipe aws_imagebuilder_image_recipe} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ImagebuilderImageRecipe(Constructs.Construct scope, string id, aws.Imagebuilder.IImagebuilderImageRecipeConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ImagebuilderImageRecipe(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ImagebuilderImageRecipe(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetBlockDeviceMapping")]
        public virtual void ResetBlockDeviceMapping()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
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

        [JsiiMethod(name: "resetWorkingDirectory")]
        public virtual void ResetWorkingDirectory()
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
        = GetStaticProperty<string>(typeof(aws.Imagebuilder.ImagebuilderImageRecipe))!;

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

        [JsiiProperty(name: "owner", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Owner
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "platform", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Platform
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "blockDeviceMappingInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.imagebuilder.ImagebuilderImageRecipeBlockDeviceMapping\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Imagebuilder.IImagebuilderImageRecipeBlockDeviceMapping[]? BlockDeviceMappingInput
        {
            get => GetInstanceProperty<aws.Imagebuilder.IImagebuilderImageRecipeBlockDeviceMapping[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "componentInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.imagebuilder.ImagebuilderImageRecipeComponent\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Imagebuilder.IImagebuilderImageRecipeComponent[]? ComponentInput
        {
            get => GetInstanceProperty<aws.Imagebuilder.IImagebuilderImageRecipeComponent[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
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
        [JsiiProperty(name: "parentImageInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ParentImageInput
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
        [JsiiProperty(name: "versionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workingDirectoryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WorkingDirectoryInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "blockDeviceMapping", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.imagebuilder.ImagebuilderImageRecipeBlockDeviceMapping\"},\"kind\":\"array\"}}")]
        public virtual aws.Imagebuilder.IImagebuilderImageRecipeBlockDeviceMapping[] BlockDeviceMapping
        {
            get => GetInstanceProperty<aws.Imagebuilder.IImagebuilderImageRecipeBlockDeviceMapping[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "component", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.imagebuilder.ImagebuilderImageRecipeComponent\"},\"kind\":\"array\"}}")]
        public virtual aws.Imagebuilder.IImagebuilderImageRecipeComponent[] Component
        {
            get => GetInstanceProperty<aws.Imagebuilder.IImagebuilderImageRecipeComponent[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
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

        [JsiiProperty(name: "parentImage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParentImage
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

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "workingDirectory", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkingDirectory
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
