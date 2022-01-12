using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codebuild
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.codebuild.CodebuildProjectBuildBatchConfig")]
    public class CodebuildProjectBuildBatchConfig : aws.Codebuild.ICodebuildProjectBuildBatchConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#service_role CodebuildProject#service_role}.</summary>
        [JsiiProperty(name: "serviceRole", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ServiceRole
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#combine_artifacts CodebuildProject#combine_artifacts}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "combineArtifacts", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? CombineArtifacts
        {
            get;
            set;
        }

        /// <summary>restrictions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#restrictions CodebuildProject#restrictions}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "restrictions", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectBuildBatchConfigRestrictions\"}", isOptional: true, isOverride: true)]
        public aws.Codebuild.ICodebuildProjectBuildBatchConfigRestrictions? Restrictions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#timeout_in_mins CodebuildProject#timeout_in_mins}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutInMins", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? TimeoutInMins
        {
            get;
            set;
        }
    }
}
