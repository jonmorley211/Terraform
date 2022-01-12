using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiInterface(nativeType: typeof(ISagemakerModelContainerImageConfig), fullyQualifiedName: "aws.sagemaker.SagemakerModelContainerImageConfig")]
    public interface ISagemakerModelContainerImageConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_model#repository_access_mode SagemakerModel#repository_access_mode}.</summary>
        [JsiiProperty(name: "repositoryAccessMode", typeJson: "{\"primitive\":\"string\"}")]
        string RepositoryAccessMode
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerModelContainerImageConfig), fullyQualifiedName: "aws.sagemaker.SagemakerModelContainerImageConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Sagemaker.ISagemakerModelContainerImageConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_model#repository_access_mode SagemakerModel#repository_access_mode}.</summary>
            [JsiiProperty(name: "repositoryAccessMode", typeJson: "{\"primitive\":\"string\"}")]
            public string RepositoryAccessMode
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
