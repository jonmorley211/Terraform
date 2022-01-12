using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codebuild
{
    [JsiiByValue(fqn: "aws.codebuild.CodebuildProjectBuildBatchConfigRestrictions")]
    public class CodebuildProjectBuildBatchConfigRestrictions : aws.Codebuild.ICodebuildProjectBuildBatchConfigRestrictions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#compute_types_allowed CodebuildProject#compute_types_allowed}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "computeTypesAllowed", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? ComputeTypesAllowed
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#maximum_builds_allowed CodebuildProject#maximum_builds_allowed}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maximumBuildsAllowed", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? MaximumBuildsAllowed
        {
            get;
            set;
        }
    }
}
