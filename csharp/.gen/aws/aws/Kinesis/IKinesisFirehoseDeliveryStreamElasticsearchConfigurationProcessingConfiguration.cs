using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiInterface(nativeType: typeof(IKinesisFirehoseDeliveryStreamElasticsearchConfigurationProcessingConfiguration), fullyQualifiedName: "aws.kinesis.KinesisFirehoseDeliveryStreamElasticsearchConfigurationProcessingConfiguration")]
    public interface IKinesisFirehoseDeliveryStreamElasticsearchConfigurationProcessingConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#enabled KinesisFirehoseDeliveryStream#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>processors block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#processors KinesisFirehoseDeliveryStream#processors}
        /// </remarks>
        [JsiiProperty(name: "processors", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamElasticsearchConfigurationProcessingConfigurationProcessors\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Kinesis.IKinesisFirehoseDeliveryStreamElasticsearchConfigurationProcessingConfigurationProcessors[]? Processors
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisFirehoseDeliveryStreamElasticsearchConfigurationProcessingConfiguration), fullyQualifiedName: "aws.kinesis.KinesisFirehoseDeliveryStreamElasticsearchConfigurationProcessingConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Kinesis.IKinesisFirehoseDeliveryStreamElasticsearchConfigurationProcessingConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#enabled KinesisFirehoseDeliveryStream#enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>processors block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#processors KinesisFirehoseDeliveryStream#processors}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "processors", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamElasticsearchConfigurationProcessingConfigurationProcessors\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Kinesis.IKinesisFirehoseDeliveryStreamElasticsearchConfigurationProcessingConfigurationProcessors[]? Processors
            {
                get => GetInstanceProperty<aws.Kinesis.IKinesisFirehoseDeliveryStreamElasticsearchConfigurationProcessingConfigurationProcessors[]?>();
            }
        }
    }
}
