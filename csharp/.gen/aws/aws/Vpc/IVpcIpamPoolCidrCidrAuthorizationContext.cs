using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Vpc
{
    [JsiiInterface(nativeType: typeof(IVpcIpamPoolCidrCidrAuthorizationContext), fullyQualifiedName: "aws.vpc.VpcIpamPoolCidrCidrAuthorizationContext")]
    public interface IVpcIpamPoolCidrCidrAuthorizationContext
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpc_ipam_pool_cidr#message VpcIpamPoolCidr#message}.</summary>
        [JsiiProperty(name: "message", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Message
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpc_ipam_pool_cidr#signature VpcIpamPoolCidr#signature}.</summary>
        [JsiiProperty(name: "signature", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Signature
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVpcIpamPoolCidrCidrAuthorizationContext), fullyQualifiedName: "aws.vpc.VpcIpamPoolCidrCidrAuthorizationContext")]
        internal sealed class _Proxy : DeputyBase, aws.Vpc.IVpcIpamPoolCidrCidrAuthorizationContext
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpc_ipam_pool_cidr#message VpcIpamPoolCidr#message}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "message", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Message
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpc_ipam_pool_cidr#signature VpcIpamPoolCidr#signature}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "signature", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Signature
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
