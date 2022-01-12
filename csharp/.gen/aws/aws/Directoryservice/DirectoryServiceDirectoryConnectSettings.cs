using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Directoryservice
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.directoryservice.DirectoryServiceDirectoryConnectSettings")]
    public class DirectoryServiceDirectoryConnectSettings : aws.Directoryservice.IDirectoryServiceDirectoryConnectSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/directory_service_directory#customer_dns_ips DirectoryServiceDirectory#customer_dns_ips}.</summary>
        [JsiiProperty(name: "customerDnsIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOverride: true)]
        public string[] CustomerDnsIps
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/directory_service_directory#customer_username DirectoryServiceDirectory#customer_username}.</summary>
        [JsiiProperty(name: "customerUsername", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string CustomerUsername
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/directory_service_directory#subnet_ids DirectoryServiceDirectory#subnet_ids}.</summary>
        [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOverride: true)]
        public string[] SubnetIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/directory_service_directory#vpc_id DirectoryServiceDirectory#vpc_id}.</summary>
        [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string VpcId
        {
            get;
            set;
        }
    }
}
