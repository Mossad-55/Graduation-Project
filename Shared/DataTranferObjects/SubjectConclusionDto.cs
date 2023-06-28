namespace Shared.DataTranferObjects;

public record SubjectConclusionDto(string Date, IEnumerable<string> GoodConclusion, IEnumerable<string> BadConclusion);