using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiByValue(fqn: "aws.ec2.InstanceCapacityReservationSpecification")]
    public class InstanceCapacityReservationSpecification : aws.Ec2.IInstanceCapacityReservationSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/instance#capacity_reservation_preference Instance#capacity_reservation_preference}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "capacityReservationPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CapacityReservationPreference
        {
            get;
            set;
        }

        /// <summary>capacity_reservation_target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/instance#capacity_reservation_target Instance#capacity_reservation_target}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "capacityReservationTarget", typeJson: "{\"fqn\":\"aws.ec2.InstanceCapacityReservationSpecificationCapacityReservationTarget\"}", isOptional: true, isOverride: true)]
        public aws.Ec2.IInstanceCapacityReservationSpecificationCapacityReservationTarget? CapacityReservationTarget
        {
            get;
            set;
        }
    }
}
