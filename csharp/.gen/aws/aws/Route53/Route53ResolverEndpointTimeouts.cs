using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53
{
    [JsiiByValue(fqn: "aws.route53.Route53ResolverEndpointTimeouts")]
    public class Route53ResolverEndpointTimeouts : aws.Route53.IRoute53ResolverEndpointTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_resolver_endpoint#create Route53ResolverEndpoint#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_resolver_endpoint#delete Route53ResolverEndpoint#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_resolver_endpoint#update Route53ResolverEndpoint#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
