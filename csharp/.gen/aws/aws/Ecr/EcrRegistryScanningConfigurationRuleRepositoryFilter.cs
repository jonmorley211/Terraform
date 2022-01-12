using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecr
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ecr.EcrRegistryScanningConfigurationRuleRepositoryFilter")]
    public class EcrRegistryScanningConfigurationRuleRepositoryFilter : aws.Ecr.IEcrRegistryScanningConfigurationRuleRepositoryFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecr_registry_scanning_configuration#filter EcrRegistryScanningConfiguration#filter}.</summary>
        [JsiiProperty(name: "filter", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Filter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecr_registry_scanning_configuration#filter_type EcrRegistryScanningConfiguration#filter_type}.</summary>
        [JsiiProperty(name: "filterType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string FilterType
        {
            get;
            set;
        }
    }
}
