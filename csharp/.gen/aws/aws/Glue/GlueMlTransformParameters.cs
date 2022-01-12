using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.glue.GlueMlTransformParameters")]
    public class GlueMlTransformParameters : aws.Glue.IGlueMlTransformParameters
    {
        /// <summary>find_matches_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_ml_transform#find_matches_parameters GlueMlTransform#find_matches_parameters}
        /// </remarks>
        [JsiiProperty(name: "findMatchesParameters", typeJson: "{\"fqn\":\"aws.glue.GlueMlTransformParametersFindMatchesParameters\"}", isOverride: true)]
        public aws.Glue.IGlueMlTransformParametersFindMatchesParameters FindMatchesParameters
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_ml_transform#transform_type GlueMlTransform#transform_type}.</summary>
        [JsiiProperty(name: "transformType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string TransformType
        {
            get;
            set;
        }
    }
}
