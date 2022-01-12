using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemaker.SagemakerModelContainerImageConfig")]
    public class SagemakerModelContainerImageConfig : aws.Sagemaker.ISagemakerModelContainerImageConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_model#repository_access_mode SagemakerModel#repository_access_mode}.</summary>
        [JsiiProperty(name: "repositoryAccessMode", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string RepositoryAccessMode
        {
            get;
            set;
        }
    }
}
