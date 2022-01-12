using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    [JsiiInterface(nativeType: typeof(IGlueMlTransformParameters), fullyQualifiedName: "aws.glue.GlueMlTransformParameters")]
    public interface IGlueMlTransformParameters
    {
        /// <summary>find_matches_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_ml_transform#find_matches_parameters GlueMlTransform#find_matches_parameters}
        /// </remarks>
        [JsiiProperty(name: "findMatchesParameters", typeJson: "{\"fqn\":\"aws.glue.GlueMlTransformParametersFindMatchesParameters\"}")]
        aws.Glue.IGlueMlTransformParametersFindMatchesParameters FindMatchesParameters
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_ml_transform#transform_type GlueMlTransform#transform_type}.</summary>
        [JsiiProperty(name: "transformType", typeJson: "{\"primitive\":\"string\"}")]
        string TransformType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueMlTransformParameters), fullyQualifiedName: "aws.glue.GlueMlTransformParameters")]
        internal sealed class _Proxy : DeputyBase, aws.Glue.IGlueMlTransformParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>find_matches_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_ml_transform#find_matches_parameters GlueMlTransform#find_matches_parameters}
            /// </remarks>
            [JsiiProperty(name: "findMatchesParameters", typeJson: "{\"fqn\":\"aws.glue.GlueMlTransformParametersFindMatchesParameters\"}")]
            public aws.Glue.IGlueMlTransformParametersFindMatchesParameters FindMatchesParameters
            {
                get => GetInstanceProperty<aws.Glue.IGlueMlTransformParametersFindMatchesParameters>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_ml_transform#transform_type GlueMlTransform#transform_type}.</summary>
            [JsiiProperty(name: "transformType", typeJson: "{\"primitive\":\"string\"}")]
            public string TransformType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
