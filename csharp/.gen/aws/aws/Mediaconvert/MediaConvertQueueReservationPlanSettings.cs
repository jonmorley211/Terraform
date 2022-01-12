using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Mediaconvert
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.mediaconvert.MediaConvertQueueReservationPlanSettings")]
    public class MediaConvertQueueReservationPlanSettings : aws.Mediaconvert.IMediaConvertQueueReservationPlanSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/media_convert_queue#commitment MediaConvertQueue#commitment}.</summary>
        [JsiiProperty(name: "commitment", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Commitment
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/media_convert_queue#renewal_type MediaConvertQueue#renewal_type}.</summary>
        [JsiiProperty(name: "renewalType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string RenewalType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/media_convert_queue#reserved_slots MediaConvertQueue#reserved_slots}.</summary>
        [JsiiProperty(name: "reservedSlots", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double ReservedSlots
        {
            get;
            set;
        }
    }
}
