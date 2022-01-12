using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Vpc
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/vpc_ipam_pool_cidr aws_vpc_ipam_pool_cidr}.</summary>
    [JsiiClass(nativeType: typeof(aws.Vpc.VpcIpamPoolCidr), fullyQualifiedName: "aws.vpc.VpcIpamPoolCidr", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.vpc.VpcIpamPoolCidrConfig\"}}]")]
    public class VpcIpamPoolCidr : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/vpc_ipam_pool_cidr aws_vpc_ipam_pool_cidr} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public VpcIpamPoolCidr(Constructs.Construct scope, string id, aws.Vpc.IVpcIpamPoolCidrConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VpcIpamPoolCidr(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VpcIpamPoolCidr(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCidrAuthorizationContext", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.vpc.VpcIpamPoolCidrCidrAuthorizationContext\"}}]")]
        public virtual void PutCidrAuthorizationContext(aws.Vpc.IVpcIpamPoolCidrCidrAuthorizationContext @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Vpc.IVpcIpamPoolCidrCidrAuthorizationContext)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCidr")]
        public virtual void ResetCidr()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCidrAuthorizationContext")]
        public virtual void ResetCidrAuthorizationContext()
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
        = GetStaticProperty<string>(typeof(aws.Vpc.VpcIpamPoolCidr))!;

        [JsiiProperty(name: "cidrAuthorizationContext", typeJson: "{\"fqn\":\"aws.vpc.VpcIpamPoolCidrCidrAuthorizationContextOutputReference\"}")]
        public virtual aws.Vpc.VpcIpamPoolCidrCidrAuthorizationContextOutputReference CidrAuthorizationContext
        {
            get => GetInstanceProperty<aws.Vpc.VpcIpamPoolCidrCidrAuthorizationContextOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cidrAuthorizationContextInput", typeJson: "{\"fqn\":\"aws.vpc.VpcIpamPoolCidrCidrAuthorizationContext\"}", isOptional: true)]
        public virtual aws.Vpc.IVpcIpamPoolCidrCidrAuthorizationContext? CidrAuthorizationContextInput
        {
            get => GetInstanceProperty<aws.Vpc.IVpcIpamPoolCidrCidrAuthorizationContext?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cidrInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CidrInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipamPoolIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IpamPoolIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "cidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Cidr
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ipamPoolId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpamPoolId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
