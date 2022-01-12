using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Athena
{
    [JsiiInterface(nativeType: typeof(IAthenaWorkgroupConfigurationEngineVersion), fullyQualifiedName: "aws.athena.AthenaWorkgroupConfigurationEngineVersion")]
    public interface IAthenaWorkgroupConfigurationEngineVersion
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/athena_workgroup#selected_engine_version AthenaWorkgroup#selected_engine_version}.</summary>
        [JsiiProperty(name: "selectedEngineVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SelectedEngineVersion
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAthenaWorkgroupConfigurationEngineVersion), fullyQualifiedName: "aws.athena.AthenaWorkgroupConfigurationEngineVersion")]
        internal sealed class _Proxy : DeputyBase, aws.Athena.IAthenaWorkgroupConfigurationEngineVersion
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/athena_workgroup#selected_engine_version AthenaWorkgroup#selected_engine_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "selectedEngineVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SelectedEngineVersion
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
