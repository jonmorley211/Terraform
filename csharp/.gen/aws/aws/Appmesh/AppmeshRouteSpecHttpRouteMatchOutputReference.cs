using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiClass(nativeType: typeof(aws.Appmesh.AppmeshRouteSpecHttpRouteMatchOutputReference), fullyQualifiedName: "aws.appmesh.AppmeshRouteSpecHttpRouteMatchOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppmeshRouteSpecHttpRouteMatchOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public AppmeshRouteSpecHttpRouteMatchOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshRouteSpecHttpRouteMatchOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshRouteSpecHttpRouteMatchOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetHeader")]
        public virtual void ResetHeader()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMethod")]
        public virtual void ResetMethod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScheme")]
        public virtual void ResetScheme()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "headerInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteMatchHeader\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshRouteSpecHttpRouteMatchHeader[]? HeaderInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecHttpRouteMatchHeader[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "methodInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MethodInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "prefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "schemeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SchemeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "header", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteMatchHeader\"},\"kind\":\"array\"}}")]
        public virtual aws.Appmesh.IAppmeshRouteSpecHttpRouteMatchHeader[] Header
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecHttpRouteMatchHeader[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "method", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Method
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Prefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scheme", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Scheme
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteMatch\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshRouteSpecHttpRouteMatch? InternalValue
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecHttpRouteMatch?>();
            set => SetInstanceProperty(value);
        }
    }
}
