using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Imagebuilder
{
    [JsiiInterface(nativeType: typeof(IImagebuilderDistributionConfigurationDistribution), fullyQualifiedName: "aws.imagebuilder.ImagebuilderDistributionConfigurationDistribution")]
    public interface IImagebuilderDistributionConfigurationDistribution
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/imagebuilder_distribution_configuration#region ImagebuilderDistributionConfiguration#region}.</summary>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        string Region
        {
            get;
        }

        /// <summary>ami_distribution_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/imagebuilder_distribution_configuration#ami_distribution_configuration ImagebuilderDistributionConfiguration#ami_distribution_configuration}
        /// </remarks>
        [JsiiProperty(name: "amiDistributionConfiguration", typeJson: "{\"fqn\":\"aws.imagebuilder.ImagebuilderDistributionConfigurationDistributionAmiDistributionConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Imagebuilder.IImagebuilderDistributionConfigurationDistributionAmiDistributionConfiguration? AmiDistributionConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/imagebuilder_distribution_configuration#license_configuration_arns ImagebuilderDistributionConfiguration#license_configuration_arns}.</summary>
        [JsiiProperty(name: "licenseConfigurationArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? LicenseConfigurationArns
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IImagebuilderDistributionConfigurationDistribution), fullyQualifiedName: "aws.imagebuilder.ImagebuilderDistributionConfigurationDistribution")]
        internal sealed class _Proxy : DeputyBase, aws.Imagebuilder.IImagebuilderDistributionConfigurationDistribution
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/imagebuilder_distribution_configuration#region ImagebuilderDistributionConfiguration#region}.</summary>
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
            public string Region
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>ami_distribution_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/imagebuilder_distribution_configuration#ami_distribution_configuration ImagebuilderDistributionConfiguration#ami_distribution_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "amiDistributionConfiguration", typeJson: "{\"fqn\":\"aws.imagebuilder.ImagebuilderDistributionConfigurationDistributionAmiDistributionConfiguration\"}", isOptional: true)]
            public aws.Imagebuilder.IImagebuilderDistributionConfigurationDistributionAmiDistributionConfiguration? AmiDistributionConfiguration
            {
                get => GetInstanceProperty<aws.Imagebuilder.IImagebuilderDistributionConfigurationDistributionAmiDistributionConfiguration?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/imagebuilder_distribution_configuration#license_configuration_arns ImagebuilderDistributionConfiguration#license_configuration_arns}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "licenseConfigurationArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? LicenseConfigurationArns
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
