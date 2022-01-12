using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elasticsearch
{
    [JsiiInterface(nativeType: typeof(IElasticsearchDomainAutoTuneOptions), fullyQualifiedName: "aws.elasticsearch.ElasticsearchDomainAutoTuneOptions")]
    public interface IElasticsearchDomainAutoTuneOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#desired_state ElasticsearchDomain#desired_state}.</summary>
        [JsiiProperty(name: "desiredState", typeJson: "{\"primitive\":\"string\"}")]
        string DesiredState
        {
            get;
        }

        /// <summary>maintenance_schedule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#maintenance_schedule ElasticsearchDomain#maintenance_schedule}
        /// </remarks>
        [JsiiProperty(name: "maintenanceSchedule", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainAutoTuneOptionsMaintenanceSchedule\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Elasticsearch.IElasticsearchDomainAutoTuneOptionsMaintenanceSchedule[]? MaintenanceSchedule
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#rollback_on_disable ElasticsearchDomain#rollback_on_disable}.</summary>
        [JsiiProperty(name: "rollbackOnDisable", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RollbackOnDisable
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IElasticsearchDomainAutoTuneOptions), fullyQualifiedName: "aws.elasticsearch.ElasticsearchDomainAutoTuneOptions")]
        internal sealed class _Proxy : DeputyBase, aws.Elasticsearch.IElasticsearchDomainAutoTuneOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#desired_state ElasticsearchDomain#desired_state}.</summary>
            [JsiiProperty(name: "desiredState", typeJson: "{\"primitive\":\"string\"}")]
            public string DesiredState
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>maintenance_schedule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#maintenance_schedule ElasticsearchDomain#maintenance_schedule}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maintenanceSchedule", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainAutoTuneOptionsMaintenanceSchedule\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Elasticsearch.IElasticsearchDomainAutoTuneOptionsMaintenanceSchedule[]? MaintenanceSchedule
            {
                get => GetInstanceProperty<aws.Elasticsearch.IElasticsearchDomainAutoTuneOptionsMaintenanceSchedule[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#rollback_on_disable ElasticsearchDomain#rollback_on_disable}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rollbackOnDisable", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RollbackOnDisable
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
