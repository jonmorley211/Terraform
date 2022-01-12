using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiInterface(nativeType: typeof(ISagemakerFeatureGroupFeatureDefinition), fullyQualifiedName: "aws.sagemaker.SagemakerFeatureGroupFeatureDefinition")]
    public interface ISagemakerFeatureGroupFeatureDefinition
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_feature_group#feature_name SagemakerFeatureGroup#feature_name}.</summary>
        [JsiiProperty(name: "featureName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FeatureName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_feature_group#feature_type SagemakerFeatureGroup#feature_type}.</summary>
        [JsiiProperty(name: "featureType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FeatureType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerFeatureGroupFeatureDefinition), fullyQualifiedName: "aws.sagemaker.SagemakerFeatureGroupFeatureDefinition")]
        internal sealed class _Proxy : DeputyBase, aws.Sagemaker.ISagemakerFeatureGroupFeatureDefinition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_feature_group#feature_name SagemakerFeatureGroup#feature_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "featureName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FeatureName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_feature_group#feature_type SagemakerFeatureGroup#feature_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "featureType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FeatureType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
