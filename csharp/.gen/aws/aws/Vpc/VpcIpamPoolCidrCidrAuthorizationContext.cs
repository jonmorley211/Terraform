using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Vpc
{
    [JsiiByValue(fqn: "aws.vpc.VpcIpamPoolCidrCidrAuthorizationContext")]
    public class VpcIpamPoolCidrCidrAuthorizationContext : aws.Vpc.IVpcIpamPoolCidrCidrAuthorizationContext
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpc_ipam_pool_cidr#message VpcIpamPoolCidr#message}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "message", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Message
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpc_ipam_pool_cidr#signature VpcIpamPoolCidr#signature}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "signature", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Signature
        {
            get;
            set;
        }
    }
}
