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

    public class FramePXXXXP : SubAssemblyBase
    {

        #region Fields

        //Constant Values

        const int panelCount = 4;
        const decimal faceCapX = 3.625m;
        const decimal facEndCap = 2.875m;
        const decimal facEndAcc = 2.9375m;
        const decimal stileOverLap = 2.5625m;
        const decimal stileOvrLpX2 = 2.0m * 2.5625m;
        const decimal stileOvrLpX3 = 3.0m * 2.5625m;
        const decimal doorGap = 0.25m;
        const decimal doorGap2X = 2.0m * 0.25m;
        const decimal edgeCap = 0.50m;
        const decimal jambReduce2X = 2.0m * 1.09375m;
        const decimal jambSplThick = 0.09375m;
        const decimal jambSplThickX2 = 2.0m * 0.09375m;
        const decimal jambAdd = 1.09375m;
        const decimal jambDimW = 1.4625m;
        const decimal jambDimW2X = 2.0m * 1.46875m;
        const decimal jambInset = 0.375m;
        const decimal jambInset2X = 2.0m * 0.375m;
        const decimal sillPanAdd2X = 2.0m * 2.0m;
        const decimal jambSpltRed = 0.1908m;
        const decimal spltHdRed = 6.5275m;
        const decimal faceMidoor = 1.65625m;
        const decimal faceXdoor = 4.1525m;
        const decimal notchHDPEadd = 4.0275m;
        const decimal headHDPEadd = 1.0m;
        const decimal reducHDPE = 0.75m;
        const decimal calkGap = 0.125m;
        const decimal trackAdd1 = 3.104625m;
        const decimal trackAdd2 = 6.28125m;
        const decimal trackRed = 2.0m;
        const decimal trackAdd3 = 1.9375m;


        //static int createID;

        #endregion

        #region Constructor

        public FramePXXXXP()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3210-FramePXXXXP";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            TrackHelper trackHelper = new TrackHelper(panelCount, m_subAssemblyWidth - stileOverLap - doorGap - jambReduce2X, 0);

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();

            #region TopTrack

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Top22mmTrackPXXXXP
            part = new Part(4447, "Top22mmTrackPXXXXP", this, 1, trackHelper.DoorPanelWidth * 6.0m - trackRed);
            part.PartGroupType = "TopTrack";
            part.PartLabel = "";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Top22mmTrackPX_
            part = new Part(4447, "Top22mmTrackPX_", this, 1, trackHelper.DoorPanelWidth * 2.0m + 1.9375m );
            part.PartGroupType = "TopTrack";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //Top22mmTrack_XP
            part = new Part(4447, "Top22mmTrack_XP", this, 1, trackHelper.DoorPanelWidth * 2.0m + 1.9375m );
            part.PartGroupType = "TopTrack";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region BotTrack

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //BotTrackPXXXXP
            part = new Part(4730, "BotTrackPXXXXP", this, 1, trackHelper.DoorPanelWidth * 6.0m - trackRed);
            part.PartGroupType = "BotTrack";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //BotTrackPX___
            part = new Part(4730, "BotTrackPX_XP", this, 1, trackHelper.DoorPanelWidth * 2.0m + trackAdd3 );
            part.PartGroupType = "BotTrack";
            part.PartLabel = "";
            m_parts.Add(part);

            //BotTrack___XP
            part = new Part(4730, "BotTrackPX_XP", this, 1, trackHelper.DoorPanelWidth * 2.0m + trackAdd3);
            part.PartGroupType = "BotTrack";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //BotTrackScreenPXXXXP
            part = new Part(4730, "BotTrackScreenPXXXXP", this, 1, trackHelper.DoorPanelWidth * 6.0m - trackRed);
            part.PartGroupType = "BotTrack";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //BotTrackScreenPX___
            part = new Part(4730, "BotTrackScreenPX___", this, 1, trackHelper.DoorPanelWidth * 2.0m + trackAdd3);
            part.PartGroupType = "BotTrack";
            part.PartLabel = "";
            m_parts.Add(part);

            //BotTrackScreen___XP
            part = new Part(4730, "BotTrackScreen___XP", this, 1, trackHelper.DoorPanelWidth * 2.0m + trackAdd3 );
            part.PartGroupType = "BotTrack";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region TrackCoverSS

            // TrackCoverSSPXXXXP
            part = new Part(4760, "TrackCoverSSPXXXXP", this, 1, trackHelper.DoorPanelWidth * 6.0m - trackRed);
            part.PartGroupType = "TrackCoverSS";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // TrackCoverSSPX___
            part = new Part(4760, "TrackCoverSSPX___", this, 1, trackHelper.DoorPanelWidth * 2.0m + trackAdd3);
            part.PartGroupType = "TrackCoverSS";
            part.PartLabel = "";
            m_parts.Add(part);

            // TrackCoverSS___XP
            part = new Part(4760, "TrackCoverSS___XP", this, 1, trackHelper.DoorPanelWidth * 2.0m  + trackAdd3);
            part.PartGroupType = "TrackCoverSS";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // TrackCvrSSScrnPXXXXP
            part = new Part(4760, "TrackCvrSSScrnPXXXXP", this, 1, trackHelper.DoorPanelWidth * 6.0m - trackRed);
            part.PartGroupType = "TrackCoverSS";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // TrackCvrSSScrnPX___
            part = new Part(4760, "TrackCvrSSScrnPX___", this, 1, trackHelper.DoorPanelWidth * 2.0m + trackAdd3);
            part.PartGroupType = "TrackCoverSS";
            part.PartLabel = "";
            m_parts.Add(part);

            // TrackCvrSSScrn___XP
            part = new Part(4760, "TrackCvrSSScrn___XP", this, 1, trackHelper.DoorPanelWidth * 2.0m + trackAdd3);
            part.PartGroupType = "TrackCoverSS";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region 316StainlessPan

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // 316_14gaAnglePan
            part = new Part(316, "316_14gaAnglePan", this, 1, trackHelper.DoorPanelWidth * 6.0m + doorGap - stileOvrLpX2 - jambInset2X + sillPanAdd2X);
            part.PartGroupType = "316StainlessPan";
            part.PartLabel = "PXXXXP";
            part.PartThick = 0.875m;
            part.PartWidth = 7.25m;
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region 464SheetMetal

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // ACRE_SMBackerP_XX_P
            part = new Part(4000, "ACRE_SMBackerP_XX_P", this, 1, trackHelper.DoorPanelWidth * 2.0m + doorGap - stileOvrLpX2 - 3.0m * edgeCap);
            part.PartGroupType = "464SheetMetal";
            part.PartLabel = "B-27";
            part.PartThick = 0.75m;
            part.PartWidth = 3.2088m;
            m_parts.Add(part);

            // 464HdChlP_XX_P
            part = new Part(299, "464HdChlP_XX_P", this, 1, trackHelper.DoorPanelWidth * 2.0m + doorGap - stileOvrLpX2 - 3.0m * edgeCap);
            part.PartGroupType = "464HeadChannel";
            part.PartLabel = "T-13";
            part.PartThick = 0.1563m;
            part.PartWidth = 3.2088m;
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // ACRE_SMBacker_PXXXXP
            part = new Part(4000, "ACRE_SMBacker_PXXXXP", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "464SheetMetal";
            part.PartLabel = "B-22";
            part.PartThick = 0.875m;
            part.PartWidth = 1.0166m;
            m_parts.Add(part);

            // 464SilChl_PXXXXP
            part = new Part(299, "464SilChl_PXXXXP", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "464SheetMetal";
            part.PartLabel = "T-11";
            part.PartThick = 0.875m;
            part.PartWidth = 1.1485m;
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // ACRE_SMBacker
            part = new Part(4000, "ACRE_SMBacker", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "464SheetMetal";
            part.PartLabel = "B-21";
            part.PartThick = 0.875m;
            part.PartWidth = 0.6645m;
            m_parts.Add(part);

            // 464SilChl_P_XX_P
            for (int i = 0; i < 2; i++)
            {
                part = new Part(299, "464SilChl_P_XX_P", this, 1, trackHelper.DoorPanelWidth + jambAdd + edgeCap);
                part.PartGroupType = "464SheetMetal";
                part.PartLabel = "T-10";
                part.PartThick = 0.3137m;
                part.PartWidth = 0.797m;
                m_parts.Add(part);
            }
        
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // ACRE_SMBacker
            part = new Part(4000, "ACRE_SMBacker", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "464SheetMetal";
            part.PartLabel = "B-3";
            part.PartThick = 0.875m;
            part.PartWidth = 0.9776m;
            m_parts.Add(part);

            // 464SilChl_P_XX_P
            for (int i = 0; i < 2; i++)
            {
                part = new Part(299, "464SilChl_P_XX_P", this, 1, trackHelper.DoorPanelWidth + jambAdd + edgeCap);
                part.PartGroupType = "464SheetMetal";
                part.PartLabel = "T-3";
                part.PartThick = 0.3137m;
                part.PartWidth = 1.1102m;
                m_parts.Add(part);
            }
        
            // 464SilChl_PX__XP
            part = new Part(299, "464SilChl_PX__XP", this, 1, trackHelper.DoorPanelWidth * 2.0m + doorGap - stileOvrLpX2 - 2.0m * edgeCap);
            part.PartGroupType = "464SheetMetal";
            part.PartLabel = "T-15";
            part.PartThick = 0.3137m;
            part.PartWidth = 4.5264m;
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // ACRE_SMBacker
            part = new Part(4000, "ACRE_SMBacker", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "464SheetMetal";
            part.PartLabel = "B-2";
            part.PartThick = 0.875m;
            part.PartWidth = 1.5807m;
            m_parts.Add(part);

            // 464SilChl_P_XX_P
            for (int i = 0; i < 2; i++)
            {
                part = new Part(299, "464SilChl_P_XX_P", this, 1, trackHelper.DoorPanelWidth + jambAdd + edgeCap);
                part.PartGroupType = "464SheetMetal";
                part.PartLabel = "T-2";
                part.PartThick = 0.3137m;
                part.PartWidth = 1.7133m;
                m_parts.Add(part);
            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            
            // ACRE_SMBacker
            part = new Part(4000, "ACRE_SMBacker", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "464SheetMetal";
            part.PartLabel = "B-1";
            part.PartThick = 0.875m;
            part.PartWidth = 0.7128m;
            m_parts.Add(part);

            // 464SilChl_PXXXXP
            part = new Part(299, "464SilChl_PXXXXP", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "464SheetMetal";
            part.PartLabel = "T-1";
            part.PartThick = 0.5625m;
            part.PartWidth = 0.9191m;
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Frame

            //////////////////////////////////////////////////////////////////////////////

            //BrzSplitJamb -->> 
            part = new Part(4891, "BrzSplitJamb", this, 1, m_subAssemblyHieght -jambSpltRed );
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

            //BrzSplitJamb -->> 
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

            //BrzSplitJamb <<-- 
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

            //BrzSplitJamb <<--
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

            ////////////////////////////////////////////////////////////////////////////////

            // BrzSplitHead ^^
            part = new Part(4891, "BrzSplitHead", this, 1, m_subAssemblyWidth - jambDimW2X);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region PocketCloseOut

            //////////////////////////////////////////////////////////////////////////////

            //AlumBar
            part = new Part(2556, "AlumBar", this, 6, 0.0m);
            part.PartGroupType = "PocketCloseOut";
            part.PartThick = 0.25m;
            part.PartWidth = 3.0m;
            part.PartLength = 3.5879m;
            part.PartLabel = "PXXXXP";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //ACRE_Closeout
            part = new Part(4000, "ACRE_Closeout", this, 1, m_subAssemblyHieght - faceMidoor);
            part.PartGroupType = "PocketCloseOut";
            part.PartThick = 1.3662m;
            part.PartWidth = 1.464m;
            part.PartLabel = "B-16";
            m_parts.Add(part);

            //ACRE_Closeout
            part = new Part(4000, "ACRE_Closeout", this, 1, m_subAssemblyHieght - faceMidoor);
            part.PartGroupType = "PocketCloseOut";
            part.PartThick = 1.3662m;
            part.PartWidth = 1.464m;
            part.PartLabel = "B-16";
            m_parts.Add(part);

            //ACRE_Closeout
            part = new Part(4000, "ACRE_Closeout", this, 1, m_subAssemblyHieght - faceMidoor);
            part.PartGroupType = "PocketCloseOut";
            part.PartThick = 0.75m;
            part.PartWidth = 3.6411m;
            part.PartLabel = "B-17";
            m_parts.Add(part);

            //ACRE_Closeout
            part = new Part(4000, "ACRE_Closeout", this, 1, m_subAssemblyHieght - faceMidoor);
            part.PartGroupType = "PocketCloseOut";
            part.PartThick = 0.75m;
            part.PartWidth = 3.6411m;
            part.PartLabel = "B-17";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //Brz18gaCloseout
            part = new Part(299, "Brz18gaCloseout", this, 1, m_subAssemblyHieght - faceMidoor);
            part.PartGroupType = "PocketCloseOut";
            part.PartThick = 0.55m;
            part.PartWidth = 2.3294m;
            part.PartLabel = "T-8";
            m_parts.Add(part);

            //Brz18gaCloseout
            part = new Part(299, "Brz18gaCloseout", this, 1, m_subAssemblyHieght - faceMidoor);
            part.PartGroupType = "PocketCloseOut";
            part.PartThick = 0.55m;
            part.PartWidth = 2.3294m;
            part.PartLabel = "T-8";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////
            
            //AlumBar
            part = new Part(2556, "AlumBar", this, 6, 0.0m);
            part.PartGroupType = "PocketCloseOut";
            part.PartThick = 0.25m;
            part.PartWidth = 3.0m;
            part.PartLength = 2.0902m;
            part.PartLabel = "PXXXXP";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // SCREEN CLOSE OUT
            // ACRE_Closeout
            part = new Part(4000, "ACRE_Closeout", this, 1, m_subAssemblyHieght - faceMidoor);
            part.PartGroupType = "PocketCloseOut";
            part.PartThick = 0.7045m;
            part.PartWidth = 0.6234m;
            part.PartLabel = "PS___P";
            m_parts.Add(part);

            // ACRE_Closeout
            part = new Part(4000, "ACRE_Closeout", this, 1, m_subAssemblyHieght - faceMidoor);
            part.PartGroupType = "PocketCloseOut";
            part.PartThick = 0.7045m;
            part.PartWidth = 0.6234m;
            part.PartLabel = "P___SP";
            m_parts.Add(part);

            // ACRE_Closeout
            part = new Part(4000, "ACRE_Closeout", this, 1, m_subAssemblyHieght - faceMidoor);
            part.PartGroupType = "PocketCloseOut";
            part.PartThick = 0.75m;
            part.PartWidth = 2.251m;
            part.PartLabel = "PS__P";
            m_parts.Add(part);

            // ACRE_Closeout
            part = new Part(4000, "ACRE_Closeout", this, 1, m_subAssemblyHieght - faceMidoor);
            part.PartGroupType = "PocketCloseOut";
            part.PartThick = 0.75m;
            part.PartWidth = 2.251m;
            part.PartLabel = "P___SP";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // SCREEN CLOSE OUT
            //Brz18gaCloseout
            part = new Part(299, "Brz18gaCloseout", this, 1, m_subAssemblyHieght - faceMidoor);
            part.PartGroupType = "ScreenCloseOut";
            part.PartThick = 0.063m;
            part.PartWidth = 2.2512m;
            part.PartLabel = "T-14";
            m_parts.Add(part);

            //Brz18gaCloseout
            part = new Part(299, "Brz18gaCloseout", this, 1, m_subAssemblyHieght - faceMidoor);
            part.PartGroupType = "ScreenCloseOut";
            part.PartThick = 0.063m;
            part.PartWidth = 2.2512m;
            part.PartLabel = "T-14";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Pile_Seals

            //////////////////////////////////////////////////////////////////////////////

            //Pile_Seals -->> 
            part = new Part(1032, "Pile_Seals", this, 4, m_subAssemblyHieght - jambSpltRed);
            part.PartGroupType = "Pile_Seals";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // Pile_Seals ^^
            part = new Part(1032, "Pile_Seals", this, 2, m_subAssemblyWidth - jambDimW2X);
            part.PartGroupType = "Pile_Seals";
            part.PartLabel = "";
            m_parts.Add(part);

            // Pile_Seals ^^
            part = new Part(979, "Pile_Seals", this, 2, trackHelper.DoorPanelWidth * 2.0m + doorGap - stileOvrLpX2 - 2.0m * edgeCap);
            part.PartGroupType = "Pile_Seals";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region ACRE_HD_JMB

            //////////////////////////////////////////////////////////////////////////////

            // ACRE_Head ^^
            part = new Part(4000, "ACRE_Head", this, 1, trackHelper.DoorPanelWidth * 6.0m - trackRed);
            part.PartGroupType = "ACRE_HD_JMB";
            part.PartLabel = "B-23";
            part.PartThick = 0.75m;
            part.PartWidth = 6.75m;
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region HDPE

            //////////////////////////////////////////////////////////////////////////////

            // HDPE_ScreenTrack ^^
            part = new Part(5296, "HDPE_ScreenTrack", this, 1, trackHelper.DoorPanelWidth * 6.0m - trackRed);
            part.PartGroupType = "HDPE_ScreenTrack";
            part.PartLabel = "B-5";
            part.PartThick = 0.73m;
            part.PartWidth = 0.625m;
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

        }

        #endregion

    }

}