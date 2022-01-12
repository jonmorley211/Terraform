using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigateway
{
    [JsiiByValue(fqn: "aws.apigateway.ApiGatewayIntegrationTlsConfig")]
    public class ApiGatewayIntegrationTlsConfig : aws.Apigateway.IApiGatewayIntegrationTlsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration#insecure_skip_verification ApiGatewayIntegration#insecure_skip_verification}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "insecureSkipVerification", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? InsecureSkipVerification
        {
            get;
            set;
        }
    }
}
