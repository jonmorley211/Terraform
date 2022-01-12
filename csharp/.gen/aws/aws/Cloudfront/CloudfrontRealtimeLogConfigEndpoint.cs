using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfront.CloudfrontRealtimeLogConfigEndpoint")]
    public class CloudfrontRealtimeLogConfigEndpoint : aws.Cloudfront.ICloudfrontRealtimeLogConfigEndpoint
    {
        /// <summary>kinesis_stream_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_realtime_log_config#kinesis_stream_config CloudfrontRealtimeLogConfig#kinesis_stream_config}
        /// </remarks>
        [JsiiProperty(name: "kinesisStreamConfig", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontRealtimeLogConfigEndpointKinesisStreamConfig\"}", isOverride: true)]
        public aws.Cloudfront.ICloudfrontRealtimeLogConfigEndpointKinesisStreamConfig KinesisStreamConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_realtime_log_config#stream_type CloudfrontRealtimeLogConfig#stream_type}.</summary>
        [JsiiProperty(name: "streamType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string StreamType
        {
            get;
            set;
        }
    }
}
