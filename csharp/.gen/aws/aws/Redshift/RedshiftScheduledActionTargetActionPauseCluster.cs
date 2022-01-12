using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Redshift
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.redshift.RedshiftScheduledActionTargetActionPauseCluster")]
    public class RedshiftScheduledActionTargetActionPauseCluster : aws.Redshift.IRedshiftScheduledActionTargetActionPauseCluster
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_scheduled_action#cluster_identifier RedshiftScheduledAction#cluster_identifier}.</summary>
        [JsiiProperty(name: "clusterIdentifier", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ClusterIdentifier
        {
            get;
            set;
        }
    }
}
