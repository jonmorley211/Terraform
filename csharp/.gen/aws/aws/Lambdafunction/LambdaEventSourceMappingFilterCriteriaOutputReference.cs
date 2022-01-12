using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lambdafunction
{
    [JsiiClass(nativeType: typeof(aws.Lambdafunction.LambdaEventSourceMappingFilterCriteriaOutputReference), fullyQualifiedName: "aws.lambdafunction.LambdaEventSourceMappingFilterCriteriaOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class LambdaEventSourceMappingFilterCriteriaOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public LambdaEventSourceMappingFilterCriteriaOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LambdaEventSourceMappingFilterCriteriaOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LambdaEventSourceMappingFilterCriteriaOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetFilter")]
        public virtual void ResetFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lambdafunction.LambdaEventSourceMappingFilterCriteriaFilter\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Lambdafunction.ILambdaEventSourceMappingFilterCriteriaFilter[]? FilterInput
        {
            get => GetInstanceProperty<aws.Lambdafunction.ILambdaEventSourceMappingFilterCriteriaFilter[]?>();
        }

        [JsiiProperty(name: "filter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lambdafunction.LambdaEventSourceMappingFilterCriteriaFilter\"},\"kind\":\"array\"}}")]
        public virtual aws.Lambdafunction.ILambdaEventSourceMappingFilterCriteriaFilter[] Filter
        {
            get => GetInstanceProperty<aws.Lambdafunction.ILambdaEventSourceMappingFilterCriteriaFilter[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaEventSourceMappingFilterCriteria\"}", isOptional: true)]
        public virtual aws.Lambdafunction.ILambdaEventSourceMappingFilterCriteria? InternalValue
        {
            get => GetInstanceProperty<aws.Lambdafunction.ILambdaEventSourceMappingFilterCriteria?>();
            set => SetInstanceProperty(value);
        }
    }
}
