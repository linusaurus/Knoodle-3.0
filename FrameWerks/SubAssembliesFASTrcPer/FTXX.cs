#region Copyright (c) 2017 WeaselWare Software
/************************************************************************************
'
' Copyright  2017 WeaselWare Software 
'
' This software is provided 'as-is', without any express or implied warranty. In no 
' event will the authors be held liable for any damages arising from the use of this 
' software.
' 
' Permission is granted to anyone to use this software for any purpose, including 
' commercial applications, and to alter it and redistribute it freely, subject to the 
' following restrictions:
'
' 1. The origin of this software must not be misrepresented; you must not claim that 
' you wrote the original software. If you use this software in a product, an 
' acknowledgment (see the following) in the product documentation is required.
'
' Portions Copyright 2017 WeaselWare Software
'
' 2. Altered source versions must be plainly marked as such, and must not be 
' misrepresented as being the original software.
'
' 3. This notice may not be removed or altered from any source distribution.
'
'***********************************************************************************/
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrameWorks;

namespace FrameWorks.Makes.SubAssembliesFASTrcPerft
{
    class FTXX : SubAssemblyBase
    {

        #region Fields

        // The values we can change for different layouts
        const int panelCount = 2;
        const decimal bladeAddX2 = 2.0m * 1.0m;
        const decimal bladeAdd = 1.0m;
        const decimal finWall = 0.25m;

        private decimal waste = decimal.Zero;

        #endregion

        #region Math Functions

        #endregion

        #region Constructor

        public FTXX()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "LiftSlide-FTXX";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            TrackHelper trackHelper = new TrackHelper(panelCount, m_subAssemblyWidth, 0);

            BridgeGenie bridgeGenie = new BridgeGenie(2.25m);

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();

            //////////////////////////////////////////////

            #region BladeSS

            //////////////////////////////////////////////////////////////////////////////

            //Blades1X
            part = new Part(3444, "Blades1X", this, 1, m_subAssemblyWidth + bladeAddX2);
            part.PartGroupType = "BladeSS";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // Blade2X
            part = new Part(3444, "Blade2X", this, 1, m_subAssemblyWidth + bladeAddX2);
            part.PartGroupType = "BladeSS";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region PerfecTack

            //////////////////////////////////////////////////////////////////////////////

            //PerfecT_1X
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4424, "PerfecT_1X", this, 1, m_subAssemblyWidth + bladeAddX2);
                part.PartGroupType = "PerfecTack";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            // PerfecT_2X
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4424, "PerfecT_2X", this, 1, m_subAssemblyWidth + bladeAddX2);
                part.PartGroupType = "PerfecTack";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            // End_Cap_Gutter
            for (int i = 0; i < panelCount * 2.0m; i++)
            {
                part = new Part(5593, "End_Cap_Gutter", this, 1, 1.25m);
                part.PartGroupType = "PerfecTack";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            //////////////////////////////////////////////

            #region Cross_Gutter

            //////////////////////////////////////////////////////////////////////////////

            // Cross_Gutter
            for (int i = 0; i < panelCount - 1.0m; i++)
            {
                part = new Part(5579, "Cross_Gutter", this, 1, 2.83m);
                part.PartGroupType = "Cross_Gutter";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region PVC_Drains

            //////////////////////////////////////////////////////////////////////////////

            // PVC_90°Drain
            for (int i = 0; i < panelCount - 1; i++)
            {
                part = new Part(5634, "PVC_90°Drain", this, 1, 0.0m);
                part.PartGroupType = "PVC_Drains";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            // PVC_StrightDrain
            for (int i = 0; i < panelCount + 1; i++)
            {
                part = new Part(5633, "PVC_StrightDrain", this, 1, 0.0m);
                part.PartGroupType = "PVC_Drains";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region SS_Drains

            //////////////////////////////////////////////////////////////////////////////

            //SS_Drains
            for (int i = 0; i < trackHelper.DrainCount; i++)
            {
                part = new Part(4465, "SS_Drains", this, 1, 0.0m);
                part.PartGroupType = "SS_Drains-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            //////////////////////////////////////////////

            #region BridgeAssemble

            //BridgeAssemble

            //////////////////////////////////////////////////////////////////////////////

            //Bridge
            for (int i = 0; i < 2; i++)
            {
                part = new Part(3445, "Bridge", this, trackHelper.BridgeCount, 0.0m);
                part.PartGroupType = "BridgeAssemble";
                part.PartLabel = "";
                part.PartLength = 5.0m;
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            //Bridge Clips
            for (int i = 0; i < 2; i++)
            {
                part = new Part(5583, "Bridge Clips", this, trackHelper.BridgeCount, 0.0m);
                part.PartGroupType = "BridgeAssemble";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////            

            //TrackBolts

            part = new Part(3451, "TrackBolts", this, trackHelper.BridgeCount * 2, 0.0m);
            part.PartGroupType = "BridgeAssemble";
            part.PartLabel = "";

            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////

            //TrackClips
            part = new Part(3447, "TrackClips", this, trackHelper.BridgeCount * 2, 0.0m);
            part.PartGroupType = "BridgeAssemble";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //Cap Screws
            part = new Part(3449, "CapScrews", this, trackHelper.BridgeCount * 2, 0.0m);
            part.PartGroupType = "BridgeAssemble";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //Flange Nuts    
            part = new Part(3450, "FlangeNuts", this, trackHelper.BridgeCount * 4, 0.0m);
            part.PartGroupType = "BridgeAssemble";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //Cutting Waste
            part = new Part(3445, "Cutting Waste", this, 1, waste);

            //////////////////////////////////////////////////////////////////////////////

        }

    }

        #endregion

            //////////////////////////////////////////////
    }

        #endregion



