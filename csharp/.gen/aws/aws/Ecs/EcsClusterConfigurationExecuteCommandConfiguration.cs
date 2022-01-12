using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecs
{
    [JsiiByValue(fqn: "aws.ecs.EcsClusterConfigurationExecuteCommandConfiguration")]
    public class EcsClusterConfigurationExecuteCommandConfiguration : aws.Ecs.IEcsClusterConfigurationExecuteCommandConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_cluster#kms_key_id EcsCluster#kms_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? KmsKeyId
        {
            get;
            set;
        }

        /// <summary>log_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_cluster#log_configuration EcsCluster#log_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "logConfiguration", typeJson: "{\"fqn\":\"aws.ecs.EcsClusterConfigurationExecuteCommandConfigurationLogConfiguration\"}", isOptional: true, isOverride: true)]
        public aws.Ecs.IEcsClusterConfigurationExecuteCommandConfigurationLogConfiguration? LogConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_cluster#logging EcsCluster#logging}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logging", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Logging
        {
            get;
            set;
        }
    }
}
