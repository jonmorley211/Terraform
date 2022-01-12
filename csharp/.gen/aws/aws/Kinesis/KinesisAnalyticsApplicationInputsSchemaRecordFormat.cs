using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiByValue(fqn: "aws.kinesis.KinesisAnalyticsApplicationInputsSchemaRecordFormat")]
    public class KinesisAnalyticsApplicationInputsSchemaRecordFormat : aws.Kinesis.IKinesisAnalyticsApplicationInputsSchemaRecordFormat
    {
        /// <summary>mapping_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#mapping_parameters KinesisAnalyticsApplication#mapping_parameters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mappingParameters", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParameters\"}", isOptional: true, isOverride: true)]
        public aws.Kinesis.IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParameters? MappingParameters
        {
            get;
            set;
        }
    }
}
