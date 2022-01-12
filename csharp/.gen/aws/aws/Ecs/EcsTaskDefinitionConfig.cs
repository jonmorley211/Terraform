using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecs
{
    #pragma warning disable CS8618

    /// <summary>AWS EC2 Container Service.</summary>
    [JsiiByValue(fqn: "aws.ecs.EcsTaskDefinitionConfig")]
    public class EcsTaskDefinitionConfig : aws.Ecs.IEcsTaskDefinitionConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#container_definitions EcsTaskDefinition#container_definitions}.</summary>
        [JsiiProperty(name: "containerDefinitions", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ContainerDefinitions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#family EcsTaskDefinition#family}.</summary>
        [JsiiProperty(name: "family", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Family
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#cpu EcsTaskDefinition#cpu}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cpu", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Cpu
        {
            get;
            set;
        }

        /// <summary>ephemeral_storage block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#ephemeral_storage EcsTaskDefinition#ephemeral_storage}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ephemeralStorage", typeJson: "{\"fqn\":\"aws.ecs.EcsTaskDefinitionEphemeralStorage\"}", isOptional: true, isOverride: true)]
        public aws.Ecs.IEcsTaskDefinitionEphemeralStorage? EphemeralStorage
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#execution_role_arn EcsTaskDefinition#execution_role_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "executionRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ExecutionRoleArn
        {
            get;
            set;
        }

        /// <summary>inference_accelerator block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#inference_accelerator EcsTaskDefinition#inference_accelerator}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "inferenceAccelerator", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecs.EcsTaskDefinitionInferenceAccelerator\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Ecs.IEcsTaskDefinitionInferenceAccelerator[]? InferenceAccelerator
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#ipc_mode EcsTaskDefinition#ipc_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipcMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? IpcMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#memory EcsTaskDefinition#memory}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "memory", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Memory
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#network_mode EcsTaskDefinition#network_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "networkMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? NetworkMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#pid_mode EcsTaskDefinition#pid_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pidMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? PidMode
        {
            get;
            set;
        }

        /// <summary>placement_constraints block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#placement_constraints EcsTaskDefinition#placement_constraints}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "placementConstraints", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecs.EcsTaskDefinitionPlacementConstraints\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Ecs.IEcsTaskDefinitionPlacementConstraints[]? PlacementConstraints
        {
            get;
            set;
        }

        /// <summary>proxy_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#proxy_configuration EcsTaskDefinition#proxy_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "proxyConfiguration", typeJson: "{\"fqn\":\"aws.ecs.EcsTaskDefinitionProxyConfiguration\"}", isOptional: true, isOverride: true)]
        public aws.Ecs.IEcsTaskDefinitionProxyConfiguration? ProxyConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#requires_compatibilities EcsTaskDefinition#requires_compatibilities}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "requiresCompatibilities", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? RequiresCompatibilities
        {
            get;
            set;
        }

        /// <summary>runtime_platform block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#runtime_platform EcsTaskDefinition#runtime_platform}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "runtimePlatform", typeJson: "{\"fqn\":\"aws.ecs.EcsTaskDefinitionRuntimePlatform\"}", isOptional: true, isOverride: true)]
        public aws.Ecs.IEcsTaskDefinitionRuntimePlatform? RuntimePlatform
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#tags EcsTaskDefinition#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true, isOverride: true)]
        public object? Tags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#tags_all EcsTaskDefinition#tags_all}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tagsAll", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true, isOverride: true)]
        public object? TagsAll
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#task_role_arn EcsTaskDefinition#task_role_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "taskRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? TaskRoleArn
        {
            get;
            set;
        }

        /// <summary>volume block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#volume EcsTaskDefinition#volume}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "volume", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecs.EcsTaskDefinitionVolume\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Ecs.IEcsTaskDefinitionVolume[]? Volume
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
