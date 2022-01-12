using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ses
{
    [JsiiByValue(fqn: "aws.ses.SesConfigurationSetDeliveryOptions")]
    public class SesConfigurationSetDeliveryOptions : aws.Ses.ISesConfigurationSetDeliveryOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_configuration_set#tls_policy SesConfigurationSet#tls_policy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tlsPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? TlsPolicy
        {
            get;
            set;
        }
    }
}
