using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudwatch
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_metric_stream aws_cloudwatch_metric_stream}.</summary>
    [JsiiClass(nativeType: typeof(aws.Cloudwatch.CloudwatchMetricStream), fullyQualifiedName: "aws.cloudwatch.CloudwatchMetricStream", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.cloudwatch.CloudwatchMetricStreamConfig\"}}]")]
    public class CloudwatchMetricStream : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_metric_stream aws_cloudwatch_metric_stream} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public CloudwatchMetricStream(Constructs.Construct scope, string id, aws.Cloudwatch.ICloudwatchMetricStreamConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudwatchMetricStream(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudwatchMetricStream(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudwatch.CloudwatchMetricStreamTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.Cloudwatch.ICloudwatchMetricStreamTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Cloudwatch.ICloudwatchMetricStreamTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetExcludeFilter")]
        public virtual void ResetExcludeFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIncludeFilter")]
        public virtual void ResetIncludeFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNamePrefix")]
        public virtual void ResetNamePrefix()
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
        = GetStaticProperty<string>(typeof(aws.Cloudwatch.CloudwatchMetricStream))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "creationDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreationDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastUpdateDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastUpdateDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.cloudwatch.CloudwatchMetricStreamTimeoutsOutputReference\"}")]
        public virtual aws.Cloudwatch.CloudwatchMetricStreamTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.Cloudwatch.CloudwatchMetricStreamTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "excludeFilterInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatch.CloudwatchMetricStreamExcludeFilter\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Cloudwatch.ICloudwatchMetricStreamExcludeFilter[]? ExcludeFilterInput
        {
            get => GetInstanceProperty<aws.Cloudwatch.ICloudwatchMetricStreamExcludeFilter[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "firehoseArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FirehoseArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "includeFilterInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatch.CloudwatchMetricStreamIncludeFilter\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Cloudwatch.ICloudwatchMetricStreamIncludeFilter[]? IncludeFilterInput
        {
            get => GetInstanceProperty<aws.Cloudwatch.ICloudwatchMetricStreamIncludeFilter[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "namePrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NamePrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "outputFormatInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OutputFormatInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "roleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoleArnInput
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.cloudwatch.CloudwatchMetricStreamTimeouts\"}", isOptional: true)]
        public virtual aws.Cloudwatch.ICloudwatchMetricStreamTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.Cloudwatch.ICloudwatchMetricStreamTimeouts?>();
        }

        [JsiiProperty(name: "excludeFilter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatch.CloudwatchMetricStreamExcludeFilter\"},\"kind\":\"array\"}}")]
        public virtual aws.Cloudwatch.ICloudwatchMetricStreamExcludeFilter[] ExcludeFilter
        {
            get => GetInstanceProperty<aws.Cloudwatch.ICloudwatchMetricStreamExcludeFilter[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "firehoseArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FirehoseArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "includeFilter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatch.CloudwatchMetricStreamIncludeFilter\"},\"kind\":\"array\"}}")]
        public virtual aws.Cloudwatch.ICloudwatchMetricStreamIncludeFilter[] IncludeFilter
        {
            get => GetInstanceProperty<aws.Cloudwatch.ICloudwatchMetricStreamIncludeFilter[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NamePrefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "outputFormat", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OutputFormat
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoleArn
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
