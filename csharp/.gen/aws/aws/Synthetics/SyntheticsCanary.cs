using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Synthetics
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/synthetics_canary aws_synthetics_canary}.</summary>
    [JsiiClass(nativeType: typeof(aws.Synthetics.SyntheticsCanary), fullyQualifiedName: "aws.synthetics.SyntheticsCanary", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.synthetics.SyntheticsCanaryConfig\"}}]")]
    public class SyntheticsCanary : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/synthetics_canary aws_synthetics_canary} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public SyntheticsCanary(Constructs.Construct scope, string id, aws.Synthetics.ISyntheticsCanaryConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SyntheticsCanary(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SyntheticsCanary(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putArtifactConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.synthetics.SyntheticsCanaryArtifactConfig\"}}]")]
        public virtual void PutArtifactConfig(aws.Synthetics.ISyntheticsCanaryArtifactConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Synthetics.ISyntheticsCanaryArtifactConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRunConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.synthetics.SyntheticsCanaryRunConfig\"}}]")]
        public virtual void PutRunConfig(aws.Synthetics.ISyntheticsCanaryRunConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Synthetics.ISyntheticsCanaryRunConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSchedule", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.synthetics.SyntheticsCanarySchedule\"}}]")]
        public virtual void PutSchedule(aws.Synthetics.ISyntheticsCanarySchedule @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Synthetics.ISyntheticsCanarySchedule)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVpcConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.synthetics.SyntheticsCanaryVpcConfig\"}}]")]
        public virtual void PutVpcConfig(aws.Synthetics.ISyntheticsCanaryVpcConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Synthetics.ISyntheticsCanaryVpcConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetArtifactConfig")]
        public virtual void ResetArtifactConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFailureRetentionPeriod")]
        public virtual void ResetFailureRetentionPeriod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRunConfig")]
        public virtual void ResetRunConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3Bucket")]
        public virtual void ResetS3Bucket()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3Key")]
        public virtual void ResetS3Key()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3Version")]
        public virtual void ResetS3Version()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStartCanary")]
        public virtual void ResetStartCanary()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSuccessRetentionPeriod")]
        public virtual void ResetSuccessRetentionPeriod()
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

        [JsiiMethod(name: "resetZipFile")]
        public virtual void ResetZipFile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "timeline", returnsJson: "{\"type\":{\"fqn\":\"aws.synthetics.SyntheticsCanaryTimeline\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Synthetics.SyntheticsCanaryTimeline Timeline(string index)
        {
            return InvokeInstanceMethod<aws.Synthetics.SyntheticsCanaryTimeline>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.Synthetics.SyntheticsCanary))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "artifactConfig", typeJson: "{\"fqn\":\"aws.synthetics.SyntheticsCanaryArtifactConfigOutputReference\"}")]
        public virtual aws.Synthetics.SyntheticsCanaryArtifactConfigOutputReference ArtifactConfig
        {
            get => GetInstanceProperty<aws.Synthetics.SyntheticsCanaryArtifactConfigOutputReference>()!;
        }

        [JsiiProperty(name: "engineArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EngineArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "runConfig", typeJson: "{\"fqn\":\"aws.synthetics.SyntheticsCanaryRunConfigOutputReference\"}")]
        public virtual aws.Synthetics.SyntheticsCanaryRunConfigOutputReference RunConfig
        {
            get => GetInstanceProperty<aws.Synthetics.SyntheticsCanaryRunConfigOutputReference>()!;
        }

        [JsiiProperty(name: "schedule", typeJson: "{\"fqn\":\"aws.synthetics.SyntheticsCanaryScheduleOutputReference\"}")]
        public virtual aws.Synthetics.SyntheticsCanaryScheduleOutputReference Schedule
        {
            get => GetInstanceProperty<aws.Synthetics.SyntheticsCanaryScheduleOutputReference>()!;
        }

        [JsiiProperty(name: "sourceLocationArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceLocationArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vpcConfig", typeJson: "{\"fqn\":\"aws.synthetics.SyntheticsCanaryVpcConfigOutputReference\"}")]
        public virtual aws.Synthetics.SyntheticsCanaryVpcConfigOutputReference VpcConfig
        {
            get => GetInstanceProperty<aws.Synthetics.SyntheticsCanaryVpcConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "artifactConfigInput", typeJson: "{\"fqn\":\"aws.synthetics.SyntheticsCanaryArtifactConfig\"}", isOptional: true)]
        public virtual aws.Synthetics.ISyntheticsCanaryArtifactConfig? ArtifactConfigInput
        {
            get => GetInstanceProperty<aws.Synthetics.ISyntheticsCanaryArtifactConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "artifactS3LocationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ArtifactS3LocationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "executionRoleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExecutionRoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "failureRetentionPeriodInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? FailureRetentionPeriodInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "handlerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HandlerInput
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
        [JsiiProperty(name: "runConfigInput", typeJson: "{\"fqn\":\"aws.synthetics.SyntheticsCanaryRunConfig\"}", isOptional: true)]
        public virtual aws.Synthetics.ISyntheticsCanaryRunConfig? RunConfigInput
        {
            get => GetInstanceProperty<aws.Synthetics.ISyntheticsCanaryRunConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "runtimeVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RuntimeVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3BucketInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? S3BucketInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3KeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? S3KeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3VersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? S3VersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scheduleInput", typeJson: "{\"fqn\":\"aws.synthetics.SyntheticsCanarySchedule\"}", isOptional: true)]
        public virtual aws.Synthetics.ISyntheticsCanarySchedule? ScheduleInput
        {
            get => GetInstanceProperty<aws.Synthetics.ISyntheticsCanarySchedule?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "startCanaryInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? StartCanaryInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "successRetentionPeriodInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SuccessRetentionPeriodInput
        {
            get => GetInstanceProperty<double?>();
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
        [JsiiProperty(name: "vpcConfigInput", typeJson: "{\"fqn\":\"aws.synthetics.SyntheticsCanaryVpcConfig\"}", isOptional: true)]
        public virtual aws.Synthetics.ISyntheticsCanaryVpcConfig? VpcConfigInput
        {
            get => GetInstanceProperty<aws.Synthetics.ISyntheticsCanaryVpcConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "zipFileInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ZipFileInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "artifactS3Location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ArtifactS3Location
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "executionRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExecutionRoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "failureRetentionPeriod", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FailureRetentionPeriod
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "handler", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Handler
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

        [JsiiProperty(name: "runtimeVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RuntimeVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "s3Bucket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S3Bucket
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "s3Key", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S3Key
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "s3Version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S3Version
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "startCanary", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object StartCanary
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "successRetentionPeriod", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SuccessRetentionPeriod
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "zipFile", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ZipFile
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
