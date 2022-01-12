using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Mwaa
{
    [JsiiInterface(nativeType: typeof(IMwaaEnvironmentLoggingConfiguration), fullyQualifiedName: "aws.mwaa.MwaaEnvironmentLoggingConfiguration")]
    public interface IMwaaEnvironmentLoggingConfiguration
    {
        /// <summary>dag_processing_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mwaa_environment#dag_processing_logs MwaaEnvironment#dag_processing_logs}
        /// </remarks>
        [JsiiProperty(name: "dagProcessingLogs", typeJson: "{\"fqn\":\"aws.mwaa.MwaaEnvironmentLoggingConfigurationDagProcessingLogs\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Mwaa.IMwaaEnvironmentLoggingConfigurationDagProcessingLogs? DagProcessingLogs
        {
            get
            {
                return null;
            }
        }

        /// <summary>scheduler_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mwaa_environment#scheduler_logs MwaaEnvironment#scheduler_logs}
        /// </remarks>
        [JsiiProperty(name: "schedulerLogs", typeJson: "{\"fqn\":\"aws.mwaa.MwaaEnvironmentLoggingConfigurationSchedulerLogs\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Mwaa.IMwaaEnvironmentLoggingConfigurationSchedulerLogs? SchedulerLogs
        {
            get
            {
                return null;
            }
        }

        /// <summary>task_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mwaa_environment#task_logs MwaaEnvironment#task_logs}
        /// </remarks>
        [JsiiProperty(name: "taskLogs", typeJson: "{\"fqn\":\"aws.mwaa.MwaaEnvironmentLoggingConfigurationTaskLogs\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Mwaa.IMwaaEnvironmentLoggingConfigurationTaskLogs? TaskLogs
        {
            get
            {
                return null;
            }
        }

        /// <summary>webserver_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mwaa_environment#webserver_logs MwaaEnvironment#webserver_logs}
        /// </remarks>
        [JsiiProperty(name: "webserverLogs", typeJson: "{\"fqn\":\"aws.mwaa.MwaaEnvironmentLoggingConfigurationWebserverLogs\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Mwaa.IMwaaEnvironmentLoggingConfigurationWebserverLogs? WebserverLogs
        {
            get
            {
                return null;
            }
        }

        /// <summary>worker_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mwaa_environment#worker_logs MwaaEnvironment#worker_logs}
        /// </remarks>
        [JsiiProperty(name: "workerLogs", typeJson: "{\"fqn\":\"aws.mwaa.MwaaEnvironmentLoggingConfigurationWorkerLogs\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Mwaa.IMwaaEnvironmentLoggingConfigurationWorkerLogs? WorkerLogs
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMwaaEnvironmentLoggingConfiguration), fullyQualifiedName: "aws.mwaa.MwaaEnvironmentLoggingConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Mwaa.IMwaaEnvironmentLoggingConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>dag_processing_logs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mwaa_environment#dag_processing_logs MwaaEnvironment#dag_processing_logs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dagProcessingLogs", typeJson: "{\"fqn\":\"aws.mwaa.MwaaEnvironmentLoggingConfigurationDagProcessingLogs\"}", isOptional: true)]
            public aws.Mwaa.IMwaaEnvironmentLoggingConfigurationDagProcessingLogs? DagProcessingLogs
            {
                get => GetInstanceProperty<aws.Mwaa.IMwaaEnvironmentLoggingConfigurationDagProcessingLogs?>();
            }

            /// <summary>scheduler_logs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mwaa_environment#scheduler_logs MwaaEnvironment#scheduler_logs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "schedulerLogs", typeJson: "{\"fqn\":\"aws.mwaa.MwaaEnvironmentLoggingConfigurationSchedulerLogs\"}", isOptional: true)]
            public aws.Mwaa.IMwaaEnvironmentLoggingConfigurationSchedulerLogs? SchedulerLogs
            {
                get => GetInstanceProperty<aws.Mwaa.IMwaaEnvironmentLoggingConfigurationSchedulerLogs?>();
            }

            /// <summary>task_logs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mwaa_environment#task_logs MwaaEnvironment#task_logs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "taskLogs", typeJson: "{\"fqn\":\"aws.mwaa.MwaaEnvironmentLoggingConfigurationTaskLogs\"}", isOptional: true)]
            public aws.Mwaa.IMwaaEnvironmentLoggingConfigurationTaskLogs? TaskLogs
            {
                get => GetInstanceProperty<aws.Mwaa.IMwaaEnvironmentLoggingConfigurationTaskLogs?>();
            }

            /// <summary>webserver_logs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mwaa_environment#webserver_logs MwaaEnvironment#webserver_logs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "webserverLogs", typeJson: "{\"fqn\":\"aws.mwaa.MwaaEnvironmentLoggingConfigurationWebserverLogs\"}", isOptional: true)]
            public aws.Mwaa.IMwaaEnvironmentLoggingConfigurationWebserverLogs? WebserverLogs
            {
                get => GetInstanceProperty<aws.Mwaa.IMwaaEnvironmentLoggingConfigurationWebserverLogs?>();
            }

            /// <summary>worker_logs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mwaa_environment#worker_logs MwaaEnvironment#worker_logs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "workerLogs", typeJson: "{\"fqn\":\"aws.mwaa.MwaaEnvironmentLoggingConfigurationWorkerLogs\"}", isOptional: true)]
            public aws.Mwaa.IMwaaEnvironmentLoggingConfigurationWorkerLogs? WorkerLogs
            {
                get => GetInstanceProperty<aws.Mwaa.IMwaaEnvironmentLoggingConfigurationWorkerLogs?>();
            }
        }
    }
}
