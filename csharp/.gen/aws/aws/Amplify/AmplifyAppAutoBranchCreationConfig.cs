using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Amplify
{
    [JsiiByValue(fqn: "aws.amplify.AmplifyAppAutoBranchCreationConfig")]
    public class AmplifyAppAutoBranchCreationConfig : aws.Amplify.IAmplifyAppAutoBranchCreationConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/amplify_app#basic_auth_credentials AmplifyApp#basic_auth_credentials}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "basicAuthCredentials", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? BasicAuthCredentials
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/amplify_app#build_spec AmplifyApp#build_spec}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "buildSpec", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? BuildSpec
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/amplify_app#enable_auto_build AmplifyApp#enable_auto_build}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enableAutoBuild", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? EnableAutoBuild
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/amplify_app#enable_basic_auth AmplifyApp#enable_basic_auth}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enableBasicAuth", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? EnableBasicAuth
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/amplify_app#enable_performance_mode AmplifyApp#enable_performance_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enablePerformanceMode", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? EnablePerformanceMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/amplify_app#enable_pull_request_preview AmplifyApp#enable_pull_request_preview}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enablePullRequestPreview", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? EnablePullRequestPreview
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/amplify_app#environment_variables AmplifyApp#environment_variables}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "environmentVariables", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true, isOverride: true)]
        public object? EnvironmentVariables
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/amplify_app#framework AmplifyApp#framework}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "framework", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Framework
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/amplify_app#pull_request_environment_name AmplifyApp#pull_request_environment_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pullRequestEnvironmentName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? PullRequestEnvironmentName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/amplify_app#stage AmplifyApp#stage}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "stage", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Stage
        {
            get;
            set;
        }
    }
}
