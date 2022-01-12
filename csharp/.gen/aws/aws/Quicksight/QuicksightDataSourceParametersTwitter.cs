using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Quicksight
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.quicksight.QuicksightDataSourceParametersTwitter")]
    public class QuicksightDataSourceParametersTwitter : aws.Quicksight.IQuicksightDataSourceParametersTwitter
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#max_rows QuicksightDataSource#max_rows}.</summary>
        [JsiiProperty(name: "maxRows", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double MaxRows
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#query QuicksightDataSource#query}.</summary>
        [JsiiProperty(name: "query", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Query
        {
            get;
            set;
        }
    }
}
