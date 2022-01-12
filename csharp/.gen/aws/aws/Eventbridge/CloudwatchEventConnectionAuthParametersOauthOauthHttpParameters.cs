using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Eventbridge
{
    [JsiiByValue(fqn: "aws.eventbridge.CloudwatchEventConnectionAuthParametersOauthOauthHttpParameters")]
    public class CloudwatchEventConnectionAuthParametersOauthOauthHttpParameters : aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauthOauthHttpParameters
    {
        /// <summary>body block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_connection#body CloudwatchEventConnection#body}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "body", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersOauthOauthHttpParametersBody\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauthOauthHttpParametersBody[]? Body
        {
            get;
            set;
        }

        /// <summary>header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_connection#header CloudwatchEventConnection#header}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "header", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersOauthOauthHttpParametersHeader\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauthOauthHttpParametersHeader[]? Header
        {
            get;
            set;
        }

        /// <summary>query_string block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_connection#query_string CloudwatchEventConnection#query_string}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "queryString", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersOauthOauthHttpParametersQueryString\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauthOauthHttpParametersQueryString[]? QueryString
        {
            get;
            set;
        }
    }
}
