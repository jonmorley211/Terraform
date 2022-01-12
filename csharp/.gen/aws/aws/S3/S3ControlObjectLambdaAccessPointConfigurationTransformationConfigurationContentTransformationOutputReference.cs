using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiClass(nativeType: typeof(aws.S3.S3ControlObjectLambdaAccessPointConfigurationTransformationConfigurationContentTransformationOutputReference), fullyQualifiedName: "aws.s3.S3ControlObjectLambdaAccessPointConfigurationTransformationConfigurationContentTransformationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class S3ControlObjectLambdaAccessPointConfigurationTransformationConfigurationContentTransformationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public S3ControlObjectLambdaAccessPointConfigurationTransformationConfigurationContentTransformationOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3ControlObjectLambdaAccessPointConfigurationTransformationConfigurationContentTransformationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3ControlObjectLambdaAccessPointConfigurationTransformationConfigurationContentTransformationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAwsLambda", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3.S3ControlObjectLambdaAccessPointConfigurationTransformationConfigurationContentTransformationAwsLambda\"}}]")]
        public virtual void PutAwsLambda(aws.S3.IS3ControlObjectLambdaAccessPointConfigurationTransformationConfigurationContentTransformationAwsLambda @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3.IS3ControlObjectLambdaAccessPointConfigurationTransformationConfigurationContentTransformationAwsLambda)}, new object[]{@value});
        }

        [JsiiProperty(name: "awsLambda", typeJson: "{\"fqn\":\"aws.s3.S3ControlObjectLambdaAccessPointConfigurationTransformationConfigurationContentTransformationAwsLambdaOutputReference\"}")]
        public virtual aws.S3.S3ControlObjectLambdaAccessPointConfigurationTransformationConfigurationContentTransformationAwsLambdaOutputReference AwsLambda
        {
            get => GetInstanceProperty<aws.S3.S3ControlObjectLambdaAccessPointConfigurationTransformationConfigurationContentTransformationAwsLambdaOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "awsLambdaInput", typeJson: "{\"fqn\":\"aws.s3.S3ControlObjectLambdaAccessPointConfigurationTransformationConfigurationContentTransformationAwsLambda\"}", isOptional: true)]
        public virtual aws.S3.IS3ControlObjectLambdaAccessPointConfigurationTransformationConfigurationContentTransformationAwsLambda? AwsLambdaInput
        {
            get => GetInstanceProperty<aws.S3.IS3ControlObjectLambdaAccessPointConfigurationTransformationConfigurationContentTransformationAwsLambda?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.s3.S3ControlObjectLambdaAccessPointConfigurationTransformationConfigurationContentTransformation\"}", isOptional: true)]
        public virtual aws.S3.IS3ControlObjectLambdaAccessPointConfigurationTransformationConfigurationContentTransformation? InternalValue
        {
            get => GetInstanceProperty<aws.S3.IS3ControlObjectLambdaAccessPointConfigurationTransformationConfigurationContentTransformation?>();
            set => SetInstanceProperty(value);
        }
    }
}
