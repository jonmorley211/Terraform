using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.kinesis.KinesisFirehoseDeliveryStreamSplunkConfiguration")]
    public class KinesisFirehoseDeliveryStreamSplunkConfiguration : aws.Kinesis.IKinesisFirehoseDeliveryStreamSplunkConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#hec_endpoint KinesisFirehoseDeliveryStream#hec_endpoint}.</summary>
        [JsiiProperty(name: "hecEndpoint", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string HecEndpoint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#hec_token KinesisFirehoseDeliveryStream#hec_token}.</summary>
        [JsiiProperty(name: "hecToken", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string HecToken
        {
            get;
            set;
        }

        /// <summary>cloudwatch_logging_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#cloudwatch_logging_options KinesisFirehoseDeliveryStream#cloudwatch_logging_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLoggingOptions", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamSplunkConfigurationCloudwatchLoggingOptions\"}", isOptional: true, isOverride: true)]
        public aws.Kinesis.IKinesisFirehoseDeliveryStreamSplunkConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#hec_acknowledgment_timeout KinesisFirehoseDeliveryStream#hec_acknowledgment_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hecAcknowledgmentTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? HecAcknowledgmentTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#hec_endpoint_type KinesisFirehoseDeliveryStream#hec_endpoint_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hecEndpointType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? HecEndpointType
        {
            get;
            set;
        }

        /// <summary>processing_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#processing_configuration KinesisFirehoseDeliveryStream#processing_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "processingConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamSplunkConfigurationProcessingConfiguration\"}", isOptional: true, isOverride: true)]
        public aws.Kinesis.IKinesisFirehoseDeliveryStreamSplunkConfigurationProcessingConfiguration? ProcessingConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#retry_duration KinesisFirehoseDeliveryStream#retry_duration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "retryDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? RetryDuration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#s3_backup_mode KinesisFirehoseDeliveryStream#s3_backup_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3BackupMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? S3BackupMode
        {
            get;
            set;
        }
    }
}
