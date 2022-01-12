using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Autoscalingplans
{
    [JsiiByValue(fqn: "aws.autoscalingplans.AutoscalingplansScalingPlanApplicationSource")]
    public class AutoscalingplansScalingPlanApplicationSource : aws.Autoscalingplans.IAutoscalingplansScalingPlanApplicationSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#cloudformation_stack_arn AutoscalingplansScalingPlan#cloudformation_stack_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cloudformationStackArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CloudformationStackArn
        {
            get;
            set;
        }

        /// <summary>tag_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#tag_filter AutoscalingplansScalingPlan#tag_filter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tagFilter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.autoscalingplans.AutoscalingplansScalingPlanApplicationSourceTagFilter\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Autoscalingplans.IAutoscalingplansScalingPlanApplicationSourceTagFilter[]? TagFilter
        {
            get;
            set;
        }
    }
}
