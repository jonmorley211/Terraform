using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ssm
{
    /// <summary>AWS Systems Manager.</summary>
    [JsiiInterface(nativeType: typeof(ISsmMaintenanceWindowTaskConfig), fullyQualifiedName: "aws.ssm.SsmMaintenanceWindowTaskConfig")]
    public interface ISsmMaintenanceWindowTaskConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#max_concurrency SsmMaintenanceWindowTask#max_concurrency}.</summary>
        [JsiiProperty(name: "maxConcurrency", typeJson: "{\"primitive\":\"string\"}")]
        string MaxConcurrency
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#max_errors SsmMaintenanceWindowTask#max_errors}.</summary>
        [JsiiProperty(name: "maxErrors", typeJson: "{\"primitive\":\"string\"}")]
        string MaxErrors
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#task_arn SsmMaintenanceWindowTask#task_arn}.</summary>
        [JsiiProperty(name: "taskArn", typeJson: "{\"primitive\":\"string\"}")]
        string TaskArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#task_type SsmMaintenanceWindowTask#task_type}.</summary>
        [JsiiProperty(name: "taskType", typeJson: "{\"primitive\":\"string\"}")]
        string TaskType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#window_id SsmMaintenanceWindowTask#window_id}.</summary>
        [JsiiProperty(name: "windowId", typeJson: "{\"primitive\":\"string\"}")]
        string WindowId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#description SsmMaintenanceWindowTask#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#name SsmMaintenanceWindowTask#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#priority SsmMaintenanceWindowTask#priority}.</summary>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Priority
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#service_role_arn SsmMaintenanceWindowTask#service_role_arn}.</summary>
        [JsiiProperty(name: "serviceRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServiceRoleArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>targets block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#targets SsmMaintenanceWindowTask#targets}
        /// </remarks>
        [JsiiProperty(name: "targets", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssm.SsmMaintenanceWindowTaskTargets\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ssm.ISsmMaintenanceWindowTaskTargets[]? Targets
        {
            get
            {
                return null;
            }
        }

        /// <summary>task_invocation_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#task_invocation_parameters SsmMaintenanceWindowTask#task_invocation_parameters}
        /// </remarks>
        [JsiiProperty(name: "taskInvocationParameters", typeJson: "{\"fqn\":\"aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParameters\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParameters? TaskInvocationParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Systems Manager.</summary>
        [JsiiTypeProxy(nativeType: typeof(ISsmMaintenanceWindowTaskConfig), fullyQualifiedName: "aws.ssm.SsmMaintenanceWindowTaskConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Ssm.ISsmMaintenanceWindowTaskConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#max_concurrency SsmMaintenanceWindowTask#max_concurrency}.</summary>
            [JsiiProperty(name: "maxConcurrency", typeJson: "{\"primitive\":\"string\"}")]
            public string MaxConcurrency
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#max_errors SsmMaintenanceWindowTask#max_errors}.</summary>
            [JsiiProperty(name: "maxErrors", typeJson: "{\"primitive\":\"string\"}")]
            public string MaxErrors
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#task_arn SsmMaintenanceWindowTask#task_arn}.</summary>
            [JsiiProperty(name: "taskArn", typeJson: "{\"primitive\":\"string\"}")]
            public string TaskArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#task_type SsmMaintenanceWindowTask#task_type}.</summary>
            [JsiiProperty(name: "taskType", typeJson: "{\"primitive\":\"string\"}")]
            public string TaskType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#window_id SsmMaintenanceWindowTask#window_id}.</summary>
            [JsiiProperty(name: "windowId", typeJson: "{\"primitive\":\"string\"}")]
            public string WindowId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#description SsmMaintenanceWindowTask#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#name SsmMaintenanceWindowTask#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#priority SsmMaintenanceWindowTask#priority}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Priority
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#service_role_arn SsmMaintenanceWindowTask#service_role_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serviceRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServiceRoleArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>targets block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#targets SsmMaintenanceWindowTask#targets}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "targets", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssm.SsmMaintenanceWindowTaskTargets\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Ssm.ISsmMaintenanceWindowTaskTargets[]? Targets
            {
                get => GetInstanceProperty<aws.Ssm.ISsmMaintenanceWindowTaskTargets[]?>();
            }

            /// <summary>task_invocation_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#task_invocation_parameters SsmMaintenanceWindowTask#task_invocation_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "taskInvocationParameters", typeJson: "{\"fqn\":\"aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParameters\"}", isOptional: true)]
            public aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParameters? TaskInvocationParameters
            {
                get => GetInstanceProperty<aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParameters?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
