using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elastictranscoder
{
    [JsiiClass(nativeType: typeof(aws.Elastictranscoder.ElastictranscoderPresetAudioCodecOptionsOutputReference), fullyQualifiedName: "aws.elastictranscoder.ElastictranscoderPresetAudioCodecOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class ElastictranscoderPresetAudioCodecOptionsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public ElastictranscoderPresetAudioCodecOptionsOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElastictranscoderPresetAudioCodecOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElastictranscoderPresetAudioCodecOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetBitDepth")]
        public virtual void ResetBitDepth()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBitOrder")]
        public virtual void ResetBitOrder()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProfile")]
        public virtual void ResetProfile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSigned")]
        public virtual void ResetSigned()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "bitDepthInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BitDepthInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bitOrderInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BitOrderInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "profileInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProfileInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "signedInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SignedInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "bitDepth", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BitDepth
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "bitOrder", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BitOrder
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "profile", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Profile
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "signed", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Signed
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPresetAudioCodecOptions\"}", isOptional: true)]
        public virtual aws.Elastictranscoder.IElastictranscoderPresetAudioCodecOptions? InternalValue
        {
            get => GetInstanceProperty<aws.Elastictranscoder.IElastictranscoderPresetAudioCodecOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
