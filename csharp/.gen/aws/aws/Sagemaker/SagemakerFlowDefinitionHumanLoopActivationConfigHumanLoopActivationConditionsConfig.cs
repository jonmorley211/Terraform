using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemaker.SagemakerFlowDefinitionHumanLoopActivationConfigHumanLoopActivationConditionsConfig")]
    public class SagemakerFlowDefinitionHumanLoopActivationConfigHumanLoopActivationConditionsConfig : aws.Sagemaker.ISagemakerFlowDefinitionHumanLoopActivationConfigHumanLoopActivationConditionsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_flow_definition#human_loop_activation_conditions SagemakerFlowDefinition#human_loop_activation_conditions}.</summary>
        [JsiiProperty(name: "humanLoopActivationConditions", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string HumanLoopActivationConditions
        {
            get;
            set;
        }
    }
}
