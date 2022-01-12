using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigatewayv2
{
    [JsiiInterface(nativeType: typeof(IApigatewayv2DomainNameMutualTlsAuthentication), fullyQualifiedName: "aws.apigatewayv2.Apigatewayv2DomainNameMutualTlsAuthentication")]
    public interface IApigatewayv2DomainNameMutualTlsAuthentication
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_domain_name#truststore_uri Apigatewayv2DomainName#truststore_uri}.</summary>
        [JsiiProperty(name: "truststoreUri", typeJson: "{\"primitive\":\"string\"}")]
        string TruststoreUri
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_domain_name#truststore_version Apigatewayv2DomainName#truststore_version}.</summary>
        [JsiiProperty(name: "truststoreVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TruststoreVersion
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApigatewayv2DomainNameMutualTlsAuthentication), fullyQualifiedName: "aws.apigatewayv2.Apigatewayv2DomainNameMutualTlsAuthentication")]
        internal sealed class _Proxy : DeputyBase, aws.Apigatewayv2.IApigatewayv2DomainNameMutualTlsAuthentication
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_domain_name#truststore_uri Apigatewayv2DomainName#truststore_uri}.</summary>
            [JsiiProperty(name: "truststoreUri", typeJson: "{\"primitive\":\"string\"}")]
            public string TruststoreUri
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_domain_name#truststore_version Apigatewayv2DomainName#truststore_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "truststoreVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TruststoreVersion
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
