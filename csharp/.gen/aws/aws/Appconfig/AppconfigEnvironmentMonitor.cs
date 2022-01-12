using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appconfig
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appconfig.AppconfigEnvironmentMonitor")]
    public class AppconfigEnvironmentMonitor : aws.Appconfig.IAppconfigEnvironmentMonitor
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appconfig_environment#alarm_arn AppconfigEnvironment#alarm_arn}.</summary>
        [JsiiProperty(name: "alarmArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string AlarmArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appconfig_environment#alarm_role_arn AppconfigEnvironment#alarm_role_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "alarmRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AlarmRoleArn
        {
            get;
            set;
        }
    }
}
