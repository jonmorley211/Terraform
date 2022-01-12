using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elasticache
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/elasticache_global_replication_group aws_elasticache_global_replication_group}.</summary>
    [JsiiClass(nativeType: typeof(aws.Elasticache.ElasticacheGlobalReplicationGroup), fullyQualifiedName: "aws.elasticache.ElasticacheGlobalReplicationGroup", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.elasticache.ElasticacheGlobalReplicationGroupConfig\"}}]")]
    public class ElasticacheGlobalReplicationGroup : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/elasticache_global_replication_group aws_elasticache_global_replication_group} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ElasticacheGlobalReplicationGroup(Constructs.Construct scope, string id, aws.Elasticache.IElasticacheGlobalReplicationGroupConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElasticacheGlobalReplicationGroup(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElasticacheGlobalReplicationGroup(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetGlobalReplicationGroupDescription")]
        public virtual void ResetGlobalReplicationGroupDescription()
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
        = GetStaticProperty<string>(typeof(aws.Elasticache.ElasticacheGlobalReplicationGroup))!;

        [JsiiProperty(name: "actualEngineVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ActualEngineVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "atRestEncryptionEnabled", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object AtRestEncryptionEnabled
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "authTokenEnabled", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object AuthTokenEnabled
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "cacheNodeType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CacheNodeType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clusterEnabled", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object ClusterEnabled
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "engine", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Engine
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "engineVersionActual", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EngineVersionActual
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "globalReplicationGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GlobalReplicationGroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "transitEncryptionEnabled", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object TransitEncryptionEnabled
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "globalReplicationGroupDescriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GlobalReplicationGroupDescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "globalReplicationGroupIdSuffixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GlobalReplicationGroupIdSuffixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "primaryReplicationGroupIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrimaryReplicationGroupIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "globalReplicationGroupDescription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GlobalReplicationGroupDescription
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "globalReplicationGroupIdSuffix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GlobalReplicationGroupIdSuffix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "primaryReplicationGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryReplicationGroupId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
