using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Iot
{
    #pragma warning disable CS8618

    /// <summary>AWS IoT.</summary>
    [JsiiByValue(fqn: "aws.iot.IotThingConfig")]
    public class IotThingConfig : aws.Iot.IIotThingConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_thing#name IotThing#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_thing#attributes IotThing#attributes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "attributes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true, isOverride: true)]
        public object? Attributes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_thing#thing_type_name IotThing#thing_type_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "thingTypeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ThingTypeName
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}