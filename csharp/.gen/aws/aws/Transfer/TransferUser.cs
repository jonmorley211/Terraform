using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Transfer
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/transfer_user aws_transfer_user}.</summary>
    [JsiiClass(nativeType: typeof(aws.Transfer.TransferUser), fullyQualifiedName: "aws.transfer.TransferUser", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.transfer.TransferUserConfig\"}}]")]
    public class TransferUser : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/transfer_user aws_transfer_user} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public TransferUser(Constructs.Construct scope, string id, aws.Transfer.ITransferUserConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected TransferUser(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected TransferUser(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putPosixProfile", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.transfer.TransferUserPosixProfile\"}}]")]
        public virtual void PutPosixProfile(aws.Transfer.ITransferUserPosixProfile @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Transfer.ITransferUserPosixProfile)}, new object[]{@value});
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

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTagsAll")]
        public virtual void ResetTagsAll()
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
        = GetStaticProperty<string>(typeof(aws.Transfer.TransferUser))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "posixProfile", typeJson: "{\"fqn\":\"aws.transfer.TransferUserPosixProfileOutputReference\"}")]
        public virtual aws.Transfer.TransferUserPosixProfileOutputReference PosixProfile
        {
            get => GetInstanceProperty<aws.Transfer.TransferUserPosixProfileOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "homeDirectoryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HomeDirectoryInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "homeDirectoryMappingsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.transfer.TransferUserHomeDirectoryMappings\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Transfer.ITransferUserHomeDirectoryMappings[]? HomeDirectoryMappingsInput
        {
            get => GetInstanceProperty<aws.Transfer.ITransferUserHomeDirectoryMappings[]?>();
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
        [JsiiProperty(name: "posixProfileInput", typeJson: "{\"fqn\":\"aws.transfer.TransferUserPosixProfile\"}", isOptional: true)]
        public virtual aws.Transfer.ITransferUserPosixProfile? PosixProfileInput
        {
            get => GetInstanceProperty<aws.Transfer.ITransferUserPosixProfile?>();
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

        [JsiiOptional]
        [JsiiProperty(name: "tagsAllInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? TagsAllInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? TagsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UserNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "homeDirectory", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HomeDirectory
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "homeDirectoryMappings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.transfer.TransferUserHomeDirectoryMappings\"},\"kind\":\"array\"}}")]
        public virtual aws.Transfer.ITransferUserHomeDirectoryMappings[] HomeDirectoryMappings
        {
            get => GetInstanceProperty<aws.Transfer.ITransferUserHomeDirectoryMappings[]>()!;
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

        [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}")]
        public virtual object Tags
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tagsAll", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}")]
        public virtual object TagsAll
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
