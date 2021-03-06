using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiInterface(nativeType: typeof(IKinesisanalyticsv2ApplicationApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutput), fullyQualifiedName: "aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutput")]
    public interface IKinesisanalyticsv2ApplicationApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutput
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#resource_arn Kinesisanalyticsv2Application#resource_arn}.</summary>
        [JsiiProperty(name: "resourceArn", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisanalyticsv2ApplicationApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutput), fullyQualifiedName: "aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutput")]
        internal sealed class _Proxy : DeputyBase, aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutput
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#resource_arn Kinesisanalyticsv2Application#resource_arn}.</summary>
            [JsiiProperty(name: "resourceArn", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
