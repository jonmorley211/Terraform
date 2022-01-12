using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Emr
{
    [JsiiInterface(nativeType: typeof(IEmrClusterMasterInstanceFleetLaunchSpecifications), fullyQualifiedName: "aws.emr.EmrClusterMasterInstanceFleetLaunchSpecifications")]
    public interface IEmrClusterMasterInstanceFleetLaunchSpecifications
    {
        /// <summary>on_demand_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#on_demand_specification EmrCluster#on_demand_specification}
        /// </remarks>
        [JsiiProperty(name: "onDemandSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrClusterMasterInstanceFleetLaunchSpecificationsOnDemandSpecification\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Emr.IEmrClusterMasterInstanceFleetLaunchSpecificationsOnDemandSpecification[]? OnDemandSpecification
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
        [JsiiProperty(name: "spotSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrClusterMasterInstanceFleetLaunchSpecificationsSpotSpecification\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Emr.IEmrClusterMasterInstanceFleetLaunchSpecificationsSpotSpecification[]? SpotSpecification
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEmrClusterMasterInstanceFleetLaunchSpecifications), fullyQualifiedName: "aws.emr.EmrClusterMasterInstanceFleetLaunchSpecifications")]
        internal sealed class _Proxy : DeputyBase, aws.Emr.IEmrClusterMasterInstanceFleetLaunchSpecifications
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>on_demand_specification block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#on_demand_specification EmrCluster#on_demand_specification}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "onDemandSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrClusterMasterInstanceFleetLaunchSpecificationsOnDemandSpecification\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Emr.IEmrClusterMasterInstanceFleetLaunchSpecificationsOnDemandSpecification[]? OnDemandSpecification
            {
                get => GetInstanceProperty<aws.Emr.IEmrClusterMasterInstanceFleetLaunchSpecificationsOnDemandSpecification[]?>();
            }

            /// <summary>spot_specification block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#spot_specification EmrCluster#spot_specification}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "spotSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrClusterMasterInstanceFleetLaunchSpecificationsSpotSpecification\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Emr.IEmrClusterMasterInstanceFleetLaunchSpecificationsSpotSpecification[]? SpotSpecification
            {
                get => GetInstanceProperty<aws.Emr.IEmrClusterMasterInstanceFleetLaunchSpecificationsSpotSpecification[]?>();
            }
        }
    }
}
