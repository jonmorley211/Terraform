using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Acm
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/acmpca_certificate aws_acmpca_certificate}.</summary>
    [JsiiClass(nativeType: typeof(aws.Acm.AcmpcaCertificate), fullyQualifiedName: "aws.acm.AcmpcaCertificate", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.acm.AcmpcaCertificateConfig\"}}]")]
    public class AcmpcaCertificate : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/acmpca_certificate aws_acmpca_certificate} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public AcmpcaCertificate(Constructs.Construct scope, string id, aws.Acm.IAcmpcaCertificateConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AcmpcaCertificate(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AcmpcaCertificate(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putValidity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.acm.AcmpcaCertificateValidity\"}}]")]
        public virtual void PutValidity(aws.Acm.IAcmpcaCertificateValidity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Acm.IAcmpcaCertificateValidity)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetTemplateArn")]
        public virtual void ResetTemplateArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.Acm.AcmpcaCertificate))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "certificate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Certificate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "certificateChain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateChain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "validity", typeJson: "{\"fqn\":\"aws.acm.AcmpcaCertificateValidityOutputReference\"}")]
        public virtual aws.Acm.AcmpcaCertificateValidityOutputReference Validity
        {
            get => GetInstanceProperty<aws.Acm.AcmpcaCertificateValidityOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateAuthorityArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CertificateAuthorityArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateSigningRequestInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CertificateSigningRequestInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "signingAlgorithmInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SigningAlgorithmInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "templateArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TemplateArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "validityInput", typeJson: "{\"fqn\":\"aws.acm.AcmpcaCertificateValidity\"}", isOptional: true)]
        public virtual aws.Acm.IAcmpcaCertificateValidity? ValidityInput
        {
            get => GetInstanceProperty<aws.Acm.IAcmpcaCertificateValidity?>();
        }

        [JsiiProperty(name: "certificateAuthorityArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateAuthorityArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "certificateSigningRequest", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateSigningRequest
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "signingAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SigningAlgorithm
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "templateArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TemplateArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
