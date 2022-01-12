using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Quicksight
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.quicksight.QuicksightDataSourceSslProperties")]
    public class QuicksightDataSourceSslProperties : aws.Quicksight.IQuicksightDataSourceSslProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#disable_ssl QuicksightDataSource#disable_ssl}.</summary>
        [JsiiProperty(name: "disableSsl", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOverride: true)]
        public object DisableSsl
        {
            get;
            set;
        }
    }
}
