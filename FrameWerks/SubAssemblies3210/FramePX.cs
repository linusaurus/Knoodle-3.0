#region Copyright (c) 2020 WeaselWare Software
/************************************************************************************
'
' Copyright  2020 WeaselWare Software 
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
' Portions Copyright 2020 WeaselWare Software
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
using System.Text;
using FrameWorks;

namespace FrameWorks.Makes.System3210
{

    public class FramePX : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        // The values we can change for different layouts
        const int panelCount = 1;

        const decimal AglORed = 3.2923m;
        const decimal stileOverLap = 2.5625m;
        const decimal stileOvrLpX2 = 2.0m * 2.5625m;
        const decimal stileOvrLpX3 = 3.0m * 2.5625m;
        const decimal doorGap = 0.25m;
        const decimal doorGap2X = 2.0m * 0.25m;
        const decimal jambInset = 0.375m;
        const decimal jambWide2X = 2.0m * 1.5m;
        const decimal doorEdgeJmb = 1.09375m;
        const decimal jambReduce2X = 2.0m * 1.09375m;
        const decimal jambSpltRed = 0.1908m;
        const decimal jambSplThick = 0.09375m;
        const decimal jambSplThickX2 = 2.0m * 0.09375m;
        const decimal jambDimW = 1.46875m;
        const decimal jambDimW2X = 2.0m * 1.46875m;
        const decimal jambInsetX2 = 2.0m * 0.375m;
        const decimal sillPanAdd = 1.5m + 0.09375m;
        const decimal yTrackPocket = 4.50m;
        const decimal notchHDPEadd = 4.0275m;
        const decimal headHDPEadd = 1.0m;
        const decimal reducHDPE = 0.75m;
        const decimal calkGap = 0.125m;
        const decimal trackAdd3 = 1.9375m;



        //static int createID;

        #endregion

        #region Constructor

        public FramePX()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3210-FramePX";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            TrackHelper trackHelper = new TrackHelper(panelCount, m_subAssemblyWidth - jambReduce2X, 0);

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();

            #region TopTrack

            //////////////////////////////////////////////////////////////////////////////

            //Top22mmTrackPX
            part = new Part(4447, "Top22mmTrackPX", this, 1, trackHelper.DoorPanelWidth * 2.0m + 0.3125m);
            part.PartGroupType = "TopTrack";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region BotTrack

            //////////////////////////////////////////////////////////////////////////////

            //BotTrack
            part = new Part(4730, "BotTrack", this, 1, trackHelper.DoorPanelWidth * 2.0m + trackAdd3);
            part.PartGroupType = "BotTrack";
            part.PartLabel = "";
            m_parts.Add(part);

            //BotTrackScreen
            part = new Part(4730, "BotTrackScreen", this, 1, trackHelper.DoorPanelWidth * 2.0m + trackAdd3);
            part.PartGroupType = "BotTrack";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region TrackCoverSS

            //////////////////////////////////////////////////////////////////////////////

            // TrackCoverSS_PX
            part = new Part(4760, "TrackCoverSS_PX", this, 1, trackHelper.DoorPanelWidth * 2.0m + trackAdd3);
            part.PartGroupType = "TrackCoverSS";
            part.PartLabel = "";
            m_parts.Add(part);

            // TrackCvrSSScrn_PXS
            part = new Part(4760, "TrackCvrSSScrn_PXS", this, 1, trackHelper.DoorPanelWidth * 2.0m + trackAdd3);
            part.PartGroupType = "TrackCoverSS";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region 316StainlessPan

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // 316_14gaAnglePan
            part = new Part(316, "316_14gaAnglePan", this, 1, trackHelper.DoorPanelWidth * 2.0m - jambInset + doorEdgeJmb + sillPanAdd);
            part.PartGroupType = "316StainlessPan";
            part.PartLabel = "PX";
            part.PartThick = 0.875m;
            part.PartWidth = 3.375m;
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region 464SheetMetal

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // ACRE_SMBacker
            part = new Part(4000, "ACRE_SMBacker", this, 1, m_subAssemblyWidth - jambSplThick);
            part.PartGroupType = "464SheetMetal";
            part.PartLabel = "B-4";
            part.PartThick = 0.875m;
            part.PartWidth = 0.5166m;
            m_parts.Add(part);

            // 464SilChl_PX
            part = new Part(299, "464SilChl_PX", this, 1, m_subAssemblyWidth - jambSplThick);
            part.PartGroupType = "464SheetMetal";
            part.PartLabel = "T-4";
            part.PartThick = 0.875m;
            part.PartWidth = 0.6485m;
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // ACRE_SMBacker
            part = new Part(4000, "ACRE_SMBacker", this, 1, m_subAssemblyWidth - jambSplThick);
            part.PartGroupType = "464SheetMetal";
            part.PartLabel = "B-3";
            part.PartThick = 0.875m;
            part.PartWidth = 0.9776m;
            m_parts.Add(part);

            // 464SilChl_PX
            part = new Part(299, "464SilChl_PX", this, 1, m_subAssemblyWidth - jambSplThick);
            part.PartGroupType = "464SheetMetal";
            part.PartLabel = "T-3";
            part.PartThick = 0.3137m;
            part.PartWidth = 1.1102m;
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // ACRE_SMBacker -->>
            part = new Part(4000, "ACRE_SMBacker", this, 1, m_subAssemblyWidth - jambSplThick);
            part.PartGroupType = "464SheetMetal";
            part.PartLabel = "B-1";
            part.PartThick = 0.875m;
            part.PartWidth = 0.7128m;
            m_parts.Add(part);

            // 464SilChl_PX
            part = new Part(299, "464SilChl_PX", this, 1, m_subAssemblyWidth - jambSplThick);
            part.PartGroupType = "464SheetMetal";
            part.PartLabel = "T-1";
            part.PartThick = 0.5625m;
            part.PartWidth = 0.9191m;
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // ACRE_SMBacker -->>
            part = new Part(4000, "ACRE_SMBacker", this, 1, m_subAssemblyHieght - reducHDPE);
            part.PartGroupType = "464SheetMetal";
            part.PartLabel = "B-8";
            part.PartThick = 0.575m;
            part.PartWidth = 1.2926m;
            m_parts.Add(part);

            // 464SilChl_PX
            part = new Part(299, "464SilChl_PX", this, 1, m_subAssemblyWidth - reducHDPE);
            part.PartGroupType = "464SheetMetal";
            part.PartLabel = "T-6";
            part.PartThick = 0.4063m;
            part.PartWidth = 1.2301m;
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Frame

            //////////////////////////////////////////////////////////////////////////////

            // BrzSplitJamb -->> 
            part = new Part(4891, "BrzSplitJamb", this, 1, m_subAssemblyHieght - jambSpltRed);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // BrzSplitJamb -->> 
            part = new Part(4891, "BrzSplitJamb", this, 1, m_subAssemblyHieght - jambSpltRed);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // BrzSplitJamb <<--
            part = new Part(4891, "BrzSplitJamb", this, 1, m_subAssemblyHieght - jambSpltRed);
            part.PartGroupType = "Frame";
            part.PartLabel = "MOD";
            m_parts.Add(part);

            // 464SplitJmb_Angle -->> 
            part = new Part(299, "464SplitJmb_Angle", this, 1, m_subAssemblyHieght - jambSpltRed);
            part.PartGroupType = "Frame";
            part.PartLabel = "T-9";
            part.PartThick = 0.75m;
            part.PartWidth = 1.50m;
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // BrzSplitJamb <<-- 
            part = new Part(4891, "BrzSplitJamb", this, 1, m_subAssemblyHieght - jambSpltRed);
            part.PartGroupType = "Frame";
            part.PartLabel = "MOD";
            m_parts.Add(part);

            // 464SplitJmb_Angle -->> 
            part = new Part(299, "464SplitJmb_Angle", this, 1, m_subAssemblyHieght - jambSpltRed);
            part.PartGroupType = "Frame";
            part.PartLabel = "T-9";
            part.PartThick = 0.75m;
            part.PartWidth = 1.50m;
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // BrzSplitHead ^^
            part = new Part(4891, "BrzSplitHead", this, 1, m_subAssemblyWidth - jambDimW2X);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // BrzSplitHead ^^
            part = new Part(4891, "BrzSplitHead", this, 1, m_subAssemblyWidth - jambDimW2X);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Pile_Seals

            //////////////////////////////////////////////////////////////////////////////

            //Pile_Seals -->> 
            part = new Part(1032, "Pile_Seals", this, 3, m_subAssemblyHieght - jambSpltRed);
            part.PartGroupType = "Pile_Seals";
            part.PartLabel = "";
            m_parts.Add(part);


            //Pile_Seals -->> 
            part = new Part(979, "Pile_Seals", this, 1, m_subAssemblyHieght - jambSpltRed);
            part.PartGroupType = "Pile_Seals";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // Pile_Seals ^^
            part = new Part(1032, "Pile_Seals", this, 2, m_subAssemblyWidth - jambWide2X);
            part.PartGroupType = "Pile_Seals";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region ACRE_HD_JMB

            //////////////////////////////////////////////////////////////////////////////

            // HDPEHead ^^
            part = new Part(4000, "ACRE_Head", this, 1, trackHelper.DoorPanelWidth * 2.0m + trackAdd3);
            part.PartGroupType = "ACRE_HD_JMB";
            part.PartLabel = "B-19";
            part.PartThick = 0.75m;
            part.PartWidth = 3.3338m;
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // HDPE_Jamb
            part = new Part(4000, "HDPE_Jamb", this, 1, m_subAssemblyHieght - reducHDPE);
            part.PartGroupType = "ACRE_HD_JMB";
            part.PartLabel = "B-18";
            part.PartThick = 0.75m;
            part.PartWidth = 3.3338m;
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region HDPE

            //////////////////////////////////////////////////////////////////////////////

            // HDPE_JmbGuide
            part = new Part(5296, "HDPE_JmbGuide", this, 1, m_subAssemblyHieght - reducHDPE);
            part.PartGroupType = "HDPE_HD_JMB";
            part.PartLabel = "B-6";
            part.PartThick = 0.5625m;
            part.PartWidth = 0.8494m;
            m_parts.Add(part);

            // HDPE_ScreenTrack ^^
            part = new Part(5296, "HDPE_ScreenTrack", this, 1, trackHelper.DoorPanelWidth * 2.0m + trackAdd3);
            part.PartGroupType = "HDPE_ScreenTrack";
            part.PartLabel = "B-5";
            part.PartThick = 0.75m;
            part.PartWidth = 0.625m;
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

        }

        #endregion

    }

}