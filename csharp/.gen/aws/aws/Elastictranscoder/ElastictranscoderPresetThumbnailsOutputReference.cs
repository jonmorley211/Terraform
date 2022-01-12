using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elastictranscoder
{
    [JsiiClass(nativeType: typeof(aws.Elastictranscoder.ElastictranscoderPresetThumbnailsOutputReference), fullyQualifiedName: "aws.elastictranscoder.ElastictranscoderPresetThumbnailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class ElastictranscoderPresetThumbnailsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public ElastictranscoderPresetThumbnailsOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElastictranscoderPresetThumbnailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElastictranscoderPresetThumbnailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAspectRatio")]
        public virtual void ResetAspectRatio()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFormat")]
        public virtual void ResetFormat()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInterval")]
        public virtual void ResetInterval()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxHeight")]
        public virtual void ResetMaxHeight()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxWidth")]
        public virtual void ResetMaxWidth()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPaddingPolicy")]
        public virtual void ResetPaddingPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResolution")]
        public virtual void ResetResolution()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSizingPolicy")]
        public virtual void ResetSizingPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "aspectRatioInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AspectRatioInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "formatInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FormatInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "intervalInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IntervalInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxHeightInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MaxHeightInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxWidthInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MaxWidthInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "paddingPolicyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PaddingPolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resolutionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResolutionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sizingPolicyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SizingPolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "aspectRatio", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AspectRatio
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Format
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Interval
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxHeight", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaxHeight
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxWidth", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaxWidth
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "paddingPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PaddingPolicy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resolution", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Resolution
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sizingPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SizingPolicy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPresetThumbnails\"}", isOptional: true)]
        public virtual aws.Elastictranscoder.IElastictranscoderPresetThumbnails? InternalValue
        {
            get => GetInstanceProperty<aws.Elastictranscoder.IElastictranscoderPresetThumbnails?>();
            set => SetInstanceProperty(value);
        }
    }
}
