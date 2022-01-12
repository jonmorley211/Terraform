using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Signer
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/signer_signing_job aws_signer_signing_job}.</summary>
    [JsiiClass(nativeType: typeof(aws.Signer.SignerSigningJob), fullyQualifiedName: "aws.signer.SignerSigningJob", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.signer.SignerSigningJobConfig\"}}]")]
    public class SignerSigningJob : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/signer_signing_job aws_signer_signing_job} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public SignerSigningJob(Constructs.Construct scope, string id, aws.Signer.ISignerSigningJobConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SignerSigningJob(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SignerSigningJob(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDestination", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.signer.SignerSigningJobDestination\"}}]")]
        public virtual void PutDestination(aws.Signer.ISignerSigningJobDestination @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Signer.ISignerSigningJobDestination)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSource", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.signer.SignerSigningJobSource\"}}]")]
        public virtual void PutSource(aws.Signer.ISignerSigningJobSource @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Signer.ISignerSigningJobSource)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetIgnoreSigningJobFailure")]
        public virtual void ResetIgnoreSigningJobFailure()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "revocationRecord", returnsJson: "{\"type\":{\"fqn\":\"aws.signer.SignerSigningJobRevocationRecord\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Signer.SignerSigningJobRevocationRecord RevocationRecord(string index)
        {
            return InvokeInstanceMethod<aws.Signer.SignerSigningJobRevocationRecord>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "signedObject", returnsJson: "{\"type\":{\"fqn\":\"aws.signer.SignerSigningJobSignedObject\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Signer.SignerSigningJobSignedObject SignedObject(string index)
        {
            return InvokeInstanceMethod<aws.Signer.SignerSigningJobSignedObject>(new System.Type[]{typeof(string)}, new object[]{index})!;
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
        = GetStaticProperty<string>(typeof(aws.Signer.SignerSigningJob))!;

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

        [JsiiProperty(name: "destination", typeJson: "{\"fqn\":\"aws.signer.SignerSigningJobDestinationOutputReference\"}")]
        public virtual aws.Signer.SignerSigningJobDestinationOutputReference Destination
        {
            get => GetInstanceProperty<aws.Signer.SignerSigningJobDestinationOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "jobId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JobId
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

        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"aws.signer.SignerSigningJobSourceOutputReference\"}")]
        public virtual aws.Signer.SignerSigningJobSourceOutputReference Source
        {
            get => GetInstanceProperty<aws.Signer.SignerSigningJobSourceOutputReference>()!;
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
        [JsiiProperty(name: "destinationInput", typeJson: "{\"fqn\":\"aws.signer.SignerSigningJobDestination\"}", isOptional: true)]
        public virtual aws.Signer.ISignerSigningJobDestination? DestinationInput
        {
            get => GetInstanceProperty<aws.Signer.ISignerSigningJobDestination?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ignoreSigningJobFailureInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IgnoreSigningJobFailureInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "profileNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProfileNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceInput", typeJson: "{\"fqn\":\"aws.signer.SignerSigningJobSource\"}", isOptional: true)]
        public virtual aws.Signer.ISignerSigningJobSource? SourceInput
        {
            get => GetInstanceProperty<aws.Signer.ISignerSigningJobSource?>();
        }

        [JsiiProperty(name: "ignoreSigningJobFailure", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object IgnoreSigningJobFailure
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "profileName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProfileName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
