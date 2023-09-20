using PSC.Blazor.Components.Chartjs.Models.Bubble;

namespace ChartjsDemo.Data
{
    public static class BubbleDataExamples
    {
        public static List<string> SimpleBubbleText = new List<string>() { "First Dataset" };
        public static List<BubbleCoords> SimpleBubbleInt = new List<BubbleCoords>() {
            new BubbleCoords() { R = 15, X = 20, Y = 30 },
            new BubbleCoords() { R = 10, X = 40, Y = 10 },
            new BubbleCoords() { R = 14, X = 30, Y = 20 },
        };
        public static List<BubbleCoords> SimpleBubbleFloat = new List<BubbleCoords>() {
            new BubbleCoords() { R = 15, X = 20.5f, Y = 30.5f },
            new BubbleCoords() { R = 10, X = 40.8f, Y = 10.4f },
            new BubbleCoords() { R = 14, X = 30.4f, Y = 20.1f },
        };
    }
}