using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationEnvironmentProperties")]
    public class Kinesisanalyticsv2ApplicationApplicationConfigurationEnvironmentProperties : aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationEnvironmentProperties
    {
        /// <summary>property_group block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#property_group Kinesisanalyticsv2Application#property_group}
        /// </remarks>
        [JsiiProperty(name: "propertyGroup", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationEnvironmentPropertiesPropertyGroup\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationEnvironmentPropertiesPropertyGroup[] PropertyGroup
        {
            get;
            set;
        }
    }
}
