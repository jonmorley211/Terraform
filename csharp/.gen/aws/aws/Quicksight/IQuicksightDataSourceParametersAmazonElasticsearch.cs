using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Quicksight
{
    [JsiiInterface(nativeType: typeof(IQuicksightDataSourceParametersAmazonElasticsearch), fullyQualifiedName: "aws.quicksight.QuicksightDataSourceParametersAmazonElasticsearch")]
    public interface IQuicksightDataSourceParametersAmazonElasticsearch
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#domain QuicksightDataSource#domain}.</summary>
        [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}")]
        string Domain
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightDataSourceParametersAmazonElasticsearch), fullyQualifiedName: "aws.quicksight.QuicksightDataSourceParametersAmazonElasticsearch")]
        internal sealed class _Proxy : DeputyBase, aws.Quicksight.IQuicksightDataSourceParametersAmazonElasticsearch
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#domain QuicksightDataSource#domain}.</summary>
            [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}")]
            public string Domain
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
