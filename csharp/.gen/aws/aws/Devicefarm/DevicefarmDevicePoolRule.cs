using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Devicefarm
{
    [JsiiByValue(fqn: "aws.devicefarm.DevicefarmDevicePoolRule")]
    public class DevicefarmDevicePoolRule : aws.Devicefarm.IDevicefarmDevicePoolRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/devicefarm_device_pool#attribute DevicefarmDevicePool#attribute}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "attribute", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Attribute
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/devicefarm_device_pool#operator DevicefarmDevicePool#operator}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Operator
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/devicefarm_device_pool#value DevicefarmDevicePool#value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Value
        {
            get;
            set;
        }
    }
}
