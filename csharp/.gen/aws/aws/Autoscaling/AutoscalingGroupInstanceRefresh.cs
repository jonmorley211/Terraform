using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Autoscaling
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.autoscaling.AutoscalingGroupInstanceRefresh")]
    public class AutoscalingGroupInstanceRefresh : aws.Autoscaling.IAutoscalingGroupInstanceRefresh
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#strategy AutoscalingGroup#strategy}.</summary>
        [JsiiProperty(name: "strategy", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Strategy
        {
            get;
            set;
        }

        /// <summary>preferences block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#preferences AutoscalingGroup#preferences}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "preferences", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingGroupInstanceRefreshPreferences\"}", isOptional: true, isOverride: true)]
        public aws.Autoscaling.IAutoscalingGroupInstanceRefreshPreferences? Preferences
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#triggers AutoscalingGroup#triggers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "triggers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? Triggers
        {
            get;
            set;
        }
    }
}
