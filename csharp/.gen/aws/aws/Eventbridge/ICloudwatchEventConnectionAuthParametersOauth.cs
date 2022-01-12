using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Eventbridge
{
    [JsiiInterface(nativeType: typeof(ICloudwatchEventConnectionAuthParametersOauth), fullyQualifiedName: "aws.eventbridge.CloudwatchEventConnectionAuthParametersOauth")]
    public interface ICloudwatchEventConnectionAuthParametersOauth
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_connection#authorization_endpoint CloudwatchEventConnection#authorization_endpoint}.</summary>
        [JsiiProperty(name: "authorizationEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        string AuthorizationEndpoint
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_connection#http_method CloudwatchEventConnection#http_method}.</summary>
        [JsiiProperty(name: "httpMethod", typeJson: "{\"primitive\":\"string\"}")]
        string HttpMethod
        {
            get;
        }

        /// <summary>oauth_http_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_connection#oauth_http_parameters CloudwatchEventConnection#oauth_http_parameters}
        /// </remarks>
        [JsiiProperty(name: "oauthHttpParameters", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersOauthOauthHttpParameters\"}")]
        aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauthOauthHttpParameters OauthHttpParameters
        {
            get;
        }

        /// <summary>client_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_connection#client_parameters CloudwatchEventConnection#client_parameters}
        /// </remarks>
        [JsiiProperty(name: "clientParameters", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersOauthClientParameters\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauthClientParameters? ClientParameters
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchEventConnectionAuthParametersOauth), fullyQualifiedName: "aws.eventbridge.CloudwatchEventConnectionAuthParametersOauth")]
        internal sealed class _Proxy : DeputyBase, aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauth
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_connection#authorization_endpoint CloudwatchEventConnection#authorization_endpoint}.</summary>
            [JsiiProperty(name: "authorizationEndpoint", typeJson: "{\"primitive\":\"string\"}")]
            public string AuthorizationEndpoint
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_connection#http_method CloudwatchEventConnection#http_method}.</summary>
            [JsiiProperty(name: "httpMethod", typeJson: "{\"primitive\":\"string\"}")]
            public string HttpMethod
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>oauth_http_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_connection#oauth_http_parameters CloudwatchEventConnection#oauth_http_parameters}
            /// </remarks>
            [JsiiProperty(name: "oauthHttpParameters", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersOauthOauthHttpParameters\"}")]
            public aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauthOauthHttpParameters OauthHttpParameters
            {
                get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauthOauthHttpParameters>()!;
            }

            /// <summary>client_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_connection#client_parameters CloudwatchEventConnection#client_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientParameters", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersOauthClientParameters\"}", isOptional: true)]
            public aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauthClientParameters? ClientParameters
            {
                get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauthClientParameters?>();
            }
        }
    }
}
