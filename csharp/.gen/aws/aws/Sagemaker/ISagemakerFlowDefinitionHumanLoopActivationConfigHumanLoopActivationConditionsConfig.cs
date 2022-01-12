using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiInterface(nativeType: typeof(ISagemakerFlowDefinitionHumanLoopActivationConfigHumanLoopActivationConditionsConfig), fullyQualifiedName: "aws.sagemaker.SagemakerFlowDefinitionHumanLoopActivationConfigHumanLoopActivationConditionsConfig")]
    public interface ISagemakerFlowDefinitionHumanLoopActivationConfigHumanLoopActivationConditionsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_flow_definition#human_loop_activation_conditions SagemakerFlowDefinition#human_loop_activation_conditions}.</summary>
        [JsiiProperty(name: "humanLoopActivationConditions", typeJson: "{\"primitive\":\"string\"}")]
        string HumanLoopActivationConditions
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerFlowDefinitionHumanLoopActivationConfigHumanLoopActivationConditionsConfig), fullyQualifiedName: "aws.sagemaker.SagemakerFlowDefinitionHumanLoopActivationConfigHumanLoopActivationConditionsConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Sagemaker.ISagemakerFlowDefinitionHumanLoopActivationConfigHumanLoopActivationConditionsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_flow_definition#human_loop_activation_conditions SagemakerFlowDefinition#human_loop_activation_conditions}.</summary>
            [JsiiProperty(name: "humanLoopActivationConditions", typeJson: "{\"primitive\":\"string\"}")]
            public string HumanLoopActivationConditions
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
