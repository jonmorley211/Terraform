using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiByValue(fqn: "aws.sagemaker.SagemakerFlowDefinitionHumanLoopConfigPublicWorkforceTaskPrice")]
    public class SagemakerFlowDefinitionHumanLoopConfigPublicWorkforceTaskPrice : aws.Sagemaker.ISagemakerFlowDefinitionHumanLoopConfigPublicWorkforceTaskPrice
    {
        /// <summary>amount_in_usd block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_flow_definition#amount_in_usd SagemakerFlowDefinition#amount_in_usd}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "amountInUsd", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerFlowDefinitionHumanLoopConfigPublicWorkforceTaskPriceAmountInUsd\"}", isOptional: true, isOverride: true)]
        public aws.Sagemaker.ISagemakerFlowDefinitionHumanLoopConfigPublicWorkforceTaskPriceAmountInUsd? AmountInUsd
        {
            get;
            set;
        }
    }
}
