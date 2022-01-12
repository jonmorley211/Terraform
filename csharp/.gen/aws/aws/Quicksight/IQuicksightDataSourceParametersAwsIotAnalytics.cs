using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Quicksight
{
    [JsiiInterface(nativeType: typeof(IQuicksightDataSourceParametersAwsIotAnalytics), fullyQualifiedName: "aws.quicksight.QuicksightDataSourceParametersAwsIotAnalytics")]
    public interface IQuicksightDataSourceParametersAwsIotAnalytics
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#data_set_name QuicksightDataSource#data_set_name}.</summary>
        [JsiiProperty(name: "dataSetName", typeJson: "{\"primitive\":\"string\"}")]
        string DataSetName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightDataSourceParametersAwsIotAnalytics), fullyQualifiedName: "aws.quicksight.QuicksightDataSourceParametersAwsIotAnalytics")]
        internal sealed class _Proxy : DeputyBase, aws.Quicksight.IQuicksightDataSourceParametersAwsIotAnalytics
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#data_set_name QuicksightDataSource#data_set_name}.</summary>
            [JsiiProperty(name: "dataSetName", typeJson: "{\"primitive\":\"string\"}")]
            public string DataSetName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
