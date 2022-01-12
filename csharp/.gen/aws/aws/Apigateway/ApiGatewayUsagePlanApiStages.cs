using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigateway
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.apigateway.ApiGatewayUsagePlanApiStages")]
    public class ApiGatewayUsagePlanApiStages : aws.Apigateway.IApiGatewayUsagePlanApiStages
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_usage_plan#api_id ApiGatewayUsagePlan#api_id}.</summary>
        [JsiiProperty(name: "apiId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ApiId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_usage_plan#stage ApiGatewayUsagePlan#stage}.</summary>
        [JsiiProperty(name: "stage", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Stage
        {
            get;
            set;
        }

        /// <summary>throttle block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_usage_plan#throttle ApiGatewayUsagePlan#throttle}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "throttle", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.apigateway.ApiGatewayUsagePlanApiStagesThrottle\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Apigateway.IApiGatewayUsagePlanApiStagesThrottle[]? Throttle
        {
            get;
            set;
        }
    }
}
