using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecr
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ecr.EcrRegistryScanningConfigurationRule")]
    public class EcrRegistryScanningConfigurationRule : aws.Ecr.IEcrRegistryScanningConfigurationRule
    {
        /// <summary>repository_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecr_registry_scanning_configuration#repository_filter EcrRegistryScanningConfiguration#repository_filter}
        /// </remarks>
        [JsiiProperty(name: "repositoryFilter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecr.EcrRegistryScanningConfigurationRuleRepositoryFilter\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.Ecr.IEcrRegistryScanningConfigurationRuleRepositoryFilter[] RepositoryFilter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecr_registry_scanning_configuration#scan_frequency EcrRegistryScanningConfiguration#scan_frequency}.</summary>
        [JsiiProperty(name: "scanFrequency", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ScanFrequency
        {
            get;
            set;
        }
    }
}
