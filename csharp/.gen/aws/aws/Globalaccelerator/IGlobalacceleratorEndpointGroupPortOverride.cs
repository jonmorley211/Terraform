using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Globalaccelerator
{
    [JsiiInterface(nativeType: typeof(IGlobalacceleratorEndpointGroupPortOverride), fullyQualifiedName: "aws.globalaccelerator.GlobalacceleratorEndpointGroupPortOverride")]
    public interface IGlobalacceleratorEndpointGroupPortOverride
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/globalaccelerator_endpoint_group#endpoint_port GlobalacceleratorEndpointGroup#endpoint_port}.</summary>
        [JsiiProperty(name: "endpointPort", typeJson: "{\"primitive\":\"number\"}")]
        double EndpointPort
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/globalaccelerator_endpoint_group#listener_port GlobalacceleratorEndpointGroup#listener_port}.</summary>
        [JsiiProperty(name: "listenerPort", typeJson: "{\"primitive\":\"number\"}")]
        double ListenerPort
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGlobalacceleratorEndpointGroupPortOverride), fullyQualifiedName: "aws.globalaccelerator.GlobalacceleratorEndpointGroupPortOverride")]
        internal sealed class _Proxy : DeputyBase, aws.Globalaccelerator.IGlobalacceleratorEndpointGroupPortOverride
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/globalaccelerator_endpoint_group#endpoint_port GlobalacceleratorEndpointGroup#endpoint_port}.</summary>
            [JsiiProperty(name: "endpointPort", typeJson: "{\"primitive\":\"number\"}")]
            public double EndpointPort
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/globalaccelerator_endpoint_group#listener_port GlobalacceleratorEndpointGroup#listener_port}.</summary>
            [JsiiProperty(name: "listenerPort", typeJson: "{\"primitive\":\"number\"}")]
            public double ListenerPort
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
