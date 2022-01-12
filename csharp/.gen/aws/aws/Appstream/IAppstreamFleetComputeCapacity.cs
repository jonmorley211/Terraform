using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appstream
{
    [JsiiInterface(nativeType: typeof(IAppstreamFleetComputeCapacity), fullyQualifiedName: "aws.appstream.AppstreamFleetComputeCapacity")]
    public interface IAppstreamFleetComputeCapacity
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appstream_fleet#desired_instances AppstreamFleet#desired_instances}.</summary>
        [JsiiProperty(name: "desiredInstances", typeJson: "{\"primitive\":\"number\"}")]
        double DesiredInstances
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppstreamFleetComputeCapacity), fullyQualifiedName: "aws.appstream.AppstreamFleetComputeCapacity")]
        internal sealed class _Proxy : DeputyBase, aws.Appstream.IAppstreamFleetComputeCapacity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appstream_fleet#desired_instances AppstreamFleet#desired_instances}.</summary>
            [JsiiProperty(name: "desiredInstances", typeJson: "{\"primitive\":\"number\"}")]
            public double DesiredInstances
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
