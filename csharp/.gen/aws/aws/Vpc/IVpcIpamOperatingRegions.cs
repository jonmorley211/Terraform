using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Vpc
{
    [JsiiInterface(nativeType: typeof(IVpcIpamOperatingRegions), fullyQualifiedName: "aws.vpc.VpcIpamOperatingRegions")]
    public interface IVpcIpamOperatingRegions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpc_ipam#region_name VpcIpam#region_name}.</summary>
        [JsiiProperty(name: "regionName", typeJson: "{\"primitive\":\"string\"}")]
        string RegionName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IVpcIpamOperatingRegions), fullyQualifiedName: "aws.vpc.VpcIpamOperatingRegions")]
        internal sealed class _Proxy : DeputyBase, aws.Vpc.IVpcIpamOperatingRegions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpc_ipam#region_name VpcIpam#region_name}.</summary>
            [JsiiProperty(name: "regionName", typeJson: "{\"primitive\":\"string\"}")]
            public string RegionName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
