using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecs
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ecs.EcsTaskDefinitionInferenceAccelerator")]
    public class EcsTaskDefinitionInferenceAccelerator : aws.Ecs.IEcsTaskDefinitionInferenceAccelerator
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#device_name EcsTaskDefinition#device_name}.</summary>
        [JsiiProperty(name: "deviceName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string DeviceName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#device_type EcsTaskDefinition#device_type}.</summary>
        [JsiiProperty(name: "deviceType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string DeviceType
        {
            get;
            set;
        }
    }
}
