using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Efs
{
    [JsiiByValue(fqn: "aws.efs.EfsFileSystemLifecyclePolicy")]
    public class EfsFileSystemLifecyclePolicy : aws.Efs.IEfsFileSystemLifecyclePolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/efs_file_system#transition_to_ia EfsFileSystem#transition_to_ia}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "transitionToIa", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? TransitionToIa
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/efs_file_system#transition_to_primary_storage_class EfsFileSystem#transition_to_primary_storage_class}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "transitionToPrimaryStorageClass", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? TransitionToPrimaryStorageClass
        {
            get;
            set;
        }
    }
}
