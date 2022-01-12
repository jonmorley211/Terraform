using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiByValue(fqn: "aws.sagemaker.SagemakerHumanTaskUiUiTemplate")]
    public class SagemakerHumanTaskUiUiTemplate : aws.Sagemaker.ISagemakerHumanTaskUiUiTemplate
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_human_task_ui#content SagemakerHumanTaskUi#content}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Content
        {
            get;
            set;
        }
    }
}
