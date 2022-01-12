using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecr
{
    [JsiiInterface(nativeType: typeof(IEcrRegistryScanningConfigurationRuleRepositoryFilter), fullyQualifiedName: "aws.ecr.EcrRegistryScanningConfigurationRuleRepositoryFilter")]
    public interface IEcrRegistryScanningConfigurationRuleRepositoryFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecr_registry_scanning_configuration#filter EcrRegistryScanningConfiguration#filter}.</summary>
        [JsiiProperty(name: "filter", typeJson: "{\"primitive\":\"string\"}")]
        string Filter
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecr_registry_scanning_configuration#filter_type EcrRegistryScanningConfiguration#filter_type}.</summary>
        [JsiiProperty(name: "filterType", typeJson: "{\"primitive\":\"string\"}")]
        string FilterType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEcrRegistryScanningConfigurationRuleRepositoryFilter), fullyQualifiedName: "aws.ecr.EcrRegistryScanningConfigurationRuleRepositoryFilter")]
        internal sealed class _Proxy : DeputyBase, aws.Ecr.IEcrRegistryScanningConfigurationRuleRepositoryFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecr_registry_scanning_configuration#filter EcrRegistryScanningConfiguration#filter}.</summary>
            [JsiiProperty(name: "filter", typeJson: "{\"primitive\":\"string\"}")]
            public string Filter
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecr_registry_scanning_configuration#filter_type EcrRegistryScanningConfiguration#filter_type}.</summary>
            [JsiiProperty(name: "filterType", typeJson: "{\"primitive\":\"string\"}")]
            public string FilterType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
