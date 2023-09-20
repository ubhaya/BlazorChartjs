﻿namespace PSC.Blazor.Components.Chartjs.Models.Bubble
{
    /// <summary>
    /// Bubble Coords
    /// </summary>
    public class BubbleCoords
    {
        /// <summary>
        /// Gets or sets the x.
        /// </summary>
        /// <value>
        /// The x.
        /// </value>
        [JsonPropertyName("x")]
        public float X { get; set; }
        /// <summary>
        /// Gets or sets the y.
        /// </summary>
        /// <value>
        /// The y.
        /// </value>
        [JsonPropertyName("y")]
        public float Y { get; set; }
        /// <summary>
        /// Gets or sets the r.
        /// </summary>
        /// <value>
        /// The r.
        /// </value>
        [JsonPropertyName("r")]
        public int R { get; set; }
    }
}
