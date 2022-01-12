using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Autoscalingplans
{
    /// <summary>AWS Auto Scaling Plans.</summary>
    [JsiiInterface(nativeType: typeof(IAutoscalingplansScalingPlanConfig), fullyQualifiedName: "aws.autoscalingplans.AutoscalingplansScalingPlanConfig")]
    public interface IAutoscalingplansScalingPlanConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>application_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#application_source AutoscalingplansScalingPlan#application_source}
        /// </remarks>
        [JsiiProperty(name: "applicationSource", typeJson: "{\"fqn\":\"aws.autoscalingplans.AutoscalingplansScalingPlanApplicationSource\"}")]
        aws.Autoscalingplans.IAutoscalingplansScalingPlanApplicationSource ApplicationSource
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#name AutoscalingplansScalingPlan#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>scaling_instruction block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#scaling_instruction AutoscalingplansScalingPlan#scaling_instruction}
        /// </remarks>
        [JsiiProperty(name: "scalingInstruction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.autoscalingplans.AutoscalingplansScalingPlanScalingInstruction\"},\"kind\":\"array\"}}")]
        aws.Autoscalingplans.IAutoscalingplansScalingPlanScalingInstruction[] ScalingInstruction
        {
            get;
        }

        /// <summary>AWS Auto Scaling Plans.</summary>
        [JsiiTypeProxy(nativeType: typeof(IAutoscalingplansScalingPlanConfig), fullyQualifiedName: "aws.autoscalingplans.AutoscalingplansScalingPlanConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Autoscalingplans.IAutoscalingplansScalingPlanConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>application_source block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#application_source AutoscalingplansScalingPlan#application_source}
            /// </remarks>
            [JsiiProperty(name: "applicationSource", typeJson: "{\"fqn\":\"aws.autoscalingplans.AutoscalingplansScalingPlanApplicationSource\"}")]
            public aws.Autoscalingplans.IAutoscalingplansScalingPlanApplicationSource ApplicationSource
            {
                get => GetInstanceProperty<aws.Autoscalingplans.IAutoscalingplansScalingPlanApplicationSource>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#name AutoscalingplansScalingPlan#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>scaling_instruction block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#scaling_instruction AutoscalingplansScalingPlan#scaling_instruction}
            /// </remarks>
            [JsiiProperty(name: "scalingInstruction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.autoscalingplans.AutoscalingplansScalingPlanScalingInstruction\"},\"kind\":\"array\"}}")]
            public aws.Autoscalingplans.IAutoscalingplansScalingPlanScalingInstruction[] ScalingInstruction
            {
                get => GetInstanceProperty<aws.Autoscalingplans.IAutoscalingplansScalingPlanScalingInstruction[]>()!;
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
