using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.kinesis.KinesisAnalyticsApplicationInputsSchema")]
    public class KinesisAnalyticsApplicationInputsSchema : aws.Kinesis.IKinesisAnalyticsApplicationInputsSchema
    {
        /// <summary>record_columns block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#record_columns KinesisAnalyticsApplication#record_columns}
        /// </remarks>
        [JsiiProperty(name: "recordColumns", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsSchemaRecordColumns\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.Kinesis.IKinesisAnalyticsApplicationInputsSchemaRecordColumns[] RecordColumns
        {
            get;
            set;
        }

        /// <summary>record_format block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#record_format KinesisAnalyticsApplication#record_format}
        /// </remarks>
        [JsiiProperty(name: "recordFormat", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsSchemaRecordFormat\"}", isOverride: true)]
        public aws.Kinesis.IKinesisAnalyticsApplicationInputsSchemaRecordFormat RecordFormat
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#record_encoding KinesisAnalyticsApplication#record_encoding}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "recordEncoding", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? RecordEncoding
        {
            get;
            set;
        }
    }
}
