using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Autoscaling
{
    [JsiiByValue(fqn: "aws.autoscaling.AutoscalingGroupWarmPool")]
    public class AutoscalingGroupWarmPool : aws.Autoscaling.IAutoscalingGroupWarmPool
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#max_group_prepared_capacity AutoscalingGroup#max_group_prepared_capacity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxGroupPreparedCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? MaxGroupPreparedCapacity
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#min_size AutoscalingGroup#min_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? MinSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#pool_state AutoscalingGroup#pool_state}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "poolState", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? PoolState
        {
            get;
            set;
        }
    }
}
