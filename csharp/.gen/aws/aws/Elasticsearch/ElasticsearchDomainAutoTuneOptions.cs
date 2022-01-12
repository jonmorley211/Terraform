using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elasticsearch
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.elasticsearch.ElasticsearchDomainAutoTuneOptions")]
    public class ElasticsearchDomainAutoTuneOptions : aws.Elasticsearch.IElasticsearchDomainAutoTuneOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#desired_state ElasticsearchDomain#desired_state}.</summary>
        [JsiiProperty(name: "desiredState", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string DesiredState
        {
            get;
            set;
        }

        /// <summary>maintenance_schedule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#maintenance_schedule ElasticsearchDomain#maintenance_schedule}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maintenanceSchedule", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainAutoTuneOptionsMaintenanceSchedule\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Elasticsearch.IElasticsearchDomainAutoTuneOptionsMaintenanceSchedule[]? MaintenanceSchedule
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#rollback_on_disable ElasticsearchDomain#rollback_on_disable}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rollbackOnDisable", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? RollbackOnDisable
        {
            get;
            set;
        }
    }
}
