using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Mwaa
{
    [JsiiInterface(nativeType: typeof(IMwaaEnvironmentLoggingConfigurationWebserverLogs), fullyQualifiedName: "aws.mwaa.MwaaEnvironmentLoggingConfigurationWebserverLogs")]
    public interface IMwaaEnvironmentLoggingConfigurationWebserverLogs
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mwaa_environment#enabled MwaaEnvironment#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mwaa_environment#log_level MwaaEnvironment#log_level}.</summary>
        [JsiiProperty(name: "logLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogLevel
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMwaaEnvironmentLoggingConfigurationWebserverLogs), fullyQualifiedName: "aws.mwaa.MwaaEnvironmentLoggingConfigurationWebserverLogs")]
        internal sealed class _Proxy : DeputyBase, aws.Mwaa.IMwaaEnvironmentLoggingConfigurationWebserverLogs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mwaa_environment#enabled MwaaEnvironment#enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mwaa_environment#log_level MwaaEnvironment#log_level}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogLevel
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
