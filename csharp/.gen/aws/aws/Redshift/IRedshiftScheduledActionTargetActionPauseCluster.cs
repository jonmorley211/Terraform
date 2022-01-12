using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Redshift
{
    [JsiiInterface(nativeType: typeof(IRedshiftScheduledActionTargetActionPauseCluster), fullyQualifiedName: "aws.redshift.RedshiftScheduledActionTargetActionPauseCluster")]
    public interface IRedshiftScheduledActionTargetActionPauseCluster
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_scheduled_action#cluster_identifier RedshiftScheduledAction#cluster_identifier}.</summary>
        [JsiiProperty(name: "clusterIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        string ClusterIdentifier
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IRedshiftScheduledActionTargetActionPauseCluster), fullyQualifiedName: "aws.redshift.RedshiftScheduledActionTargetActionPauseCluster")]
        internal sealed class _Proxy : DeputyBase, aws.Redshift.IRedshiftScheduledActionTargetActionPauseCluster
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_scheduled_action#cluster_identifier RedshiftScheduledAction#cluster_identifier}.</summary>
            [JsiiProperty(name: "clusterIdentifier", typeJson: "{\"primitive\":\"string\"}")]
            public string ClusterIdentifier
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
