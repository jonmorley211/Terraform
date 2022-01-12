using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigateway
{
    [JsiiInterface(nativeType: typeof(IApiGatewayDomainNameMutualTlsAuthentication), fullyQualifiedName: "aws.apigateway.ApiGatewayDomainNameMutualTlsAuthentication")]
    public interface IApiGatewayDomainNameMutualTlsAuthentication
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_domain_name#truststore_uri ApiGatewayDomainName#truststore_uri}.</summary>
        [JsiiProperty(name: "truststoreUri", typeJson: "{\"primitive\":\"string\"}")]
        string TruststoreUri
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_domain_name#truststore_version ApiGatewayDomainName#truststore_version}.</summary>
        [JsiiProperty(name: "truststoreVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TruststoreVersion
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiGatewayDomainNameMutualTlsAuthentication), fullyQualifiedName: "aws.apigateway.ApiGatewayDomainNameMutualTlsAuthentication")]
        internal sealed class _Proxy : DeputyBase, aws.Apigateway.IApiGatewayDomainNameMutualTlsAuthentication
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_domain_name#truststore_uri ApiGatewayDomainName#truststore_uri}.</summary>
            [JsiiProperty(name: "truststoreUri", typeJson: "{\"primitive\":\"string\"}")]
            public string TruststoreUri
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_domain_name#truststore_version ApiGatewayDomainName#truststore_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "truststoreVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TruststoreVersion
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
