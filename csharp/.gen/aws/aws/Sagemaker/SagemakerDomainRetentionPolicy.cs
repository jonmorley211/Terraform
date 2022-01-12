using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiByValue(fqn: "aws.sagemaker.SagemakerDomainRetentionPolicy")]
    public class SagemakerDomainRetentionPolicy : aws.Sagemaker.ISagemakerDomainRetentionPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_domain#home_efs_file_system SagemakerDomain#home_efs_file_system}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "homeEfsFileSystem", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? HomeEfsFileSystem
        {
            get;
            set;
        }
    }
}
