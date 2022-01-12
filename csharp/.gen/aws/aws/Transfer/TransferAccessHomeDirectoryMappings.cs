using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Transfer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.transfer.TransferAccessHomeDirectoryMappings")]
    public class TransferAccessHomeDirectoryMappings : aws.Transfer.ITransferAccessHomeDirectoryMappings
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/transfer_access#entry TransferAccess#entry}.</summary>
        [JsiiProperty(name: "entry", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Entry
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/transfer_access#target TransferAccess#target}.</summary>
        [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Target
        {
            get;
            set;
        }
    }
}
