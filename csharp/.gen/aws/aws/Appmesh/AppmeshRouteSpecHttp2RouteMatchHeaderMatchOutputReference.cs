using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiClass(nativeType: typeof(aws.Appmesh.AppmeshRouteSpecHttp2RouteMatchHeaderMatchOutputReference), fullyQualifiedName: "aws.appmesh.AppmeshRouteSpecHttp2RouteMatchHeaderMatchOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppmeshRouteSpecHttp2RouteMatchHeaderMatchOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public AppmeshRouteSpecHttp2RouteMatchHeaderMatchOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshRouteSpecHttp2RouteMatchHeaderMatchOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshRouteSpecHttp2RouteMatchHeaderMatchOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putRange", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttp2RouteMatchHeaderMatchRange\"}}]")]
        public virtual void PutRange(aws.Appmesh.IAppmeshRouteSpecHttp2RouteMatchHeaderMatchRange @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshRouteSpecHttp2RouteMatchHeaderMatchRange)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetExact")]
        public virtual void ResetExact()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrefix")]
        public virtual void ResetPrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRange")]
        public virtual void ResetRange()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegex")]
        public virtual void ResetRegex()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSuffix")]
        public virtual void ResetSuffix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "range", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttp2RouteMatchHeaderMatchRangeOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshRouteSpecHttp2RouteMatchHeaderMatchRangeOutputReference Range
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshRouteSpecHttp2RouteMatchHeaderMatchRangeOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "exactInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExactInput
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
        [JsiiProperty(name: "rangeInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttp2RouteMatchHeaderMatchRange\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshRouteSpecHttp2RouteMatchHeaderMatchRange? RangeInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecHttp2RouteMatchHeaderMatchRange?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regexInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegexInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "suffixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SuffixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "exact", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Exact
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

        [JsiiProperty(name: "regex", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Regex
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "suffix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Suffix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttp2RouteMatchHeaderMatch\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshRouteSpecHttp2RouteMatchHeaderMatch? InternalValue
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecHttp2RouteMatchHeaderMatch?>();
            set => SetInstanceProperty(value);
        }
    }
}
