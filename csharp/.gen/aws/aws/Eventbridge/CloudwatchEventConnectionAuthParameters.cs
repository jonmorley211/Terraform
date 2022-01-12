using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Eventbridge
{
    [JsiiByValue(fqn: "aws.eventbridge.CloudwatchEventConnectionAuthParameters")]
    public class CloudwatchEventConnectionAuthParameters : aws.Eventbridge.ICloudwatchEventConnectionAuthParameters
    {
        /// <summary>api_key block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_connection#api_key CloudwatchEventConnection#api_key}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "apiKey", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersApiKey\"}", isOptional: true, isOverride: true)]
        public aws.Eventbridge.ICloudwatchEventConnectionAuthParametersApiKey? ApiKey
        {
            get;
            set;
        }

        /// <summary>basic block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_connection#basic CloudwatchEventConnection#basic}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "basic", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersBasic\"}", isOptional: true, isOverride: true)]
        public aws.Eventbridge.ICloudwatchEventConnectionAuthParametersBasic? Basic
        {
            get;
            set;
        }

        /// <summary>invocation_http_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_connection#invocation_http_parameters CloudwatchEventConnection#invocation_http_parameters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "invocationHttpParameters", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersInvocationHttpParameters\"}", isOptional: true, isOverride: true)]
        public aws.Eventbridge.ICloudwatchEventConnectionAuthParametersInvocationHttpParameters? InvocationHttpParameters
        {
            get;
            set;
        }

        /// <summary>oauth block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_connection#oauth CloudwatchEventConnection#oauth}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "oauth", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersOauth\"}", isOptional: true, isOverride: true)]
        public aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauth? Oauth
        {
            get;
            set;
        }
    }
}
