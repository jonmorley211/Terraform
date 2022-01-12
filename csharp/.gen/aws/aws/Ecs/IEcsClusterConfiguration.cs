using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecs
{
    [JsiiInterface(nativeType: typeof(IEcsClusterConfiguration), fullyQualifiedName: "aws.ecs.EcsClusterConfiguration")]
    public interface IEcsClusterConfiguration
    {
        /// <summary>execute_command_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_cluster#execute_command_configuration EcsCluster#execute_command_configuration}
        /// </remarks>
        [JsiiProperty(name: "executeCommandConfiguration", typeJson: "{\"fqn\":\"aws.ecs.EcsClusterConfigurationExecuteCommandConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ecs.IEcsClusterConfigurationExecuteCommandConfiguration? ExecuteCommandConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsClusterConfiguration), fullyQualifiedName: "aws.ecs.EcsClusterConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Ecs.IEcsClusterConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>execute_command_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_cluster#execute_command_configuration EcsCluster#execute_command_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "executeCommandConfiguration", typeJson: "{\"fqn\":\"aws.ecs.EcsClusterConfigurationExecuteCommandConfiguration\"}", isOptional: true)]
            public aws.Ecs.IEcsClusterConfigurationExecuteCommandConfiguration? ExecuteCommandConfiguration
            {
                get => GetInstanceProperty<aws.Ecs.IEcsClusterConfigurationExecuteCommandConfiguration?>();
            }
        }
    }
}
