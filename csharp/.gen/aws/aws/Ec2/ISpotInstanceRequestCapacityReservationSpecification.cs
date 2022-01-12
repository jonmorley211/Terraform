using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiInterface(nativeType: typeof(ISpotInstanceRequestCapacityReservationSpecification), fullyQualifiedName: "aws.ec2.SpotInstanceRequestCapacityReservationSpecification")]
    public interface ISpotInstanceRequestCapacityReservationSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#capacity_reservation_preference SpotInstanceRequest#capacity_reservation_preference}.</summary>
        [JsiiProperty(name: "capacityReservationPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CapacityReservationPreference
        {
            get
            {
                return null;
            }
        }

        /// <summary>capacity_reservation_target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#capacity_reservation_target SpotInstanceRequest#capacity_reservation_target}
        /// </remarks>
        [JsiiProperty(name: "capacityReservationTarget", typeJson: "{\"fqn\":\"aws.ec2.SpotInstanceRequestCapacityReservationSpecificationCapacityReservationTarget\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ec2.ISpotInstanceRequestCapacityReservationSpecificationCapacityReservationTarget? CapacityReservationTarget
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISpotInstanceRequestCapacityReservationSpecification), fullyQualifiedName: "aws.ec2.SpotInstanceRequestCapacityReservationSpecification")]
        internal sealed class _Proxy : DeputyBase, aws.Ec2.ISpotInstanceRequestCapacityReservationSpecification
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#capacity_reservation_preference SpotInstanceRequest#capacity_reservation_preference}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "capacityReservationPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CapacityReservationPreference
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>capacity_reservation_target block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#capacity_reservation_target SpotInstanceRequest#capacity_reservation_target}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "capacityReservationTarget", typeJson: "{\"fqn\":\"aws.ec2.SpotInstanceRequestCapacityReservationSpecificationCapacityReservationTarget\"}", isOptional: true)]
            public aws.Ec2.ISpotInstanceRequestCapacityReservationSpecificationCapacityReservationTarget? CapacityReservationTarget
            {
                get => GetInstanceProperty<aws.Ec2.ISpotInstanceRequestCapacityReservationSpecificationCapacityReservationTarget?>();
            }
        }
    }
}
