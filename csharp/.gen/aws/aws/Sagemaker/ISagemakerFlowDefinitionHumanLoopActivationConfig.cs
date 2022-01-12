using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiInterface(nativeType: typeof(ISagemakerFlowDefinitionHumanLoopActivationConfig), fullyQualifiedName: "aws.sagemaker.SagemakerFlowDefinitionHumanLoopActivationConfig")]
    public interface ISagemakerFlowDefinitionHumanLoopActivationConfig
    {
        /// <summary>human_loop_activation_conditions_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_flow_definition#human_loop_activation_conditions_config SagemakerFlowDefinition#human_loop_activation_conditions_config}
        /// </remarks>
        [JsiiProperty(name: "humanLoopActivationConditionsConfig", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerFlowDefinitionHumanLoopActivationConfigHumanLoopActivationConditionsConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Sagemaker.ISagemakerFlowDefinitionHumanLoopActivationConfigHumanLoopActivationConditionsConfig? HumanLoopActivationConditionsConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerFlowDefinitionHumanLoopActivationConfig), fullyQualifiedName: "aws.sagemaker.SagemakerFlowDefinitionHumanLoopActivationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Sagemaker.ISagemakerFlowDefinitionHumanLoopActivationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>human_loop_activation_conditions_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_flow_definition#human_loop_activation_conditions_config SagemakerFlowDefinition#human_loop_activation_conditions_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "humanLoopActivationConditionsConfig", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerFlowDefinitionHumanLoopActivationConfigHumanLoopActivationConditionsConfig\"}", isOptional: true)]
            public aws.Sagemaker.ISagemakerFlowDefinitionHumanLoopActivationConfigHumanLoopActivationConditionsConfig? HumanLoopActivationConditionsConfig
            {
                get => GetInstanceProperty<aws.Sagemaker.ISagemakerFlowDefinitionHumanLoopActivationConfigHumanLoopActivationConditionsConfig?>();
            }
        }
    }
}
