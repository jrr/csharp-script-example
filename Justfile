# list available commands
help:
    @just --list

# format an internal ID for display
format-id value:
    @dotnet run Scripts/FormatId.cs format {{value}}

# parse a formatted ID back to its integer value
parse-id formatted:
    @dotnet run Scripts/FormatId.cs parse {{formatted}}
