using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ses
{
    [JsiiInterface(nativeType: typeof(ISesConfigurationSetDeliveryOptions), fullyQualifiedName: "aws.ses.SesConfigurationSetDeliveryOptions")]
    public interface ISesConfigurationSetDeliveryOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_configuration_set#tls_policy SesConfigurationSet#tls_policy}.</summary>
        [JsiiProperty(name: "tlsPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TlsPolicy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISesConfigurationSetDeliveryOptions), fullyQualifiedName: "aws.ses.SesConfigurationSetDeliveryOptions")]
        internal sealed class _Proxy : DeputyBase, aws.Ses.ISesConfigurationSetDeliveryOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_configuration_set#tls_policy SesConfigurationSet#tls_policy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tlsPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TlsPolicy
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
