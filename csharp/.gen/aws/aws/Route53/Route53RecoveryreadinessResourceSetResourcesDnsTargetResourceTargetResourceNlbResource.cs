using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53
{
    [JsiiByValue(fqn: "aws.route53.Route53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResourceNlbResource")]
    public class Route53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResourceNlbResource : aws.Route53.IRoute53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResourceNlbResource
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53recoveryreadiness_resource_set#arn Route53RecoveryreadinessResourceSet#arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Arn
        {
            get;
            set;
        }
    }
}
