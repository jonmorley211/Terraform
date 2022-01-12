using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiByValue(fqn: "aws.kinesis.KinesisFirehoseDeliveryStreamRedshiftConfigurationProcessingConfiguration")]
    public class KinesisFirehoseDeliveryStreamRedshiftConfigurationProcessingConfiguration : aws.Kinesis.IKinesisFirehoseDeliveryStreamRedshiftConfigurationProcessingConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#enabled KinesisFirehoseDeliveryStream#enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? Enabled
        {
            get;
            set;
        }

        /// <summary>processors block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#processors KinesisFirehoseDeliveryStream#processors}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "processors", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamRedshiftConfigurationProcessingConfigurationProcessors\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Kinesis.IKinesisFirehoseDeliveryStreamRedshiftConfigurationProcessingConfigurationProcessors[]? Processors
        {
            get;
            set;
        }
    }
}
