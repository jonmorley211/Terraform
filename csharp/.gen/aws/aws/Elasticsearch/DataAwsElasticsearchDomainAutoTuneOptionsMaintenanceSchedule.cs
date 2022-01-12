using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elasticsearch
{
    [JsiiClass(nativeType: typeof(aws.Elasticsearch.DataAwsElasticsearchDomainAutoTuneOptionsMaintenanceSchedule), fullyQualifiedName: "aws.elasticsearch.DataAwsElasticsearchDomainAutoTuneOptionsMaintenanceSchedule", parametersJson: "[{\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"complexComputedListIndex\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataAwsElasticsearchDomainAutoTuneOptionsMaintenanceSchedule : HashiCorp.Cdktf.ComplexComputedList
    {
        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        public DataAwsElasticsearchDomainAutoTuneOptionsMaintenanceSchedule(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, string complexComputedListIndex): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexComputedListIndex}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsElasticsearchDomainAutoTuneOptionsMaintenanceSchedule(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsElasticsearchDomainAutoTuneOptionsMaintenanceSchedule(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "cronExpressionForRecurrence", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CronExpressionForRecurrence
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object Duration
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "startAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StartAt
        {
            get => GetInstanceProperty<string>()!;
        }
    }
}
