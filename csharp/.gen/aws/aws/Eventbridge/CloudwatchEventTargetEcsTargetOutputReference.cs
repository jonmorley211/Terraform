using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Eventbridge
{
    [JsiiClass(nativeType: typeof(aws.Eventbridge.CloudwatchEventTargetEcsTargetOutputReference), fullyQualifiedName: "aws.eventbridge.CloudwatchEventTargetEcsTargetOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class CloudwatchEventTargetEcsTargetOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public CloudwatchEventTargetEcsTargetOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudwatchEventTargetEcsTargetOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudwatchEventTargetEcsTargetOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putNetworkConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetEcsTargetNetworkConfiguration\"}}]")]
        public virtual void PutNetworkConfiguration(aws.Eventbridge.ICloudwatchEventTargetEcsTargetNetworkConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Eventbridge.ICloudwatchEventTargetEcsTargetNetworkConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEnableEcsManagedTags")]
        public virtual void ResetEnableEcsManagedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnableExecuteCommand")]
        public virtual void ResetEnableExecuteCommand()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGroup")]
        public virtual void ResetGroup()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLaunchType")]
        public virtual void ResetLaunchType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkConfiguration")]
        public virtual void ResetNetworkConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPlacementConstraint")]
        public virtual void ResetPlacementConstraint()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPlatformVersion")]
        public virtual void ResetPlatformVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPropagateTags")]
        public virtual void ResetPropagateTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTaskCount")]
        public virtual void ResetTaskCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "networkConfiguration", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetEcsTargetNetworkConfigurationOutputReference\"}")]
        public virtual aws.Eventbridge.CloudwatchEventTargetEcsTargetNetworkConfigurationOutputReference NetworkConfiguration
        {
            get => GetInstanceProperty<aws.Eventbridge.CloudwatchEventTargetEcsTargetNetworkConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableEcsManagedTagsInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnableEcsManagedTagsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableExecuteCommandInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnableExecuteCommandInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "groupInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GroupInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "launchTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LaunchTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkConfigurationInput", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetEcsTargetNetworkConfiguration\"}", isOptional: true)]
        public virtual aws.Eventbridge.ICloudwatchEventTargetEcsTargetNetworkConfiguration? NetworkConfigurationInput
        {
            get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventTargetEcsTargetNetworkConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "placementConstraintInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetEcsTargetPlacementConstraint\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Eventbridge.ICloudwatchEventTargetEcsTargetPlacementConstraint[]? PlacementConstraintInput
        {
            get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventTargetEcsTargetPlacementConstraint[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "platformVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PlatformVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "propagateTagsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PropagateTagsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? TagsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "taskCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TaskCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "taskDefinitionArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TaskDefinitionArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "enableEcsManagedTags", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object EnableEcsManagedTags
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enableExecuteCommand", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object EnableExecuteCommand
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "group", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Group
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "launchType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LaunchType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "placementConstraint", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetEcsTargetPlacementConstraint\"},\"kind\":\"array\"}}")]
        public virtual aws.Eventbridge.ICloudwatchEventTargetEcsTargetPlacementConstraint[] PlacementConstraint
        {
            get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventTargetEcsTargetPlacementConstraint[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "platformVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlatformVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "propagateTags", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PropagateTags
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

        [JsiiProperty(name: "taskCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TaskCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "taskDefinitionArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TaskDefinitionArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetEcsTarget\"}", isOptional: true)]
        public virtual aws.Eventbridge.ICloudwatchEventTargetEcsTarget? InternalValue
        {
            get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventTargetEcsTarget?>();
            set => SetInstanceProperty(value);
        }
    }
}
