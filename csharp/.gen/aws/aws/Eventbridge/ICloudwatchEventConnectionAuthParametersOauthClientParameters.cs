using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Eventbridge
{
    [JsiiInterface(nativeType: typeof(ICloudwatchEventConnectionAuthParametersOauthClientParameters), fullyQualifiedName: "aws.eventbridge.CloudwatchEventConnectionAuthParametersOauthClientParameters")]
    public interface ICloudwatchEventConnectionAuthParametersOauthClientParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_connection#client_id CloudwatchEventConnection#client_id}.</summary>
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
        string ClientId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_connection#client_secret CloudwatchEventConnection#client_secret}.</summary>
        [JsiiProperty(name: "clientSecret", typeJson: "{\"primitive\":\"string\"}")]
        string ClientSecret
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchEventConnectionAuthParametersOauthClientParameters), fullyQualifiedName: "aws.eventbridge.CloudwatchEventConnectionAuthParametersOauthClientParameters")]
        internal sealed class _Proxy : DeputyBase, aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauthClientParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_connection#client_id CloudwatchEventConnection#client_id}.</summary>
            [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
            public string ClientId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_connection#client_secret CloudwatchEventConnection#client_secret}.</summary>
            [JsiiProperty(name: "clientSecret", typeJson: "{\"primitive\":\"string\"}")]
            public string ClientSecret
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
