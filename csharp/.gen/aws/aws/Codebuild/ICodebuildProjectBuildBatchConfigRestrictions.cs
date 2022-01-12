using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codebuild
{
    [JsiiInterface(nativeType: typeof(ICodebuildProjectBuildBatchConfigRestrictions), fullyQualifiedName: "aws.codebuild.CodebuildProjectBuildBatchConfigRestrictions")]
    public interface ICodebuildProjectBuildBatchConfigRestrictions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#compute_types_allowed CodebuildProject#compute_types_allowed}.</summary>
        [JsiiProperty(name: "computeTypesAllowed", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ComputeTypesAllowed
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#maximum_builds_allowed CodebuildProject#maximum_builds_allowed}.</summary>
        [JsiiProperty(name: "maximumBuildsAllowed", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaximumBuildsAllowed
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodebuildProjectBuildBatchConfigRestrictions), fullyQualifiedName: "aws.codebuild.CodebuildProjectBuildBatchConfigRestrictions")]
        internal sealed class _Proxy : DeputyBase, aws.Codebuild.ICodebuildProjectBuildBatchConfigRestrictions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#compute_types_allowed CodebuildProject#compute_types_allowed}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "computeTypesAllowed", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ComputeTypesAllowed
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#maximum_builds_allowed CodebuildProject#maximum_builds_allowed}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maximumBuildsAllowed", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaximumBuildsAllowed
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
