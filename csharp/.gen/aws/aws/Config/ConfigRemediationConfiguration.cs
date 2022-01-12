using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Config
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/config_remediation_configuration aws_config_remediation_configuration}.</summary>
    [JsiiClass(nativeType: typeof(aws.Config.ConfigRemediationConfiguration), fullyQualifiedName: "aws.config.ConfigRemediationConfiguration", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.config.ConfigRemediationConfigurationConfig\"}}]")]
    public class ConfigRemediationConfiguration : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/config_remediation_configuration aws_config_remediation_configuration} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ConfigRemediationConfiguration(Constructs.Construct scope, string id, aws.Config.IConfigRemediationConfigurationConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ConfigRemediationConfiguration(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ConfigRemediationConfiguration(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putExecutionControls", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.config.ConfigRemediationConfigurationExecutionControls\"}}]")]
        public virtual void PutExecutionControls(aws.Config.IConfigRemediationConfigurationExecutionControls @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Config.IConfigRemediationConfigurationExecutionControls)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAutomatic")]
        public virtual void ResetAutomatic()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExecutionControls")]
        public virtual void ResetExecutionControls()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaximumAutomaticAttempts")]
        public virtual void ResetMaximumAutomaticAttempts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetParameter")]
        public virtual void ResetParameter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceType")]
        public virtual void ResetResourceType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRetryAttemptSeconds")]
        public virtual void ResetRetryAttemptSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetVersion")]
        public virtual void ResetTargetVersion()
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
        = GetStaticProperty<string>(typeof(aws.Config.ConfigRemediationConfiguration))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "executionControls", typeJson: "{\"fqn\":\"aws.config.ConfigRemediationConfigurationExecutionControlsOutputReference\"}")]
        public virtual aws.Config.ConfigRemediationConfigurationExecutionControlsOutputReference ExecutionControls
        {
            get => GetInstanceProperty<aws.Config.ConfigRemediationConfigurationExecutionControlsOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "automaticInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AutomaticInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "configRuleNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConfigRuleNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "executionControlsInput", typeJson: "{\"fqn\":\"aws.config.ConfigRemediationConfigurationExecutionControls\"}", isOptional: true)]
        public virtual aws.Config.IConfigRemediationConfigurationExecutionControls? ExecutionControlsInput
        {
            get => GetInstanceProperty<aws.Config.IConfigRemediationConfigurationExecutionControls?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maximumAutomaticAttemptsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaximumAutomaticAttemptsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "parameterInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.config.ConfigRemediationConfigurationParameter\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Config.IConfigRemediationConfigurationParameter[]? ParameterInput
        {
            get => GetInstanceProperty<aws.Config.IConfigRemediationConfigurationParameter[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "retryAttemptSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? RetryAttemptSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "automatic", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object Automatic
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "configRuleName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigRuleName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maximumAutomaticAttempts", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaximumAutomaticAttempts
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "parameter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.config.ConfigRemediationConfigurationParameter\"},\"kind\":\"array\"}}")]
        public virtual aws.Config.IConfigRemediationConfigurationParameter[] Parameter
        {
            get => GetInstanceProperty<aws.Config.IConfigRemediationConfigurationParameter[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "retryAttemptSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RetryAttemptSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
