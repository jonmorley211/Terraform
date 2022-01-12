using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Eventbridge
{
    [JsiiInterface(nativeType: typeof(ICloudwatchEventConnectionAuthParametersInvocationHttpParameters), fullyQualifiedName: "aws.eventbridge.CloudwatchEventConnectionAuthParametersInvocationHttpParameters")]
    public interface ICloudwatchEventConnectionAuthParametersInvocationHttpParameters
    {
        /// <summary>body block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_connection#body CloudwatchEventConnection#body}
        /// </remarks>
        [JsiiProperty(name: "body", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersInvocationHttpParametersBody\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Eventbridge.ICloudwatchEventConnectionAuthParametersInvocationHttpParametersBody[]? Body
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
        [JsiiProperty(name: "header", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersInvocationHttpParametersHeader\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Eventbridge.ICloudwatchEventConnectionAuthParametersInvocationHttpParametersHeader[]? Header
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
        [JsiiProperty(name: "queryString", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersInvocationHttpParametersQueryString\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Eventbridge.ICloudwatchEventConnectionAuthParametersInvocationHttpParametersQueryString[]? QueryString
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchEventConnectionAuthParametersInvocationHttpParameters), fullyQualifiedName: "aws.eventbridge.CloudwatchEventConnectionAuthParametersInvocationHttpParameters")]
        internal sealed class _Proxy : DeputyBase, aws.Eventbridge.ICloudwatchEventConnectionAuthParametersInvocationHttpParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>body block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_connection#body CloudwatchEventConnection#body}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "body", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersInvocationHttpParametersBody\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Eventbridge.ICloudwatchEventConnectionAuthParametersInvocationHttpParametersBody[]? Body
            {
                get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventConnectionAuthParametersInvocationHttpParametersBody[]?>();
            }

            /// <summary>header block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_connection#header CloudwatchEventConnection#header}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "header", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersInvocationHttpParametersHeader\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Eventbridge.ICloudwatchEventConnectionAuthParametersInvocationHttpParametersHeader[]? Header
            {
                get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventConnectionAuthParametersInvocationHttpParametersHeader[]?>();
            }

            /// <summary>query_string block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_connection#query_string CloudwatchEventConnection#query_string}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queryString", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersInvocationHttpParametersQueryString\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Eventbridge.ICloudwatchEventConnectionAuthParametersInvocationHttpParametersQueryString[]? QueryString
            {
                get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventConnectionAuthParametersInvocationHttpParametersQueryString[]?>();
            }
        }
    }
}
