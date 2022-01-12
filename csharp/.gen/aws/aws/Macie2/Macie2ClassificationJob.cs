using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Macie2
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/macie2_classification_job aws_macie2_classification_job}.</summary>
    [JsiiClass(nativeType: typeof(aws.Macie2.Macie2ClassificationJob), fullyQualifiedName: "aws.macie2.Macie2ClassificationJob", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.macie2.Macie2ClassificationJobConfig\"}}]")]
    public class Macie2ClassificationJob : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/macie2_classification_job aws_macie2_classification_job} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public Macie2ClassificationJob(Constructs.Construct scope, string id, aws.Macie2.IMacie2ClassificationJobConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Macie2ClassificationJob(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Macie2ClassificationJob(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putS3JobDefinition", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.macie2.Macie2ClassificationJobS3JobDefinition\"}}]")]
        public virtual void PutS3JobDefinition(aws.Macie2.IMacie2ClassificationJobS3JobDefinition @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Macie2.IMacie2ClassificationJobS3JobDefinition)}, new object[]{@value});
        }

        [JsiiMethod(name: "putScheduleFrequency", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.macie2.Macie2ClassificationJobScheduleFrequency\"}}]")]
        public virtual void PutScheduleFrequency(aws.Macie2.IMacie2ClassificationJobScheduleFrequency @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Macie2.IMacie2ClassificationJobScheduleFrequency)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCustomDataIdentifierIds")]
        public virtual void ResetCustomDataIdentifierIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInitialRun")]
        public virtual void ResetInitialRun()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJobStatus")]
        public virtual void ResetJobStatus()
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

        [JsiiMethod(name: "resetSamplingPercentage")]
        public virtual void ResetSamplingPercentage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScheduleFrequency")]
        public virtual void ResetScheduleFrequency()
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

        [JsiiMethod(name: "userPausedDetails", returnsJson: "{\"type\":{\"fqn\":\"aws.macie2.Macie2ClassificationJobUserPausedDetails\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Macie2.Macie2ClassificationJobUserPausedDetails UserPausedDetails(string index)
        {
            return InvokeInstanceMethod<aws.Macie2.Macie2ClassificationJobUserPausedDetails>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.Macie2.Macie2ClassificationJob))!;

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "jobArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JobArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "jobId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JobId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "s3JobDefinition", typeJson: "{\"fqn\":\"aws.macie2.Macie2ClassificationJobS3JobDefinitionOutputReference\"}")]
        public virtual aws.Macie2.Macie2ClassificationJobS3JobDefinitionOutputReference S3JobDefinition
        {
            get => GetInstanceProperty<aws.Macie2.Macie2ClassificationJobS3JobDefinitionOutputReference>()!;
        }

        [JsiiProperty(name: "scheduleFrequency", typeJson: "{\"fqn\":\"aws.macie2.Macie2ClassificationJobScheduleFrequencyOutputReference\"}")]
        public virtual aws.Macie2.Macie2ClassificationJobScheduleFrequencyOutputReference ScheduleFrequency
        {
            get => GetInstanceProperty<aws.Macie2.Macie2ClassificationJobScheduleFrequencyOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "customDataIdentifierIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? CustomDataIdentifierIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "initialRunInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? InitialRunInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jobStatusInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? JobStatusInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jobTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? JobTypeInput
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
        [JsiiProperty(name: "namePrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NamePrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3JobDefinitionInput", typeJson: "{\"fqn\":\"aws.macie2.Macie2ClassificationJobS3JobDefinition\"}", isOptional: true)]
        public virtual aws.Macie2.IMacie2ClassificationJobS3JobDefinition? S3JobDefinitionInput
        {
            get => GetInstanceProperty<aws.Macie2.IMacie2ClassificationJobS3JobDefinition?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "samplingPercentageInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SamplingPercentageInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scheduleFrequencyInput", typeJson: "{\"fqn\":\"aws.macie2.Macie2ClassificationJobScheduleFrequency\"}", isOptional: true)]
        public virtual aws.Macie2.IMacie2ClassificationJobScheduleFrequency? ScheduleFrequencyInput
        {
            get => GetInstanceProperty<aws.Macie2.IMacie2ClassificationJobScheduleFrequency?>();
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

        [JsiiProperty(name: "customDataIdentifierIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] CustomDataIdentifierIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "initialRun", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object InitialRun
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "jobStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JobStatus
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "jobType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JobType
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

        [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NamePrefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "samplingPercentage", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SamplingPercentage
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
    }
}
