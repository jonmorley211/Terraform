using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Quicksight
{
    [JsiiInterface(nativeType: typeof(IQuicksightDataSourceSslProperties), fullyQualifiedName: "aws.quicksight.QuicksightDataSourceSslProperties")]
    public interface IQuicksightDataSourceSslProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#disable_ssl QuicksightDataSource#disable_ssl}.</summary>
        [JsiiProperty(name: "disableSsl", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object DisableSsl
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightDataSourceSslProperties), fullyQualifiedName: "aws.quicksight.QuicksightDataSourceSslProperties")]
        internal sealed class _Proxy : DeputyBase, aws.Quicksight.IQuicksightDataSourceSslProperties
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#disable_ssl QuicksightDataSource#disable_ssl}.</summary>
            [JsiiProperty(name: "disableSsl", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object DisableSsl
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
