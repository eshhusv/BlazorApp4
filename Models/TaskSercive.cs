using BlazorApp4.Components.Pages;

namespace BlazorApp4.Models
{
    public class TaskSercive
    {
        public int TaskId { get; set; }

        public string? TaskName { get; set; }

        public int TaskNavigationCustomerId { get; set; }

        public int ExecutorId { get; set; }
    }
}