using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Imagebuilder
{
    [JsiiClass(nativeType: typeof(aws.Imagebuilder.DataAwsImagebuilderImagePipelineImageTestsConfiguration), fullyQualifiedName: "aws.imagebuilder.DataAwsImagebuilderImagePipelineImageTestsConfiguration", parametersJson: "[{\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"complexComputedListIndex\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataAwsImagebuilderImagePipelineImageTestsConfiguration : HashiCorp.Cdktf.ComplexComputedList
    {
        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        public DataAwsImagebuilderImagePipelineImageTestsConfiguration(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, string complexComputedListIndex): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexComputedListIndex}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsImagebuilderImagePipelineImageTestsConfiguration(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsImagebuilderImagePipelineImageTestsConfiguration(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "imageTestsEnabled", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object ImageTestsEnabled
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "timeoutMinutes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TimeoutMinutes
        {
            get => GetInstanceProperty<double>()!;
        }
    }
}
