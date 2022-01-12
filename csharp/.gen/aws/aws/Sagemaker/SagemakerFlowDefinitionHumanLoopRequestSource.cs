using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemaker.SagemakerFlowDefinitionHumanLoopRequestSource")]
    public class SagemakerFlowDefinitionHumanLoopRequestSource : aws.Sagemaker.ISagemakerFlowDefinitionHumanLoopRequestSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_flow_definition#aws_managed_human_loop_request_source SagemakerFlowDefinition#aws_managed_human_loop_request_source}.</summary>
        [JsiiProperty(name: "awsManagedHumanLoopRequestSource", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string AwsManagedHumanLoopRequestSource
        {
            get;
            set;
        }
    }
}
