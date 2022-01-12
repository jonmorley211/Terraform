using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiByValue(fqn: "aws.kinesis.KinesisFirehoseDeliveryStreamHttpEndpointConfigurationRequestConfiguration")]
    public class KinesisFirehoseDeliveryStreamHttpEndpointConfigurationRequestConfiguration : aws.Kinesis.IKinesisFirehoseDeliveryStreamHttpEndpointConfigurationRequestConfiguration
    {
        /// <summary>common_attributes block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#common_attributes KinesisFirehoseDeliveryStream#common_attributes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "commonAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamHttpEndpointConfigurationRequestConfigurationCommonAttributes\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Kinesis.IKinesisFirehoseDeliveryStreamHttpEndpointConfigurationRequestConfigurationCommonAttributes[]? CommonAttributes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#content_encoding KinesisFirehoseDeliveryStream#content_encoding}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "contentEncoding", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ContentEncoding
        {
            get;
            set;
        }
    }
}
