using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecs
{
    [JsiiClass(nativeType: typeof(aws.Ecs.EcsTaskDefinitionRuntimePlatformOutputReference), fullyQualifiedName: "aws.ecs.EcsTaskDefinitionRuntimePlatformOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class EcsTaskDefinitionRuntimePlatformOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public EcsTaskDefinitionRuntimePlatformOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcsTaskDefinitionRuntimePlatformOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcsTaskDefinitionRuntimePlatformOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCpuArchitecture")]
        public virtual void ResetCpuArchitecture()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOperatingSystemFamily")]
        public virtual void ResetOperatingSystemFamily()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "cpuArchitectureInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CpuArchitectureInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "operatingSystemFamilyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OperatingSystemFamilyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "cpuArchitecture", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CpuArchitecture
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "operatingSystemFamily", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OperatingSystemFamily
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ecs.EcsTaskDefinitionRuntimePlatform\"}", isOptional: true)]
        public virtual aws.Ecs.IEcsTaskDefinitionRuntimePlatform? InternalValue
        {
            get => GetInstanceProperty<aws.Ecs.IEcsTaskDefinitionRuntimePlatform?>();
            set => SetInstanceProperty(value);
        }
    }
}
