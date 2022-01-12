using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Athena
{
    [JsiiByValue(fqn: "aws.athena.AthenaWorkgroupConfigurationEngineVersion")]
    public class AthenaWorkgroupConfigurationEngineVersion : aws.Athena.IAthenaWorkgroupConfigurationEngineVersion
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/athena_workgroup#selected_engine_version AthenaWorkgroup#selected_engine_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "selectedEngineVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SelectedEngineVersion
        {
            get;
            set;
        }
    }
}
