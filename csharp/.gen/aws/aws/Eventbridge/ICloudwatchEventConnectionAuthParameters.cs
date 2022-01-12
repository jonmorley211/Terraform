using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Eventbridge
{
    [JsiiInterface(nativeType: typeof(ICloudwatchEventConnectionAuthParameters), fullyQualifiedName: "aws.eventbridge.CloudwatchEventConnectionAuthParameters")]
    public interface ICloudwatchEventConnectionAuthParameters
    {
        /// <summary>api_key block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_connection#api_key CloudwatchEventConnection#api_key}
        /// </remarks>
        [JsiiProperty(name: "apiKey", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersApiKey\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Eventbridge.ICloudwatchEventConnectionAuthParametersApiKey? ApiKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>basic block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_connection#basic CloudwatchEventConnection#basic}
        /// </remarks>
        [JsiiProperty(name: "basic", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersBasic\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Eventbridge.ICloudwatchEventConnectionAuthParametersBasic? Basic
        {
            get
            {
                return null;
            }
        }

        /// <summary>invocation_http_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_connection#invocation_http_parameters CloudwatchEventConnection#invocation_http_parameters}
        /// </remarks>
        [JsiiProperty(name: "invocationHttpParameters", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersInvocationHttpParameters\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Eventbridge.ICloudwatchEventConnectionAuthParametersInvocationHttpParameters? InvocationHttpParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>oauth block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_connection#oauth CloudwatchEventConnection#oauth}
        /// </remarks>
        [JsiiProperty(name: "oauth", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersOauth\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauth? Oauth
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchEventConnectionAuthParameters), fullyQualifiedName: "aws.eventbridge.CloudwatchEventConnectionAuthParameters")]
        internal sealed class _Proxy : DeputyBase, aws.Eventbridge.ICloudwatchEventConnectionAuthParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>api_key block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_connection#api_key CloudwatchEventConnection#api_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "apiKey", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersApiKey\"}", isOptional: true)]
            public aws.Eventbridge.ICloudwatchEventConnectionAuthParametersApiKey? ApiKey
            {
                get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventConnectionAuthParametersApiKey?>();
            }

            /// <summary>basic block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_connection#basic CloudwatchEventConnection#basic}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "basic", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersBasic\"}", isOptional: true)]
            public aws.Eventbridge.ICloudwatchEventConnectionAuthParametersBasic? Basic
            {
                get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventConnectionAuthParametersBasic?>();
            }

            /// <summary>invocation_http_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_connection#invocation_http_parameters CloudwatchEventConnection#invocation_http_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "invocationHttpParameters", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersInvocationHttpParameters\"}", isOptional: true)]
            public aws.Eventbridge.ICloudwatchEventConnectionAuthParametersInvocationHttpParameters? InvocationHttpParameters
            {
                get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventConnectionAuthParametersInvocationHttpParameters?>();
            }

            /// <summary>oauth block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_connection#oauth CloudwatchEventConnection#oauth}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "oauth", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersOauth\"}", isOptional: true)]
            public aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauth? Oauth
            {
                get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauth?>();
            }
        }
    }
}
