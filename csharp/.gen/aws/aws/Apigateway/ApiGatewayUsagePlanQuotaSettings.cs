using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigateway
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.apigateway.ApiGatewayUsagePlanQuotaSettings")]
    public class ApiGatewayUsagePlanQuotaSettings : aws.Apigateway.IApiGatewayUsagePlanQuotaSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_usage_plan#limit ApiGatewayUsagePlan#limit}.</summary>
        [JsiiProperty(name: "limit", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double Limit
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_usage_plan#period ApiGatewayUsagePlan#period}.</summary>
        [JsiiProperty(name: "period", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Period
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_usage_plan#offset ApiGatewayUsagePlan#offset}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "offset", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Offset
        {
            get;
            set;
        }
    }
}
