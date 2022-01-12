using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiByValue(fqn: "aws.sagemaker.SagemakerFeatureGroupOnlineStoreConfig")]
    public class SagemakerFeatureGroupOnlineStoreConfig : aws.Sagemaker.ISagemakerFeatureGroupOnlineStoreConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_feature_group#enable_online_store SagemakerFeatureGroup#enable_online_store}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enableOnlineStore", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? EnableOnlineStore
        {
            get;
            set;
        }

        /// <summary>security_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_feature_group#security_config SagemakerFeatureGroup#security_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "securityConfig", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerFeatureGroupOnlineStoreConfigSecurityConfig\"}", isOptional: true, isOverride: true)]
        public aws.Sagemaker.ISagemakerFeatureGroupOnlineStoreConfigSecurityConfig? SecurityConfig
        {
            get;
            set;
        }
    }
}
