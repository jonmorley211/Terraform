using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Imagebuilder
{
    [JsiiByValue(fqn: "aws.imagebuilder.ImagebuilderImageRecipeBlockDeviceMapping")]
    public class ImagebuilderImageRecipeBlockDeviceMapping : aws.Imagebuilder.IImagebuilderImageRecipeBlockDeviceMapping
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/imagebuilder_image_recipe#device_name ImagebuilderImageRecipe#device_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deviceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DeviceName
        {
            get;
            set;
        }

        /// <summary>ebs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/imagebuilder_image_recipe#ebs ImagebuilderImageRecipe#ebs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ebs", typeJson: "{\"fqn\":\"aws.imagebuilder.ImagebuilderImageRecipeBlockDeviceMappingEbs\"}", isOptional: true, isOverride: true)]
        public aws.Imagebuilder.IImagebuilderImageRecipeBlockDeviceMappingEbs? Ebs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/imagebuilder_image_recipe#no_device ImagebuilderImageRecipe#no_device}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "noDevice", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? NoDevice
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/imagebuilder_image_recipe#virtual_name ImagebuilderImageRecipe#virtual_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "virtualName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? VirtualName
        {
            get;
            set;
        }
    }
}
