using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Vpc
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.vpc.VpcIpamOperatingRegions")]
    public class VpcIpamOperatingRegions : aws.Vpc.IVpcIpamOperatingRegions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpc_ipam#region_name VpcIpam#region_name}.</summary>
        [JsiiProperty(name: "regionName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string RegionName
        {
            get;
            set;
        }
    }
}
