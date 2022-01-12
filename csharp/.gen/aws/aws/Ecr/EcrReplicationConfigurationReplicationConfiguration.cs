using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecr
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ecr.EcrReplicationConfigurationReplicationConfiguration")]
    public class EcrReplicationConfigurationReplicationConfiguration : aws.Ecr.IEcrReplicationConfigurationReplicationConfiguration
    {
        /// <summary>rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecr_replication_configuration#rule EcrReplicationConfiguration#rule}
        /// </remarks>
        [JsiiProperty(name: "rule", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecr.EcrReplicationConfigurationReplicationConfigurationRule\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.Ecr.IEcrReplicationConfigurationReplicationConfigurationRule[] Rule
        {
            get;
            set;
        }
    }
}
