using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Quicksight
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.quicksight.QuicksightDataSourceVpcConnectionProperties")]
    public class QuicksightDataSourceVpcConnectionProperties : aws.Quicksight.IQuicksightDataSourceVpcConnectionProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#vpc_connection_arn QuicksightDataSource#vpc_connection_arn}.</summary>
        [JsiiProperty(name: "vpcConnectionArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string VpcConnectionArn
        {
            get;
            set;
        }
    }
}
