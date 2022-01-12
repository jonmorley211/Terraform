using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiInterface(nativeType: typeof(ISpotInstanceRequestCapacityReservationSpecificationCapacityReservationTarget), fullyQualifiedName: "aws.ec2.SpotInstanceRequestCapacityReservationSpecificationCapacityReservationTarget")]
    public interface ISpotInstanceRequestCapacityReservationSpecificationCapacityReservationTarget
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#capacity_reservation_id SpotInstanceRequest#capacity_reservation_id}.</summary>
        [JsiiProperty(name: "capacityReservationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CapacityReservationId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISpotInstanceRequestCapacityReservationSpecificationCapacityReservationTarget), fullyQualifiedName: "aws.ec2.SpotInstanceRequestCapacityReservationSpecificationCapacityReservationTarget")]
        internal sealed class _Proxy : DeputyBase, aws.Ec2.ISpotInstanceRequestCapacityReservationSpecificationCapacityReservationTarget
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#capacity_reservation_id SpotInstanceRequest#capacity_reservation_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "capacityReservationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CapacityReservationId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
