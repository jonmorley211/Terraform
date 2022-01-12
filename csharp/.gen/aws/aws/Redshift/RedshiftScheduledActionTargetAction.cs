using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Redshift
{
    [JsiiByValue(fqn: "aws.redshift.RedshiftScheduledActionTargetAction")]
    public class RedshiftScheduledActionTargetAction : aws.Redshift.IRedshiftScheduledActionTargetAction
    {
        /// <summary>pause_cluster block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_scheduled_action#pause_cluster RedshiftScheduledAction#pause_cluster}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pauseCluster", typeJson: "{\"fqn\":\"aws.redshift.RedshiftScheduledActionTargetActionPauseCluster\"}", isOptional: true, isOverride: true)]
        public aws.Redshift.IRedshiftScheduledActionTargetActionPauseCluster? PauseCluster
        {
            get;
            set;
        }

        /// <summary>resize_cluster block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_scheduled_action#resize_cluster RedshiftScheduledAction#resize_cluster}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resizeCluster", typeJson: "{\"fqn\":\"aws.redshift.RedshiftScheduledActionTargetActionResizeCluster\"}", isOptional: true, isOverride: true)]
        public aws.Redshift.IRedshiftScheduledActionTargetActionResizeCluster? ResizeCluster
        {
            get;
            set;
        }

        /// <summary>resume_cluster block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_scheduled_action#resume_cluster RedshiftScheduledAction#resume_cluster}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resumeCluster", typeJson: "{\"fqn\":\"aws.redshift.RedshiftScheduledActionTargetActionResumeCluster\"}", isOptional: true, isOverride: true)]
        public aws.Redshift.IRedshiftScheduledActionTargetActionResumeCluster? ResumeCluster
        {
            get;
            set;
        }
    }
}
