using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ses
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ses.SesEventDestinationCloudwatchDestination")]
    public class SesEventDestinationCloudwatchDestination : aws.Ses.ISesEventDestinationCloudwatchDestination
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_event_destination#default_value SesEventDestination#default_value}.</summary>
        [JsiiProperty(name: "defaultValue", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string DefaultValue
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_event_destination#dimension_name SesEventDestination#dimension_name}.</summary>
        [JsiiProperty(name: "dimensionName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string DimensionName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_event_destination#value_source SesEventDestination#value_source}.</summary>
        [JsiiProperty(name: "valueSource", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ValueSource
        {
            get;
            set;
        }
    }
}
