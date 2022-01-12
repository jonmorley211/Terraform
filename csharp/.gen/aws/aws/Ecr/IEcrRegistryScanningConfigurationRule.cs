using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecr
{
    [JsiiInterface(nativeType: typeof(IEcrRegistryScanningConfigurationRule), fullyQualifiedName: "aws.ecr.EcrRegistryScanningConfigurationRule")]
    public interface IEcrRegistryScanningConfigurationRule
    {
        /// <summary>repository_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecr_registry_scanning_configuration#repository_filter EcrRegistryScanningConfiguration#repository_filter}
        /// </remarks>
        [JsiiProperty(name: "repositoryFilter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecr.EcrRegistryScanningConfigurationRuleRepositoryFilter\"},\"kind\":\"array\"}}")]
        aws.Ecr.IEcrRegistryScanningConfigurationRuleRepositoryFilter[] RepositoryFilter
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecr_registry_scanning_configuration#scan_frequency EcrRegistryScanningConfiguration#scan_frequency}.</summary>
        [JsiiProperty(name: "scanFrequency", typeJson: "{\"primitive\":\"string\"}")]
        string ScanFrequency
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEcrRegistryScanningConfigurationRule), fullyQualifiedName: "aws.ecr.EcrRegistryScanningConfigurationRule")]
        internal sealed class _Proxy : DeputyBase, aws.Ecr.IEcrRegistryScanningConfigurationRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>repository_filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecr_registry_scanning_configuration#repository_filter EcrRegistryScanningConfiguration#repository_filter}
            /// </remarks>
            [JsiiProperty(name: "repositoryFilter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecr.EcrRegistryScanningConfigurationRuleRepositoryFilter\"},\"kind\":\"array\"}}")]
            public aws.Ecr.IEcrRegistryScanningConfigurationRuleRepositoryFilter[] RepositoryFilter
            {
                get => GetInstanceProperty<aws.Ecr.IEcrRegistryScanningConfigurationRuleRepositoryFilter[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecr_registry_scanning_configuration#scan_frequency EcrRegistryScanningConfiguration#scan_frequency}.</summary>
            [JsiiProperty(name: "scanFrequency", typeJson: "{\"primitive\":\"string\"}")]
            public string ScanFrequency
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
