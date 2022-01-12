using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordColumn")]
    public class Kinesisanalyticsv2ApplicationApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordColumn : aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordColumn
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#name Kinesisanalyticsv2Application#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#sql_type Kinesisanalyticsv2Application#sql_type}.</summary>
        [JsiiProperty(name: "sqlType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string SqlType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#mapping Kinesisanalyticsv2Application#mapping}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mapping", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Mapping
        {
            get;
            set;
        }
    }
}
