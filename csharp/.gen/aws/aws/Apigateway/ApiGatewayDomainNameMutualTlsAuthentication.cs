using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigateway
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.apigateway.ApiGatewayDomainNameMutualTlsAuthentication")]
    public class ApiGatewayDomainNameMutualTlsAuthentication : aws.Apigateway.IApiGatewayDomainNameMutualTlsAuthentication
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_domain_name#truststore_uri ApiGatewayDomainName#truststore_uri}.</summary>
        [JsiiProperty(name: "truststoreUri", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string TruststoreUri
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_domain_name#truststore_version ApiGatewayDomainName#truststore_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "truststoreVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? TruststoreVersion
        {
            get;
            set;
        }
    }
}
