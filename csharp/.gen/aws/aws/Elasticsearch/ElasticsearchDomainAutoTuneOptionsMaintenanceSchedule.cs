using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elasticsearch
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.elasticsearch.ElasticsearchDomainAutoTuneOptionsMaintenanceSchedule")]
    public class ElasticsearchDomainAutoTuneOptionsMaintenanceSchedule : aws.Elasticsearch.IElasticsearchDomainAutoTuneOptionsMaintenanceSchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#cron_expression_for_recurrence ElasticsearchDomain#cron_expression_for_recurrence}.</summary>
        [JsiiProperty(name: "cronExpressionForRecurrence", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string CronExpressionForRecurrence
        {
            get;
            set;
        }

        /// <summary>duration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#duration ElasticsearchDomain#duration}
        /// </remarks>
        [JsiiProperty(name: "duration", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainAutoTuneOptionsMaintenanceScheduleDuration\"}", isOverride: true)]
        public aws.Elasticsearch.IElasticsearchDomainAutoTuneOptionsMaintenanceScheduleDuration Duration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#start_at ElasticsearchDomain#start_at}.</summary>
        [JsiiProperty(name: "startAt", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string StartAt
        {
            get;
            set;
        }
    }
}
