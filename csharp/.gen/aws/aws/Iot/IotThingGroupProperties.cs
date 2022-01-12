using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Iot
{
    [JsiiByValue(fqn: "aws.iot.IotThingGroupProperties")]
    public class IotThingGroupProperties : aws.Iot.IIotThingGroupProperties
    {
        /// <summary>attribute_payload block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_thing_group#attribute_payload IotThingGroup#attribute_payload}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "attributePayload", typeJson: "{\"fqn\":\"aws.iot.IotThingGroupPropertiesAttributePayload\"}", isOptional: true, isOverride: true)]
        public aws.Iot.IIotThingGroupPropertiesAttributePayload? AttributePayload
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_thing_group#description IotThingGroup#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Description
        {
            get;
            set;
        }
    }
}
