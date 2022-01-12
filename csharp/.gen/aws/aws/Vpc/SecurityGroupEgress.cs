using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Vpc
{
    [JsiiByValue(fqn: "aws.vpc.SecurityGroupEgress")]
    public class SecurityGroupEgress : aws.Vpc.ISecurityGroupEgress
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/security_group#cidr_blocks SecurityGroup#cidr_blocks}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cidrBlocks", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? CidrBlocks
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/security_group#description SecurityGroup#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/security_group#from_port SecurityGroup#from_port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fromPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? FromPort
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/security_group#ipv6_cidr_blocks SecurityGroup#ipv6_cidr_blocks}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipv6CidrBlocks", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? Ipv6CidrBlocks
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/security_group#prefix_list_ids SecurityGroup#prefix_list_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "prefixListIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? PrefixListIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/security_group#protocol SecurityGroup#protocol}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Protocol
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/security_group#security_groups SecurityGroup#security_groups}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? SecurityGroups
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/security_group#self SecurityGroup#self}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "selfAttribute", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? SelfAttribute
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/security_group#to_port SecurityGroup#to_port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "toPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? ToPort
        {
            get;
            set;
        }
    }
}
