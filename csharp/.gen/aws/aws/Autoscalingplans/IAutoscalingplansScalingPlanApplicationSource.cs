using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Autoscalingplans
{
    [JsiiInterface(nativeType: typeof(IAutoscalingplansScalingPlanApplicationSource), fullyQualifiedName: "aws.autoscalingplans.AutoscalingplansScalingPlanApplicationSource")]
    public interface IAutoscalingplansScalingPlanApplicationSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#cloudformation_stack_arn AutoscalingplansScalingPlan#cloudformation_stack_arn}.</summary>
        [JsiiProperty(name: "cloudformationStackArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CloudformationStackArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>tag_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#tag_filter AutoscalingplansScalingPlan#tag_filter}
        /// </remarks>
        [JsiiProperty(name: "tagFilter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.autoscalingplans.AutoscalingplansScalingPlanApplicationSourceTagFilter\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Autoscalingplans.IAutoscalingplansScalingPlanApplicationSourceTagFilter[]? TagFilter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAutoscalingplansScalingPlanApplicationSource), fullyQualifiedName: "aws.autoscalingplans.AutoscalingplansScalingPlanApplicationSource")]
        internal sealed class _Proxy : DeputyBase, aws.Autoscalingplans.IAutoscalingplansScalingPlanApplicationSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#cloudformation_stack_arn AutoscalingplansScalingPlan#cloudformation_stack_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cloudformationStackArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CloudformationStackArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>tag_filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#tag_filter AutoscalingplansScalingPlan#tag_filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tagFilter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.autoscalingplans.AutoscalingplansScalingPlanApplicationSourceTagFilter\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Autoscalingplans.IAutoscalingplansScalingPlanApplicationSourceTagFilter[]? TagFilter
            {
                get => GetInstanceProperty<aws.Autoscalingplans.IAutoscalingplansScalingPlanApplicationSourceTagFilter[]?>();
            }
        }
    }
}
