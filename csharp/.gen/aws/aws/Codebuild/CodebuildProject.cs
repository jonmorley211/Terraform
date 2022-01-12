using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codebuild
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project aws_codebuild_project}.</summary>
    [JsiiClass(nativeType: typeof(aws.Codebuild.CodebuildProject), fullyQualifiedName: "aws.codebuild.CodebuildProject", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.codebuild.CodebuildProjectConfig\"}}]")]
    public class CodebuildProject : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project aws_codebuild_project} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public CodebuildProject(Constructs.Construct scope, string id, aws.Codebuild.ICodebuildProjectConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodebuildProject(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodebuildProject(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putArtifacts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codebuild.CodebuildProjectArtifacts\"}}]")]
        public virtual void PutArtifacts(aws.Codebuild.ICodebuildProjectArtifacts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Codebuild.ICodebuildProjectArtifacts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBuildBatchConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codebuild.CodebuildProjectBuildBatchConfig\"}}]")]
        public virtual void PutBuildBatchConfig(aws.Codebuild.ICodebuildProjectBuildBatchConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Codebuild.ICodebuildProjectBuildBatchConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCache", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codebuild.CodebuildProjectCache\"}}]")]
        public virtual void PutCache(aws.Codebuild.ICodebuildProjectCache @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Codebuild.ICodebuildProjectCache)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEnvironment", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codebuild.CodebuildProjectEnvironment\"}}]")]
        public virtual void PutEnvironment(aws.Codebuild.ICodebuildProjectEnvironment @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Codebuild.ICodebuildProjectEnvironment)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLogsConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codebuild.CodebuildProjectLogsConfig\"}}]")]
        public virtual void PutLogsConfig(aws.Codebuild.ICodebuildProjectLogsConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Codebuild.ICodebuildProjectLogsConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSource", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codebuild.CodebuildProjectSource\"}}]")]
        public virtual void PutSource(aws.Codebuild.ICodebuildProjectSource @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Codebuild.ICodebuildProjectSource)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVpcConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codebuild.CodebuildProjectVpcConfig\"}}]")]
        public virtual void PutVpcConfig(aws.Codebuild.ICodebuildProjectVpcConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Codebuild.ICodebuildProjectVpcConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBadgeEnabled")]
        public virtual void ResetBadgeEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBuildBatchConfig")]
        public virtual void ResetBuildBatchConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBuildTimeout")]
        public virtual void ResetBuildTimeout()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCache")]
        public virtual void ResetCache()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConcurrentBuildLimit")]
        public virtual void ResetConcurrentBuildLimit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEncryptionKey")]
        public virtual void ResetEncryptionKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFileSystemLocations")]
        public virtual void ResetFileSystemLocations()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogsConfig")]
        public virtual void ResetLogsConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProjectVisibility")]
        public virtual void ResetProjectVisibility()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQueuedTimeout")]
        public virtual void ResetQueuedTimeout()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceAccessRole")]
        public virtual void ResetResourceAccessRole()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecondaryArtifacts")]
        public virtual void ResetSecondaryArtifacts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecondarySources")]
        public virtual void ResetSecondarySources()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecondarySourceVersion")]
        public virtual void ResetSecondarySourceVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceVersion")]
        public virtual void ResetSourceVersion()
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

        [JsiiMethod(name: "resetVpcConfig")]
        public virtual void ResetVpcConfig()
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
        = GetStaticProperty<string>(typeof(aws.Codebuild.CodebuildProject))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "artifacts", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectArtifactsOutputReference\"}")]
        public virtual aws.Codebuild.CodebuildProjectArtifactsOutputReference Artifacts
        {
            get => GetInstanceProperty<aws.Codebuild.CodebuildProjectArtifactsOutputReference>()!;
        }

        [JsiiProperty(name: "badgeUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BadgeUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "buildBatchConfig", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectBuildBatchConfigOutputReference\"}")]
        public virtual aws.Codebuild.CodebuildProjectBuildBatchConfigOutputReference BuildBatchConfig
        {
            get => GetInstanceProperty<aws.Codebuild.CodebuildProjectBuildBatchConfigOutputReference>()!;
        }

        [JsiiProperty(name: "cache", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectCacheOutputReference\"}")]
        public virtual aws.Codebuild.CodebuildProjectCacheOutputReference Cache
        {
            get => GetInstanceProperty<aws.Codebuild.CodebuildProjectCacheOutputReference>()!;
        }

        [JsiiProperty(name: "environment", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectEnvironmentOutputReference\"}")]
        public virtual aws.Codebuild.CodebuildProjectEnvironmentOutputReference Environment
        {
            get => GetInstanceProperty<aws.Codebuild.CodebuildProjectEnvironmentOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "logsConfig", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectLogsConfigOutputReference\"}")]
        public virtual aws.Codebuild.CodebuildProjectLogsConfigOutputReference LogsConfig
        {
            get => GetInstanceProperty<aws.Codebuild.CodebuildProjectLogsConfigOutputReference>()!;
        }

        [JsiiProperty(name: "publicProjectAlias", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublicProjectAlias
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectSourceOutputReference\"}")]
        public virtual aws.Codebuild.CodebuildProjectSourceOutputReference Source
        {
            get => GetInstanceProperty<aws.Codebuild.CodebuildProjectSourceOutputReference>()!;
        }

        [JsiiProperty(name: "vpcConfig", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectVpcConfigOutputReference\"}")]
        public virtual aws.Codebuild.CodebuildProjectVpcConfigOutputReference VpcConfig
        {
            get => GetInstanceProperty<aws.Codebuild.CodebuildProjectVpcConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "artifactsInput", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectArtifacts\"}", isOptional: true)]
        public virtual aws.Codebuild.ICodebuildProjectArtifacts? ArtifactsInput
        {
            get => GetInstanceProperty<aws.Codebuild.ICodebuildProjectArtifacts?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "badgeEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? BadgeEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "buildBatchConfigInput", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectBuildBatchConfig\"}", isOptional: true)]
        public virtual aws.Codebuild.ICodebuildProjectBuildBatchConfig? BuildBatchConfigInput
        {
            get => GetInstanceProperty<aws.Codebuild.ICodebuildProjectBuildBatchConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "buildTimeoutInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BuildTimeoutInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cacheInput", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectCache\"}", isOptional: true)]
        public virtual aws.Codebuild.ICodebuildProjectCache? CacheInput
        {
            get => GetInstanceProperty<aws.Codebuild.ICodebuildProjectCache?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "concurrentBuildLimitInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ConcurrentBuildLimitInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptionKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EncryptionKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "environmentInput", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectEnvironment\"}", isOptional: true)]
        public virtual aws.Codebuild.ICodebuildProjectEnvironment? EnvironmentInput
        {
            get => GetInstanceProperty<aws.Codebuild.ICodebuildProjectEnvironment?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fileSystemLocationsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codebuild.CodebuildProjectFileSystemLocations\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Codebuild.ICodebuildProjectFileSystemLocations[]? FileSystemLocationsInput
        {
            get => GetInstanceProperty<aws.Codebuild.ICodebuildProjectFileSystemLocations[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logsConfigInput", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectLogsConfig\"}", isOptional: true)]
        public virtual aws.Codebuild.ICodebuildProjectLogsConfig? LogsConfigInput
        {
            get => GetInstanceProperty<aws.Codebuild.ICodebuildProjectLogsConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "projectVisibilityInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProjectVisibilityInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queuedTimeoutInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? QueuedTimeoutInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceAccessRoleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceAccessRoleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "secondaryArtifactsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codebuild.CodebuildProjectSecondaryArtifacts\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Codebuild.ICodebuildProjectSecondaryArtifacts[]? SecondaryArtifactsInput
        {
            get => GetInstanceProperty<aws.Codebuild.ICodebuildProjectSecondaryArtifacts[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "secondarySourcesInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codebuild.CodebuildProjectSecondarySources\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Codebuild.ICodebuildProjectSecondarySources[]? SecondarySourcesInput
        {
            get => GetInstanceProperty<aws.Codebuild.ICodebuildProjectSecondarySources[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "secondarySourceVersionInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codebuild.CodebuildProjectSecondarySourceVersion\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Codebuild.ICodebuildProjectSecondarySourceVersion[]? SecondarySourceVersionInput
        {
            get => GetInstanceProperty<aws.Codebuild.ICodebuildProjectSecondarySourceVersion[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceRoleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceRoleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceInput", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectSource\"}", isOptional: true)]
        public virtual aws.Codebuild.ICodebuildProjectSource? SourceInput
        {
            get => GetInstanceProperty<aws.Codebuild.ICodebuildProjectSource?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceVersionInput
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
        [JsiiProperty(name: "vpcConfigInput", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectVpcConfig\"}", isOptional: true)]
        public virtual aws.Codebuild.ICodebuildProjectVpcConfig? VpcConfigInput
        {
            get => GetInstanceProperty<aws.Codebuild.ICodebuildProjectVpcConfig?>();
        }

        [JsiiProperty(name: "badgeEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object BadgeEnabled
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "buildTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BuildTimeout
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "concurrentBuildLimit", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ConcurrentBuildLimit
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "encryptionKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EncryptionKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "fileSystemLocations", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codebuild.CodebuildProjectFileSystemLocations\"},\"kind\":\"array\"}}")]
        public virtual aws.Codebuild.ICodebuildProjectFileSystemLocations[] FileSystemLocations
        {
            get => GetInstanceProperty<aws.Codebuild.ICodebuildProjectFileSystemLocations[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "projectVisibility", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProjectVisibility
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "queuedTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double QueuedTimeout
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceAccessRole", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceAccessRole
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "secondaryArtifacts", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codebuild.CodebuildProjectSecondaryArtifacts\"},\"kind\":\"array\"}}")]
        public virtual aws.Codebuild.ICodebuildProjectSecondaryArtifacts[] SecondaryArtifacts
        {
            get => GetInstanceProperty<aws.Codebuild.ICodebuildProjectSecondaryArtifacts[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "secondarySources", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codebuild.CodebuildProjectSecondarySources\"},\"kind\":\"array\"}}")]
        public virtual aws.Codebuild.ICodebuildProjectSecondarySources[] SecondarySources
        {
            get => GetInstanceProperty<aws.Codebuild.ICodebuildProjectSecondarySources[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "secondarySourceVersion", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codebuild.CodebuildProjectSecondarySourceVersion\"},\"kind\":\"array\"}}")]
        public virtual aws.Codebuild.ICodebuildProjectSecondarySourceVersion[] SecondarySourceVersion
        {
            get => GetInstanceProperty<aws.Codebuild.ICodebuildProjectSecondarySourceVersion[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceRole", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceRole
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceVersion
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
