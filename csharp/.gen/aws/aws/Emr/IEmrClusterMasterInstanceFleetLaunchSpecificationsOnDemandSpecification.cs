using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Emr
{
    [JsiiInterface(nativeType: typeof(IEmrClusterMasterInstanceFleetLaunchSpecificationsOnDemandSpecification), fullyQualifiedName: "aws.emr.EmrClusterMasterInstanceFleetLaunchSpecificationsOnDemandSpecification")]
    public interface IEmrClusterMasterInstanceFleetLaunchSpecificationsOnDemandSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#allocation_strategy EmrCluster#allocation_strategy}.</summary>
        [JsiiProperty(name: "allocationStrategy", typeJson: "{\"primitive\":\"string\"}")]
        string AllocationStrategy
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEmrClusterMasterInstanceFleetLaunchSpecificationsOnDemandSpecification), fullyQualifiedName: "aws.emr.EmrClusterMasterInstanceFleetLaunchSpecificationsOnDemandSpecification")]
        internal sealed class _Proxy : DeputyBase, aws.Emr.IEmrClusterMasterInstanceFleetLaunchSpecificationsOnDemandSpecification
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#allocation_strategy EmrCluster#allocation_strategy}.</summary>
            [JsiiProperty(name: "allocationStrategy", typeJson: "{\"primitive\":\"string\"}")]
            public string AllocationStrategy
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
