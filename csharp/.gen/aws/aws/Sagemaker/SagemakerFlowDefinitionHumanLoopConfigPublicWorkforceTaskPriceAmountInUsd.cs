using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiByValue(fqn: "aws.sagemaker.SagemakerFlowDefinitionHumanLoopConfigPublicWorkforceTaskPriceAmountInUsd")]
    public class SagemakerFlowDefinitionHumanLoopConfigPublicWorkforceTaskPriceAmountInUsd : aws.Sagemaker.ISagemakerFlowDefinitionHumanLoopConfigPublicWorkforceTaskPriceAmountInUsd
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_flow_definition#cents SagemakerFlowDefinition#cents}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cents", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Cents
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_flow_definition#dollars SagemakerFlowDefinition#dollars}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dollars", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Dollars
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_flow_definition#tenth_fractions_of_a_cent SagemakerFlowDefinition#tenth_fractions_of_a_cent}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tenthFractionsOfACent", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? TenthFractionsOfACent
        {
            get;
            set;
        }
    }
}
