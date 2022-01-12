using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Redshift
{
    [JsiiClass(nativeType: typeof(aws.Redshift.RedshiftScheduledActionTargetActionOutputReference), fullyQualifiedName: "aws.redshift.RedshiftScheduledActionTargetActionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class RedshiftScheduledActionTargetActionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public RedshiftScheduledActionTargetActionOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected RedshiftScheduledActionTargetActionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected RedshiftScheduledActionTargetActionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putPauseCluster", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.redshift.RedshiftScheduledActionTargetActionPauseCluster\"}}]")]
        public virtual void PutPauseCluster(aws.Redshift.IRedshiftScheduledActionTargetActionPauseCluster @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Redshift.IRedshiftScheduledActionTargetActionPauseCluster)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResizeCluster", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.redshift.RedshiftScheduledActionTargetActionResizeCluster\"}}]")]
        public virtual void PutResizeCluster(aws.Redshift.IRedshiftScheduledActionTargetActionResizeCluster @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Redshift.IRedshiftScheduledActionTargetActionResizeCluster)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResumeCluster", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.redshift.RedshiftScheduledActionTargetActionResumeCluster\"}}]")]
        public virtual void PutResumeCluster(aws.Redshift.IRedshiftScheduledActionTargetActionResumeCluster @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Redshift.IRedshiftScheduledActionTargetActionResumeCluster)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetPauseCluster")]
        public virtual void ResetPauseCluster()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResizeCluster")]
        public virtual void ResetResizeCluster()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResumeCluster")]
        public virtual void ResetResumeCluster()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "pauseCluster", typeJson: "{\"fqn\":\"aws.redshift.RedshiftScheduledActionTargetActionPauseClusterOutputReference\"}")]
        public virtual aws.Redshift.RedshiftScheduledActionTargetActionPauseClusterOutputReference PauseCluster
        {
            get => GetInstanceProperty<aws.Redshift.RedshiftScheduledActionTargetActionPauseClusterOutputReference>()!;
        }

        [JsiiProperty(name: "resizeCluster", typeJson: "{\"fqn\":\"aws.redshift.RedshiftScheduledActionTargetActionResizeClusterOutputReference\"}")]
        public virtual aws.Redshift.RedshiftScheduledActionTargetActionResizeClusterOutputReference ResizeCluster
        {
            get => GetInstanceProperty<aws.Redshift.RedshiftScheduledActionTargetActionResizeClusterOutputReference>()!;
        }

        [JsiiProperty(name: "resumeCluster", typeJson: "{\"fqn\":\"aws.redshift.RedshiftScheduledActionTargetActionResumeClusterOutputReference\"}")]
        public virtual aws.Redshift.RedshiftScheduledActionTargetActionResumeClusterOutputReference ResumeCluster
        {
            get => GetInstanceProperty<aws.Redshift.RedshiftScheduledActionTargetActionResumeClusterOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "pauseClusterInput", typeJson: "{\"fqn\":\"aws.redshift.RedshiftScheduledActionTargetActionPauseCluster\"}", isOptional: true)]
        public virtual aws.Redshift.IRedshiftScheduledActionTargetActionPauseCluster? PauseClusterInput
        {
            get => GetInstanceProperty<aws.Redshift.IRedshiftScheduledActionTargetActionPauseCluster?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resizeClusterInput", typeJson: "{\"fqn\":\"aws.redshift.RedshiftScheduledActionTargetActionResizeCluster\"}", isOptional: true)]
        public virtual aws.Redshift.IRedshiftScheduledActionTargetActionResizeCluster? ResizeClusterInput
        {
            get => GetInstanceProperty<aws.Redshift.IRedshiftScheduledActionTargetActionResizeCluster?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resumeClusterInput", typeJson: "{\"fqn\":\"aws.redshift.RedshiftScheduledActionTargetActionResumeCluster\"}", isOptional: true)]
        public virtual aws.Redshift.IRedshiftScheduledActionTargetActionResumeCluster? ResumeClusterInput
        {
            get => GetInstanceProperty<aws.Redshift.IRedshiftScheduledActionTargetActionResumeCluster?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.redshift.RedshiftScheduledActionTargetAction\"}", isOptional: true)]
        public virtual aws.Redshift.IRedshiftScheduledActionTargetAction? InternalValue
        {
            get => GetInstanceProperty<aws.Redshift.IRedshiftScheduledActionTargetAction?>();
            set => SetInstanceProperty(value);
        }
    }
}
