using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Acm
{
    /// <summary>Amazon Certificate Manager.</summary>
    [JsiiInterface(nativeType: typeof(IAcmpcaCertificateConfig), fullyQualifiedName: "aws.acm.AcmpcaCertificateConfig")]
    public interface IAcmpcaCertificateConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acmpca_certificate#certificate_authority_arn AcmpcaCertificate#certificate_authority_arn}.</summary>
        [JsiiProperty(name: "certificateAuthorityArn", typeJson: "{\"primitive\":\"string\"}")]
        string CertificateAuthorityArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acmpca_certificate#certificate_signing_request AcmpcaCertificate#certificate_signing_request}.</summary>
        [JsiiProperty(name: "certificateSigningRequest", typeJson: "{\"primitive\":\"string\"}")]
        string CertificateSigningRequest
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acmpca_certificate#signing_algorithm AcmpcaCertificate#signing_algorithm}.</summary>
        [JsiiProperty(name: "signingAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        string SigningAlgorithm
        {
            get;
        }

        /// <summary>validity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acmpca_certificate#validity AcmpcaCertificate#validity}
        /// </remarks>
        [JsiiProperty(name: "validity", typeJson: "{\"fqn\":\"aws.acm.AcmpcaCertificateValidity\"}")]
        aws.Acm.IAcmpcaCertificateValidity Validity
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acmpca_certificate#template_arn AcmpcaCertificate#template_arn}.</summary>
        [JsiiProperty(name: "templateArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TemplateArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Amazon Certificate Manager.</summary>
        [JsiiTypeProxy(nativeType: typeof(IAcmpcaCertificateConfig), fullyQualifiedName: "aws.acm.AcmpcaCertificateConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Acm.IAcmpcaCertificateConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acmpca_certificate#certificate_authority_arn AcmpcaCertificate#certificate_authority_arn}.</summary>
            [JsiiProperty(name: "certificateAuthorityArn", typeJson: "{\"primitive\":\"string\"}")]
            public string CertificateAuthorityArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acmpca_certificate#certificate_signing_request AcmpcaCertificate#certificate_signing_request}.</summary>
            [JsiiProperty(name: "certificateSigningRequest", typeJson: "{\"primitive\":\"string\"}")]
            public string CertificateSigningRequest
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acmpca_certificate#signing_algorithm AcmpcaCertificate#signing_algorithm}.</summary>
            [JsiiProperty(name: "signingAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
            public string SigningAlgorithm
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>validity block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acmpca_certificate#validity AcmpcaCertificate#validity}
            /// </remarks>
            [JsiiProperty(name: "validity", typeJson: "{\"fqn\":\"aws.acm.AcmpcaCertificateValidity\"}")]
            public aws.Acm.IAcmpcaCertificateValidity Validity
            {
                get => GetInstanceProperty<aws.Acm.IAcmpcaCertificateValidity>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/acmpca_certificate#template_arn AcmpcaCertificate#template_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "templateArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TemplateArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
