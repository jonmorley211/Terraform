using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiInterface(nativeType: typeof(IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersCsv), fullyQualifiedName: "aws.kinesis.KinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersCsv")]
    public interface IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersCsv
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#record_column_delimiter KinesisAnalyticsApplication#record_column_delimiter}.</summary>
        [JsiiProperty(name: "recordColumnDelimiter", typeJson: "{\"primitive\":\"string\"}")]
        string RecordColumnDelimiter
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#record_row_delimiter KinesisAnalyticsApplication#record_row_delimiter}.</summary>
        [JsiiProperty(name: "recordRowDelimiter", typeJson: "{\"primitive\":\"string\"}")]
        string RecordRowDelimiter
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersCsv), fullyQualifiedName: "aws.kinesis.KinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersCsv")]
        internal sealed class _Proxy : DeputyBase, aws.Kinesis.IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersCsv
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#record_column_delimiter KinesisAnalyticsApplication#record_column_delimiter}.</summary>
            [JsiiProperty(name: "recordColumnDelimiter", typeJson: "{\"primitive\":\"string\"}")]
            public string RecordColumnDelimiter
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#record_row_delimiter KinesisAnalyticsApplication#record_row_delimiter}.</summary>
            [JsiiProperty(name: "recordRowDelimiter", typeJson: "{\"primitive\":\"string\"}")]
            public string RecordRowDelimiter
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
