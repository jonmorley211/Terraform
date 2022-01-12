using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Eventbridge
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.eventbridge.CloudwatchEventConnectionAuthParametersOauth")]
    public class CloudwatchEventConnectionAuthParametersOauth : aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauth
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_connection#authorization_endpoint CloudwatchEventConnection#authorization_endpoint}.</summary>
        [JsiiProperty(name: "authorizationEndpoint", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string AuthorizationEndpoint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_connection#http_method CloudwatchEventConnection#http_method}.</summary>
        [JsiiProperty(name: "httpMethod", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string HttpMethod
        {
            get;
            set;
        }

        /// <summary>oauth_http_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_connection#oauth_http_parameters CloudwatchEventConnection#oauth_http_parameters}
        /// </remarks>
        [JsiiProperty(name: "oauthHttpParameters", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersOauthOauthHttpParameters\"}", isOverride: true)]
        public aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauthOauthHttpParameters OauthHttpParameters
        {
            get;
            set;
        }

        /// <summary>client_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_connection#client_parameters CloudwatchEventConnection#client_parameters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clientParameters", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersOauthClientParameters\"}", isOptional: true, isOverride: true)]
        public aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauthClientParameters? ClientParameters
        {
            get;
            set;
        }
    }
}
