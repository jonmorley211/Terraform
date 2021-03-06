using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appconfig
{
    [JsiiInterface(nativeType: typeof(IAppconfigEnvironmentMonitor), fullyQualifiedName: "aws.appconfig.AppconfigEnvironmentMonitor")]
    public interface IAppconfigEnvironmentMonitor
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appconfig_environment#alarm_arn AppconfigEnvironment#alarm_arn}.</summary>
        [JsiiProperty(name: "alarmArn", typeJson: "{\"primitive\":\"string\"}")]
        string AlarmArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appconfig_environment#alarm_role_arn AppconfigEnvironment#alarm_role_arn}.</summary>
        [JsiiProperty(name: "alarmRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AlarmRoleArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppconfigEnvironmentMonitor), fullyQualifiedName: "aws.appconfig.AppconfigEnvironmentMonitor")]
        internal sealed class _Proxy : DeputyBase, aws.Appconfig.IAppconfigEnvironmentMonitor
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appconfig_environment#alarm_arn AppconfigEnvironment#alarm_arn}.</summary>
            [JsiiProperty(name: "alarmArn", typeJson: "{\"primitive\":\"string\"}")]
            public string AlarmArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appconfig_environment#alarm_role_arn AppconfigEnvironment#alarm_role_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "alarmRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AlarmRoleArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
