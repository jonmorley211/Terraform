using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Config
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.config.ConfigOrganizationConformancePackInputParameter")]
    public class ConfigOrganizationConformancePackInputParameter : aws.Config.IConfigOrganizationConformancePackInputParameter
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_organization_conformance_pack#parameter_name ConfigOrganizationConformancePack#parameter_name}.</summary>
        [JsiiProperty(name: "parameterName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ParameterName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_organization_conformance_pack#parameter_value ConfigOrganizationConformancePack#parameter_value}.</summary>
        [JsiiProperty(name: "parameterValue", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ParameterValue
        {
            get;
            set;
        }
    }
}
