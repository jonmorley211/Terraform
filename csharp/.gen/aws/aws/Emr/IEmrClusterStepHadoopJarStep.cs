using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Emr
{
    [JsiiInterface(nativeType: typeof(IEmrClusterStepHadoopJarStep), fullyQualifiedName: "aws.emr.EmrClusterStepHadoopJarStep")]
    public interface IEmrClusterStepHadoopJarStep
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#args EmrCluster#args}.</summary>
        [JsiiProperty(name: "args", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Args
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#jar EmrCluster#jar}.</summary>
        [JsiiProperty(name: "jar", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Jar
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#main_class EmrCluster#main_class}.</summary>
        [JsiiProperty(name: "mainClass", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MainClass
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#properties EmrCluster#properties}.</summary>
        [JsiiProperty(name: "properties", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Properties
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEmrClusterStepHadoopJarStep), fullyQualifiedName: "aws.emr.EmrClusterStepHadoopJarStep")]
        internal sealed class _Proxy : DeputyBase, aws.Emr.IEmrClusterStepHadoopJarStep
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#args EmrCluster#args}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "args", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Args
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#jar EmrCluster#jar}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "jar", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Jar
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#main_class EmrCluster#main_class}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mainClass", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MainClass
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#properties EmrCluster#properties}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "properties", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? Properties
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
