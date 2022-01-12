using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiInterface(nativeType: typeof(IKinesisanalyticsv2ApplicationCloudwatchLoggingOptions), fullyQualifiedName: "aws.kinesis.Kinesisanalyticsv2ApplicationCloudwatchLoggingOptions")]
    public interface IKinesisanalyticsv2ApplicationCloudwatchLoggingOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#log_stream_arn Kinesisanalyticsv2Application#log_stream_arn}.</summary>
        [JsiiProperty(name: "logStreamArn", typeJson: "{\"primitive\":\"string\"}")]
        string LogStreamArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisanalyticsv2ApplicationCloudwatchLoggingOptions), fullyQualifiedName: "aws.kinesis.Kinesisanalyticsv2ApplicationCloudwatchLoggingOptions")]
        internal sealed class _Proxy : DeputyBase, aws.Kinesis.IKinesisanalyticsv2ApplicationCloudwatchLoggingOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#log_stream_arn Kinesisanalyticsv2Application#log_stream_arn}.</summary>
            [JsiiProperty(name: "logStreamArn", typeJson: "{\"primitive\":\"string\"}")]
            public string LogStreamArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
