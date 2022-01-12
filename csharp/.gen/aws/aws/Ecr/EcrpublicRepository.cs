using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecr
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/ecrpublic_repository aws_ecrpublic_repository}.</summary>
    [JsiiClass(nativeType: typeof(aws.Ecr.EcrpublicRepository), fullyQualifiedName: "aws.ecr.EcrpublicRepository", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.ecr.EcrpublicRepositoryConfig\"}}]")]
    public class EcrpublicRepository : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/ecrpublic_repository aws_ecrpublic_repository} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public EcrpublicRepository(Constructs.Construct scope, string id, aws.Ecr.IEcrpublicRepositoryConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcrpublicRepository(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcrpublicRepository(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCatalogData", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ecr.EcrpublicRepositoryCatalogData\"}}]")]
        public virtual void PutCatalogData(aws.Ecr.IEcrpublicRepositoryCatalogData @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ecr.IEcrpublicRepositoryCatalogData)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ecr.EcrpublicRepositoryTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.Ecr.IEcrpublicRepositoryTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ecr.IEcrpublicRepositoryTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCatalogData")]
        public virtual void ResetCatalogData()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetForceDestroy")]
        public virtual void ResetForceDestroy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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
        = GetStaticProperty<string>(typeof(aws.Ecr.EcrpublicRepository))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "catalogData", typeJson: "{\"fqn\":\"aws.ecr.EcrpublicRepositoryCatalogDataOutputReference\"}")]
        public virtual aws.Ecr.EcrpublicRepositoryCatalogDataOutputReference CatalogData
        {
            get => GetInstanceProperty<aws.Ecr.EcrpublicRepositoryCatalogDataOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "registryId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RegistryId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "repositoryUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RepositoryUri
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.ecr.EcrpublicRepositoryTimeoutsOutputReference\"}")]
        public virtual aws.Ecr.EcrpublicRepositoryTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.Ecr.EcrpublicRepositoryTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "catalogDataInput", typeJson: "{\"fqn\":\"aws.ecr.EcrpublicRepositoryCatalogData\"}", isOptional: true)]
        public virtual aws.Ecr.IEcrpublicRepositoryCatalogData? CatalogDataInput
        {
            get => GetInstanceProperty<aws.Ecr.IEcrpublicRepositoryCatalogData?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "forceDestroyInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ForceDestroyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "repositoryNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RepositoryNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.ecr.EcrpublicRepositoryTimeouts\"}", isOptional: true)]
        public virtual aws.Ecr.IEcrpublicRepositoryTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.Ecr.IEcrpublicRepositoryTimeouts?>();
        }

        [JsiiProperty(name: "forceDestroy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object ForceDestroy
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "repositoryName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RepositoryName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
