using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Emr
{
    [JsiiInterface(nativeType: typeof(IEmrInstanceFleetLaunchSpecifications), fullyQualifiedName: "aws.emr.EmrInstanceFleetLaunchSpecifications")]
    public interface IEmrInstanceFleetLaunchSpecifications
    {
        /// <summary>on_demand_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_fleet#on_demand_specification EmrInstanceFleet#on_demand_specification}
        /// </remarks>
        [JsiiProperty(name: "onDemandSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrInstanceFleetLaunchSpecificationsOnDemandSpecification\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Emr.IEmrInstanceFleetLaunchSpecificationsOnDemandSpecification[]? OnDemandSpecification
        {
            get
            {
                return null;
            }
        }

        /// <summary>spot_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_fleet#spot_specification EmrInstanceFleet#spot_specification}
        /// </remarks>
        [JsiiProperty(name: "spotSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrInstanceFleetLaunchSpecificationsSpotSpecification\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Emr.IEmrInstanceFleetLaunchSpecificationsSpotSpecification[]? SpotSpecification
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEmrInstanceFleetLaunchSpecifications), fullyQualifiedName: "aws.emr.EmrInstanceFleetLaunchSpecifications")]
        internal sealed class _Proxy : DeputyBase, aws.Emr.IEmrInstanceFleetLaunchSpecifications
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>on_demand_specification block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_fleet#on_demand_specification EmrInstanceFleet#on_demand_specification}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "onDemandSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrInstanceFleetLaunchSpecificationsOnDemandSpecification\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Emr.IEmrInstanceFleetLaunchSpecificationsOnDemandSpecification[]? OnDemandSpecification
            {
                get => GetInstanceProperty<aws.Emr.IEmrInstanceFleetLaunchSpecificationsOnDemandSpecification[]?>();
            }

            /// <summary>spot_specification block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_fleet#spot_specification EmrInstanceFleet#spot_specification}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "spotSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrInstanceFleetLaunchSpecificationsSpotSpecification\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Emr.IEmrInstanceFleetLaunchSpecificationsSpotSpecification[]? SpotSpecification
            {
                get => GetInstanceProperty<aws.Emr.IEmrInstanceFleetLaunchSpecificationsSpotSpecification[]?>();
            }
        }
    }
}
