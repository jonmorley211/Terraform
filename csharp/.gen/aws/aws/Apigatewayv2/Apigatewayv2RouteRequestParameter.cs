using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigatewayv2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.apigatewayv2.Apigatewayv2RouteRequestParameter")]
    public class Apigatewayv2RouteRequestParameter : aws.Apigatewayv2.IApigatewayv2RouteRequestParameter
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_route#request_parameter_key Apigatewayv2Route#request_parameter_key}.</summary>
        [JsiiProperty(name: "requestParameterKey", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string RequestParameterKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_route#required Apigatewayv2Route#required}.</summary>
        [JsiiProperty(name: "required", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOverride: true)]
        public object Required
        {
            get;
            set;
        }
    }
}
