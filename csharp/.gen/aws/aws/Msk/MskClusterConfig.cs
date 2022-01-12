using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Msk
{
    #pragma warning disable CS8618

    /// <summary>AWS Managed Streaming for Kafka.</summary>
    [JsiiByValue(fqn: "aws.msk.MskClusterConfig")]
    public class MskClusterConfig : aws.Msk.IMskClusterConfig
    {
        /// <summary>broker_node_group_info block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#broker_node_group_info MskCluster#broker_node_group_info}
        /// </remarks>
        [JsiiProperty(name: "brokerNodeGroupInfo", typeJson: "{\"fqn\":\"aws.msk.MskClusterBrokerNodeGroupInfo\"}", isOverride: true)]
        public aws.Msk.IMskClusterBrokerNodeGroupInfo BrokerNodeGroupInfo
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#cluster_name MskCluster#cluster_name}.</summary>
        [JsiiProperty(name: "clusterName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ClusterName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#kafka_version MskCluster#kafka_version}.</summary>
        [JsiiProperty(name: "kafkaVersion", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string KafkaVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#number_of_broker_nodes MskCluster#number_of_broker_nodes}.</summary>
        [JsiiProperty(name: "numberOfBrokerNodes", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double NumberOfBrokerNodes
        {
            get;
            set;
        }

        /// <summary>client_authentication block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#client_authentication MskCluster#client_authentication}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clientAuthentication", typeJson: "{\"fqn\":\"aws.msk.MskClusterClientAuthentication\"}", isOptional: true, isOverride: true)]
        public aws.Msk.IMskClusterClientAuthentication? ClientAuthentication
        {
            get;
            set;
        }

        /// <summary>configuration_info block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#configuration_info MskCluster#configuration_info}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "configurationInfo", typeJson: "{\"fqn\":\"aws.msk.MskClusterConfigurationInfo\"}", isOptional: true, isOverride: true)]
        public aws.Msk.IMskClusterConfigurationInfo? ConfigurationInfo
        {
            get;
            set;
        }

        /// <summary>encryption_info block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#encryption_info MskCluster#encryption_info}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "encryptionInfo", typeJson: "{\"fqn\":\"aws.msk.MskClusterEncryptionInfo\"}", isOptional: true, isOverride: true)]
        public aws.Msk.IMskClusterEncryptionInfo? EncryptionInfo
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#enhanced_monitoring MskCluster#enhanced_monitoring}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enhancedMonitoring", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? EnhancedMonitoring
        {
            get;
            set;
        }

        /// <summary>logging_info block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#logging_info MskCluster#logging_info}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "loggingInfo", typeJson: "{\"fqn\":\"aws.msk.MskClusterLoggingInfo\"}", isOptional: true, isOverride: true)]
        public aws.Msk.IMskClusterLoggingInfo? LoggingInfo
        {
            get;
            set;
        }

        /// <summary>open_monitoring block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#open_monitoring MskCluster#open_monitoring}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "openMonitoring", typeJson: "{\"fqn\":\"aws.msk.MskClusterOpenMonitoring\"}", isOptional: true, isOverride: true)]
        public aws.Msk.IMskClusterOpenMonitoring? OpenMonitoring
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#tags MskCluster#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true, isOverride: true)]
        public object? Tags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#tags_all MskCluster#tags_all}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tagsAll", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true, isOverride: true)]
        public object? TagsAll
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#timeouts MskCluster#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.msk.MskClusterTimeouts\"}", isOptional: true, isOverride: true)]
        public aws.Msk.IMskClusterTimeouts? Timeouts
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
