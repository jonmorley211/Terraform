using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Mwaa
{
    [JsiiClass(nativeType: typeof(aws.Mwaa.MwaaEnvironmentLoggingConfigurationOutputReference), fullyQualifiedName: "aws.mwaa.MwaaEnvironmentLoggingConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class MwaaEnvironmentLoggingConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public MwaaEnvironmentLoggingConfigurationOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MwaaEnvironmentLoggingConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MwaaEnvironmentLoggingConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDagProcessingLogs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mwaa.MwaaEnvironmentLoggingConfigurationDagProcessingLogs\"}}]")]
        public virtual void PutDagProcessingLogs(aws.Mwaa.IMwaaEnvironmentLoggingConfigurationDagProcessingLogs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Mwaa.IMwaaEnvironmentLoggingConfigurationDagProcessingLogs)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSchedulerLogs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mwaa.MwaaEnvironmentLoggingConfigurationSchedulerLogs\"}}]")]
        public virtual void PutSchedulerLogs(aws.Mwaa.IMwaaEnvironmentLoggingConfigurationSchedulerLogs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Mwaa.IMwaaEnvironmentLoggingConfigurationSchedulerLogs)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTaskLogs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mwaa.MwaaEnvironmentLoggingConfigurationTaskLogs\"}}]")]
        public virtual void PutTaskLogs(aws.Mwaa.IMwaaEnvironmentLoggingConfigurationTaskLogs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Mwaa.IMwaaEnvironmentLoggingConfigurationTaskLogs)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWebserverLogs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mwaa.MwaaEnvironmentLoggingConfigurationWebserverLogs\"}}]")]
        public virtual void PutWebserverLogs(aws.Mwaa.IMwaaEnvironmentLoggingConfigurationWebserverLogs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Mwaa.IMwaaEnvironmentLoggingConfigurationWebserverLogs)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWorkerLogs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mwaa.MwaaEnvironmentLoggingConfigurationWorkerLogs\"}}]")]
        public virtual void PutWorkerLogs(aws.Mwaa.IMwaaEnvironmentLoggingConfigurationWorkerLogs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Mwaa.IMwaaEnvironmentLoggingConfigurationWorkerLogs)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDagProcessingLogs")]
        public virtual void ResetDagProcessingLogs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSchedulerLogs")]
        public virtual void ResetSchedulerLogs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTaskLogs")]
        public virtual void ResetTaskLogs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWebserverLogs")]
        public virtual void ResetWebserverLogs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWorkerLogs")]
        public virtual void ResetWorkerLogs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "dagProcessingLogs", typeJson: "{\"fqn\":\"aws.mwaa.MwaaEnvironmentLoggingConfigurationDagProcessingLogsOutputReference\"}")]
        public virtual aws.Mwaa.MwaaEnvironmentLoggingConfigurationDagProcessingLogsOutputReference DagProcessingLogs
        {
            get => GetInstanceProperty<aws.Mwaa.MwaaEnvironmentLoggingConfigurationDagProcessingLogsOutputReference>()!;
        }

        [JsiiProperty(name: "schedulerLogs", typeJson: "{\"fqn\":\"aws.mwaa.MwaaEnvironmentLoggingConfigurationSchedulerLogsOutputReference\"}")]
        public virtual aws.Mwaa.MwaaEnvironmentLoggingConfigurationSchedulerLogsOutputReference SchedulerLogs
        {
            get => GetInstanceProperty<aws.Mwaa.MwaaEnvironmentLoggingConfigurationSchedulerLogsOutputReference>()!;
        }

        [JsiiProperty(name: "taskLogs", typeJson: "{\"fqn\":\"aws.mwaa.MwaaEnvironmentLoggingConfigurationTaskLogsOutputReference\"}")]
        public virtual aws.Mwaa.MwaaEnvironmentLoggingConfigurationTaskLogsOutputReference TaskLogs
        {
            get => GetInstanceProperty<aws.Mwaa.MwaaEnvironmentLoggingConfigurationTaskLogsOutputReference>()!;
        }

        [JsiiProperty(name: "webserverLogs", typeJson: "{\"fqn\":\"aws.mwaa.MwaaEnvironmentLoggingConfigurationWebserverLogsOutputReference\"}")]
        public virtual aws.Mwaa.MwaaEnvironmentLoggingConfigurationWebserverLogsOutputReference WebserverLogs
        {
            get => GetInstanceProperty<aws.Mwaa.MwaaEnvironmentLoggingConfigurationWebserverLogsOutputReference>()!;
        }

        [JsiiProperty(name: "workerLogs", typeJson: "{\"fqn\":\"aws.mwaa.MwaaEnvironmentLoggingConfigurationWorkerLogsOutputReference\"}")]
        public virtual aws.Mwaa.MwaaEnvironmentLoggingConfigurationWorkerLogsOutputReference WorkerLogs
        {
            get => GetInstanceProperty<aws.Mwaa.MwaaEnvironmentLoggingConfigurationWorkerLogsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dagProcessingLogsInput", typeJson: "{\"fqn\":\"aws.mwaa.MwaaEnvironmentLoggingConfigurationDagProcessingLogs\"}", isOptional: true)]
        public virtual aws.Mwaa.IMwaaEnvironmentLoggingConfigurationDagProcessingLogs? DagProcessingLogsInput
        {
            get => GetInstanceProperty<aws.Mwaa.IMwaaEnvironmentLoggingConfigurationDagProcessingLogs?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "schedulerLogsInput", typeJson: "{\"fqn\":\"aws.mwaa.MwaaEnvironmentLoggingConfigurationSchedulerLogs\"}", isOptional: true)]
        public virtual aws.Mwaa.IMwaaEnvironmentLoggingConfigurationSchedulerLogs? SchedulerLogsInput
        {
            get => GetInstanceProperty<aws.Mwaa.IMwaaEnvironmentLoggingConfigurationSchedulerLogs?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "taskLogsInput", typeJson: "{\"fqn\":\"aws.mwaa.MwaaEnvironmentLoggingConfigurationTaskLogs\"}", isOptional: true)]
        public virtual aws.Mwaa.IMwaaEnvironmentLoggingConfigurationTaskLogs? TaskLogsInput
        {
            get => GetInstanceProperty<aws.Mwaa.IMwaaEnvironmentLoggingConfigurationTaskLogs?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "webserverLogsInput", typeJson: "{\"fqn\":\"aws.mwaa.MwaaEnvironmentLoggingConfigurationWebserverLogs\"}", isOptional: true)]
        public virtual aws.Mwaa.IMwaaEnvironmentLoggingConfigurationWebserverLogs? WebserverLogsInput
        {
            get => GetInstanceProperty<aws.Mwaa.IMwaaEnvironmentLoggingConfigurationWebserverLogs?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workerLogsInput", typeJson: "{\"fqn\":\"aws.mwaa.MwaaEnvironmentLoggingConfigurationWorkerLogs\"}", isOptional: true)]
        public virtual aws.Mwaa.IMwaaEnvironmentLoggingConfigurationWorkerLogs? WorkerLogsInput
        {
            get => GetInstanceProperty<aws.Mwaa.IMwaaEnvironmentLoggingConfigurationWorkerLogs?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.mwaa.MwaaEnvironmentLoggingConfiguration\"}", isOptional: true)]
        public virtual aws.Mwaa.IMwaaEnvironmentLoggingConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.Mwaa.IMwaaEnvironmentLoggingConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
