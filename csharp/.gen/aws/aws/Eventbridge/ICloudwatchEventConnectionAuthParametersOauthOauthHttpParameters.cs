using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Eventbridge
{
    [JsiiInterface(nativeType: typeof(ICloudwatchEventConnectionAuthParametersOauthOauthHttpParameters), fullyQualifiedName: "aws.eventbridge.CloudwatchEventConnectionAuthParametersOauthOauthHttpParameters")]
    public interface ICloudwatchEventConnectionAuthParametersOauthOauthHttpParameters
    {
        /// <summary>body block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_connection#body CloudwatchEventConnection#body}
        /// </remarks>
        [JsiiProperty(name: "body", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersOauthOauthHttpParametersBody\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauthOauthHttpParametersBody[]? Body
        {
            get
            {
                return null;
            }
        }

        /// <summary>header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_connection#header CloudwatchEventConnection#header}
        /// </remarks>
        [JsiiProperty(name: "header", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersOauthOauthHttpParametersHeader\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauthOauthHttpParametersHeader[]? Header
        {
            get
            {
                return null;
            }
        }

        /// <summary>query_string block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_connection#query_string CloudwatchEventConnection#query_string}
        /// </remarks>
        [JsiiProperty(name: "queryString", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersOauthOauthHttpParametersQueryString\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauthOauthHttpParametersQueryString[]? QueryString
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchEventConnectionAuthParametersOauthOauthHttpParameters), fullyQualifiedName: "aws.eventbridge.CloudwatchEventConnectionAuthParametersOauthOauthHttpParameters")]
        internal sealed class _Proxy : DeputyBase, aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauthOauthHttpParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>body block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_connection#body CloudwatchEventConnection#body}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "body", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersOauthOauthHttpParametersBody\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauthOauthHttpParametersBody[]? Body
            {
                get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauthOauthHttpParametersBody[]?>();
            }

            /// <summary>header block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_connection#header CloudwatchEventConnection#header}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "header", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersOauthOauthHttpParametersHeader\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauthOauthHttpParametersHeader[]? Header
            {
                get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauthOauthHttpParametersHeader[]?>();
            }

            /// <summary>query_string block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_connection#query_string CloudwatchEventConnection#query_string}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queryString", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersOauthOauthHttpParametersQueryString\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauthOauthHttpParametersQueryString[]? QueryString
            {
                get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauthOauthHttpParametersQueryString[]?>();
            }
        }
    }
}
