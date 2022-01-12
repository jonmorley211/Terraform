using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codebuild
{
    [JsiiInterface(nativeType: typeof(ICodebuildProjectBuildBatchConfig), fullyQualifiedName: "aws.codebuild.CodebuildProjectBuildBatchConfig")]
    public interface ICodebuildProjectBuildBatchConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#service_role CodebuildProject#service_role}.</summary>
        [JsiiProperty(name: "serviceRole", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceRole
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#combine_artifacts CodebuildProject#combine_artifacts}.</summary>
        [JsiiProperty(name: "combineArtifacts", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CombineArtifacts
        {
            get
            {
                return null;
            }
        }

        /// <summary>restrictions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#restrictions CodebuildProject#restrictions}
        /// </remarks>
        [JsiiProperty(name: "restrictions", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectBuildBatchConfigRestrictions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Codebuild.ICodebuildProjectBuildBatchConfigRestrictions? Restrictions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#timeout_in_mins CodebuildProject#timeout_in_mins}.</summary>
        [JsiiProperty(name: "timeoutInMins", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TimeoutInMins
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodebuildProjectBuildBatchConfig), fullyQualifiedName: "aws.codebuild.CodebuildProjectBuildBatchConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Codebuild.ICodebuildProjectBuildBatchConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#service_role CodebuildProject#service_role}.</summary>
            [JsiiProperty(name: "serviceRole", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceRole
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#combine_artifacts CodebuildProject#combine_artifacts}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "combineArtifacts", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? CombineArtifacts
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>restrictions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#restrictions CodebuildProject#restrictions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "restrictions", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectBuildBatchConfigRestrictions\"}", isOptional: true)]
            public aws.Codebuild.ICodebuildProjectBuildBatchConfigRestrictions? Restrictions
            {
                get => GetInstanceProperty<aws.Codebuild.ICodebuildProjectBuildBatchConfigRestrictions?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#timeout_in_mins CodebuildProject#timeout_in_mins}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeoutInMins", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TimeoutInMins
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
