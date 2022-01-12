using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiByValue(fqn: "aws.ec2.SpotInstanceRequestCapacityReservationSpecificationCapacityReservationTarget")]
    public class SpotInstanceRequestCapacityReservationSpecificationCapacityReservationTarget : aws.Ec2.ISpotInstanceRequestCapacityReservationSpecificationCapacityReservationTarget
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#capacity_reservation_id SpotInstanceRequest#capacity_reservation_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "capacityReservationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CapacityReservationId
        {
            get;
            set;
        }
    }
}
