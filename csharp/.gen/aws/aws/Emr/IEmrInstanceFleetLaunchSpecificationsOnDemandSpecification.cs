using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Emr
{
    [JsiiInterface(nativeType: typeof(IEmrInstanceFleetLaunchSpecificationsOnDemandSpecification), fullyQualifiedName: "aws.emr.EmrInstanceFleetLaunchSpecificationsOnDemandSpecification")]
    public interface IEmrInstanceFleetLaunchSpecificationsOnDemandSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_fleet#allocation_strategy EmrInstanceFleet#allocation_strategy}.</summary>
        [JsiiProperty(name: "allocationStrategy", typeJson: "{\"primitive\":\"string\"}")]
        string AllocationStrategy
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEmrInstanceFleetLaunchSpecificationsOnDemandSpecification), fullyQualifiedName: "aws.emr.EmrInstanceFleetLaunchSpecificationsOnDemandSpecification")]
        internal sealed class _Proxy : DeputyBase, aws.Emr.IEmrInstanceFleetLaunchSpecificationsOnDemandSpecification
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_fleet#allocation_strategy EmrInstanceFleet#allocation_strategy}.</summary>
            [JsiiProperty(name: "allocationStrategy", typeJson: "{\"primitive\":\"string\"}")]
            public string AllocationStrategy
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
