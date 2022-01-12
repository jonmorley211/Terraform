using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudtrail
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudtrail.CloudtrailAdvancedEventSelector")]
    public class CloudtrailAdvancedEventSelector : aws.Cloudtrail.ICloudtrailAdvancedEventSelector
    {
        /// <summary>field_selector block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#field_selector Cloudtrail#field_selector}
        /// </remarks>
        [JsiiProperty(name: "fieldSelector", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudtrail.CloudtrailAdvancedEventSelectorFieldSelector\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.Cloudtrail.ICloudtrailAdvancedEventSelectorFieldSelector[] FieldSelector
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#name Cloudtrail#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Name
        {
            get;
            set;
        }
    }
}
