using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Transfer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.transfer.TransferUserPosixProfile")]
    public class TransferUserPosixProfile : aws.Transfer.ITransferUserPosixProfile
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/transfer_user#gid TransferUser#gid}.</summary>
        [JsiiProperty(name: "gid", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double Gid
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/transfer_user#uid TransferUser#uid}.</summary>
        [JsiiProperty(name: "uid", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double Uid
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/transfer_user#secondary_gids TransferUser#secondary_gids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "secondaryGids", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public double[]? SecondaryGids
        {
            get;
            set;
        }
    }
}
