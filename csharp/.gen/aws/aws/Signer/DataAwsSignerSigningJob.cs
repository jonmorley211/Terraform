using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Signer
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/d/signer_signing_job aws_signer_signing_job}.</summary>
    [JsiiClass(nativeType: typeof(aws.Signer.DataAwsSignerSigningJob), fullyQualifiedName: "aws.signer.DataAwsSignerSigningJob", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.signer.DataAwsSignerSigningJobConfig\"}}]")]
    public class DataAwsSignerSigningJob : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/d/signer_signing_job aws_signer_signing_job} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsSignerSigningJob(Constructs.Construct scope, string id, aws.Signer.IDataAwsSignerSigningJobConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsSignerSigningJob(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsSignerSigningJob(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "revocationRecord", returnsJson: "{\"type\":{\"fqn\":\"aws.signer.DataAwsSignerSigningJobRevocationRecord\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Signer.DataAwsSignerSigningJobRevocationRecord RevocationRecord(string index)
        {
            return InvokeInstanceMethod<aws.Signer.DataAwsSignerSigningJobRevocationRecord>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "signedObject", returnsJson: "{\"type\":{\"fqn\":\"aws.signer.DataAwsSignerSigningJobSignedObject\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Signer.DataAwsSignerSigningJobSignedObject SignedObject(string index)
        {
            return InvokeInstanceMethod<aws.Signer.DataAwsSignerSigningJobSignedObject>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "source", returnsJson: "{\"type\":{\"fqn\":\"aws.signer.DataAwsSignerSigningJobSource\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Signer.DataAwsSignerSigningJobSource Source(string index)
        {
            return InvokeInstanceMethod<aws.Signer.DataAwsSignerSigningJobSource>(new System.Type[]{typeof(string)}, new object[]{index})!;
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
        = GetStaticProperty<string>(typeof(aws.Signer.DataAwsSignerSigningJob))!;

        [JsiiProperty(name: "completedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompletedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "jobInvoker", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JobInvoker
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "jobOwner", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JobOwner
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "platformDisplayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlatformDisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "platformId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlatformId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "profileName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProfileName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "profileVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProfileVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "requestedBy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RequestedBy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "signatureExpiresAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SignatureExpiresAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "statusReason", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StatusReason
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "jobIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? JobIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "jobId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JobId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
