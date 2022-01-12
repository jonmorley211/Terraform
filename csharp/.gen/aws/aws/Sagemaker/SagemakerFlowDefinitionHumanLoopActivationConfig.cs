using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiByValue(fqn: "aws.sagemaker.SagemakerFlowDefinitionHumanLoopActivationConfig")]
    public class SagemakerFlowDefinitionHumanLoopActivationConfig : aws.Sagemaker.ISagemakerFlowDefinitionHumanLoopActivationConfig
    {
        /// <summary>human_loop_activation_conditions_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_flow_definition#human_loop_activation_conditions_config SagemakerFlowDefinition#human_loop_activation_conditions_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "humanLoopActivationConditionsConfig", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerFlowDefinitionHumanLoopActivationConfigHumanLoopActivationConditionsConfig\"}", isOptional: true, isOverride: true)]
        public aws.Sagemaker.ISagemakerFlowDefinitionHumanLoopActivationConfigHumanLoopActivationConditionsConfig? HumanLoopActivationConditionsConfig
        {
            get;
            set;
        }
    }
}
