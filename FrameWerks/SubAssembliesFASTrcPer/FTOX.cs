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
    class FTOX : SubAssemblyBase
    {

        #region Fields

        // The values we can change for different layouts
        const int panelCount = 2;
        const decimal stileWidth = 1.34375m;
        const decimal stileOverLap = 1.34375m;
        const decimal stileCut = 0.46875m;
        const decimal bladeAdd = 1.0m;
        const decimal bladeAddX2 = 2.0m * 1.0m;

        private decimal waste = decimal.Zero;

        #endregion

        #region Math Functions




        #endregion

        #region Constructor

        public FTOX()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "LiftSlide-FTOX";
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

            //////////////////////////////////////////////////////////////////////////////////////////////////

            //BladeO
            part = new Part(3444, "BladeO", this, 1, (trackHelper.DoorPanelWidth + bladeAdd));
            part.PartGroupType = "BladeSS-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////

            // BladeOX
            part = new Part(3444, "BladeOX", this, 1, (trackHelper.DoorPanelWidth * 2.0m - stileOverLap + bladeAddX2));
            part.PartGroupType = "BladeSS-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region PerfecTack

            //////////////////////////////////////////////////////////////////////////////////////////////////

            //PerfecT_O
            part = new Part(4424, "PerfecT_O", this, 2, (trackHelper.DoorPanelWidth + bladeAdd));
            part.PartGroupType = "PerfecTack";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////

            // PerfecT_OX
            part = new Part(4424, "PerfecT_OX", this, 2, (trackHelper.DoorPanelWidth * 2.0m - stileOverLap + bladeAddX2));
            part.PartGroupType = "PerfecTack";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////

            // Cross_Gutter
            for (int i = 0; i < panelCount - 1.0m; i++)
            {
                part = new Part(5579, "Cross_Gutter", this, 1, 2.83m);
                part.PartGroupType = "PerfecTack";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////

            // End_Cap_Gutter
            for (int i = 0; i < panelCount * 2.0m; i++)
            {
                part = new Part(5593, "End_Cap_Gutter", this, 1, 1.25m);
                part.PartGroupType = "PerfecTack";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            //////////////////////////////////////////////

            #region Cross_Gutter

            //////////////////////////////////////////////////////////////////////////////////////////////////

            // Cross_Gutter
            for (int i = 0; i < panelCount - 1.0m; i++)
            {
                part = new Part(5579, "Cross_Gutter", this, 1, 2.83m);
                part.PartGroupType = "Cross_Gutter";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region PVC_Drains

            //////////////////////////////////////////////////////////////////////////////////////////////////

            // PVC_90°Drain
            for (int i = 0; i < panelCount - 1; i++)
            {
                part = new Part(5634, "PVC_90°Drain", this, 1, 0.0m);
                part.PartGroupType = "PVC_Drains";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////

            // PVC_StrightDrain
            for (int i = 0; i < panelCount + 1; i++)
            {
                part = new Part(5633, "PVC_StrightDrain", this, 1, 0.0m);
                part.PartGroupType = "PVC_Drains";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region SS_Drains

            //////////////////////////////////////////////////////////////////////////////////////////////////

            //SS_Drains
            for (int i = 0; i < trackHelper.DrainCount; i++)
            {
                part = new Part(4465, "SS_Drains", this, 1, 0.0m);
                part.PartGroupType = "SS_Drains";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            //////////////////////////////////////////////

            #region BridgeAssemble

            //////////////////////////////////////////////////////////////////////////////////////////////////

            //Bridge
            for (int i = 1; i < panelCount + 1; i++)
            {                
                if (i > 1)
                {
                    decimal waste = decimal.Zero;
                    for (int j = 1; j < trackHelper.BridgeCount + 1; j++)
                    {
                        part = new Part(3445, "Bridge", this, 1, bridgeGenie.result[i - 1]);
                        part.PartGroupType = "BridgeAssemble";
                        part.PartLabel = "";
                        m_parts.Add(part);
                        waste += 0.125m;                     
                        m_parts.Add(part);

                //BridgeClips
                        part = new Part(bridgeGenie.Clips[i - 1], "Bridge Clips-" + j.ToString(), this, 1, 0.0m);                       
                        m_parts.Add(part);
                    }
                                     
                }

                //////////////////////////////////////////////////////////////////////////////////////////////////

                //Bridge
                else
                {
                    decimal waste = decimal.Zero;
                    for (int j = 1; j < trackHelper.BridgeCount + 1; j++)
                    {
                        part = new Part(3445, "Bridge", this, 1, bridgeGenie.result[i - 1]);
                        part.PartGroupType = "BridgeAssemble";
                        part.PartLabel = "";
                        m_parts.Add(part);
                        waste += 0.125m;

                 //BridgeClips
                        part = new Part(bridgeGenie.Clips[i - 1], "Bridge Clips-" + j.ToString(), this, 1, 0.0m);
                        m_parts.Add(part);
                    }
                }

                //////////////////////////////////////////////////////////////////////////////////////////////////
                
                //TrackBolts
                if (i > 1)
                {
                part = new Part(3451, "TrackBolts", this, trackHelper.BridgeCount * 2, 0.0m);
                part.PartGroupType = "BridgeAssemble";
                part.PartLabel = "";

                m_parts.Add(part);
                }
                else
                {
                part = new Part(3451, "TrackBolts", this, trackHelper.BridgeCount * 2, 0.0m);
                part.PartGroupType = "BridgeAssemble";
                part.PartLabel = "";
                m_parts.Add(part);
                }

                //////////////////////////////////////////////////////////////////////////////////////////////////

                //TrackClips
                part = new Part(3447, "TrackClips", this, trackHelper.BridgeCount * i * 2, 0.0m);
                part.PartGroupType = "BridgeAssemble";
                part.PartLabel = "";
                m_parts.Add(part);

                //////////////////////////////////////////////////////////////////////////////////////////////////

                //Cap Screws
                part = new Part(3449, "CapScrews", this, trackHelper.BridgeCount * i * 2, 0.0m);
                part.PartGroupType = "BridgeAssemble";
                part.PartLabel = "";
                m_parts.Add(part);

                //////////////////////////////////////////////////////////////////////////////////////////////////

                //FlangeNuts
                if (i > 1)
                {
                    part = new Part(3450, "FlangeNuts", this, trackHelper.BridgeCount * 4, 0.0m);
                    part.PartGroupType = "BridgeAssemble";
                    part.PartLabel = "";
                    m_parts.Add(part);
                }
                else
                {
                    part = new Part(3450, "FlangeNuts", this, trackHelper.BridgeCount * 4, 0.0m);
                    part.PartGroupType = "BridgeAssemble";
                    part.PartLabel = "";
                    m_parts.Add(part);
                }

                // Cutting Waste
                part = new Part(3445, "Cutting Waste", this, 1, waste);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////

        #endregion

        //////////////////////////////////////////////

    }

}

        #endregion


