using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Emr
{
    [JsiiInterface(nativeType: typeof(IEmrClusterCoreInstanceFleet), fullyQualifiedName: "aws.emr.EmrClusterCoreInstanceFleet")]
    public interface IEmrClusterCoreInstanceFleet
    {
        /// <summary>instance_type_configs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#instance_type_configs EmrCluster#instance_type_configs}
        /// </remarks>
        [JsiiProperty(name: "instanceTypeConfigs", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrClusterCoreInstanceFleetInstanceTypeConfigs\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Emr.IEmrClusterCoreInstanceFleetInstanceTypeConfigs[]? InstanceTypeConfigs
        {
            get
            {
                return null;
            }
        }

        /// <summary>launch_specifications block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#launch_specifications EmrCluster#launch_specifications}
        /// </remarks>
        [JsiiProperty(name: "launchSpecifications", typeJson: "{\"fqn\":\"aws.emr.EmrClusterCoreInstanceFleetLaunchSpecifications\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Emr.IEmrClusterCoreInstanceFleetLaunchSpecifications? LaunchSpecifications
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#name EmrCluster#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#target_on_demand_capacity EmrCluster#target_on_demand_capacity}.</summary>
        [JsiiProperty(name: "targetOnDemandCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TargetOnDemandCapacity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#target_spot_capacity EmrCluster#target_spot_capacity}.</summary>
        [JsiiProperty(name: "targetSpotCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TargetSpotCapacity
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEmrClusterCoreInstanceFleet), fullyQualifiedName: "aws.emr.EmrClusterCoreInstanceFleet")]
        internal sealed class _Proxy : DeputyBase, aws.Emr.IEmrClusterCoreInstanceFleet
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>instance_type_configs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#instance_type_configs EmrCluster#instance_type_configs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "instanceTypeConfigs", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrClusterCoreInstanceFleetInstanceTypeConfigs\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Emr.IEmrClusterCoreInstanceFleetInstanceTypeConfigs[]? InstanceTypeConfigs
            {
                get => GetInstanceProperty<aws.Emr.IEmrClusterCoreInstanceFleetInstanceTypeConfigs[]?>();
            }

            /// <summary>launch_specifications block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#launch_specifications EmrCluster#launch_specifications}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "launchSpecifications", typeJson: "{\"fqn\":\"aws.emr.EmrClusterCoreInstanceFleetLaunchSpecifications\"}", isOptional: true)]
            public aws.Emr.IEmrClusterCoreInstanceFleetLaunchSpecifications? LaunchSpecifications
            {
                get => GetInstanceProperty<aws.Emr.IEmrClusterCoreInstanceFleetLaunchSpecifications?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#name EmrCluster#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#target_on_demand_capacity EmrCluster#target_on_demand_capacity}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetOnDemandCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TargetOnDemandCapacity
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#target_spot_capacity EmrCluster#target_spot_capacity}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetSpotCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TargetSpotCapacity
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
