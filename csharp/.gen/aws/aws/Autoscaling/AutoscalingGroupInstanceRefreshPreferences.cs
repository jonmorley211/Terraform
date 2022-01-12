using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Autoscaling
{
    [JsiiByValue(fqn: "aws.autoscaling.AutoscalingGroupInstanceRefreshPreferences")]
    public class AutoscalingGroupInstanceRefreshPreferences : aws.Autoscaling.IAutoscalingGroupInstanceRefreshPreferences
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#checkpoint_delay AutoscalingGroup#checkpoint_delay}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "checkpointDelay", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CheckpointDelay
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#checkpoint_percentages AutoscalingGroup#checkpoint_percentages}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "checkpointPercentages", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public double[]? CheckpointPercentages
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#instance_warmup AutoscalingGroup#instance_warmup}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceWarmup", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? InstanceWarmup
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#min_healthy_percentage AutoscalingGroup#min_healthy_percentage}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minHealthyPercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? MinHealthyPercentage
        {
            get;
            set;
        }
    }
}
