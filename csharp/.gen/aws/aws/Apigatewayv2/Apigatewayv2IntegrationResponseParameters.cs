using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigatewayv2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.apigatewayv2.Apigatewayv2IntegrationResponseParameters")]
    public class Apigatewayv2IntegrationResponseParameters : aws.Apigatewayv2.IApigatewayv2IntegrationResponseParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_integration#mappings Apigatewayv2Integration#mappings}.</summary>
        [JsiiProperty(name: "mappings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOverride: true)]
        public object Mappings
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_integration#status_code Apigatewayv2Integration#status_code}.</summary>
        [JsiiProperty(name: "statusCode", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string StatusCode
        {
            get;
            set;
        }
    }
}
