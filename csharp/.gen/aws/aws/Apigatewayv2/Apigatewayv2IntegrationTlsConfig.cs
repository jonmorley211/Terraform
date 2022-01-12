using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigatewayv2
{
    [JsiiByValue(fqn: "aws.apigatewayv2.Apigatewayv2IntegrationTlsConfig")]
    public class Apigatewayv2IntegrationTlsConfig : aws.Apigatewayv2.IApigatewayv2IntegrationTlsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_integration#server_name_to_verify Apigatewayv2Integration#server_name_to_verify}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serverNameToVerify", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ServerNameToVerify
        {
            get;
            set;
        }
    }
}
