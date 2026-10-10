using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Maui.Controls;

namespace MauiApp1.PageModels
{
    public partial class BenchmarkDashboardPageModel : ObservableObject
    {
        [ObservableProperty]
        private List<BenchmarkCategoryData> _benchmarkBreakdown = [];

        [ObservableProperty]
        private List<Brush> _categoryPalette = [];

        [ObservableProperty]
        private List<BenchmarkModel> _featuredBenchmarks = [];

        [ObservableProperty]
        private List<BenchmarkModel> _leaderboardBenchmarks = [];

        [ObservableProperty]
        private int _totalTrackedModels;

        [ObservableProperty]
        private double _averageModelScore;

        [ObservableProperty]
        private double _averageSystemLatencyMs;

        public BenchmarkDashboardPageModel()
        {
            BenchmarkBreakdown =
            [
                new() { Title = "LLM", Count = 42 },
                new() { Title = "Vision", Count = 24 },
                new() { Title = "Code", Count = 18 },
                new() { Title = "Multimodal", Count = 12 },
                new() { Title = "Edge", Count = 8 }
            ];

            CategoryPalette =
            [
                new SolidColorBrush(Color.FromArgb("#7DD3FC")),
                new SolidColorBrush(Color.FromArgb("#A78BFA")),
                new SolidColorBrush(Color.FromArgb("#34D399")),
                new SolidColorBrush(Color.FromArgb("#F9A8D4")),
                new SolidColorBrush(Color.FromArgb("#FBBF24"))
            ];

            FeaturedBenchmarks =
            [
                new() { Name = "Halo-Flow 7B", Vendor = "Halo Labs", Category = "LLM", Score = 96.4, LatencyMs = 118, Tag = "HOT", AccentHex = "#7DD3FC" },
                new() { Name = "Vision-Lite", Vendor = "Windows Zenith", Category = "Vision", Score = 93.1, LatencyMs = 144, Tag = "NEW", AccentHex = "#A78BFA" },
                new() { Name = "CodeForge", Vendor = "DevCore", Category = "Code", Score = 92.7, LatencyMs = 132, Tag = "TOP", AccentHex = "#34D399" }
            ];

            LeaderboardBenchmarks =
            [
                new() { Name = "Halo-Flow 7B", Vendor = "Halo Labs", Category = "LLM", Score = 96.4, LatencyMs = 118, Tag = "#1", AccentHex = "#7DD3FC" },
                new() { Name = "Vision-Lite", Vendor = "Windows Zenith", Category = "Vision", Score = 93.1, LatencyMs = 144, Tag = "#2", AccentHex = "#A78BFA" },
                new() { Name = "CodeForge", Vendor = "DevCore", Category = "Code", Score = 92.7, LatencyMs = 132, Tag = "#3", AccentHex = "#34D399" },
                new() { Name = "EdgePeak", Vendor = "SysForge", Category = "Edge", Score = 89.8, LatencyMs = 96, Tag = "#4", AccentHex = "#F9A8D4" }
            ];

            TotalTrackedModels = 128;
            AverageModelScore = 94.6;
            AverageSystemLatencyMs = 132;
        }
    }

    public class BenchmarkCategoryData
    {
        public string Title { get; set; } = string.Empty;
        public int Count { get; set; }
    }

    public class BenchmarkModel
    {
        public string Name { get; set; } = string.Empty;
        public string Vendor { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public double Score { get; set; }
        public double LatencyMs { get; set; }
        public string Tag { get; set; } = string.Empty;
        public string AccentHex { get; set; } = "#7DD3FC";
        public Color Accent => Color.FromArgb(AccentHex);
    }
}
