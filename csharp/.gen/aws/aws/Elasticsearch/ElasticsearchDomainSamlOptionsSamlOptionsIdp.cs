using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elasticsearch
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.elasticsearch.ElasticsearchDomainSamlOptionsSamlOptionsIdp")]
    public class ElasticsearchDomainSamlOptionsSamlOptionsIdp : aws.Elasticsearch.IElasticsearchDomainSamlOptionsSamlOptionsIdp
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain_saml_options#entity_id ElasticsearchDomainSamlOptions#entity_id}.</summary>
        [JsiiProperty(name: "entityId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string EntityId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain_saml_options#metadata_content ElasticsearchDomainSamlOptions#metadata_content}.</summary>
        [JsiiProperty(name: "metadataContent", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string MetadataContent
        {
            get;
            set;
        }
    }
}
