using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Storagegateway
{
    [JsiiByValue(fqn: "aws.storagegateway.StoragegatewayGatewayTimeouts")]
    public class StoragegatewayGatewayTimeouts : aws.Storagegateway.IStoragegatewayGatewayTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_gateway#create StoragegatewayGateway#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Create
        {
            get;
            set;
        }
    }
}
