using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Mwaa
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/mwaa_environment aws_mwaa_environment}.</summary>
    [JsiiClass(nativeType: typeof(aws.Mwaa.MwaaEnvironment), fullyQualifiedName: "aws.mwaa.MwaaEnvironment", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.mwaa.MwaaEnvironmentConfig\"}}]")]
    public class MwaaEnvironment : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/mwaa_environment aws_mwaa_environment} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public MwaaEnvironment(Constructs.Construct scope, string id, aws.Mwaa.IMwaaEnvironmentConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MwaaEnvironment(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MwaaEnvironment(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "lastUpdated", returnsJson: "{\"type\":{\"fqn\":\"aws.mwaa.MwaaEnvironmentLastUpdated\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Mwaa.MwaaEnvironmentLastUpdated LastUpdated(string index)
        {
            return InvokeInstanceMethod<aws.Mwaa.MwaaEnvironmentLastUpdated>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "putLoggingConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mwaa.MwaaEnvironmentLoggingConfiguration\"}}]")]
        public virtual void PutLoggingConfiguration(aws.Mwaa.IMwaaEnvironmentLoggingConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Mwaa.IMwaaEnvironmentLoggingConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetworkConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mwaa.MwaaEnvironmentNetworkConfiguration\"}}]")]
        public virtual void PutNetworkConfiguration(aws.Mwaa.IMwaaEnvironmentNetworkConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Mwaa.IMwaaEnvironmentNetworkConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAirflowConfigurationOptions")]
        public virtual void ResetAirflowConfigurationOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAirflowVersion")]
        public virtual void ResetAirflowVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnvironmentClass")]
        public virtual void ResetEnvironmentClass()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKmsKey")]
        public virtual void ResetKmsKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLoggingConfiguration")]
        public virtual void ResetLoggingConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxWorkers")]
        public virtual void ResetMaxWorkers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinWorkers")]
        public virtual void ResetMinWorkers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPluginsS3ObjectVersion")]
        public virtual void ResetPluginsS3ObjectVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPluginsS3Path")]
        public virtual void ResetPluginsS3Path()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequirementsS3ObjectVersion")]
        public virtual void ResetRequirementsS3ObjectVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequirementsS3Path")]
        public virtual void ResetRequirementsS3Path()
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

        [JsiiMethod(name: "resetWebserverAccessMode")]
        public virtual void ResetWebserverAccessMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWeeklyMaintenanceWindowStart")]
        public virtual void ResetWeeklyMaintenanceWindowStart()
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
        = GetStaticProperty<string>(typeof(aws.Mwaa.MwaaEnvironment))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

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

        [JsiiProperty(name: "loggingConfiguration", typeJson: "{\"fqn\":\"aws.mwaa.MwaaEnvironmentLoggingConfigurationOutputReference\"}")]
        public virtual aws.Mwaa.MwaaEnvironmentLoggingConfigurationOutputReference LoggingConfiguration
        {
            get => GetInstanceProperty<aws.Mwaa.MwaaEnvironmentLoggingConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "networkConfiguration", typeJson: "{\"fqn\":\"aws.mwaa.MwaaEnvironmentNetworkConfigurationOutputReference\"}")]
        public virtual aws.Mwaa.MwaaEnvironmentNetworkConfigurationOutputReference NetworkConfiguration
        {
            get => GetInstanceProperty<aws.Mwaa.MwaaEnvironmentNetworkConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "serviceRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceRoleArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "webserverUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WebserverUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "airflowConfigurationOptionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? AirflowConfigurationOptionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "airflowVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AirflowVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dagS3PathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DagS3PathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "environmentClassInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EnvironmentClassInput
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
        [JsiiProperty(name: "kmsKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KmsKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loggingConfigurationInput", typeJson: "{\"fqn\":\"aws.mwaa.MwaaEnvironmentLoggingConfiguration\"}", isOptional: true)]
        public virtual aws.Mwaa.IMwaaEnvironmentLoggingConfiguration? LoggingConfigurationInput
        {
            get => GetInstanceProperty<aws.Mwaa.IMwaaEnvironmentLoggingConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxWorkersInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxWorkersInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minWorkersInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinWorkersInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkConfigurationInput", typeJson: "{\"fqn\":\"aws.mwaa.MwaaEnvironmentNetworkConfiguration\"}", isOptional: true)]
        public virtual aws.Mwaa.IMwaaEnvironmentNetworkConfiguration? NetworkConfigurationInput
        {
            get => GetInstanceProperty<aws.Mwaa.IMwaaEnvironmentNetworkConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pluginsS3ObjectVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PluginsS3ObjectVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pluginsS3PathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PluginsS3PathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requirementsS3ObjectVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RequirementsS3ObjectVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requirementsS3PathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RequirementsS3PathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceBucketArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceBucketArnInput
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
        [JsiiProperty(name: "webserverAccessModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WebserverAccessModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "weeklyMaintenanceWindowStartInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WeeklyMaintenanceWindowStartInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "airflowConfigurationOptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}")]
        public virtual object AirflowConfigurationOptions
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "airflowVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AirflowVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dagS3Path", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DagS3Path
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "environmentClass", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EnvironmentClass
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

        [JsiiProperty(name: "kmsKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KmsKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxWorkers", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxWorkers
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minWorkers", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinWorkers
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pluginsS3ObjectVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PluginsS3ObjectVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pluginsS3Path", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PluginsS3Path
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "requirementsS3ObjectVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RequirementsS3ObjectVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "requirementsS3Path", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RequirementsS3Path
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceBucketArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceBucketArn
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

        [JsiiProperty(name: "webserverAccessMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WebserverAccessMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "weeklyMaintenanceWindowStart", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WeeklyMaintenanceWindowStart
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
