using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apprunner
{
    [JsiiByValue(fqn: "aws.apprunner.ApprunnerServiceSourceConfigurationAuthenticationConfiguration")]
    public class ApprunnerServiceSourceConfigurationAuthenticationConfiguration : aws.Apprunner.IApprunnerServiceSourceConfigurationAuthenticationConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apprunner_service#access_role_arn ApprunnerService#access_role_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "accessRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AccessRoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apprunner_service#connection_arn ApprunnerService#connection_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "connectionArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ConnectionArn
        {
            get;
            set;
        }
    }
}
