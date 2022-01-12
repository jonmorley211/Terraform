using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiInterface(nativeType: typeof(ISagemakerDomainRetentionPolicy), fullyQualifiedName: "aws.sagemaker.SagemakerDomainRetentionPolicy")]
    public interface ISagemakerDomainRetentionPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_domain#home_efs_file_system SagemakerDomain#home_efs_file_system}.</summary>
        [JsiiProperty(name: "homeEfsFileSystem", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HomeEfsFileSystem
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerDomainRetentionPolicy), fullyQualifiedName: "aws.sagemaker.SagemakerDomainRetentionPolicy")]
        internal sealed class _Proxy : DeputyBase, aws.Sagemaker.ISagemakerDomainRetentionPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_domain#home_efs_file_system SagemakerDomain#home_efs_file_system}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "homeEfsFileSystem", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HomeEfsFileSystem
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
