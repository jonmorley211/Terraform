using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elasticsearch
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/d/elasticsearch_domain aws_elasticsearch_domain}.</summary>
    [JsiiClass(nativeType: typeof(aws.Elasticsearch.DataAwsElasticsearchDomain), fullyQualifiedName: "aws.elasticsearch.DataAwsElasticsearchDomain", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.elasticsearch.DataAwsElasticsearchDomainConfig\"}}]")]
    public class DataAwsElasticsearchDomain : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/d/elasticsearch_domain aws_elasticsearch_domain} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsElasticsearchDomain(Constructs.Construct scope, string id, aws.Elasticsearch.IDataAwsElasticsearchDomainConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsElasticsearchDomain(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsElasticsearchDomain(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "advancedOptions", returnsJson: "{\"type\":{\"primitive\":\"string\"}}", parametersJson: "[{\"name\":\"key\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual string AdvancedOptions(string key)
        {
            return InvokeInstanceMethod<string>(new System.Type[]{typeof(string)}, new object[]{key})!;
        }

        [JsiiMethod(name: "advancedSecurityOptions", returnsJson: "{\"type\":{\"fqn\":\"aws.elasticsearch.DataAwsElasticsearchDomainAdvancedSecurityOptions\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Elasticsearch.DataAwsElasticsearchDomainAdvancedSecurityOptions AdvancedSecurityOptions(string index)
        {
            return InvokeInstanceMethod<aws.Elasticsearch.DataAwsElasticsearchDomainAdvancedSecurityOptions>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "autoTuneOptions", returnsJson: "{\"type\":{\"fqn\":\"aws.elasticsearch.DataAwsElasticsearchDomainAutoTuneOptions\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Elasticsearch.DataAwsElasticsearchDomainAutoTuneOptions AutoTuneOptions(string index)
        {
            return InvokeInstanceMethod<aws.Elasticsearch.DataAwsElasticsearchDomainAutoTuneOptions>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "clusterConfig", returnsJson: "{\"type\":{\"fqn\":\"aws.elasticsearch.DataAwsElasticsearchDomainClusterConfig\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Elasticsearch.DataAwsElasticsearchDomainClusterConfig ClusterConfig(string index)
        {
            return InvokeInstanceMethod<aws.Elasticsearch.DataAwsElasticsearchDomainClusterConfig>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "cognitoOptions", returnsJson: "{\"type\":{\"fqn\":\"aws.elasticsearch.DataAwsElasticsearchDomainCognitoOptions\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Elasticsearch.DataAwsElasticsearchDomainCognitoOptions CognitoOptions(string index)
        {
            return InvokeInstanceMethod<aws.Elasticsearch.DataAwsElasticsearchDomainCognitoOptions>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "ebsOptions", returnsJson: "{\"type\":{\"fqn\":\"aws.elasticsearch.DataAwsElasticsearchDomainEbsOptions\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Elasticsearch.DataAwsElasticsearchDomainEbsOptions EbsOptions(string index)
        {
            return InvokeInstanceMethod<aws.Elasticsearch.DataAwsElasticsearchDomainEbsOptions>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "encryptionAtRest", returnsJson: "{\"type\":{\"fqn\":\"aws.elasticsearch.DataAwsElasticsearchDomainEncryptionAtRest\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Elasticsearch.DataAwsElasticsearchDomainEncryptionAtRest EncryptionAtRest(string index)
        {
            return InvokeInstanceMethod<aws.Elasticsearch.DataAwsElasticsearchDomainEncryptionAtRest>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "logPublishingOptions", returnsJson: "{\"type\":{\"fqn\":\"aws.elasticsearch.DataAwsElasticsearchDomainLogPublishingOptions\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Elasticsearch.DataAwsElasticsearchDomainLogPublishingOptions LogPublishingOptions(string index)
        {
            return InvokeInstanceMethod<aws.Elasticsearch.DataAwsElasticsearchDomainLogPublishingOptions>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "nodeToNodeEncryption", returnsJson: "{\"type\":{\"fqn\":\"aws.elasticsearch.DataAwsElasticsearchDomainNodeToNodeEncryption\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Elasticsearch.DataAwsElasticsearchDomainNodeToNodeEncryption NodeToNodeEncryption(string index)
        {
            return InvokeInstanceMethod<aws.Elasticsearch.DataAwsElasticsearchDomainNodeToNodeEncryption>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "snapshotOptions", returnsJson: "{\"type\":{\"fqn\":\"aws.elasticsearch.DataAwsElasticsearchDomainSnapshotOptions\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Elasticsearch.DataAwsElasticsearchDomainSnapshotOptions SnapshotOptions(string index)
        {
            return InvokeInstanceMethod<aws.Elasticsearch.DataAwsElasticsearchDomainSnapshotOptions>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "vpcOptions", returnsJson: "{\"type\":{\"fqn\":\"aws.elasticsearch.DataAwsElasticsearchDomainVpcOptions\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Elasticsearch.DataAwsElasticsearchDomainVpcOptions VpcOptions(string index)
        {
            return InvokeInstanceMethod<aws.Elasticsearch.DataAwsElasticsearchDomainVpcOptions>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.Elasticsearch.DataAwsElasticsearchDomain))!;

        [JsiiProperty(name: "accessPolicies", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccessPolicies
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "created", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object Created
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "deleted", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object Deleted
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "domainId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "elasticsearchVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ElasticsearchVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Endpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "kibanaEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KibanaEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "processing", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object Processing
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "domainNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DomainNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? TagsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainName
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
    }
}
