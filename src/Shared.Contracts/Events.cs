namespace Shared.Contracts;

public record SubmissionCreatedEvent(
    Guid SubmissionId,
    Guid AssignmentId,
    string StudentId,
    string Content,
    DateTime SubmittedAtUtc,
    Guid CorrelationId
);

public record SubmissionGradedEvent(
    Guid SubmissionId,
    Guid AssignmentId,
    string StudentId,
    decimal Score,
    string Feedback,
    string Status,
    DateTime GradedAtUtc,
    Guid CorrelationId
);
