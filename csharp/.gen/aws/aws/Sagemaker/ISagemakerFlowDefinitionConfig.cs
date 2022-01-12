using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    /// <summary>AWS SageMaker.</summary>
    [JsiiInterface(nativeType: typeof(ISagemakerFlowDefinitionConfig), fullyQualifiedName: "aws.sagemaker.SagemakerFlowDefinitionConfig")]
    public interface ISagemakerFlowDefinitionConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_flow_definition#flow_definition_name SagemakerFlowDefinition#flow_definition_name}.</summary>
        [JsiiProperty(name: "flowDefinitionName", typeJson: "{\"primitive\":\"string\"}")]
        string FlowDefinitionName
        {
            get;
        }

        /// <summary>human_loop_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_flow_definition#human_loop_config SagemakerFlowDefinition#human_loop_config}
        /// </remarks>
        [JsiiProperty(name: "humanLoopConfig", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerFlowDefinitionHumanLoopConfig\"}")]
        aws.Sagemaker.ISagemakerFlowDefinitionHumanLoopConfig HumanLoopConfig
        {
            get;
        }

        /// <summary>output_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_flow_definition#output_config SagemakerFlowDefinition#output_config}
        /// </remarks>
        [JsiiProperty(name: "outputConfig", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerFlowDefinitionOutputConfig\"}")]
        aws.Sagemaker.ISagemakerFlowDefinitionOutputConfig OutputConfig
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_flow_definition#role_arn SagemakerFlowDefinition#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        /// <summary>human_loop_activation_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_flow_definition#human_loop_activation_config SagemakerFlowDefinition#human_loop_activation_config}
        /// </remarks>
        [JsiiProperty(name: "humanLoopActivationConfig", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerFlowDefinitionHumanLoopActivationConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Sagemaker.ISagemakerFlowDefinitionHumanLoopActivationConfig? HumanLoopActivationConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>human_loop_request_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_flow_definition#human_loop_request_source SagemakerFlowDefinition#human_loop_request_source}
        /// </remarks>
        [JsiiProperty(name: "humanLoopRequestSource", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerFlowDefinitionHumanLoopRequestSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Sagemaker.ISagemakerFlowDefinitionHumanLoopRequestSource? HumanLoopRequestSource
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_flow_definition#tags SagemakerFlowDefinition#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_flow_definition#tags_all SagemakerFlowDefinition#tags_all}.</summary>
        [JsiiProperty(name: "tagsAll", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TagsAll
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS SageMaker.</summary>
        [JsiiTypeProxy(nativeType: typeof(ISagemakerFlowDefinitionConfig), fullyQualifiedName: "aws.sagemaker.SagemakerFlowDefinitionConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Sagemaker.ISagemakerFlowDefinitionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_flow_definition#flow_definition_name SagemakerFlowDefinition#flow_definition_name}.</summary>
            [JsiiProperty(name: "flowDefinitionName", typeJson: "{\"primitive\":\"string\"}")]
            public string FlowDefinitionName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>human_loop_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_flow_definition#human_loop_config SagemakerFlowDefinition#human_loop_config}
            /// </remarks>
            [JsiiProperty(name: "humanLoopConfig", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerFlowDefinitionHumanLoopConfig\"}")]
            public aws.Sagemaker.ISagemakerFlowDefinitionHumanLoopConfig HumanLoopConfig
            {
                get => GetInstanceProperty<aws.Sagemaker.ISagemakerFlowDefinitionHumanLoopConfig>()!;
            }

            /// <summary>output_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_flow_definition#output_config SagemakerFlowDefinition#output_config}
            /// </remarks>
            [JsiiProperty(name: "outputConfig", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerFlowDefinitionOutputConfig\"}")]
            public aws.Sagemaker.ISagemakerFlowDefinitionOutputConfig OutputConfig
            {
                get => GetInstanceProperty<aws.Sagemaker.ISagemakerFlowDefinitionOutputConfig>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_flow_definition#role_arn SagemakerFlowDefinition#role_arn}.</summary>
            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>human_loop_activation_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_flow_definition#human_loop_activation_config SagemakerFlowDefinition#human_loop_activation_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "humanLoopActivationConfig", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerFlowDefinitionHumanLoopActivationConfig\"}", isOptional: true)]
            public aws.Sagemaker.ISagemakerFlowDefinitionHumanLoopActivationConfig? HumanLoopActivationConfig
            {
                get => GetInstanceProperty<aws.Sagemaker.ISagemakerFlowDefinitionHumanLoopActivationConfig?>();
            }

            /// <summary>human_loop_request_source block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_flow_definition#human_loop_request_source SagemakerFlowDefinition#human_loop_request_source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "humanLoopRequestSource", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerFlowDefinitionHumanLoopRequestSource\"}", isOptional: true)]
            public aws.Sagemaker.ISagemakerFlowDefinitionHumanLoopRequestSource? HumanLoopRequestSource
            {
                get => GetInstanceProperty<aws.Sagemaker.ISagemakerFlowDefinitionHumanLoopRequestSource?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_flow_definition#tags SagemakerFlowDefinition#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? Tags
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_flow_definition#tags_all SagemakerFlowDefinition#tags_all}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tagsAll", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? TagsAll
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
