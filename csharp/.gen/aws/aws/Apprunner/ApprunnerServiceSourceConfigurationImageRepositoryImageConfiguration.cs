using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apprunner
{
    [JsiiByValue(fqn: "aws.apprunner.ApprunnerServiceSourceConfigurationImageRepositoryImageConfiguration")]
    public class ApprunnerServiceSourceConfigurationImageRepositoryImageConfiguration : aws.Apprunner.IApprunnerServiceSourceConfigurationImageRepositoryImageConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apprunner_service#port ApprunnerService#port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Port
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apprunner_service#runtime_environment_variables ApprunnerService#runtime_environment_variables}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "runtimeEnvironmentVariables", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true, isOverride: true)]
        public object? RuntimeEnvironmentVariables
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apprunner_service#start_command ApprunnerService#start_command}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "startCommand", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? StartCommand
        {
            get;
            set;
        }
    }
}
