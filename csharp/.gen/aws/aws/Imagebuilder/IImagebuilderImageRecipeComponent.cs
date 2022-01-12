using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Imagebuilder
{
    [JsiiInterface(nativeType: typeof(IImagebuilderImageRecipeComponent), fullyQualifiedName: "aws.imagebuilder.ImagebuilderImageRecipeComponent")]
    public interface IImagebuilderImageRecipeComponent
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/imagebuilder_image_recipe#component_arn ImagebuilderImageRecipe#component_arn}.</summary>
        [JsiiProperty(name: "componentArn", typeJson: "{\"primitive\":\"string\"}")]
        string ComponentArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IImagebuilderImageRecipeComponent), fullyQualifiedName: "aws.imagebuilder.ImagebuilderImageRecipeComponent")]
        internal sealed class _Proxy : DeputyBase, aws.Imagebuilder.IImagebuilderImageRecipeComponent
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/imagebuilder_image_recipe#component_arn ImagebuilderImageRecipe#component_arn}.</summary>
            [JsiiProperty(name: "componentArn", typeJson: "{\"primitive\":\"string\"}")]
            public string ComponentArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
