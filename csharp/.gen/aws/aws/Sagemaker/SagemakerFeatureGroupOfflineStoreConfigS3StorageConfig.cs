using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemaker.SagemakerFeatureGroupOfflineStoreConfigS3StorageConfig")]
    public class SagemakerFeatureGroupOfflineStoreConfigS3StorageConfig : aws.Sagemaker.ISagemakerFeatureGroupOfflineStoreConfigS3StorageConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_feature_group#s3_uri SagemakerFeatureGroup#s3_uri}.</summary>
        [JsiiProperty(name: "s3Uri", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string S3Uri
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_feature_group#kms_key_id SagemakerFeatureGroup#kms_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? KmsKeyId
        {
            get;
            set;
        }
    }
}
