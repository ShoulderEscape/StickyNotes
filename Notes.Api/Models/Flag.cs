namespace Notes.Api.Models;

public enum Flag
{
    UNKNOWN = 0,
    SENSITIVE_DATA_EXPOSURE = 1,
    BROKEN_ACCESS_CONTROL = 2,
    CROSS_SITE_SCRIPTING = 3,
    SQL_INJECTION = 4,
    INSECURE_DESERIALIZATION = 5,
    VULNERABLE_AND_OUTDATED_COMPONENTS = 6,
}