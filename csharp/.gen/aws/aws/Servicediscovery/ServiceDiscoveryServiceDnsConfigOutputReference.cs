using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Servicediscovery
{
    [JsiiClass(nativeType: typeof(aws.Servicediscovery.ServiceDiscoveryServiceDnsConfigOutputReference), fullyQualifiedName: "aws.servicediscovery.ServiceDiscoveryServiceDnsConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class ServiceDiscoveryServiceDnsConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public ServiceDiscoveryServiceDnsConfigOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServiceDiscoveryServiceDnsConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServiceDiscoveryServiceDnsConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetRoutingPolicy")]
        public virtual void ResetRoutingPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "dnsRecordsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.servicediscovery.ServiceDiscoveryServiceDnsConfigDnsRecords\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Servicediscovery.IServiceDiscoveryServiceDnsConfigDnsRecords[]? DnsRecordsInput
        {
            get => GetInstanceProperty<aws.Servicediscovery.IServiceDiscoveryServiceDnsConfigDnsRecords[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "namespaceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NamespaceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "routingPolicyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoutingPolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "dnsRecords", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.servicediscovery.ServiceDiscoveryServiceDnsConfigDnsRecords\"},\"kind\":\"array\"}}")]
        public virtual aws.Servicediscovery.IServiceDiscoveryServiceDnsConfigDnsRecords[] DnsRecords
        {
            get => GetInstanceProperty<aws.Servicediscovery.IServiceDiscoveryServiceDnsConfigDnsRecords[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "namespaceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NamespaceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "routingPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoutingPolicy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.servicediscovery.ServiceDiscoveryServiceDnsConfig\"}", isOptional: true)]
        public virtual aws.Servicediscovery.IServiceDiscoveryServiceDnsConfig? InternalValue
        {
            get => GetInstanceProperty<aws.Servicediscovery.IServiceDiscoveryServiceDnsConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
