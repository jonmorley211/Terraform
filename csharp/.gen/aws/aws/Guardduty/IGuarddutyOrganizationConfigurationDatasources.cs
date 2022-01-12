using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Guardduty
{
    [JsiiInterface(nativeType: typeof(IGuarddutyOrganizationConfigurationDatasources), fullyQualifiedName: "aws.guardduty.GuarddutyOrganizationConfigurationDatasources")]
    public interface IGuarddutyOrganizationConfigurationDatasources
    {
        /// <summary>s3_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/guardduty_organization_configuration#s3_logs GuarddutyOrganizationConfiguration#s3_logs}
        /// </remarks>
        [JsiiProperty(name: "s3Logs", typeJson: "{\"fqn\":\"aws.guardduty.GuarddutyOrganizationConfigurationDatasourcesS3Logs\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Guardduty.IGuarddutyOrganizationConfigurationDatasourcesS3Logs? S3Logs
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGuarddutyOrganizationConfigurationDatasources), fullyQualifiedName: "aws.guardduty.GuarddutyOrganizationConfigurationDatasources")]
        internal sealed class _Proxy : DeputyBase, aws.Guardduty.IGuarddutyOrganizationConfigurationDatasources
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>s3_logs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/guardduty_organization_configuration#s3_logs GuarddutyOrganizationConfiguration#s3_logs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3Logs", typeJson: "{\"fqn\":\"aws.guardduty.GuarddutyOrganizationConfigurationDatasourcesS3Logs\"}", isOptional: true)]
            public aws.Guardduty.IGuarddutyOrganizationConfigurationDatasourcesS3Logs? S3Logs
            {
                get => GetInstanceProperty<aws.Guardduty.IGuarddutyOrganizationConfigurationDatasourcesS3Logs?>();
            }
        }
    }
}
