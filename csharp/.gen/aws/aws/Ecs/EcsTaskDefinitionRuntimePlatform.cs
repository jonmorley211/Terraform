using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecs
{
    [JsiiByValue(fqn: "aws.ecs.EcsTaskDefinitionRuntimePlatform")]
    public class EcsTaskDefinitionRuntimePlatform : aws.Ecs.IEcsTaskDefinitionRuntimePlatform
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#cpu_architecture EcsTaskDefinition#cpu_architecture}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cpuArchitecture", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CpuArchitecture
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#operating_system_family EcsTaskDefinition#operating_system_family}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "operatingSystemFamily", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? OperatingSystemFamily
        {
            get;
            set;
        }
    }
}
