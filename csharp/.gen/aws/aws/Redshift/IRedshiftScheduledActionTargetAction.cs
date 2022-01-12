using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Redshift
{
    [JsiiInterface(nativeType: typeof(IRedshiftScheduledActionTargetAction), fullyQualifiedName: "aws.redshift.RedshiftScheduledActionTargetAction")]
    public interface IRedshiftScheduledActionTargetAction
    {
        /// <summary>pause_cluster block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_scheduled_action#pause_cluster RedshiftScheduledAction#pause_cluster}
        /// </remarks>
        [JsiiProperty(name: "pauseCluster", typeJson: "{\"fqn\":\"aws.redshift.RedshiftScheduledActionTargetActionPauseCluster\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Redshift.IRedshiftScheduledActionTargetActionPauseCluster? PauseCluster
        {
            get
            {
                return null;
            }
        }

        /// <summary>resize_cluster block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_scheduled_action#resize_cluster RedshiftScheduledAction#resize_cluster}
        /// </remarks>
        [JsiiProperty(name: "resizeCluster", typeJson: "{\"fqn\":\"aws.redshift.RedshiftScheduledActionTargetActionResizeCluster\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Redshift.IRedshiftScheduledActionTargetActionResizeCluster? ResizeCluster
        {
            get
            {
                return null;
            }
        }

        /// <summary>resume_cluster block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_scheduled_action#resume_cluster RedshiftScheduledAction#resume_cluster}
        /// </remarks>
        [JsiiProperty(name: "resumeCluster", typeJson: "{\"fqn\":\"aws.redshift.RedshiftScheduledActionTargetActionResumeCluster\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Redshift.IRedshiftScheduledActionTargetActionResumeCluster? ResumeCluster
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRedshiftScheduledActionTargetAction), fullyQualifiedName: "aws.redshift.RedshiftScheduledActionTargetAction")]
        internal sealed class _Proxy : DeputyBase, aws.Redshift.IRedshiftScheduledActionTargetAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>pause_cluster block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_scheduled_action#pause_cluster RedshiftScheduledAction#pause_cluster}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pauseCluster", typeJson: "{\"fqn\":\"aws.redshift.RedshiftScheduledActionTargetActionPauseCluster\"}", isOptional: true)]
            public aws.Redshift.IRedshiftScheduledActionTargetActionPauseCluster? PauseCluster
            {
                get => GetInstanceProperty<aws.Redshift.IRedshiftScheduledActionTargetActionPauseCluster?>();
            }

            /// <summary>resize_cluster block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_scheduled_action#resize_cluster RedshiftScheduledAction#resize_cluster}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resizeCluster", typeJson: "{\"fqn\":\"aws.redshift.RedshiftScheduledActionTargetActionResizeCluster\"}", isOptional: true)]
            public aws.Redshift.IRedshiftScheduledActionTargetActionResizeCluster? ResizeCluster
            {
                get => GetInstanceProperty<aws.Redshift.IRedshiftScheduledActionTargetActionResizeCluster?>();
            }

            /// <summary>resume_cluster block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_scheduled_action#resume_cluster RedshiftScheduledAction#resume_cluster}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resumeCluster", typeJson: "{\"fqn\":\"aws.redshift.RedshiftScheduledActionTargetActionResumeCluster\"}", isOptional: true)]
            public aws.Redshift.IRedshiftScheduledActionTargetActionResumeCluster? ResumeCluster
            {
                get => GetInstanceProperty<aws.Redshift.IRedshiftScheduledActionTargetActionResumeCluster?>();
            }
        }
    }
}
