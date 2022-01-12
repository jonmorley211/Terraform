using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Quicksight
{
    [JsiiInterface(nativeType: typeof(IQuicksightDataSourceVpcConnectionProperties), fullyQualifiedName: "aws.quicksight.QuicksightDataSourceVpcConnectionProperties")]
    public interface IQuicksightDataSourceVpcConnectionProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#vpc_connection_arn QuicksightDataSource#vpc_connection_arn}.</summary>
        [JsiiProperty(name: "vpcConnectionArn", typeJson: "{\"primitive\":\"string\"}")]
        string VpcConnectionArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightDataSourceVpcConnectionProperties), fullyQualifiedName: "aws.quicksight.QuicksightDataSourceVpcConnectionProperties")]
        internal sealed class _Proxy : DeputyBase, aws.Quicksight.IQuicksightDataSourceVpcConnectionProperties
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#vpc_connection_arn QuicksightDataSource#vpc_connection_arn}.</summary>
            [JsiiProperty(name: "vpcConnectionArn", typeJson: "{\"primitive\":\"string\"}")]
            public string VpcConnectionArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
