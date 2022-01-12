using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecs
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition aws_ecs_task_definition}.</summary>
    [JsiiClass(nativeType: typeof(aws.Ecs.EcsTaskDefinition), fullyQualifiedName: "aws.ecs.EcsTaskDefinition", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.ecs.EcsTaskDefinitionConfig\"}}]")]
    public class EcsTaskDefinition : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition aws_ecs_task_definition} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public EcsTaskDefinition(Constructs.Construct scope, string id, aws.Ecs.IEcsTaskDefinitionConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcsTaskDefinition(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcsTaskDefinition(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putEphemeralStorage", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ecs.EcsTaskDefinitionEphemeralStorage\"}}]")]
        public virtual void PutEphemeralStorage(aws.Ecs.IEcsTaskDefinitionEphemeralStorage @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ecs.IEcsTaskDefinitionEphemeralStorage)}, new object[]{@value});
        }

        [JsiiMethod(name: "putProxyConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ecs.EcsTaskDefinitionProxyConfiguration\"}}]")]
        public virtual void PutProxyConfiguration(aws.Ecs.IEcsTaskDefinitionProxyConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ecs.IEcsTaskDefinitionProxyConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRuntimePlatform", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ecs.EcsTaskDefinitionRuntimePlatform\"}}]")]
        public virtual void PutRuntimePlatform(aws.Ecs.IEcsTaskDefinitionRuntimePlatform @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ecs.IEcsTaskDefinitionRuntimePlatform)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCpu")]
        public virtual void ResetCpu()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEphemeralStorage")]
        public virtual void ResetEphemeralStorage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExecutionRoleArn")]
        public virtual void ResetExecutionRoleArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInferenceAccelerator")]
        public virtual void ResetInferenceAccelerator()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIpcMode")]
        public virtual void ResetIpcMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMemory")]
        public virtual void ResetMemory()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkMode")]
        public virtual void ResetNetworkMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPidMode")]
        public virtual void ResetPidMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPlacementConstraints")]
        public virtual void ResetPlacementConstraints()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProxyConfiguration")]
        public virtual void ResetProxyConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequiresCompatibilities")]
        public virtual void ResetRequiresCompatibilities()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRuntimePlatform")]
        public virtual void ResetRuntimePlatform()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTagsAll")]
        public virtual void ResetTagsAll()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTaskRoleArn")]
        public virtual void ResetTaskRoleArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVolume")]
        public virtual void ResetVolume()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.Ecs.EcsTaskDefinition))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ephemeralStorage", typeJson: "{\"fqn\":\"aws.ecs.EcsTaskDefinitionEphemeralStorageOutputReference\"}")]
        public virtual aws.Ecs.EcsTaskDefinitionEphemeralStorageOutputReference EphemeralStorage
        {
            get => GetInstanceProperty<aws.Ecs.EcsTaskDefinitionEphemeralStorageOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "proxyConfiguration", typeJson: "{\"fqn\":\"aws.ecs.EcsTaskDefinitionProxyConfigurationOutputReference\"}")]
        public virtual aws.Ecs.EcsTaskDefinitionProxyConfigurationOutputReference ProxyConfiguration
        {
            get => GetInstanceProperty<aws.Ecs.EcsTaskDefinitionProxyConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "revision", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Revision
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "runtimePlatform", typeJson: "{\"fqn\":\"aws.ecs.EcsTaskDefinitionRuntimePlatformOutputReference\"}")]
        public virtual aws.Ecs.EcsTaskDefinitionRuntimePlatformOutputReference RuntimePlatform
        {
            get => GetInstanceProperty<aws.Ecs.EcsTaskDefinitionRuntimePlatformOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "containerDefinitionsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ContainerDefinitionsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cpuInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CpuInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ephemeralStorageInput", typeJson: "{\"fqn\":\"aws.ecs.EcsTaskDefinitionEphemeralStorage\"}", isOptional: true)]
        public virtual aws.Ecs.IEcsTaskDefinitionEphemeralStorage? EphemeralStorageInput
        {
            get => GetInstanceProperty<aws.Ecs.IEcsTaskDefinitionEphemeralStorage?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "executionRoleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExecutionRoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "familyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FamilyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inferenceAcceleratorInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecs.EcsTaskDefinitionInferenceAccelerator\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Ecs.IEcsTaskDefinitionInferenceAccelerator[]? InferenceAcceleratorInput
        {
            get => GetInstanceProperty<aws.Ecs.IEcsTaskDefinitionInferenceAccelerator[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipcModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IpcModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "memoryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MemoryInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NetworkModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pidModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PidModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "placementConstraintsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecs.EcsTaskDefinitionPlacementConstraints\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Ecs.IEcsTaskDefinitionPlacementConstraints[]? PlacementConstraintsInput
        {
            get => GetInstanceProperty<aws.Ecs.IEcsTaskDefinitionPlacementConstraints[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "proxyConfigurationInput", typeJson: "{\"fqn\":\"aws.ecs.EcsTaskDefinitionProxyConfiguration\"}", isOptional: true)]
        public virtual aws.Ecs.IEcsTaskDefinitionProxyConfiguration? ProxyConfigurationInput
        {
            get => GetInstanceProperty<aws.Ecs.IEcsTaskDefinitionProxyConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requiresCompatibilitiesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? RequiresCompatibilitiesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "runtimePlatformInput", typeJson: "{\"fqn\":\"aws.ecs.EcsTaskDefinitionRuntimePlatform\"}", isOptional: true)]
        public virtual aws.Ecs.IEcsTaskDefinitionRuntimePlatform? RuntimePlatformInput
        {
            get => GetInstanceProperty<aws.Ecs.IEcsTaskDefinitionRuntimePlatform?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsAllInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? TagsAllInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? TagsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "taskRoleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TaskRoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "volumeInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecs.EcsTaskDefinitionVolume\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Ecs.IEcsTaskDefinitionVolume[]? VolumeInput
        {
            get => GetInstanceProperty<aws.Ecs.IEcsTaskDefinitionVolume[]?>();
        }

        [JsiiProperty(name: "containerDefinitions", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContainerDefinitions
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "cpu", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Cpu
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "executionRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExecutionRoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "family", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Family
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "inferenceAccelerator", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecs.EcsTaskDefinitionInferenceAccelerator\"},\"kind\":\"array\"}}")]
        public virtual aws.Ecs.IEcsTaskDefinitionInferenceAccelerator[] InferenceAccelerator
        {
            get => GetInstanceProperty<aws.Ecs.IEcsTaskDefinitionInferenceAccelerator[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ipcMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpcMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "memory", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Memory
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "networkMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pidMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PidMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "placementConstraints", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecs.EcsTaskDefinitionPlacementConstraints\"},\"kind\":\"array\"}}")]
        public virtual aws.Ecs.IEcsTaskDefinitionPlacementConstraints[] PlacementConstraints
        {
            get => GetInstanceProperty<aws.Ecs.IEcsTaskDefinitionPlacementConstraints[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "requiresCompatibilities", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] RequiresCompatibilities
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}")]
        public virtual object Tags
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tagsAll", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}")]
        public virtual object TagsAll
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "taskRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TaskRoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "volume", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecs.EcsTaskDefinitionVolume\"},\"kind\":\"array\"}}")]
        public virtual aws.Ecs.IEcsTaskDefinitionVolume[] Volume
        {
            get => GetInstanceProperty<aws.Ecs.IEcsTaskDefinitionVolume[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
