using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Autoscalingplans
{
    [JsiiInterface(nativeType: typeof(IAutoscalingplansScalingPlanScalingInstructionPredefinedLoadMetricSpecification), fullyQualifiedName: "aws.autoscalingplans.AutoscalingplansScalingPlanScalingInstructionPredefinedLoadMetricSpecification")]
    public interface IAutoscalingplansScalingPlanScalingInstructionPredefinedLoadMetricSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#predefined_load_metric_type AutoscalingplansScalingPlan#predefined_load_metric_type}.</summary>
        [JsiiProperty(name: "predefinedLoadMetricType", typeJson: "{\"primitive\":\"string\"}")]
        string PredefinedLoadMetricType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#resource_label AutoscalingplansScalingPlan#resource_label}.</summary>
        [JsiiProperty(name: "resourceLabel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourceLabel
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAutoscalingplansScalingPlanScalingInstructionPredefinedLoadMetricSpecification), fullyQualifiedName: "aws.autoscalingplans.AutoscalingplansScalingPlanScalingInstructionPredefinedLoadMetricSpecification")]
        internal sealed class _Proxy : DeputyBase, aws.Autoscalingplans.IAutoscalingplansScalingPlanScalingInstructionPredefinedLoadMetricSpecification
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#predefined_load_metric_type AutoscalingplansScalingPlan#predefined_load_metric_type}.</summary>
            [JsiiProperty(name: "predefinedLoadMetricType", typeJson: "{\"primitive\":\"string\"}")]
            public string PredefinedLoadMetricType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#resource_label AutoscalingplansScalingPlan#resource_label}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resourceLabel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourceLabel
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
