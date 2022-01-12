using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    [JsiiClass(nativeType: typeof(aws.Glue.GlueMlTransformParametersOutputReference), fullyQualifiedName: "aws.glue.GlueMlTransformParametersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class GlueMlTransformParametersOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public GlueMlTransformParametersOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueMlTransformParametersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueMlTransformParametersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putFindMatchesParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.glue.GlueMlTransformParametersFindMatchesParameters\"}}]")]
        public virtual void PutFindMatchesParameters(aws.Glue.IGlueMlTransformParametersFindMatchesParameters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Glue.IGlueMlTransformParametersFindMatchesParameters)}, new object[]{@value});
        }

        [JsiiProperty(name: "findMatchesParameters", typeJson: "{\"fqn\":\"aws.glue.GlueMlTransformParametersFindMatchesParametersOutputReference\"}")]
        public virtual aws.Glue.GlueMlTransformParametersFindMatchesParametersOutputReference FindMatchesParameters
        {
            get => GetInstanceProperty<aws.Glue.GlueMlTransformParametersFindMatchesParametersOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "findMatchesParametersInput", typeJson: "{\"fqn\":\"aws.glue.GlueMlTransformParametersFindMatchesParameters\"}", isOptional: true)]
        public virtual aws.Glue.IGlueMlTransformParametersFindMatchesParameters? FindMatchesParametersInput
        {
            get => GetInstanceProperty<aws.Glue.IGlueMlTransformParametersFindMatchesParameters?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "transformTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TransformTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "transformType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TransformType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.glue.GlueMlTransformParameters\"}", isOptional: true)]
        public virtual aws.Glue.IGlueMlTransformParameters? InternalValue
        {
            get => GetInstanceProperty<aws.Glue.IGlueMlTransformParameters?>();
            set => SetInstanceProperty(value);
        }
    }
}
