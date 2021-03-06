using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Datasync
{
    [JsiiInterface(nativeType: typeof(IDatasyncTaskExcludes), fullyQualifiedName: "aws.datasync.DatasyncTaskExcludes")]
    public interface IDatasyncTaskExcludes
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_task#filter_type DatasyncTask#filter_type}.</summary>
        [JsiiProperty(name: "filterType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FilterType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_task#value DatasyncTask#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Value
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatasyncTaskExcludes), fullyQualifiedName: "aws.datasync.DatasyncTaskExcludes")]
        internal sealed class _Proxy : DeputyBase, aws.Datasync.IDatasyncTaskExcludes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_task#filter_type DatasyncTask#filter_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "filterType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FilterType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_task#value DatasyncTask#value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Value
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
