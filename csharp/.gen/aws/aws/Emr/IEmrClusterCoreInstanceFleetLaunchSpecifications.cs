using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Emr
{
    [JsiiInterface(nativeType: typeof(IEmrClusterCoreInstanceFleetLaunchSpecifications), fullyQualifiedName: "aws.emr.EmrClusterCoreInstanceFleetLaunchSpecifications")]
    public interface IEmrClusterCoreInstanceFleetLaunchSpecifications
    {
        /// <summary>on_demand_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#on_demand_specification EmrCluster#on_demand_specification}
        /// </remarks>
        [JsiiProperty(name: "onDemandSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrClusterCoreInstanceFleetLaunchSpecificationsOnDemandSpecification\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Emr.IEmrClusterCoreInstanceFleetLaunchSpecificationsOnDemandSpecification[]? OnDemandSpecification
        {
            get
            {
                return null;
            }
        }

        /// <summary>spot_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#spot_specification EmrCluster#spot_specification}
        /// </remarks>
        [JsiiProperty(name: "spotSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrClusterCoreInstanceFleetLaunchSpecificationsSpotSpecification\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Emr.IEmrClusterCoreInstanceFleetLaunchSpecificationsSpotSpecification[]? SpotSpecification
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEmrClusterCoreInstanceFleetLaunchSpecifications), fullyQualifiedName: "aws.emr.EmrClusterCoreInstanceFleetLaunchSpecifications")]
        internal sealed class _Proxy : DeputyBase, aws.Emr.IEmrClusterCoreInstanceFleetLaunchSpecifications
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>on_demand_specification block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#on_demand_specification EmrCluster#on_demand_specification}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "onDemandSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrClusterCoreInstanceFleetLaunchSpecificationsOnDemandSpecification\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Emr.IEmrClusterCoreInstanceFleetLaunchSpecificationsOnDemandSpecification[]? OnDemandSpecification
            {
                get => GetInstanceProperty<aws.Emr.IEmrClusterCoreInstanceFleetLaunchSpecificationsOnDemandSpecification[]?>();
            }

            /// <summary>spot_specification block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#spot_specification EmrCluster#spot_specification}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "spotSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrClusterCoreInstanceFleetLaunchSpecificationsSpotSpecification\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Emr.IEmrClusterCoreInstanceFleetLaunchSpecificationsSpotSpecification[]? SpotSpecification
            {
                get => GetInstanceProperty<aws.Emr.IEmrClusterCoreInstanceFleetLaunchSpecificationsSpotSpecification[]?>();
            }
        }
    }
}
