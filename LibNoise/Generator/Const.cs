﻿using System.ComponentModel;

namespace LibNoise.Generator
{
    /// <summary>
    /// Provides a noise module that outputs a constant value. [GENERATOR]
    /// </summary>
    public class Const : ModuleBase
    {
        #region Properties

        /// <summary>
        /// Gets or sets the constant value.
        /// </summary>
        [Category("Noise Settings")]
        [DisplayName("Value")]
        [Description("Generates an output value given the coordinates of the specified input value.")]
        [Editor("DoubleUpDownEditor", "DoubleUpDownEditor")]
        public double Value { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of Const.
        /// </summary>
        public Const()
            : base(0)
        {
        }

        /// <summary>
        /// Initializes a new instance of Const.
        /// </summary>
        /// <param name="value">The constant value.</param>
        public Const(double value)
            : base(0)
        {
            Value = value;
        }

        #endregion

        #region ModuleBase Members

        public override string GetDescription()
        {
            return "Noise module that outputs a constant value. This noise module is not useful by itself, but it is often used as a source module for other noise modules.";
        }

        /// <summary>
        /// Returns the output value for the given input coordinates.
        /// </summary>
        /// <param name="x">The input coordinate on the x-axis.</param>
        /// <param name="y">The input coordinate on the y-axis.</param>
        /// <param name="z">The input coordinate on the z-axis.</param>
        /// <returns>The resulting output value.</returns>
        public override double GetValue(double x, double y, double z, int scale)
        {
            return Value;
        }

        #endregion
    }
}