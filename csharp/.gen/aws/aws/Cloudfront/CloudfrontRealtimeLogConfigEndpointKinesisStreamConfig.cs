using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfront.CloudfrontRealtimeLogConfigEndpointKinesisStreamConfig")]
    public class CloudfrontRealtimeLogConfigEndpointKinesisStreamConfig : aws.Cloudfront.ICloudfrontRealtimeLogConfigEndpointKinesisStreamConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_realtime_log_config#role_arn CloudfrontRealtimeLogConfig#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string RoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_realtime_log_config#stream_arn CloudfrontRealtimeLogConfig#stream_arn}.</summary>
        [JsiiProperty(name: "streamArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string StreamArn
        {
            get;
            set;
        }
    }
}
