using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiInterface(nativeType: typeof(IKinesisAnalyticsApplicationInputsStartingPositionConfiguration), fullyQualifiedName: "aws.kinesis.KinesisAnalyticsApplicationInputsStartingPositionConfiguration")]
    public interface IKinesisAnalyticsApplicationInputsStartingPositionConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#starting_position KinesisAnalyticsApplication#starting_position}.</summary>
        [JsiiProperty(name: "startingPosition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StartingPosition
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisAnalyticsApplicationInputsStartingPositionConfiguration), fullyQualifiedName: "aws.kinesis.KinesisAnalyticsApplicationInputsStartingPositionConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Kinesis.IKinesisAnalyticsApplicationInputsStartingPositionConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#starting_position KinesisAnalyticsApplication#starting_position}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "startingPosition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StartingPosition
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
