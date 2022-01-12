using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Imagebuilder
{
    [JsiiInterface(nativeType: typeof(IImagebuilderImagePipelineSchedule), fullyQualifiedName: "aws.imagebuilder.ImagebuilderImagePipelineSchedule")]
    public interface IImagebuilderImagePipelineSchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/imagebuilder_image_pipeline#schedule_expression ImagebuilderImagePipeline#schedule_expression}.</summary>
        [JsiiProperty(name: "scheduleExpression", typeJson: "{\"primitive\":\"string\"}")]
        string ScheduleExpression
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/imagebuilder_image_pipeline#pipeline_execution_start_condition ImagebuilderImagePipeline#pipeline_execution_start_condition}.</summary>
        [JsiiProperty(name: "pipelineExecutionStartCondition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PipelineExecutionStartCondition
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IImagebuilderImagePipelineSchedule), fullyQualifiedName: "aws.imagebuilder.ImagebuilderImagePipelineSchedule")]
        internal sealed class _Proxy : DeputyBase, aws.Imagebuilder.IImagebuilderImagePipelineSchedule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/imagebuilder_image_pipeline#schedule_expression ImagebuilderImagePipeline#schedule_expression}.</summary>
            [JsiiProperty(name: "scheduleExpression", typeJson: "{\"primitive\":\"string\"}")]
            public string ScheduleExpression
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/imagebuilder_image_pipeline#pipeline_execution_start_condition ImagebuilderImagePipeline#pipeline_execution_start_condition}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "pipelineExecutionStartCondition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PipelineExecutionStartCondition
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
