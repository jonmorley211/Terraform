using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiByValue(fqn: "aws.sagemaker.SagemakerUserProfileUserSettingsSharingSettings")]
    public class SagemakerUserProfileUserSettingsSharingSettings : aws.Sagemaker.ISagemakerUserProfileUserSettingsSharingSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_user_profile#notebook_output_option SagemakerUserProfile#notebook_output_option}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "notebookOutputOption", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? NotebookOutputOption
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_user_profile#s3_kms_key_id SagemakerUserProfile#s3_kms_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3KmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? S3KmsKeyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_user_profile#s3_output_path SagemakerUserProfile#s3_output_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3OutputPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? S3OutputPath
        {
            get;
            set;
        }
    }
}
