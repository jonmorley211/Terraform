using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiInterface(nativeType: typeof(IKinesisanalyticsv2ApplicationApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordFormatMappingParametersJsonMappingParameters), fullyQualifiedName: "aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordFormatMappingParametersJsonMappingParameters")]
    public interface IKinesisanalyticsv2ApplicationApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordFormatMappingParametersJsonMappingParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#record_row_path Kinesisanalyticsv2Application#record_row_path}.</summary>
        [JsiiProperty(name: "recordRowPath", typeJson: "{\"primitive\":\"string\"}")]
        string RecordRowPath
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisanalyticsv2ApplicationApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordFormatMappingParametersJsonMappingParameters), fullyQualifiedName: "aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordFormatMappingParametersJsonMappingParameters")]
        internal sealed class _Proxy : DeputyBase, aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordFormatMappingParametersJsonMappingParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#record_row_path Kinesisanalyticsv2Application#record_row_path}.</summary>
            [JsiiProperty(name: "recordRowPath", typeJson: "{\"primitive\":\"string\"}")]
            public string RecordRowPath
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
