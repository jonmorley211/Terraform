using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Emr
{
    /// <summary>AWS Elastic MapReduce.</summary>
    [JsiiInterface(nativeType: typeof(IEmrInstanceFleetConfig), fullyQualifiedName: "aws.emr.EmrInstanceFleetConfig")]
    public interface IEmrInstanceFleetConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_fleet#cluster_id EmrInstanceFleet#cluster_id}.</summary>
        [JsiiProperty(name: "clusterId", typeJson: "{\"primitive\":\"string\"}")]
        string ClusterId
        {
            get;
        }

        /// <summary>instance_type_configs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_fleet#instance_type_configs EmrInstanceFleet#instance_type_configs}
        /// </remarks>
        [JsiiProperty(name: "instanceTypeConfigs", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrInstanceFleetInstanceTypeConfigs\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Emr.IEmrInstanceFleetInstanceTypeConfigs[]? InstanceTypeConfigs
        {
            get
            {
                return null;
            }
        }

        /// <summary>launch_specifications block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_fleet#launch_specifications EmrInstanceFleet#launch_specifications}
        /// </remarks>
        [JsiiProperty(name: "launchSpecifications", typeJson: "{\"fqn\":\"aws.emr.EmrInstanceFleetLaunchSpecifications\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Emr.IEmrInstanceFleetLaunchSpecifications? LaunchSpecifications
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_fleet#name EmrInstanceFleet#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_fleet#target_on_demand_capacity EmrInstanceFleet#target_on_demand_capacity}.</summary>
        [JsiiProperty(name: "targetOnDemandCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TargetOnDemandCapacity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_fleet#target_spot_capacity EmrInstanceFleet#target_spot_capacity}.</summary>
        [JsiiProperty(name: "targetSpotCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TargetSpotCapacity
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Elastic MapReduce.</summary>
        [JsiiTypeProxy(nativeType: typeof(IEmrInstanceFleetConfig), fullyQualifiedName: "aws.emr.EmrInstanceFleetConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Emr.IEmrInstanceFleetConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_fleet#cluster_id EmrInstanceFleet#cluster_id}.</summary>
            [JsiiProperty(name: "clusterId", typeJson: "{\"primitive\":\"string\"}")]
            public string ClusterId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>instance_type_configs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_fleet#instance_type_configs EmrInstanceFleet#instance_type_configs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "instanceTypeConfigs", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrInstanceFleetInstanceTypeConfigs\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Emr.IEmrInstanceFleetInstanceTypeConfigs[]? InstanceTypeConfigs
            {
                get => GetInstanceProperty<aws.Emr.IEmrInstanceFleetInstanceTypeConfigs[]?>();
            }

            /// <summary>launch_specifications block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_fleet#launch_specifications EmrInstanceFleet#launch_specifications}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "launchSpecifications", typeJson: "{\"fqn\":\"aws.emr.EmrInstanceFleetLaunchSpecifications\"}", isOptional: true)]
            public aws.Emr.IEmrInstanceFleetLaunchSpecifications? LaunchSpecifications
            {
                get => GetInstanceProperty<aws.Emr.IEmrInstanceFleetLaunchSpecifications?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_fleet#name EmrInstanceFleet#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_fleet#target_on_demand_capacity EmrInstanceFleet#target_on_demand_capacity}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetOnDemandCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TargetOnDemandCapacity
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_fleet#target_spot_capacity EmrInstanceFleet#target_spot_capacity}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetSpotCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TargetSpotCapacity
            {
                get => GetInstanceProperty<double?>();
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
