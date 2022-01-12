using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecr
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ecr.EcrReplicationConfigurationReplicationConfigurationRuleDestination")]
    public class EcrReplicationConfigurationReplicationConfigurationRuleDestination : aws.Ecr.IEcrReplicationConfigurationReplicationConfigurationRuleDestination
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecr_replication_configuration#region EcrReplicationConfiguration#region}.</summary>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Region
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecr_replication_configuration#registry_id EcrReplicationConfiguration#registry_id}.</summary>
        [JsiiProperty(name: "registryId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string RegistryId
        {
            get;
            set;
        }
    }
}
