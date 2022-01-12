using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Transfer
{
    [JsiiInterface(nativeType: typeof(ITransferAccessPosixProfile), fullyQualifiedName: "aws.transfer.TransferAccessPosixProfile")]
    public interface ITransferAccessPosixProfile
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/transfer_access#gid TransferAccess#gid}.</summary>
        [JsiiProperty(name: "gid", typeJson: "{\"primitive\":\"number\"}")]
        double Gid
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/transfer_access#uid TransferAccess#uid}.</summary>
        [JsiiProperty(name: "uid", typeJson: "{\"primitive\":\"number\"}")]
        double Uid
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/transfer_access#secondary_gids TransferAccess#secondary_gids}.</summary>
        [JsiiProperty(name: "secondaryGids", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double[]? SecondaryGids
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITransferAccessPosixProfile), fullyQualifiedName: "aws.transfer.TransferAccessPosixProfile")]
        internal sealed class _Proxy : DeputyBase, aws.Transfer.ITransferAccessPosixProfile
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/transfer_access#gid TransferAccess#gid}.</summary>
            [JsiiProperty(name: "gid", typeJson: "{\"primitive\":\"number\"}")]
            public double Gid
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/transfer_access#uid TransferAccess#uid}.</summary>
            [JsiiProperty(name: "uid", typeJson: "{\"primitive\":\"number\"}")]
            public double Uid
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/transfer_access#secondary_gids TransferAccess#secondary_gids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "secondaryGids", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
            public double[]? SecondaryGids
            {
                get => GetInstanceProperty<double[]?>();
            }
        }
    }
}
