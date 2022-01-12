using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Imagebuilder
{
    [JsiiByValue(fqn: "aws.imagebuilder.ImagebuilderDistributionConfigurationDistributionAmiDistributionConfigurationLaunchPermission")]
    public class ImagebuilderDistributionConfigurationDistributionAmiDistributionConfigurationLaunchPermission : aws.Imagebuilder.IImagebuilderDistributionConfigurationDistributionAmiDistributionConfigurationLaunchPermission
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/imagebuilder_distribution_configuration#user_groups ImagebuilderDistributionConfiguration#user_groups}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? UserGroups
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/imagebuilder_distribution_configuration#user_ids ImagebuilderDistributionConfiguration#user_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? UserIds
        {
            get;
            set;
        }
    }
}
