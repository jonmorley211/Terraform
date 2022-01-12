using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiInterface(nativeType: typeof(IKinesisanalyticsv2ApplicationApplicationConfigurationSqlApplicationConfigurationOutput), fullyQualifiedName: "aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationSqlApplicationConfigurationOutput")]
    public interface IKinesisanalyticsv2ApplicationApplicationConfigurationSqlApplicationConfigurationOutput
    {
        /// <summary>destination_schema block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#destination_schema Kinesisanalyticsv2Application#destination_schema}
        /// </remarks>
        [JsiiProperty(name: "destinationSchema", typeJson: "{\"fqn\":\"aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationSqlApplicationConfigurationOutputDestinationSchema\"}")]
        aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationSqlApplicationConfigurationOutputDestinationSchema DestinationSchema
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#name Kinesisanalyticsv2Application#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>kinesis_firehose_output block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#kinesis_firehose_output Kinesisanalyticsv2Application#kinesis_firehose_output}
        /// </remarks>
        [JsiiProperty(name: "kinesisFirehoseOutput", typeJson: "{\"fqn\":\"aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutput\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutput? KinesisFirehoseOutput
        {
            get
            {
                return null;
            }
        }

        /// <summary>kinesis_streams_output block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#kinesis_streams_output Kinesisanalyticsv2Application#kinesis_streams_output}
        /// </remarks>
        [JsiiProperty(name: "kinesisStreamsOutput", typeJson: "{\"fqn\":\"aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationSqlApplicationConfigurationOutputKinesisStreamsOutput\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationSqlApplicationConfigurationOutputKinesisStreamsOutput? KinesisStreamsOutput
        {
            get
            {
                return null;
            }
        }

        /// <summary>lambda_output block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#lambda_output Kinesisanalyticsv2Application#lambda_output}
        /// </remarks>
        [JsiiProperty(name: "lambdaOutput", typeJson: "{\"fqn\":\"aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutput\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutput? LambdaOutput
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisanalyticsv2ApplicationApplicationConfigurationSqlApplicationConfigurationOutput), fullyQualifiedName: "aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationSqlApplicationConfigurationOutput")]
        internal sealed class _Proxy : DeputyBase, aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationSqlApplicationConfigurationOutput
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>destination_schema block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#destination_schema Kinesisanalyticsv2Application#destination_schema}
            /// </remarks>
            [JsiiProperty(name: "destinationSchema", typeJson: "{\"fqn\":\"aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationSqlApplicationConfigurationOutputDestinationSchema\"}")]
            public aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationSqlApplicationConfigurationOutputDestinationSchema DestinationSchema
            {
                get => GetInstanceProperty<aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationSqlApplicationConfigurationOutputDestinationSchema>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#name Kinesisanalyticsv2Application#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>kinesis_firehose_output block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#kinesis_firehose_output Kinesisanalyticsv2Application#kinesis_firehose_output}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kinesisFirehoseOutput", typeJson: "{\"fqn\":\"aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutput\"}", isOptional: true)]
            public aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutput? KinesisFirehoseOutput
            {
                get => GetInstanceProperty<aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutput?>();
            }

            /// <summary>kinesis_streams_output block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#kinesis_streams_output Kinesisanalyticsv2Application#kinesis_streams_output}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kinesisStreamsOutput", typeJson: "{\"fqn\":\"aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationSqlApplicationConfigurationOutputKinesisStreamsOutput\"}", isOptional: true)]
            public aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationSqlApplicationConfigurationOutputKinesisStreamsOutput? KinesisStreamsOutput
            {
                get => GetInstanceProperty<aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationSqlApplicationConfigurationOutputKinesisStreamsOutput?>();
            }

            /// <summary>lambda_output block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#lambda_output Kinesisanalyticsv2Application#lambda_output}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lambdaOutput", typeJson: "{\"fqn\":\"aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutput\"}", isOptional: true)]
            public aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutput? LambdaOutput
            {
                get => GetInstanceProperty<aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutput?>();
            }
        }
    }
}
