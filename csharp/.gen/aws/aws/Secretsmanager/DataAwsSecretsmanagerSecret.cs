using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Secretsmanager
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/d/secretsmanager_secret aws_secretsmanager_secret}.</summary>
    [JsiiClass(nativeType: typeof(aws.Secretsmanager.DataAwsSecretsmanagerSecret), fullyQualifiedName: "aws.secretsmanager.DataAwsSecretsmanagerSecret", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"aws.secretsmanager.DataAwsSecretsmanagerSecretConfig\"}}]")]
    public class DataAwsSecretsmanagerSecret : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/d/secretsmanager_secret aws_secretsmanager_secret} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsSecretsmanagerSecret(Constructs.Construct scope, string id, aws.Secretsmanager.IDataAwsSecretsmanagerSecretConfig? config = null): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsSecretsmanagerSecret(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsSecretsmanagerSecret(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "rotationRules", returnsJson: "{\"type\":{\"fqn\":\"aws.secretsmanager.DataAwsSecretsmanagerSecretRotationRules\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Secretsmanager.DataAwsSecretsmanagerSecretRotationRules RotationRules(string index)
        {
            return InvokeInstanceMethod<aws.Secretsmanager.DataAwsSecretsmanagerSecretRotationRules>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "tags", returnsJson: "{\"type\":{\"primitive\":\"string\"}}", parametersJson: "[{\"name\":\"key\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual string Tags(string key)
        {
            return InvokeInstanceMethod<string>(new System.Type[]{typeof(string)}, new object[]{key})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.Secretsmanager.DataAwsSecretsmanagerSecret))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KmsKeyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Policy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rotationEnabled", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object RotationEnabled
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "rotationLambdaArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RotationLambdaArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
