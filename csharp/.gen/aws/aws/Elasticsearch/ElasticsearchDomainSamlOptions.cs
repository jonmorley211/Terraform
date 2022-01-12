using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elasticsearch
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain_saml_options aws_elasticsearch_domain_saml_options}.</summary>
    [JsiiClass(nativeType: typeof(aws.Elasticsearch.ElasticsearchDomainSamlOptions), fullyQualifiedName: "aws.elasticsearch.ElasticsearchDomainSamlOptions", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainSamlOptionsConfig\"}}]")]
    public class ElasticsearchDomainSamlOptions : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain_saml_options aws_elasticsearch_domain_saml_options} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ElasticsearchDomainSamlOptions(Constructs.Construct scope, string id, aws.Elasticsearch.IElasticsearchDomainSamlOptionsConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElasticsearchDomainSamlOptions(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElasticsearchDomainSamlOptions(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putSamlOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainSamlOptionsSamlOptions\"}}]")]
        public virtual void PutSamlOptions(aws.Elasticsearch.IElasticsearchDomainSamlOptionsSamlOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Elasticsearch.IElasticsearchDomainSamlOptionsSamlOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetSamlOptions")]
        public virtual void ResetSamlOptions()
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
        = GetStaticProperty<string>(typeof(aws.Elasticsearch.ElasticsearchDomainSamlOptions))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "samlOptions", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainSamlOptionsSamlOptionsOutputReference\"}")]
        public virtual aws.Elasticsearch.ElasticsearchDomainSamlOptionsSamlOptionsOutputReference SamlOptions
        {
            get => GetInstanceProperty<aws.Elasticsearch.ElasticsearchDomainSamlOptionsSamlOptionsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "domainNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DomainNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "samlOptionsInput", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainSamlOptionsSamlOptions\"}", isOptional: true)]
        public virtual aws.Elasticsearch.IElasticsearchDomainSamlOptionsSamlOptions? SamlOptionsInput
        {
            get => GetInstanceProperty<aws.Elasticsearch.IElasticsearchDomainSamlOptionsSamlOptions?>();
        }

        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
