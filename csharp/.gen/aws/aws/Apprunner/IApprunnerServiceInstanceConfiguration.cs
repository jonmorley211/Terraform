using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apprunner
{
    [JsiiInterface(nativeType: typeof(IApprunnerServiceInstanceConfiguration), fullyQualifiedName: "aws.apprunner.ApprunnerServiceInstanceConfiguration")]
    public interface IApprunnerServiceInstanceConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apprunner_service#cpu ApprunnerService#cpu}.</summary>
        [JsiiProperty(name: "cpu", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Cpu
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apprunner_service#instance_role_arn ApprunnerService#instance_role_arn}.</summary>
        [JsiiProperty(name: "instanceRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InstanceRoleArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apprunner_service#memory ApprunnerService#memory}.</summary>
        [JsiiProperty(name: "memory", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Memory
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApprunnerServiceInstanceConfiguration), fullyQualifiedName: "aws.apprunner.ApprunnerServiceInstanceConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Apprunner.IApprunnerServiceInstanceConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apprunner_service#cpu ApprunnerService#cpu}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cpu", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Cpu
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apprunner_service#instance_role_arn ApprunnerService#instance_role_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instanceRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InstanceRoleArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apprunner_service#memory ApprunnerService#memory}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "memory", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Memory
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
