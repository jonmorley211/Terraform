using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Guardduty
{
    [JsiiInterface(nativeType: typeof(IGuarddutyOrganizationConfigurationDatasourcesS3Logs), fullyQualifiedName: "aws.guardduty.GuarddutyOrganizationConfigurationDatasourcesS3Logs")]
    public interface IGuarddutyOrganizationConfigurationDatasourcesS3Logs
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/guardduty_organization_configuration#auto_enable GuarddutyOrganizationConfiguration#auto_enable}.</summary>
        [JsiiProperty(name: "autoEnable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object AutoEnable
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGuarddutyOrganizationConfigurationDatasourcesS3Logs), fullyQualifiedName: "aws.guardduty.GuarddutyOrganizationConfigurationDatasourcesS3Logs")]
        internal sealed class _Proxy : DeputyBase, aws.Guardduty.IGuarddutyOrganizationConfigurationDatasourcesS3Logs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/guardduty_organization_configuration#auto_enable GuarddutyOrganizationConfiguration#auto_enable}.</summary>
            [JsiiProperty(name: "autoEnable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object AutoEnable
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
