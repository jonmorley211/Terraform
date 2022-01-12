using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiByValue(fqn: "aws.ec2.InstanceCapacityReservationSpecificationCapacityReservationTarget")]
    public class InstanceCapacityReservationSpecificationCapacityReservationTarget : aws.Ec2.IInstanceCapacityReservationSpecificationCapacityReservationTarget
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/instance#capacity_reservation_id Instance#capacity_reservation_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "capacityReservationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CapacityReservationId
        {
            get;
            set;
        }
    }
}
