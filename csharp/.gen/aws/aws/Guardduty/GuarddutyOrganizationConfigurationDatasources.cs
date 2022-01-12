using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Guardduty
{
    [JsiiByValue(fqn: "aws.guardduty.GuarddutyOrganizationConfigurationDatasources")]
    public class GuarddutyOrganizationConfigurationDatasources : aws.Guardduty.IGuarddutyOrganizationConfigurationDatasources
    {
        /// <summary>s3_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/guardduty_organization_configuration#s3_logs GuarddutyOrganizationConfiguration#s3_logs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3Logs", typeJson: "{\"fqn\":\"aws.guardduty.GuarddutyOrganizationConfigurationDatasourcesS3Logs\"}", isOptional: true, isOverride: true)]
        public aws.Guardduty.IGuarddutyOrganizationConfigurationDatasourcesS3Logs? S3Logs
        {
            get;
            set;
        }
    }
}
