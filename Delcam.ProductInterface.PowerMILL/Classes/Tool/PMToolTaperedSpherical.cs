// **********************************************************************
// *         � COPYRIGHT 2024 Autodesk, Inc.All Rights Reserved         *
// *                                                                    *
// *  Use of this software is subject to the terms of the Autodesk      *
// *  license agreement provided at the time of installation            *
// *  or download, or which otherwise accompanies this software         *
// *  in either electronic or hard copy form.                           *
// **********************************************************************

using System;
using Autodesk.Geometry;

namespace Autodesk.ProductInterface.PowerMILL
{
    /// <summary>
    /// Represents a tapered spherical tool in PowerMill.
    /// </summary>
    /// <remarks></remarks>
    public class PMToolTaperedSpherical : PMTool
    {
        #region Constructors

        /// <summary>
        /// Initialises the item.
        /// </summary>
        /// <param name="powerMILL">The base instance to interact with PowerMILL.</param>
        internal PMToolTaperedSpherical(PMAutomation powerMILL) : base(powerMILL)
        {
        }

        /// <summary>
        /// Initialises the item.
        /// </summary>
        /// <param name="powerMILL">The base instance to interact with PowerMILL.</param>
        /// <param name="name">The new instance name.</param>
        internal PMToolTaperedSpherical(PMAutomation powerMILL, string name) : base(powerMILL, name)
        {
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets and sets the tip radius of a Tapered Spherical tool.
        /// </summary>
        public MM TipRadius
        {
            get
            {
                return
                    Convert.ToDouble(
                        PowerMill.GetPowerMillEntityParameter("tool", Name, "tipradius").Trim());
            }
            set { PowerMill.DoCommand("EDIT TOOL \"" + Name + "\" TIPRADIUS \"" + value + "\"", "TOOL ACCEPT"); }
        }

        /// <summary>
        /// Gets and sets the taper angle of a Tapered Spherical tool.
        /// </summary>
        public Degree TaperAngle
        {
            get
            {
                return
                    Convert.ToDouble(
                        PowerMill.GetPowerMillEntityParameter("tool", Name, "taperangle").Trim());
            }
            set { PowerMill.DoCommand("EDIT TOOL \"" + Name + "\" TAPERANGLE \"" + value + "\"", "TOOL ACCEPT"); }
        }

        #endregion
    }
}