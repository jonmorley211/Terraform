using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecs
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_set aws_ecs_task_set}.</summary>
    [JsiiClass(nativeType: typeof(aws.Ecs.EcsTaskSet), fullyQualifiedName: "aws.ecs.EcsTaskSet", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.ecs.EcsTaskSetConfig\"}}]")]
    public class EcsTaskSet : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_set aws_ecs_task_set} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public EcsTaskSet(Constructs.Construct scope, string id, aws.Ecs.IEcsTaskSetConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcsTaskSet(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcsTaskSet(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putNetworkConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ecs.EcsTaskSetNetworkConfiguration\"}}]")]
        public virtual void PutNetworkConfiguration(aws.Ecs.IEcsTaskSetNetworkConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ecs.IEcsTaskSetNetworkConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putScale", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ecs.EcsTaskSetScale\"}}]")]
        public virtual void PutScale(aws.Ecs.IEcsTaskSetScale @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ecs.IEcsTaskSetScale)}, new object[]{@value});
        }

        [JsiiMethod(name: "putServiceRegistries", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ecs.EcsTaskSetServiceRegistries\"}}]")]
        public virtual void PutServiceRegistries(aws.Ecs.IEcsTaskSetServiceRegistries @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ecs.IEcsTaskSetServiceRegistries)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCapacityProviderStrategy")]
        public virtual void ResetCapacityProviderStrategy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExternalId")]
        public virtual void ResetExternalId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetForceDelete")]
        public virtual void ResetForceDelete()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLaunchType")]
        public virtual void ResetLaunchType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLoadBalancer")]
        public virtual void ResetLoadBalancer()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkConfiguration")]
        public virtual void ResetNetworkConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPlatformVersion")]
        public virtual void ResetPlatformVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScale")]
        public virtual void ResetScale()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceRegistries")]
        public virtual void ResetServiceRegistries()
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

        [JsiiMethod(name: "resetWaitUntilStable")]
        public virtual void ResetWaitUntilStable()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWaitUntilStableTimeout")]
        public virtual void ResetWaitUntilStableTimeout()
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
        = GetStaticProperty<string>(typeof(aws.Ecs.EcsTaskSet))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkConfiguration", typeJson: "{\"fqn\":\"aws.ecs.EcsTaskSetNetworkConfigurationOutputReference\"}")]
        public virtual aws.Ecs.EcsTaskSetNetworkConfigurationOutputReference NetworkConfiguration
        {
            get => GetInstanceProperty<aws.Ecs.EcsTaskSetNetworkConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "scale", typeJson: "{\"fqn\":\"aws.ecs.EcsTaskSetScaleOutputReference\"}")]
        public virtual aws.Ecs.EcsTaskSetScaleOutputReference Scale
        {
            get => GetInstanceProperty<aws.Ecs.EcsTaskSetScaleOutputReference>()!;
        }

        [JsiiProperty(name: "serviceRegistries", typeJson: "{\"fqn\":\"aws.ecs.EcsTaskSetServiceRegistriesOutputReference\"}")]
        public virtual aws.Ecs.EcsTaskSetServiceRegistriesOutputReference ServiceRegistries
        {
            get => GetInstanceProperty<aws.Ecs.EcsTaskSetServiceRegistriesOutputReference>()!;
        }

        [JsiiProperty(name: "stabilityStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StabilityStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "taskSetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TaskSetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "capacityProviderStrategyInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecs.EcsTaskSetCapacityProviderStrategy\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Ecs.IEcsTaskSetCapacityProviderStrategy[]? CapacityProviderStrategyInput
        {
            get => GetInstanceProperty<aws.Ecs.IEcsTaskSetCapacityProviderStrategy[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "externalIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExternalIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "forceDeleteInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ForceDeleteInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "launchTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LaunchTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loadBalancerInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecs.EcsTaskSetLoadBalancer\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Ecs.IEcsTaskSetLoadBalancer[]? LoadBalancerInput
        {
            get => GetInstanceProperty<aws.Ecs.IEcsTaskSetLoadBalancer[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkConfigurationInput", typeJson: "{\"fqn\":\"aws.ecs.EcsTaskSetNetworkConfiguration\"}", isOptional: true)]
        public virtual aws.Ecs.IEcsTaskSetNetworkConfiguration? NetworkConfigurationInput
        {
            get => GetInstanceProperty<aws.Ecs.IEcsTaskSetNetworkConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "platformVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PlatformVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scaleInput", typeJson: "{\"fqn\":\"aws.ecs.EcsTaskSetScale\"}", isOptional: true)]
        public virtual aws.Ecs.IEcsTaskSetScale? ScaleInput
        {
            get => GetInstanceProperty<aws.Ecs.IEcsTaskSetScale?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceRegistriesInput", typeJson: "{\"fqn\":\"aws.ecs.EcsTaskSetServiceRegistries\"}", isOptional: true)]
        public virtual aws.Ecs.IEcsTaskSetServiceRegistries? ServiceRegistriesInput
        {
            get => GetInstanceProperty<aws.Ecs.IEcsTaskSetServiceRegistries?>();
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
        [JsiiProperty(name: "taskDefinitionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TaskDefinitionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "waitUntilStableInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? WaitUntilStableInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "waitUntilStableTimeoutInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WaitUntilStableTimeoutInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "capacityProviderStrategy", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecs.EcsTaskSetCapacityProviderStrategy\"},\"kind\":\"array\"}}")]
        public virtual aws.Ecs.IEcsTaskSetCapacityProviderStrategy[] CapacityProviderStrategy
        {
            get => GetInstanceProperty<aws.Ecs.IEcsTaskSetCapacityProviderStrategy[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "cluster", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Cluster
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExternalId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "forceDelete", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object ForceDelete
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "launchType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LaunchType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "loadBalancer", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecs.EcsTaskSetLoadBalancer\"},\"kind\":\"array\"}}")]
        public virtual aws.Ecs.IEcsTaskSetLoadBalancer[] LoadBalancer
        {
            get => GetInstanceProperty<aws.Ecs.IEcsTaskSetLoadBalancer[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "platformVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlatformVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "service", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Service
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "taskDefinition", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TaskDefinition
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "waitUntilStable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object WaitUntilStable
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "waitUntilStableTimeout", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WaitUntilStableTimeout
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
