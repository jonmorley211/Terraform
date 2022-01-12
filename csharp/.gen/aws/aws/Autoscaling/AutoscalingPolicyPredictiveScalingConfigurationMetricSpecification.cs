using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Autoscaling
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.autoscaling.AutoscalingPolicyPredictiveScalingConfigurationMetricSpecification")]
    public class AutoscalingPolicyPredictiveScalingConfigurationMetricSpecification : aws.Autoscaling.IAutoscalingPolicyPredictiveScalingConfigurationMetricSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#target_value AutoscalingPolicy#target_value}.</summary>
        [JsiiProperty(name: "targetValue", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double TargetValue
        {
            get;
            set;
        }

        /// <summary>predefined_load_metric_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#predefined_load_metric_specification AutoscalingPolicy#predefined_load_metric_specification}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "predefinedLoadMetricSpecification", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationPredefinedLoadMetricSpecification\"}", isOptional: true, isOverride: true)]
        public aws.Autoscaling.IAutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationPredefinedLoadMetricSpecification? PredefinedLoadMetricSpecification
        {
            get;
            set;
        }

        /// <summary>predefined_metric_pair_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#predefined_metric_pair_specification AutoscalingPolicy#predefined_metric_pair_specification}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "predefinedMetricPairSpecification", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationPredefinedMetricPairSpecification\"}", isOptional: true, isOverride: true)]
        public aws.Autoscaling.IAutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationPredefinedMetricPairSpecification? PredefinedMetricPairSpecification
        {
            get;
            set;
        }

        /// <summary>predefined_scaling_metric_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#predefined_scaling_metric_specification AutoscalingPolicy#predefined_scaling_metric_specification}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "predefinedScalingMetricSpecification", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationPredefinedScalingMetricSpecification\"}", isOptional: true, isOverride: true)]
        public aws.Autoscaling.IAutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationPredefinedScalingMetricSpecification? PredefinedScalingMetricSpecification
        {
            get;
            set;
        }
    }
}
