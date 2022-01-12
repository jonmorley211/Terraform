using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecs
{
    [JsiiInterface(nativeType: typeof(IEcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfigurationAuthorizationConfig), fullyQualifiedName: "aws.ecs.EcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfigurationAuthorizationConfig")]
    public interface IEcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfigurationAuthorizationConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#credentials_parameter EcsTaskDefinition#credentials_parameter}.</summary>
        [JsiiProperty(name: "credentialsParameter", typeJson: "{\"primitive\":\"string\"}")]
        string CredentialsParameter
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#domain EcsTaskDefinition#domain}.</summary>
        [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}")]
        string Domain
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfigurationAuthorizationConfig), fullyQualifiedName: "aws.ecs.EcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfigurationAuthorizationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Ecs.IEcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfigurationAuthorizationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#credentials_parameter EcsTaskDefinition#credentials_parameter}.</summary>
            [JsiiProperty(name: "credentialsParameter", typeJson: "{\"primitive\":\"string\"}")]
            public string CredentialsParameter
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#domain EcsTaskDefinition#domain}.</summary>
            [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}")]
            public string Domain
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
