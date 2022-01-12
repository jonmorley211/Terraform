using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecs
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ecs.EcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfigurationAuthorizationConfig")]
    public class EcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfigurationAuthorizationConfig : aws.Ecs.IEcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfigurationAuthorizationConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#credentials_parameter EcsTaskDefinition#credentials_parameter}.</summary>
        [JsiiProperty(name: "credentialsParameter", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string CredentialsParameter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#domain EcsTaskDefinition#domain}.</summary>
        [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Domain
        {
            get;
            set;
        }
    }
}
