using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Quicksight
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.quicksight.QuicksightDataSourceParametersSpark")]
    public class QuicksightDataSourceParametersSpark : aws.Quicksight.IQuicksightDataSourceParametersSpark
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#host QuicksightDataSource#host}.</summary>
        [JsiiProperty(name: "host", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Host
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#port QuicksightDataSource#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double Port
        {
            get;
            set;
        }
    }
}
