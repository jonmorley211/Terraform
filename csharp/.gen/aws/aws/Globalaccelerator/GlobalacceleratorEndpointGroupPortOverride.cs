using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Globalaccelerator
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.globalaccelerator.GlobalacceleratorEndpointGroupPortOverride")]
    public class GlobalacceleratorEndpointGroupPortOverride : aws.Globalaccelerator.IGlobalacceleratorEndpointGroupPortOverride
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/globalaccelerator_endpoint_group#endpoint_port GlobalacceleratorEndpointGroup#endpoint_port}.</summary>
        [JsiiProperty(name: "endpointPort", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double EndpointPort
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/globalaccelerator_endpoint_group#listener_port GlobalacceleratorEndpointGroup#listener_port}.</summary>
        [JsiiProperty(name: "listenerPort", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double ListenerPort
        {
            get;
            set;
        }
    }
}
