using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Imagebuilder
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.imagebuilder.ImagebuilderImagePipelineSchedule")]
    public class ImagebuilderImagePipelineSchedule : aws.Imagebuilder.IImagebuilderImagePipelineSchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/imagebuilder_image_pipeline#schedule_expression ImagebuilderImagePipeline#schedule_expression}.</summary>
        [JsiiProperty(name: "scheduleExpression", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ScheduleExpression
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/imagebuilder_image_pipeline#pipeline_execution_start_condition ImagebuilderImagePipeline#pipeline_execution_start_condition}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pipelineExecutionStartCondition", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? PipelineExecutionStartCondition
        {
            get;
            set;
        }
    }
}
