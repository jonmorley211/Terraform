using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53
{
    [JsiiByValue(fqn: "aws.route53.Route53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResource")]
    public class Route53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResource : aws.Route53.IRoute53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResource
    {
        /// <summary>nlb_resource block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53recoveryreadiness_resource_set#nlb_resource Route53RecoveryreadinessResourceSet#nlb_resource}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nlbResource", typeJson: "{\"fqn\":\"aws.route53.Route53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResourceNlbResource\"}", isOptional: true, isOverride: true)]
        public aws.Route53.IRoute53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResourceNlbResource? NlbResource
        {
            get;
            set;
        }

        /// <summary>r53_resource block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53recoveryreadiness_resource_set#r53_resource Route53RecoveryreadinessResourceSet#r53_resource}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "r53Resource", typeJson: "{\"fqn\":\"aws.route53.Route53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResourceR53Resource\"}", isOptional: true, isOverride: true)]
        public aws.Route53.IRoute53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResourceR53Resource? R53Resource
        {
            get;
            set;
        }
    }
}
