﻿#region Copyright (c) 2017 WeaselWare Software
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
    class FTPXS : SubAssemblyBase
    {

        #region Fields

        // The values we can change for different layouts
        const int panelCount = 1;
        const decimal doorGap = 0.2500m;
        const decimal pocketInset = 0.375m;
        const decimal bladeAdd = 1.0m;

        //////////////////////////////////////////////////////////////////////////////////////////////////

        #endregion

        #region Math Functions


        #endregion

        #region Constructor

        public FTPXS()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "LiftSlide-FTPXS";
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

            // BladePX
            part = new Part(3444, "BladePX", this, 1, (trackHelper.DoorPanelWidth * 2.0m) + bladeAdd);
            part.PartGroupType = "BladeSS";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////

            // BladePS
            part = new Part(3444, "BladePS", this, 1, (trackHelper.DoorPanelWidth * 2.0m) + bladeAdd);
            part.PartGroupType = "BladeSS";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region PerfecTack

            //////////////////////////////////////////////////////////////////////////////////////////////////

            //PerfecT_PX
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4424, "PerfecT_PX", this, 1, (trackHelper.DoorPanelWidth * 2.0m) - pocketInset + doorGap);
                part.PartGroupType = "PerfecTack";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////

            //PerfecT_PS
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4424, "PerfecT_PS", this, 1, (trackHelper.DoorPanelWidth * 2.0m) - pocketInset + doorGap);
                part.PartGroupType = "PerfecTack";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////

            // End_Cap_Gutter
            for (int i = 0; i < panelCount * 4.0m; i++)
            {
                part = new Part(5593, "End_Cap_Gutter", this, 1, 1.25m);
                part.PartGroupType = "PerfecTack";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            //////////////////////////////////////////////

            #region PVC_Pocket_Drain

            //////////////////////////////////////////////////////////////////////////////////////////////////

            // PVC_Pocket_Drain
            for (int i = 0; i < 1; i++)
            {
                part = new Part(5628, "PVC_Pocket_Drain", this, 1, 0.0m);
                part.PartGroupType = "PVC_Pocket_Drain-Parts";
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
                    }
                    part = new Part(3445, "Cutting Waste", this, 1, waste);
                    m_parts.Add(part);
                }
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
                    }
                    part = new Part(3445, "Cutting Waste", this, 1, waste);
                    m_parts.Add(part);
                }
               
                //BridgeClips
                if (i > 1)
                {
                    part = new Part(5432, "BridgeClips", this, trackHelper.BridgeCount * 2, 0.0m);
                    part.PartGroupType = "BridgeAssemble";
                    part.PartLabel = "";
                    m_parts.Add(part);
                }
                else
                {
                    part = new Part(5432, "BridgeClips", this, trackHelper.BridgeCount * 2, 0.0m);
                    part.PartGroupType = "BridgeAssemble";
                    part.PartLabel = "";
                    m_parts.Add(part);
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

                // CapScrews
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

                //////////////////////////////////////////////////////////////////////////////////////////////////

                //NutPlateConnector
                if (i > 1 && i != panelCount)
                {
                    // your the second door but NOT second to last
                    if (i >= 2 && i < (panelCount - 1))
                    {
                        part = new Part(5433, "NutPlateConnector", this, trackHelper.BridgeCount * (panelCount - 2), 0.0m);
                        part.PartGroupType = "BridgeAssemble";
                        part.PartLabel = "";
                        m_parts.Add(part);
                    }
                    // your the second door but ARE second to last
                    else
                    {
                        part = new Part(5433, "NutPlateConnector", this, trackHelper.BridgeCount * (panelCount - 2), 0.0m);
                        part.PartGroupType = "BridgeAssemble";
                        part.PartLabel = "";
                        m_parts.Add(part);
                    }

                }

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region PocBrdgAssY

            //////////////////////////////////////////////////////////////////////////////////////////////////

            //Bridge
            decimal CutWaste = decimal.Zero;
            for (int j = 1; j < trackHelper.BridgeCount + 1; j++)
            {
                part = new Part(3445, "BridgePoc", this, 1, bridgeGenie.result[panelCount - 1]);
                part.PartGroupType = "PocBrdgAssY";
                part.PartLabel = "";
                m_parts.Add(part);
                CutWaste += 0.125m;
            }
            part = new Part(3445, "CutPocWaste", this, 1, CutWaste);
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////

            //BridgeClips
            part = new Part(5432, "BridgeClipsPoc", this, trackHelper.BridgeCount * 2, 0.0m);
            part.PartGroupType = "PocBrdgAssY";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////

            //TrackClips
            part = new Part(3447, "TrackClipsPoc", this, trackHelper.BridgeCount * panelCount * 2, 0.0m);
            part.PartGroupType = "PocBrdgAssY";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////

            //NutPlateConnector
            // your the second door but NOT second to last

            part = new Part(5433, "NutPlateConPoc", this, (trackHelper.BridgeCount) * (panelCount - 2), 0.0m);
            part.PartGroupType = "PocBrdgAssY";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////

            //CapScrews
            part = new Part(3449, "CapScrewsPoc", this, trackHelper.BridgeCount * panelCount * 2, 0.0m);
            part.PartGroupType = "PocBrdgAssY";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////

            //FlangeNuts
            part = new Part(3450, "FlangeNutsPoc", this, trackHelper.BridgeCount * 4, 0.0m);
            part.PartGroupType = "PocBrdgAssY";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////

            //TrackBolts
            part = new Part(3451, "TrackBoltsPoc", this, trackHelper.BridgeCount * 2, 0.0m);
            part.PartGroupType = "PocBrdgAssY";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            //////////////////////////////////////////////

        }

    }

        #endregion

}

