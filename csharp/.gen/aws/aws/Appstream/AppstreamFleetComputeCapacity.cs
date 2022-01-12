using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appstream
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appstream.AppstreamFleetComputeCapacity")]
    public class AppstreamFleetComputeCapacity : aws.Appstream.IAppstreamFleetComputeCapacity
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appstream_fleet#desired_instances AppstreamFleet#desired_instances}.</summary>
        [JsiiProperty(name: "desiredInstances", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double DesiredInstances
        {
            get;
            set;
        }
    }
}
