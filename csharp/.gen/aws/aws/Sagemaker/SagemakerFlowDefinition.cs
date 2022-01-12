using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_flow_definition aws_sagemaker_flow_definition}.</summary>
    [JsiiClass(nativeType: typeof(aws.Sagemaker.SagemakerFlowDefinition), fullyQualifiedName: "aws.sagemaker.SagemakerFlowDefinition", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.sagemaker.SagemakerFlowDefinitionConfig\"}}]")]
    public class SagemakerFlowDefinition : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_flow_definition aws_sagemaker_flow_definition} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public SagemakerFlowDefinition(Constructs.Construct scope, string id, aws.Sagemaker.ISagemakerFlowDefinitionConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerFlowDefinition(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerFlowDefinition(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putHumanLoopActivationConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemaker.SagemakerFlowDefinitionHumanLoopActivationConfig\"}}]")]
        public virtual void PutHumanLoopActivationConfig(aws.Sagemaker.ISagemakerFlowDefinitionHumanLoopActivationConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Sagemaker.ISagemakerFlowDefinitionHumanLoopActivationConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHumanLoopConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemaker.SagemakerFlowDefinitionHumanLoopConfig\"}}]")]
        public virtual void PutHumanLoopConfig(aws.Sagemaker.ISagemakerFlowDefinitionHumanLoopConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Sagemaker.ISagemakerFlowDefinitionHumanLoopConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHumanLoopRequestSource", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemaker.SagemakerFlowDefinitionHumanLoopRequestSource\"}}]")]
        public virtual void PutHumanLoopRequestSource(aws.Sagemaker.ISagemakerFlowDefinitionHumanLoopRequestSource @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Sagemaker.ISagemakerFlowDefinitionHumanLoopRequestSource)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOutputConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemaker.SagemakerFlowDefinitionOutputConfig\"}}]")]
        public virtual void PutOutputConfig(aws.Sagemaker.ISagemakerFlowDefinitionOutputConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Sagemaker.ISagemakerFlowDefinitionOutputConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetHumanLoopActivationConfig")]
        public virtual void ResetHumanLoopActivationConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHumanLoopRequestSource")]
        public virtual void ResetHumanLoopRequestSource()
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
        = GetStaticProperty<string>(typeof(aws.Sagemaker.SagemakerFlowDefinition))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "humanLoopActivationConfig", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerFlowDefinitionHumanLoopActivationConfigOutputReference\"}")]
        public virtual aws.Sagemaker.SagemakerFlowDefinitionHumanLoopActivationConfigOutputReference HumanLoopActivationConfig
        {
            get => GetInstanceProperty<aws.Sagemaker.SagemakerFlowDefinitionHumanLoopActivationConfigOutputReference>()!;
        }

        [JsiiProperty(name: "humanLoopConfig", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerFlowDefinitionHumanLoopConfigOutputReference\"}")]
        public virtual aws.Sagemaker.SagemakerFlowDefinitionHumanLoopConfigOutputReference HumanLoopConfig
        {
            get => GetInstanceProperty<aws.Sagemaker.SagemakerFlowDefinitionHumanLoopConfigOutputReference>()!;
        }

        [JsiiProperty(name: "humanLoopRequestSource", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerFlowDefinitionHumanLoopRequestSourceOutputReference\"}")]
        public virtual aws.Sagemaker.SagemakerFlowDefinitionHumanLoopRequestSourceOutputReference HumanLoopRequestSource
        {
            get => GetInstanceProperty<aws.Sagemaker.SagemakerFlowDefinitionHumanLoopRequestSourceOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "outputConfig", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerFlowDefinitionOutputConfigOutputReference\"}")]
        public virtual aws.Sagemaker.SagemakerFlowDefinitionOutputConfigOutputReference OutputConfig
        {
            get => GetInstanceProperty<aws.Sagemaker.SagemakerFlowDefinitionOutputConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "flowDefinitionNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FlowDefinitionNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "humanLoopActivationConfigInput", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerFlowDefinitionHumanLoopActivationConfig\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerFlowDefinitionHumanLoopActivationConfig? HumanLoopActivationConfigInput
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerFlowDefinitionHumanLoopActivationConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "humanLoopConfigInput", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerFlowDefinitionHumanLoopConfig\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerFlowDefinitionHumanLoopConfig? HumanLoopConfigInput
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerFlowDefinitionHumanLoopConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "humanLoopRequestSourceInput", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerFlowDefinitionHumanLoopRequestSource\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerFlowDefinitionHumanLoopRequestSource? HumanLoopRequestSourceInput
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerFlowDefinitionHumanLoopRequestSource?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "outputConfigInput", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerFlowDefinitionOutputConfig\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerFlowDefinitionOutputConfig? OutputConfigInput
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerFlowDefinitionOutputConfig?>();
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

        [JsiiProperty(name: "flowDefinitionName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FlowDefinitionName
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
