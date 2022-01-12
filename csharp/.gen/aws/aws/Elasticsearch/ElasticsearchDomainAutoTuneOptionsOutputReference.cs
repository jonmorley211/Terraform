using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elasticsearch
{
    [JsiiClass(nativeType: typeof(aws.Elasticsearch.ElasticsearchDomainAutoTuneOptionsOutputReference), fullyQualifiedName: "aws.elasticsearch.ElasticsearchDomainAutoTuneOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class ElasticsearchDomainAutoTuneOptionsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public ElasticsearchDomainAutoTuneOptionsOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElasticsearchDomainAutoTuneOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElasticsearchDomainAutoTuneOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetMaintenanceSchedule")]
        public virtual void ResetMaintenanceSchedule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRollbackOnDisable")]
        public virtual void ResetRollbackOnDisable()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "desiredStateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DesiredStateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maintenanceScheduleInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainAutoTuneOptionsMaintenanceSchedule\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Elasticsearch.IElasticsearchDomainAutoTuneOptionsMaintenanceSchedule[]? MaintenanceScheduleInput
        {
            get => GetInstanceProperty<aws.Elasticsearch.IElasticsearchDomainAutoTuneOptionsMaintenanceSchedule[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rollbackOnDisableInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RollbackOnDisableInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "desiredState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DesiredState
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maintenanceSchedule", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainAutoTuneOptionsMaintenanceSchedule\"},\"kind\":\"array\"}}")]
        public virtual aws.Elasticsearch.IElasticsearchDomainAutoTuneOptionsMaintenanceSchedule[] MaintenanceSchedule
        {
            get => GetInstanceProperty<aws.Elasticsearch.IElasticsearchDomainAutoTuneOptionsMaintenanceSchedule[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "rollbackOnDisable", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RollbackOnDisable
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainAutoTuneOptions\"}", isOptional: true)]
        public virtual aws.Elasticsearch.IElasticsearchDomainAutoTuneOptions? InternalValue
        {
            get => GetInstanceProperty<aws.Elasticsearch.IElasticsearchDomainAutoTuneOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
