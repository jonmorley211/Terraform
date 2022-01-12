using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Guardduty
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.guardduty.GuarddutyOrganizationConfigurationDatasourcesS3Logs")]
    public class GuarddutyOrganizationConfigurationDatasourcesS3Logs : aws.Guardduty.IGuarddutyOrganizationConfigurationDatasourcesS3Logs
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/guardduty_organization_configuration#auto_enable GuarddutyOrganizationConfiguration#auto_enable}.</summary>
        [JsiiProperty(name: "autoEnable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOverride: true)]
        public object AutoEnable
        {
            get;
            set;
        }
    }
}
