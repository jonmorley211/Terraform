using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Imagebuilder
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.imagebuilder.ImagebuilderImageRecipeComponent")]
    public class ImagebuilderImageRecipeComponent : aws.Imagebuilder.IImagebuilderImageRecipeComponent
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/imagebuilder_image_recipe#component_arn ImagebuilderImageRecipe#component_arn}.</summary>
        [JsiiProperty(name: "componentArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ComponentArn
        {
            get;
            set;
        }
    }
}
