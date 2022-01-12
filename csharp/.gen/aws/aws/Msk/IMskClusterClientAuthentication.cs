using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Msk
{
    [JsiiInterface(nativeType: typeof(IMskClusterClientAuthentication), fullyQualifiedName: "aws.msk.MskClusterClientAuthentication")]
    public interface IMskClusterClientAuthentication
    {
        /// <summary>sasl block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#sasl MskCluster#sasl}
        /// </remarks>
        [JsiiProperty(name: "sasl", typeJson: "{\"fqn\":\"aws.msk.MskClusterClientAuthenticationSasl\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Msk.IMskClusterClientAuthenticationSasl? Sasl
        {
            get
            {
                return null;
            }
        }

        /// <summary>tls block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#tls MskCluster#tls}
        /// </remarks>
        [JsiiProperty(name: "tls", typeJson: "{\"fqn\":\"aws.msk.MskClusterClientAuthenticationTls\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Msk.IMskClusterClientAuthenticationTls? Tls
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMskClusterClientAuthentication), fullyQualifiedName: "aws.msk.MskClusterClientAuthentication")]
        internal sealed class _Proxy : DeputyBase, aws.Msk.IMskClusterClientAuthentication
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>sasl block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#sasl MskCluster#sasl}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sasl", typeJson: "{\"fqn\":\"aws.msk.MskClusterClientAuthenticationSasl\"}", isOptional: true)]
            public aws.Msk.IMskClusterClientAuthenticationSasl? Sasl
            {
                get => GetInstanceProperty<aws.Msk.IMskClusterClientAuthenticationSasl?>();
            }

            /// <summary>tls block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#tls MskCluster#tls}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tls", typeJson: "{\"fqn\":\"aws.msk.MskClusterClientAuthenticationTls\"}", isOptional: true)]
            public aws.Msk.IMskClusterClientAuthenticationTls? Tls
            {
                get => GetInstanceProperty<aws.Msk.IMskClusterClientAuthenticationTls?>();
            }
        }
    }
}
