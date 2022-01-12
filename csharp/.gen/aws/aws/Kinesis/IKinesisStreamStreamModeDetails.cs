using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiInterface(nativeType: typeof(IKinesisStreamStreamModeDetails), fullyQualifiedName: "aws.kinesis.KinesisStreamStreamModeDetails")]
    public interface IKinesisStreamStreamModeDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_stream#stream_mode KinesisStream#stream_mode}.</summary>
        [JsiiProperty(name: "streamMode", typeJson: "{\"primitive\":\"string\"}")]
        string StreamMode
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisStreamStreamModeDetails), fullyQualifiedName: "aws.kinesis.KinesisStreamStreamModeDetails")]
        internal sealed class _Proxy : DeputyBase, aws.Kinesis.IKinesisStreamStreamModeDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_stream#stream_mode KinesisStream#stream_mode}.</summary>
            [JsiiProperty(name: "streamMode", typeJson: "{\"primitive\":\"string\"}")]
            public string StreamMode
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
