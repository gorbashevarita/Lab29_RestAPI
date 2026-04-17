namespace TaskApi.Models;

public class UpdateTaskDto {
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public bool IsComleted { get; set; }
    public string Priority { get; set; } = "Normal";
}