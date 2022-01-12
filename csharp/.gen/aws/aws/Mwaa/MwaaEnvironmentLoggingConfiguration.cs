using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Mwaa
{
    [JsiiByValue(fqn: "aws.mwaa.MwaaEnvironmentLoggingConfiguration")]
    public class MwaaEnvironmentLoggingConfiguration : aws.Mwaa.IMwaaEnvironmentLoggingConfiguration
    {
        /// <summary>dag_processing_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mwaa_environment#dag_processing_logs MwaaEnvironment#dag_processing_logs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dagProcessingLogs", typeJson: "{\"fqn\":\"aws.mwaa.MwaaEnvironmentLoggingConfigurationDagProcessingLogs\"}", isOptional: true, isOverride: true)]
        public aws.Mwaa.IMwaaEnvironmentLoggingConfigurationDagProcessingLogs? DagProcessingLogs
        {
            get;
            set;
        }

        /// <summary>scheduler_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mwaa_environment#scheduler_logs MwaaEnvironment#scheduler_logs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "schedulerLogs", typeJson: "{\"fqn\":\"aws.mwaa.MwaaEnvironmentLoggingConfigurationSchedulerLogs\"}", isOptional: true, isOverride: true)]
        public aws.Mwaa.IMwaaEnvironmentLoggingConfigurationSchedulerLogs? SchedulerLogs
        {
            get;
            set;
        }

        /// <summary>task_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mwaa_environment#task_logs MwaaEnvironment#task_logs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "taskLogs", typeJson: "{\"fqn\":\"aws.mwaa.MwaaEnvironmentLoggingConfigurationTaskLogs\"}", isOptional: true, isOverride: true)]
        public aws.Mwaa.IMwaaEnvironmentLoggingConfigurationTaskLogs? TaskLogs
        {
            get;
            set;
        }

        /// <summary>webserver_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mwaa_environment#webserver_logs MwaaEnvironment#webserver_logs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "webserverLogs", typeJson: "{\"fqn\":\"aws.mwaa.MwaaEnvironmentLoggingConfigurationWebserverLogs\"}", isOptional: true, isOverride: true)]
        public aws.Mwaa.IMwaaEnvironmentLoggingConfigurationWebserverLogs? WebserverLogs
        {
            get;
            set;
        }

        /// <summary>worker_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mwaa_environment#worker_logs MwaaEnvironment#worker_logs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "workerLogs", typeJson: "{\"fqn\":\"aws.mwaa.MwaaEnvironmentLoggingConfigurationWorkerLogs\"}", isOptional: true, isOverride: true)]
        public aws.Mwaa.IMwaaEnvironmentLoggingConfigurationWorkerLogs? WorkerLogs
        {
            get;
            set;
        }
    }
}
