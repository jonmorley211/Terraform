using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Imagebuilder
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.imagebuilder.ImagebuilderDistributionConfigurationDistribution")]
    public class ImagebuilderDistributionConfigurationDistribution : aws.Imagebuilder.IImagebuilderDistributionConfigurationDistribution
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/imagebuilder_distribution_configuration#region ImagebuilderDistributionConfiguration#region}.</summary>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Region
        {
            get;
            set;
        }

        /// <summary>ami_distribution_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/imagebuilder_distribution_configuration#ami_distribution_configuration ImagebuilderDistributionConfiguration#ami_distribution_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "amiDistributionConfiguration", typeJson: "{\"fqn\":\"aws.imagebuilder.ImagebuilderDistributionConfigurationDistributionAmiDistributionConfiguration\"}", isOptional: true, isOverride: true)]
        public aws.Imagebuilder.IImagebuilderDistributionConfigurationDistributionAmiDistributionConfiguration? AmiDistributionConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/imagebuilder_distribution_configuration#license_configuration_arns ImagebuilderDistributionConfiguration#license_configuration_arns}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "licenseConfigurationArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? LicenseConfigurationArns
        {
            get;
            set;
        }
    }
}
