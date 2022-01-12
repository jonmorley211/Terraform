using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigatewayv2
{
    [JsiiByValue(fqn: "aws.apigatewayv2.Apigatewayv2AuthorizerJwtConfiguration")]
    public class Apigatewayv2AuthorizerJwtConfiguration : aws.Apigatewayv2.IApigatewayv2AuthorizerJwtConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_authorizer#audience Apigatewayv2Authorizer#audience}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "audience", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? Audience
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_authorizer#issuer Apigatewayv2Authorizer#issuer}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Issuer
        {
            get;
            set;
        }
    }
}
