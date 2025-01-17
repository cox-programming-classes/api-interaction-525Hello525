namespace CS8_MessageAPI.Services;

    public record AssessmentCalendar(
        String id,
        String type,
        String summary,
        String description,
        String start,
        String end,
        bool allday,
        String[] affectedClasses,
        bool? passUsed,
        bool? passAvailable

    );

    public record AssessmentDetails(
        String assesmentId,
        String displayName,
        String block,
        String assementDateTime,
        String Teacher,
        String[] Students,
        bool latePass,
        int conflictCount,
        bool redFlag
    );

