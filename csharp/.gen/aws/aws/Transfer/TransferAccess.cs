using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Transfer
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/transfer_access aws_transfer_access}.</summary>
    [JsiiClass(nativeType: typeof(aws.Transfer.TransferAccess), fullyQualifiedName: "aws.transfer.TransferAccess", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.transfer.TransferAccessConfig\"}}]")]
    public class TransferAccess : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/transfer_access aws_transfer_access} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public TransferAccess(Constructs.Construct scope, string id, aws.Transfer.ITransferAccessConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected TransferAccess(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected TransferAccess(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putPosixProfile", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.transfer.TransferAccessPosixProfile\"}}]")]
        public virtual void PutPosixProfile(aws.Transfer.ITransferAccessPosixProfile @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Transfer.ITransferAccessPosixProfile)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetHomeDirectory")]
        public virtual void ResetHomeDirectory()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHomeDirectoryMappings")]
        public virtual void ResetHomeDirectoryMappings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHomeDirectoryType")]
        public virtual void ResetHomeDirectoryType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPolicy")]
        public virtual void ResetPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPosixProfile")]
        public virtual void ResetPosixProfile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRole")]
        public virtual void ResetRole()
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
        = GetStaticProperty<string>(typeof(aws.Transfer.TransferAccess))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "posixProfile", typeJson: "{\"fqn\":\"aws.transfer.TransferAccessPosixProfileOutputReference\"}")]
        public virtual aws.Transfer.TransferAccessPosixProfileOutputReference PosixProfile
        {
            get => GetInstanceProperty<aws.Transfer.TransferAccessPosixProfileOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "externalIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExternalIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "homeDirectoryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HomeDirectoryInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "homeDirectoryMappingsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.transfer.TransferAccessHomeDirectoryMappings\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Transfer.ITransferAccessHomeDirectoryMappings[]? HomeDirectoryMappingsInput
        {
            get => GetInstanceProperty<aws.Transfer.ITransferAccessHomeDirectoryMappings[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "homeDirectoryTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HomeDirectoryTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "policyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "posixProfileInput", typeJson: "{\"fqn\":\"aws.transfer.TransferAccessPosixProfile\"}", isOptional: true)]
        public virtual aws.Transfer.ITransferAccessPosixProfile? PosixProfileInput
        {
            get => GetInstanceProperty<aws.Transfer.ITransferAccessPosixProfile?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "roleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serverIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServerIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExternalId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "homeDirectory", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HomeDirectory
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "homeDirectoryMappings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.transfer.TransferAccessHomeDirectoryMappings\"},\"kind\":\"array\"}}")]
        public virtual aws.Transfer.ITransferAccessHomeDirectoryMappings[] HomeDirectoryMappings
        {
            get => GetInstanceProperty<aws.Transfer.ITransferAccessHomeDirectoryMappings[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "homeDirectoryType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HomeDirectoryType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Policy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Role
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serverId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServerId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
