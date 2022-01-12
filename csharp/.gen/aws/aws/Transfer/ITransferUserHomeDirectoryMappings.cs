using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Transfer
{
    [JsiiInterface(nativeType: typeof(ITransferUserHomeDirectoryMappings), fullyQualifiedName: "aws.transfer.TransferUserHomeDirectoryMappings")]
    public interface ITransferUserHomeDirectoryMappings
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/transfer_user#entry TransferUser#entry}.</summary>
        [JsiiProperty(name: "entry", typeJson: "{\"primitive\":\"string\"}")]
        string Entry
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/transfer_user#target TransferUser#target}.</summary>
        [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}")]
        string Target
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ITransferUserHomeDirectoryMappings), fullyQualifiedName: "aws.transfer.TransferUserHomeDirectoryMappings")]
        internal sealed class _Proxy : DeputyBase, aws.Transfer.ITransferUserHomeDirectoryMappings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/transfer_user#entry TransferUser#entry}.</summary>
            [JsiiProperty(name: "entry", typeJson: "{\"primitive\":\"string\"}")]
            public string Entry
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/transfer_user#target TransferUser#target}.</summary>
            [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}")]
            public string Target
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
