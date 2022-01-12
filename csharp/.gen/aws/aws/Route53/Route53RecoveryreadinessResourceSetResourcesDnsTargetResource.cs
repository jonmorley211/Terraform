using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.route53.Route53RecoveryreadinessResourceSetResourcesDnsTargetResource")]
    public class Route53RecoveryreadinessResourceSetResourcesDnsTargetResource : aws.Route53.IRoute53RecoveryreadinessResourceSetResourcesDnsTargetResource
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53recoveryreadiness_resource_set#domain_name Route53RecoveryreadinessResourceSet#domain_name}.</summary>
        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string DomainName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53recoveryreadiness_resource_set#hosted_zone_arn Route53RecoveryreadinessResourceSet#hosted_zone_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hostedZoneArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? HostedZoneArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53recoveryreadiness_resource_set#record_set_id Route53RecoveryreadinessResourceSet#record_set_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "recordSetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? RecordSetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53recoveryreadiness_resource_set#record_type Route53RecoveryreadinessResourceSet#record_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "recordType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? RecordType
        {
            get;
            set;
        }

        /// <summary>target_resource block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53recoveryreadiness_resource_set#target_resource Route53RecoveryreadinessResourceSet#target_resource}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "targetResource", typeJson: "{\"fqn\":\"aws.route53.Route53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResource\"}", isOptional: true, isOverride: true)]
        public aws.Route53.IRoute53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResource? TargetResource
        {
            get;
            set;
        }
    }
}
