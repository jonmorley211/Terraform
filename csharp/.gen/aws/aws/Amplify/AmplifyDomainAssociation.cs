using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Amplify
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/amplify_domain_association aws_amplify_domain_association}.</summary>
    [JsiiClass(nativeType: typeof(aws.Amplify.AmplifyDomainAssociation), fullyQualifiedName: "aws.amplify.AmplifyDomainAssociation", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.amplify.AmplifyDomainAssociationConfig\"}}]")]
    public class AmplifyDomainAssociation : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/amplify_domain_association aws_amplify_domain_association} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public AmplifyDomainAssociation(Constructs.Construct scope, string id, aws.Amplify.IAmplifyDomainAssociationConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AmplifyDomainAssociation(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AmplifyDomainAssociation(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetWaitForVerification")]
        public virtual void ResetWaitForVerification()
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
        = GetStaticProperty<string>(typeof(aws.Amplify.AmplifyDomainAssociation))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "certificateVerificationDnsRecord", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateVerificationDnsRecord
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "appIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AppIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "domainNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DomainNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subDomainInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.amplify.AmplifyDomainAssociationSubDomain\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Amplify.IAmplifyDomainAssociationSubDomain[]? SubDomainInput
        {
            get => GetInstanceProperty<aws.Amplify.IAmplifyDomainAssociationSubDomain[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "waitForVerificationInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? WaitForVerificationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "appId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AppId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subDomain", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.amplify.AmplifyDomainAssociationSubDomain\"},\"kind\":\"array\"}}")]
        public virtual aws.Amplify.IAmplifyDomainAssociationSubDomain[] SubDomain
        {
            get => GetInstanceProperty<aws.Amplify.IAmplifyDomainAssociationSubDomain[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "waitForVerification", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object WaitForVerification
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }
    }
}
