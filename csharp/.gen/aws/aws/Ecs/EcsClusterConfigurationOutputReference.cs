using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecs
{
    [JsiiClass(nativeType: typeof(aws.Ecs.EcsClusterConfigurationOutputReference), fullyQualifiedName: "aws.ecs.EcsClusterConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class EcsClusterConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public EcsClusterConfigurationOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcsClusterConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcsClusterConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putExecuteCommandConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ecs.EcsClusterConfigurationExecuteCommandConfiguration\"}}]")]
        public virtual void PutExecuteCommandConfiguration(aws.Ecs.IEcsClusterConfigurationExecuteCommandConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ecs.IEcsClusterConfigurationExecuteCommandConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetExecuteCommandConfiguration")]
        public virtual void ResetExecuteCommandConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "executeCommandConfiguration", typeJson: "{\"fqn\":\"aws.ecs.EcsClusterConfigurationExecuteCommandConfigurationOutputReference\"}")]
        public virtual aws.Ecs.EcsClusterConfigurationExecuteCommandConfigurationOutputReference ExecuteCommandConfiguration
        {
            get => GetInstanceProperty<aws.Ecs.EcsClusterConfigurationExecuteCommandConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "executeCommandConfigurationInput", typeJson: "{\"fqn\":\"aws.ecs.EcsClusterConfigurationExecuteCommandConfiguration\"}", isOptional: true)]
        public virtual aws.Ecs.IEcsClusterConfigurationExecuteCommandConfiguration? ExecuteCommandConfigurationInput
        {
            get => GetInstanceProperty<aws.Ecs.IEcsClusterConfigurationExecuteCommandConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ecs.EcsClusterConfiguration\"}", isOptional: true)]
        public virtual aws.Ecs.IEcsClusterConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.Ecs.IEcsClusterConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
