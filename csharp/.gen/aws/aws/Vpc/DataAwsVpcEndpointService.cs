using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Vpc
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/d/vpc_endpoint_service aws_vpc_endpoint_service}.</summary>
    [JsiiClass(nativeType: typeof(aws.Vpc.DataAwsVpcEndpointService), fullyQualifiedName: "aws.vpc.DataAwsVpcEndpointService", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"aws.vpc.DataAwsVpcEndpointServiceConfig\"}}]")]
    public class DataAwsVpcEndpointService : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/d/vpc_endpoint_service aws_vpc_endpoint_service} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsVpcEndpointService(Constructs.Construct scope, string id, aws.Vpc.IDataAwsVpcEndpointServiceConfig? config = null): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsVpcEndpointService(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsVpcEndpointService(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetFilter")]
        public virtual void ResetFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetService")]
        public virtual void ResetService()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceName")]
        public virtual void ResetServiceName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceType")]
        public virtual void ResetServiceType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
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
        = GetStaticProperty<string>(typeof(aws.Vpc.DataAwsVpcEndpointService))!;

        [JsiiProperty(name: "acceptanceRequired", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object AcceptanceRequired
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "availabilityZones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AvailabilityZones
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "baseEndpointDnsNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] BaseEndpointDnsNames
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "managesVpcEndpoints", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object ManagesVpcEndpoints
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "owner", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Owner
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "privateDnsName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateDnsName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vpcEndpointPolicySupported", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object VpcEndpointPolicySupported
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.vpc.DataAwsVpcEndpointServiceFilter\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Vpc.IDataAwsVpcEndpointServiceFilter[]? FilterInput
        {
            get => GetInstanceProperty<aws.Vpc.IDataAwsVpcEndpointServiceFilter[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? TagsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "filter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.vpc.DataAwsVpcEndpointServiceFilter\"},\"kind\":\"array\"}}")]
        public virtual aws.Vpc.IDataAwsVpcEndpointServiceFilter[] Filter
        {
            get => GetInstanceProperty<aws.Vpc.IDataAwsVpcEndpointServiceFilter[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "service", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Service
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceType
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
