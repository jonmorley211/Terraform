using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sfn
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/sfn_state_machine aws_sfn_state_machine}.</summary>
    [JsiiClass(nativeType: typeof(aws.Sfn.SfnStateMachine), fullyQualifiedName: "aws.sfn.SfnStateMachine", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.sfn.SfnStateMachineConfig\"}}]")]
    public class SfnStateMachine : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/sfn_state_machine aws_sfn_state_machine} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public SfnStateMachine(Constructs.Construct scope, string id, aws.Sfn.ISfnStateMachineConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SfnStateMachine(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SfnStateMachine(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putLoggingConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sfn.SfnStateMachineLoggingConfiguration\"}}]")]
        public virtual void PutLoggingConfiguration(aws.Sfn.ISfnStateMachineLoggingConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Sfn.ISfnStateMachineLoggingConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTracingConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sfn.SfnStateMachineTracingConfiguration\"}}]")]
        public virtual void PutTracingConfiguration(aws.Sfn.ISfnStateMachineTracingConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Sfn.ISfnStateMachineTracingConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetLoggingConfiguration")]
        public virtual void ResetLoggingConfiguration()
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

        [JsiiMethod(name: "resetTracingConfiguration")]
        public virtual void ResetTracingConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetType")]
        public virtual void ResetType()
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
        = GetStaticProperty<string>(typeof(aws.Sfn.SfnStateMachine))!;

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

        [JsiiProperty(name: "loggingConfiguration", typeJson: "{\"fqn\":\"aws.sfn.SfnStateMachineLoggingConfigurationOutputReference\"}")]
        public virtual aws.Sfn.SfnStateMachineLoggingConfigurationOutputReference LoggingConfiguration
        {
            get => GetInstanceProperty<aws.Sfn.SfnStateMachineLoggingConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tracingConfiguration", typeJson: "{\"fqn\":\"aws.sfn.SfnStateMachineTracingConfigurationOutputReference\"}")]
        public virtual aws.Sfn.SfnStateMachineTracingConfigurationOutputReference TracingConfiguration
        {
            get => GetInstanceProperty<aws.Sfn.SfnStateMachineTracingConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "definitionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DefinitionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loggingConfigurationInput", typeJson: "{\"fqn\":\"aws.sfn.SfnStateMachineLoggingConfiguration\"}", isOptional: true)]
        public virtual aws.Sfn.ISfnStateMachineLoggingConfiguration? LoggingConfigurationInput
        {
            get => GetInstanceProperty<aws.Sfn.ISfnStateMachineLoggingConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
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
        [JsiiProperty(name: "tracingConfigurationInput", typeJson: "{\"fqn\":\"aws.sfn.SfnStateMachineTracingConfiguration\"}", isOptional: true)]
        public virtual aws.Sfn.ISfnStateMachineTracingConfiguration? TracingConfigurationInput
        {
            get => GetInstanceProperty<aws.Sfn.ISfnStateMachineTracingConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "definition", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Definition
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

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
