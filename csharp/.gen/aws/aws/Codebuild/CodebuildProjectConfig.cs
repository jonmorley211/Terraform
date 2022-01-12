using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codebuild
{
    #pragma warning disable CS8618

    /// <summary>AWS CodeBuild.</summary>
    [JsiiByValue(fqn: "aws.codebuild.CodebuildProjectConfig")]
    public class CodebuildProjectConfig : aws.Codebuild.ICodebuildProjectConfig
    {
        /// <summary>artifacts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#artifacts CodebuildProject#artifacts}
        /// </remarks>
        [JsiiProperty(name: "artifacts", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectArtifacts\"}", isOverride: true)]
        public aws.Codebuild.ICodebuildProjectArtifacts Artifacts
        {
            get;
            set;
        }

        /// <summary>environment block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#environment CodebuildProject#environment}
        /// </remarks>
        [JsiiProperty(name: "environment", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectEnvironment\"}", isOverride: true)]
        public aws.Codebuild.ICodebuildProjectEnvironment Environment
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#name CodebuildProject#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#service_role CodebuildProject#service_role}.</summary>
        [JsiiProperty(name: "serviceRole", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ServiceRole
        {
            get;
            set;
        }

        /// <summary>source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#source CodebuildProject#source}
        /// </remarks>
        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectSource\"}", isOverride: true)]
        public aws.Codebuild.ICodebuildProjectSource Source
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#badge_enabled CodebuildProject#badge_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "badgeEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? BadgeEnabled
        {
            get;
            set;
        }

        /// <summary>build_batch_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#build_batch_config CodebuildProject#build_batch_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "buildBatchConfig", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectBuildBatchConfig\"}", isOptional: true, isOverride: true)]
        public aws.Codebuild.ICodebuildProjectBuildBatchConfig? BuildBatchConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#build_timeout CodebuildProject#build_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "buildTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? BuildTimeout
        {
            get;
            set;
        }

        /// <summary>cache block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#cache CodebuildProject#cache}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cache", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectCache\"}", isOptional: true, isOverride: true)]
        public aws.Codebuild.ICodebuildProjectCache? Cache
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#concurrent_build_limit CodebuildProject#concurrent_build_limit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "concurrentBuildLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? ConcurrentBuildLimit
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#description CodebuildProject#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#encryption_key CodebuildProject#encryption_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "encryptionKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? EncryptionKey
        {
            get;
            set;
        }

        /// <summary>file_system_locations block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#file_system_locations CodebuildProject#file_system_locations}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fileSystemLocations", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codebuild.CodebuildProjectFileSystemLocations\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Codebuild.ICodebuildProjectFileSystemLocations[]? FileSystemLocations
        {
            get;
            set;
        }

        /// <summary>logs_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#logs_config CodebuildProject#logs_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "logsConfig", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectLogsConfig\"}", isOptional: true, isOverride: true)]
        public aws.Codebuild.ICodebuildProjectLogsConfig? LogsConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#project_visibility CodebuildProject#project_visibility}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "projectVisibility", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ProjectVisibility
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#queued_timeout CodebuildProject#queued_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "queuedTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? QueuedTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#resource_access_role CodebuildProject#resource_access_role}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceAccessRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ResourceAccessRole
        {
            get;
            set;
        }

        /// <summary>secondary_artifacts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#secondary_artifacts CodebuildProject#secondary_artifacts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secondaryArtifacts", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codebuild.CodebuildProjectSecondaryArtifacts\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Codebuild.ICodebuildProjectSecondaryArtifacts[]? SecondaryArtifacts
        {
            get;
            set;
        }

        /// <summary>secondary_sources block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#secondary_sources CodebuildProject#secondary_sources}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secondarySources", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codebuild.CodebuildProjectSecondarySources\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Codebuild.ICodebuildProjectSecondarySources[]? SecondarySources
        {
            get;
            set;
        }

        /// <summary>secondary_source_version block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#secondary_source_version CodebuildProject#secondary_source_version}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secondarySourceVersion", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codebuild.CodebuildProjectSecondarySourceVersion\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Codebuild.ICodebuildProjectSecondarySourceVersion[]? SecondarySourceVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#source_version CodebuildProject#source_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SourceVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#tags CodebuildProject#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true, isOverride: true)]
        public object? Tags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#tags_all CodebuildProject#tags_all}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tagsAll", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true, isOverride: true)]
        public object? TagsAll
        {
            get;
            set;
        }

        /// <summary>vpc_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#vpc_config CodebuildProject#vpc_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vpcConfig", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectVpcConfig\"}", isOptional: true, isOverride: true)]
        public aws.Codebuild.ICodebuildProjectVpcConfig? VpcConfig
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
