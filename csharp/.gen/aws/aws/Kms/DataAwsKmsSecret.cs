using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kms
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/d/kms_secret aws_kms_secret}.</summary>
    [JsiiClass(nativeType: typeof(aws.Kms.DataAwsKmsSecret), fullyQualifiedName: "aws.kms.DataAwsKmsSecret", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.kms.DataAwsKmsSecretConfig\"}}]")]
    public class DataAwsKmsSecret : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/d/kms_secret aws_kms_secret} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsKmsSecret(Constructs.Construct scope, string id, aws.Kms.IDataAwsKmsSecretConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsKmsSecret(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsKmsSecret(DeputyProps props): base(props)
        {
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
        = GetStaticProperty<string>(typeof(aws.Kms.DataAwsKmsSecret))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "secretInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.kms.DataAwsKmsSecretSecret\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Kms.IDataAwsKmsSecretSecret[]? SecretInput
        {
            get => GetInstanceProperty<aws.Kms.IDataAwsKmsSecretSecret[]?>();
        }

        [JsiiProperty(name: "secret", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.kms.DataAwsKmsSecretSecret\"},\"kind\":\"array\"}}")]
        public virtual aws.Kms.IDataAwsKmsSecretSecret[] Secret
        {
            get => GetInstanceProperty<aws.Kms.IDataAwsKmsSecretSecret[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
