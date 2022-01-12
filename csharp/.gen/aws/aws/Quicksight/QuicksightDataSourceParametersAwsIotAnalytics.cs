using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Quicksight
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.quicksight.QuicksightDataSourceParametersAwsIotAnalytics")]
    public class QuicksightDataSourceParametersAwsIotAnalytics : aws.Quicksight.IQuicksightDataSourceParametersAwsIotAnalytics
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#data_set_name QuicksightDataSource#data_set_name}.</summary>
        [JsiiProperty(name: "dataSetName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string DataSetName
        {
            get;
            set;
        }
    }
}
