using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiByValue(fqn: "aws.sagemaker.SagemakerFeatureGroupFeatureDefinition")]
    public class SagemakerFeatureGroupFeatureDefinition : aws.Sagemaker.ISagemakerFeatureGroupFeatureDefinition
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_feature_group#feature_name SagemakerFeatureGroup#feature_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "featureName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? FeatureName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_feature_group#feature_type SagemakerFeatureGroup#feature_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "featureType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? FeatureType
        {
            get;
            set;
        }
    }
}
