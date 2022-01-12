using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Datasync
{
    [JsiiByValue(fqn: "aws.datasync.DatasyncLocationHdfsQopConfiguration")]
    public class DatasyncLocationHdfsQopConfiguration : aws.Datasync.IDatasyncLocationHdfsQopConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_location_hdfs#data_transfer_protection DatasyncLocationHdfs#data_transfer_protection}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dataTransferProtection", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DataTransferProtection
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_location_hdfs#rpc_protection DatasyncLocationHdfs#rpc_protection}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rpcProtection", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? RpcProtection
        {
            get;
            set;
        }
    }
}
