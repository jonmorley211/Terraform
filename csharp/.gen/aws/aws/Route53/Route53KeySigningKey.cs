using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/route53_key_signing_key aws_route53_key_signing_key}.</summary>
    [JsiiClass(nativeType: typeof(aws.Route53.Route53KeySigningKey), fullyQualifiedName: "aws.route53.Route53KeySigningKey", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.route53.Route53KeySigningKeyConfig\"}}]")]
    public class Route53KeySigningKey : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/route53_key_signing_key aws_route53_key_signing_key} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public Route53KeySigningKey(Constructs.Construct scope, string id, aws.Route53.IRoute53KeySigningKeyConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Route53KeySigningKey(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Route53KeySigningKey(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetStatus")]
        public virtual void ResetStatus()
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
        = GetStaticProperty<string>(typeof(aws.Route53.Route53KeySigningKey))!;

        [JsiiProperty(name: "digestAlgorithmMnemonic", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DigestAlgorithmMnemonic
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "digestAlgorithmType", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DigestAlgorithmType
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "digestValue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DigestValue
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dnskeyRecord", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DnskeyRecord
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dsRecord", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DsRecord
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "flag", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Flag
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "keyTag", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double KeyTag
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "publicKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublicKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "signingAlgorithmMnemonic", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SigningAlgorithmMnemonic
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "signingAlgorithmType", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SigningAlgorithmType
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostedZoneIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HostedZoneIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyManagementServiceArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KeyManagementServiceArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "statusInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StatusInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "hostedZoneId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostedZoneId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "keyManagementServiceArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyManagementServiceArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
