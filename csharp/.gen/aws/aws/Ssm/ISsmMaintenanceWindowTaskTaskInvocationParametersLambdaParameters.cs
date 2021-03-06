using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ssm
{
    [JsiiInterface(nativeType: typeof(ISsmMaintenanceWindowTaskTaskInvocationParametersLambdaParameters), fullyQualifiedName: "aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParametersLambdaParameters")]
    public interface ISsmMaintenanceWindowTaskTaskInvocationParametersLambdaParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#client_context SsmMaintenanceWindowTask#client_context}.</summary>
        [JsiiProperty(name: "clientContext", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientContext
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#payload SsmMaintenanceWindowTask#payload}.</summary>
        [JsiiProperty(name: "payload", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Payload
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#qualifier SsmMaintenanceWindowTask#qualifier}.</summary>
        [JsiiProperty(name: "qualifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Qualifier
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISsmMaintenanceWindowTaskTaskInvocationParametersLambdaParameters), fullyQualifiedName: "aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParametersLambdaParameters")]
        internal sealed class _Proxy : DeputyBase, aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParametersLambdaParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#client_context SsmMaintenanceWindowTask#client_context}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "clientContext", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientContext
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#payload SsmMaintenanceWindowTask#payload}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "payload", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Payload
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#qualifier SsmMaintenanceWindowTask#qualifier}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "qualifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Qualifier
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
