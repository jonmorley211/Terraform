using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codeartifact
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/codeartifact_repository aws_codeartifact_repository}.</summary>
    [JsiiClass(nativeType: typeof(aws.Codeartifact.CodeartifactRepository), fullyQualifiedName: "aws.codeartifact.CodeartifactRepository", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.codeartifact.CodeartifactRepositoryConfig\"}}]")]
    public class CodeartifactRepository : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/codeartifact_repository aws_codeartifact_repository} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public CodeartifactRepository(Constructs.Construct scope, string id, aws.Codeartifact.ICodeartifactRepositoryConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodeartifactRepository(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodeartifactRepository(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putExternalConnections", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codeartifact.CodeartifactRepositoryExternalConnections\"}}]")]
        public virtual void PutExternalConnections(aws.Codeartifact.ICodeartifactRepositoryExternalConnections @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Codeartifact.ICodeartifactRepositoryExternalConnections)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDomainOwner")]
        public virtual void ResetDomainOwner()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExternalConnections")]
        public virtual void ResetExternalConnections()
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

        [JsiiMethod(name: "resetUpstream")]
        public virtual void ResetUpstream()
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
        = GetStaticProperty<string>(typeof(aws.Codeartifact.CodeartifactRepository))!;

        [JsiiProperty(name: "administratorAccount", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdministratorAccount
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "externalConnections", typeJson: "{\"fqn\":\"aws.codeartifact.CodeartifactRepositoryExternalConnectionsOutputReference\"}")]
        public virtual aws.Codeartifact.CodeartifactRepositoryExternalConnectionsOutputReference ExternalConnections
        {
            get => GetInstanceProperty<aws.Codeartifact.CodeartifactRepositoryExternalConnectionsOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "domainInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DomainInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "domainOwnerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DomainOwnerInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "externalConnectionsInput", typeJson: "{\"fqn\":\"aws.codeartifact.CodeartifactRepositoryExternalConnections\"}", isOptional: true)]
        public virtual aws.Codeartifact.ICodeartifactRepositoryExternalConnections? ExternalConnectionsInput
        {
            get => GetInstanceProperty<aws.Codeartifact.ICodeartifactRepositoryExternalConnections?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "repositoryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RepositoryInput
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
        [JsiiProperty(name: "upstreamInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codeartifact.CodeartifactRepositoryUpstream\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Codeartifact.ICodeartifactRepositoryUpstream[]? UpstreamInput
        {
            get => GetInstanceProperty<aws.Codeartifact.ICodeartifactRepositoryUpstream[]?>();
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Domain
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "domainOwner", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainOwner
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "repository", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Repository
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

        [JsiiProperty(name: "upstream", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codeartifact.CodeartifactRepositoryUpstream\"},\"kind\":\"array\"}}")]
        public virtual aws.Codeartifact.ICodeartifactRepositoryUpstream[] Upstream
        {
            get => GetInstanceProperty<aws.Codeartifact.ICodeartifactRepositoryUpstream[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
