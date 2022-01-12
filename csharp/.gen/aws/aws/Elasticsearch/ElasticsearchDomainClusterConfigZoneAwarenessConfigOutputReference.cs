using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elasticsearch
{
    [JsiiClass(nativeType: typeof(aws.Elasticsearch.ElasticsearchDomainClusterConfigZoneAwarenessConfigOutputReference), fullyQualifiedName: "aws.elasticsearch.ElasticsearchDomainClusterConfigZoneAwarenessConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class ElasticsearchDomainClusterConfigZoneAwarenessConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public ElasticsearchDomainClusterConfigZoneAwarenessConfigOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElasticsearchDomainClusterConfigZoneAwarenessConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElasticsearchDomainClusterConfigZoneAwarenessConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAvailabilityZoneCount")]
        public virtual void ResetAvailabilityZoneCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "availabilityZoneCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AvailabilityZoneCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "availabilityZoneCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AvailabilityZoneCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainClusterConfigZoneAwarenessConfig\"}", isOptional: true)]
        public virtual aws.Elasticsearch.IElasticsearchDomainClusterConfigZoneAwarenessConfig? InternalValue
        {
            get => GetInstanceProperty<aws.Elasticsearch.IElasticsearchDomainClusterConfigZoneAwarenessConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
