using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiByValue(fqn: "aws.ec2.SpotInstanceRequestCapacityReservationSpecification")]
    public class SpotInstanceRequestCapacityReservationSpecification : aws.Ec2.ISpotInstanceRequestCapacityReservationSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#capacity_reservation_preference SpotInstanceRequest#capacity_reservation_preference}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "capacityReservationPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CapacityReservationPreference
        {
            get;
            set;
        }

        /// <summary>capacity_reservation_target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#capacity_reservation_target SpotInstanceRequest#capacity_reservation_target}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "capacityReservationTarget", typeJson: "{\"fqn\":\"aws.ec2.SpotInstanceRequestCapacityReservationSpecificationCapacityReservationTarget\"}", isOptional: true, isOverride: true)]
        public aws.Ec2.ISpotInstanceRequestCapacityReservationSpecificationCapacityReservationTarget? CapacityReservationTarget
        {
            get;
            set;
        }
    }
}
