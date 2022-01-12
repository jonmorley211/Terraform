using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Msk
{
    [JsiiByValue(fqn: "aws.msk.MskClusterClientAuthentication")]
    public class MskClusterClientAuthentication : aws.Msk.IMskClusterClientAuthentication
    {
        /// <summary>sasl block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#sasl MskCluster#sasl}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sasl", typeJson: "{\"fqn\":\"aws.msk.MskClusterClientAuthenticationSasl\"}", isOptional: true, isOverride: true)]
        public aws.Msk.IMskClusterClientAuthenticationSasl? Sasl
        {
            get;
            set;
        }

        /// <summary>tls block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#tls MskCluster#tls}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tls", typeJson: "{\"fqn\":\"aws.msk.MskClusterClientAuthenticationTls\"}", isOptional: true, isOverride: true)]
        public aws.Msk.IMskClusterClientAuthenticationTls? Tls
        {
            get;
            set;
        }
    }
}
