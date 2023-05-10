using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Net.Http.Headers;
using Shared.DataTranferObjects;
using System.Text;

namespace GraduationProject_API;

public class CsvOutputFormatter : TextOutputFormatter
{
	public CsvOutputFormatter()
	{
		SupportedMediaTypes.Add(MediaTypeHeaderValue.Parse("text/csv"));
        SupportedEncodings.Add(Encoding.UTF8);
        SupportedEncodings.Add(Encoding.Unicode);
    }

    protected override bool CanWriteType(Type? type)
    {
        if (typeof(SubmitionDto).IsAssignableFrom(type) ||
            typeof(IEnumerable<SubmitionDto>).IsAssignableFrom(type))
        {
            return base.CanWriteType(type);
        }

        return false;
    }

    public override async Task WriteResponseBodyAsync(OutputFormatterWriteContext context, Encoding selectedEncoding)
    {
        var response = context.HttpContext.Response;
        var buffer = new StringBuilder();

        buffer.AppendLine("SubmitionId, InstructorEfficiency, CourseUnderstand, InstructorRespect, InstructorMaterial, ExamContent, AssistantTeacher, InstructorRecommendation, CourseRecommendation, CourseMarket");
        if (context.Object is IEnumerable<SubmitionDto>)
        {
            foreach (var submition in (IEnumerable<SubmitionDto>)context.Object)
                FormatCsv(buffer, submition);
        }
        else
            FormatCsv(buffer, (SubmitionDto)context.Object);

        await response.WriteAsync(buffer.ToString());
    }

    private static void FormatCsv(StringBuilder buffer, SubmitionDto submition)
    {
        buffer.AppendLine($"{submition.Id}, {submition.InstructorEfficiency}, {submition.CourseUnderstand}, {submition.InstructorRespect}, {submition.InstructorMaterial}, {submition.ExamContent}, {submition.AssistantTeacher}, {submition.InstructorRecommendation}, {submition.CourseRecommendation}, {submition.CourseMarket}");
    }
}
