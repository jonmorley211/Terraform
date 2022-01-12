using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Efs
{
    [JsiiInterface(nativeType: typeof(IEfsFileSystemLifecyclePolicy), fullyQualifiedName: "aws.efs.EfsFileSystemLifecyclePolicy")]
    public interface IEfsFileSystemLifecyclePolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/efs_file_system#transition_to_ia EfsFileSystem#transition_to_ia}.</summary>
        [JsiiProperty(name: "transitionToIa", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TransitionToIa
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/efs_file_system#transition_to_primary_storage_class EfsFileSystem#transition_to_primary_storage_class}.</summary>
        [JsiiProperty(name: "transitionToPrimaryStorageClass", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TransitionToPrimaryStorageClass
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEfsFileSystemLifecyclePolicy), fullyQualifiedName: "aws.efs.EfsFileSystemLifecyclePolicy")]
        internal sealed class _Proxy : DeputyBase, aws.Efs.IEfsFileSystemLifecyclePolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/efs_file_system#transition_to_ia EfsFileSystem#transition_to_ia}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "transitionToIa", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TransitionToIa
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/efs_file_system#transition_to_primary_storage_class EfsFileSystem#transition_to_primary_storage_class}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "transitionToPrimaryStorageClass", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TransitionToPrimaryStorageClass
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
