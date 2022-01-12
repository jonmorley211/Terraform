using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiInterface(nativeType: typeof(ICloudfrontRealtimeLogConfigEndpoint), fullyQualifiedName: "aws.cloudfront.CloudfrontRealtimeLogConfigEndpoint")]
    public interface ICloudfrontRealtimeLogConfigEndpoint
    {
        /// <summary>kinesis_stream_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_realtime_log_config#kinesis_stream_config CloudfrontRealtimeLogConfig#kinesis_stream_config}
        /// </remarks>
        [JsiiProperty(name: "kinesisStreamConfig", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontRealtimeLogConfigEndpointKinesisStreamConfig\"}")]
        aws.Cloudfront.ICloudfrontRealtimeLogConfigEndpointKinesisStreamConfig KinesisStreamConfig
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_realtime_log_config#stream_type CloudfrontRealtimeLogConfig#stream_type}.</summary>
        [JsiiProperty(name: "streamType", typeJson: "{\"primitive\":\"string\"}")]
        string StreamType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontRealtimeLogConfigEndpoint), fullyQualifiedName: "aws.cloudfront.CloudfrontRealtimeLogConfigEndpoint")]
        internal sealed class _Proxy : DeputyBase, aws.Cloudfront.ICloudfrontRealtimeLogConfigEndpoint
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>kinesis_stream_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_realtime_log_config#kinesis_stream_config CloudfrontRealtimeLogConfig#kinesis_stream_config}
            /// </remarks>
            [JsiiProperty(name: "kinesisStreamConfig", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontRealtimeLogConfigEndpointKinesisStreamConfig\"}")]
            public aws.Cloudfront.ICloudfrontRealtimeLogConfigEndpointKinesisStreamConfig KinesisStreamConfig
            {
                get => GetInstanceProperty<aws.Cloudfront.ICloudfrontRealtimeLogConfigEndpointKinesisStreamConfig>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_realtime_log_config#stream_type CloudfrontRealtimeLogConfig#stream_type}.</summary>
            [JsiiProperty(name: "streamType", typeJson: "{\"primitive\":\"string\"}")]
            public string StreamType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
