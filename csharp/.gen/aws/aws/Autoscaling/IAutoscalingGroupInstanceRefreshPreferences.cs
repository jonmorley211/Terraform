using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Autoscaling
{
    [JsiiInterface(nativeType: typeof(IAutoscalingGroupInstanceRefreshPreferences), fullyQualifiedName: "aws.autoscaling.AutoscalingGroupInstanceRefreshPreferences")]
    public interface IAutoscalingGroupInstanceRefreshPreferences
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#checkpoint_delay AutoscalingGroup#checkpoint_delay}.</summary>
        [JsiiProperty(name: "checkpointDelay", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CheckpointDelay
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#checkpoint_percentages AutoscalingGroup#checkpoint_percentages}.</summary>
        [JsiiProperty(name: "checkpointPercentages", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double[]? CheckpointPercentages
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#instance_warmup AutoscalingGroup#instance_warmup}.</summary>
        [JsiiProperty(name: "instanceWarmup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InstanceWarmup
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#min_healthy_percentage AutoscalingGroup#min_healthy_percentage}.</summary>
        [JsiiProperty(name: "minHealthyPercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinHealthyPercentage
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAutoscalingGroupInstanceRefreshPreferences), fullyQualifiedName: "aws.autoscaling.AutoscalingGroupInstanceRefreshPreferences")]
        internal sealed class _Proxy : DeputyBase, aws.Autoscaling.IAutoscalingGroupInstanceRefreshPreferences
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#checkpoint_delay AutoscalingGroup#checkpoint_delay}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "checkpointDelay", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CheckpointDelay
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#checkpoint_percentages AutoscalingGroup#checkpoint_percentages}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "checkpointPercentages", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
            public double[]? CheckpointPercentages
            {
                get => GetInstanceProperty<double[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#instance_warmup AutoscalingGroup#instance_warmup}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instanceWarmup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InstanceWarmup
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#min_healthy_percentage AutoscalingGroup#min_healthy_percentage}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minHealthyPercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinHealthyPercentage
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
