using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecs
{
    [JsiiClass(nativeType: typeof(aws.Ecs.EcsClusterConfigurationExecuteCommandConfigurationOutputReference), fullyQualifiedName: "aws.ecs.EcsClusterConfigurationExecuteCommandConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class EcsClusterConfigurationExecuteCommandConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public EcsClusterConfigurationExecuteCommandConfigurationOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcsClusterConfigurationExecuteCommandConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcsClusterConfigurationExecuteCommandConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putLogConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ecs.EcsClusterConfigurationExecuteCommandConfigurationLogConfiguration\"}}]")]
        public virtual void PutLogConfiguration(aws.Ecs.IEcsClusterConfigurationExecuteCommandConfigurationLogConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ecs.IEcsClusterConfigurationExecuteCommandConfigurationLogConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetKmsKeyId")]
        public virtual void ResetKmsKeyId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogConfiguration")]
        public virtual void ResetLogConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogging")]
        public virtual void ResetLogging()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "logConfiguration", typeJson: "{\"fqn\":\"aws.ecs.EcsClusterConfigurationExecuteCommandConfigurationLogConfigurationOutputReference\"}")]
        public virtual aws.Ecs.EcsClusterConfigurationExecuteCommandConfigurationLogConfigurationOutputReference LogConfiguration
        {
            get => GetInstanceProperty<aws.Ecs.EcsClusterConfigurationExecuteCommandConfigurationLogConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KmsKeyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logConfigurationInput", typeJson: "{\"fqn\":\"aws.ecs.EcsClusterConfigurationExecuteCommandConfigurationLogConfiguration\"}", isOptional: true)]
        public virtual aws.Ecs.IEcsClusterConfigurationExecuteCommandConfigurationLogConfiguration? LogConfigurationInput
        {
            get => GetInstanceProperty<aws.Ecs.IEcsClusterConfigurationExecuteCommandConfigurationLogConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loggingInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LoggingInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KmsKeyId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "logging", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Logging
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ecs.EcsClusterConfigurationExecuteCommandConfiguration\"}", isOptional: true)]
        public virtual aws.Ecs.IEcsClusterConfigurationExecuteCommandConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.Ecs.IEcsClusterConfigurationExecuteCommandConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
