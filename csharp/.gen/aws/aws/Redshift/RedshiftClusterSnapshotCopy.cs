using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Redshift
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.redshift.RedshiftClusterSnapshotCopy")]
    public class RedshiftClusterSnapshotCopy : aws.Redshift.IRedshiftClusterSnapshotCopy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_cluster#destination_region RedshiftCluster#destination_region}.</summary>
        [JsiiProperty(name: "destinationRegion", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string DestinationRegion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_cluster#grant_name RedshiftCluster#grant_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "grantName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? GrantName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_cluster#retention_period RedshiftCluster#retention_period}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "retentionPeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? RetentionPeriod
        {
            get;
            set;
        }
    }
}
