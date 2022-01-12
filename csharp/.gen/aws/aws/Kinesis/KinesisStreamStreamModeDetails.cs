using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.kinesis.KinesisStreamStreamModeDetails")]
    public class KinesisStreamStreamModeDetails : aws.Kinesis.IKinesisStreamStreamModeDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_stream#stream_mode KinesisStream#stream_mode}.</summary>
        [JsiiProperty(name: "streamMode", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string StreamMode
        {
            get;
            set;
        }
    }
}
