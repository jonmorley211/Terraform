using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiClass(nativeType: typeof(aws.Appmesh.AppmeshVirtualNodeSpecListenerTimeoutHttp2IdleOutputReference), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutHttp2IdleOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppmeshVirtualNodeSpecListenerTimeoutHttp2IdleOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public AppmeshVirtualNodeSpecListenerTimeoutHttp2IdleOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualNodeSpecListenerTimeoutHttp2IdleOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualNodeSpecListenerTimeoutHttp2IdleOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "unitInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UnitInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "valueInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ValueInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "unit", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Unit
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Value
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutHttp2Idle\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutHttp2Idle? InternalValue
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutHttp2Idle?>();
            set => SetInstanceProperty(value);
        }
    }
}
