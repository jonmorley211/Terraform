using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Acm
{
    [JsiiInterface(nativeType: typeof(IDataAwsAcmpcaCertificateAuthorityRevocationConfiguration), fullyQualifiedName: "aws.acm.DataAwsAcmpcaCertificateAuthorityRevocationConfiguration")]
    public interface IDataAwsAcmpcaCertificateAuthorityRevocationConfiguration
    {
        /// <summary>crl_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/acmpca_certificate_authority#crl_configuration DataAwsAcmpcaCertificateAuthority#crl_configuration}
        /// </remarks>
        [JsiiProperty(name: "crlConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.acm.DataAwsAcmpcaCertificateAuthorityRevocationConfigurationCrlConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Acm.IDataAwsAcmpcaCertificateAuthorityRevocationConfigurationCrlConfiguration[]? CrlConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsAcmpcaCertificateAuthorityRevocationConfiguration), fullyQualifiedName: "aws.acm.DataAwsAcmpcaCertificateAuthorityRevocationConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Acm.IDataAwsAcmpcaCertificateAuthorityRevocationConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>crl_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/acmpca_certificate_authority#crl_configuration DataAwsAcmpcaCertificateAuthority#crl_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "crlConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.acm.DataAwsAcmpcaCertificateAuthorityRevocationConfigurationCrlConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Acm.IDataAwsAcmpcaCertificateAuthorityRevocationConfigurationCrlConfiguration[]? CrlConfiguration
            {
                get => GetInstanceProperty<aws.Acm.IDataAwsAcmpcaCertificateAuthorityRevocationConfigurationCrlConfiguration[]?>();
            }
        }
    }
}
