using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationEnvironmentPropertiesPropertyGroup")]
    public class Kinesisanalyticsv2ApplicationApplicationConfigurationEnvironmentPropertiesPropertyGroup : aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationEnvironmentPropertiesPropertyGroup
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#property_group_id Kinesisanalyticsv2Application#property_group_id}.</summary>
        [JsiiProperty(name: "propertyGroupId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string PropertyGroupId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#property_map Kinesisanalyticsv2Application#property_map}.</summary>
        [JsiiProperty(name: "propertyMap", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOverride: true)]
        public object PropertyMap
        {
            get;
            set;
        }
    }
}
