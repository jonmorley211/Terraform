using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecr
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ecr.EcrReplicationConfigurationReplicationConfigurationRule")]
    public class EcrReplicationConfigurationReplicationConfigurationRule : aws.Ecr.IEcrReplicationConfigurationReplicationConfigurationRule
    {
        /// <summary>destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecr_replication_configuration#destination EcrReplicationConfiguration#destination}
        /// </remarks>
        [JsiiProperty(name: "destination", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecr.EcrReplicationConfigurationReplicationConfigurationRuleDestination\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.Ecr.IEcrReplicationConfigurationReplicationConfigurationRuleDestination[] Destination
        {
            get;
            set;
        }

        /// <summary>repository_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecr_replication_configuration#repository_filter EcrReplicationConfiguration#repository_filter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "repositoryFilter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecr.EcrReplicationConfigurationReplicationConfigurationRuleRepositoryFilter\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Ecr.IEcrReplicationConfigurationReplicationConfigurationRuleRepositoryFilter[]? RepositoryFilter
        {
            get;
            set;
        }
    }
}
