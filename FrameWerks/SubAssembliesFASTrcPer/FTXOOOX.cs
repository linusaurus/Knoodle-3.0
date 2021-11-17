#region Copyright (c) 2018 WeaselWare Software
/************************************************************************************
'
' Copyright  2018 WeaselWare Software 
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
' Portions Copyright 2018 WeaselWare Software
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
    class FTXOOOX : SubAssemblyBase
    {

        #region Fields

        // The values we can change for different layouts
        const int panelCount = 5;
        const decimal stileWidth = 2.5625m;
        const decimal stileOvrLpX4 = 4.0m * 2.5625m;
        const decimal scrnPocAddX2 = 2.0m * 51.375m;
        const decimal brzPanlAdd = 2.3125m;
        const decimal centGapHlf = 0.25m / 2.0m;

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        #endregion

        #region Math Functions

        #endregion

        #region Constructor

        public FTXOOOX()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "LiftSlide-FTXOOOX";
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

            //BladePXOOOXP
            for (int i = 0; i < 1; i++)
            {
                part = new Part(3444, "BladePXOOOXP", this, 1,  (trackHelper.DoorPanelWidth * 5.0m) - stileOvrLpX4 + scrnPocAddX2 );
                part.PartGroupType = "BladeSS";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////

            // Blade___O_O___
            for (int i = 0; i < 2; i++)
            {
                part = new Part(3444, "Blade___O_O___", this, 1, trackHelper.DoorPanelWidth );
                part.PartGroupType = "BladeSS";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////

            // BladeBP_____BP
            for (int i = 0; i < 2; i++)
            {
                part = new Part(3444, "BladeBP_____BP", this, 1, trackHelper.DoorPanelWidth + brzPanlAdd);
                part.PartGroupType = "BladeSS";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region PerfecTack

            //////////////////////////////////////////////////////////////////////////////////////////////////

            //PerfecT_PXOOOXP
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4424, "PerfecT_PXOOOXP", this, 1, (trackHelper.DoorPanelWidth * 5.0m) - stileOvrLpX4 + scrnPocAddX2);
                part.PartGroupType = "PerfecTack";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////

            //PerfecT___O_O___
            for (int i = 0; i < 4; i++)
            {
                part = new Part(4424, "PerfecT___O_O___", this, 1, trackHelper.DoorPanelWidth);
                part.PartGroupType = "PerfecTack";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////

            //PerfecT_BP_____BP
            for (int i = 0; i < 4; i++)
            {
                part = new Part(4424, "PerfecT_BP_____BP", this, 1, trackHelper.DoorPanelWidth + brzPanlAdd);
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

            //BridgeAssemble

            //Bridge1
            for (int i = 0; i < 9; i++)
            {
                part = new Part(3445, "Bridge1", this, 1, 0.0m);
                part.PartGroupType = "BridgeAssemble-Parts";
                part.PartLabel = "";
                part.PartLength = 2.125m;
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////

            //BridgeClipDuelEnd
            for (int i = 0; i < 9; i++)
            {
                part = new Part(5434, "ClipDuelEnd", this, 1, 0.0m);
                part.PartGroupType = "BridgeAssemble-Parts";
                part.PartLabel = "";
                part.PartLength = 4.125m;
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////


            //Bridge2
            for (int i = 0; i < 12; i++)
            {
                part = new Part(3445, "Bridge2", this, 1, 0.0m  );
                part.PartGroupType = "BridgeAssemble-Parts";
                part.PartLabel = "";
                part.PartLength = 5.0m;
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////

            //BridgeClips

            for (int i = 0; i < 24; i++)
            {
                part = new Part(3446, "BridgeClips", this, 1, 0.0m);
                part.PartGroupType = "BridgeAssemble-Parts";
                part.PartLabel = "";
                part.PartLength = 2.7m;
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////

            //TrackClips

            for (int i = 0; i < 42; i++)
            {
                part = new Part(3447, "TrackClips", this, 1, 0.0m);
                part.PartGroupType = "BridgeAssemble";
                part.PartLabel = "";
                part.PartLength = 1.0m;
                part.PartWidth = 0.916m;
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 1; i < panelCount + 1; i++)
            {
                //Bridge
                //if (i > 1)
                //{
                    //decimal waste = decimal.Zero;
                    //for (int j = 1; j < trackHelper.BridgeCount + 2; j++)
                    //{
                        //part = new Part(3445, "Bridge", this, 1, bridgeGenie.result[i - 1]);
                        //part.PartGroupType = "BridgeAssemble";
                        //part.PartLabel = "";
                        //m_parts.Add(part);
                        //waste += 0.125m;
                    //}
                    //part = new Part(3445, "Cutting Waste", this, 1, waste);
                   // m_parts.Add(part);
                //}

                //else
                //{
                    //decimal waste = decimal.Zero;
                    //for (int j = 1; j < trackHelper.BridgeCount + 1; j++)
                    //{
                        //part = new Part(3445, "Bridge", this, 1, bridgeGenie.result[i - 1]);
                        //part.PartGroupType = "BridgeAssemble";
                        //part.PartLabel = "";

                        //m_parts.Add(part);
                        //waste += 0.125m;
                   // }
                   // part = new Part(3445, "Cutting Waste", this, 1, waste);
                   // m_parts.Add(part);
               // }

                //BridgeClips
                //if (i > 1)
                //{
                    //part = new Part(5432, "BridgeClips", this, trackHelper.BridgeCount * 2, 0.0m);
                    //part.PartGroupType = "BridgeAssemble";
                    //part.PartLabel = "";
                    //m_parts.Add(part);

                //}

                //else
                //{

                    //part = new Part(5432, "BridgeClips", this, trackHelper.BridgeCount * 2, 0.0m);
                    //part.PartGroupType = "BridgeAssemble";
                    //part.PartLabel = "";
                    //m_parts.Add(part);

                //}

                //TrackClips
                //part = new Part(3447, "TrackClips", this, trackHelper.BridgeCount * i * 2, 0.0m);
                //part.PartGroupType = "BridgeAssemble";
                //part.PartLabel = "";

                //m_parts.Add(part);

                //part = new Part(3449, "CapScrews", this, trackHelper.BridgeCount * i * 2, 0.0m);
                //part.PartGroupType = "BridgeAssemble";
                //part.PartLabel = "";

                //m_parts.Add(part);

                //NutPlateConnector

                //if (i > 1 && i != panelCount)
                //{
                    // your the second door but NOT second to last
                    //if (i >= 2 && i < (panelCount - 1))
                    //{
                        //part = new Part(5433, "NutPlateConnector", this, trackHelper.BridgeCount * (panelCount - 2), 0.0m);
                        //part.PartGroupType = "BridgeAssemble";
                        //part.PartLabel = "";

                        //m_parts.Add(part);
                    //}
                    // your the second door but ARE second to last
                    //else
                    //{
                        //part = new Part(5433, "NutPlateConnector", this, trackHelper.BridgeCount * (panelCount - 2), 0.0m);
                        //part.PartGroupType = "BridgeAssemble";
                        //part.PartLabel = "";

                       // m_parts.Add(part);

                    //}

                //}
            }

            #endregion

            //////////////////////////////////////////////

        }

        #endregion

    }

}
