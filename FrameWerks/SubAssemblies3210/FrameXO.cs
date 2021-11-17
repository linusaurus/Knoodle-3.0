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

    public class FrameXO : SubAssemblyBase
    {

        #region Fields

        //Constant Values

        const int panelCount = 2;
        const decimal AglORed = 3.2923m;
        const decimal FaciaCap11 = 3.9508m;
        const decimal FaciaCap10 = 2.875m;
        const decimal FaciaCap9 = 2.9375m;
        const decimal stileOverLap = 2.5625m;
        const decimal stileOvrLpX2 = 2.0m * 2.5625m;
        const decimal stileOvrLpX3 = 3.0m * 2.5625m;
        const decimal doorGap = 0.25m;
        const decimal doorGap2X = 2.0m * 0.25m;
        const decimal jambGuide = 0.4375m;
        const decimal jambFinCap = 0.6266m;
        const decimal jambReduce = 0.84375m;
        const decimal jambReduce2X = 2.0m * 0.84375m;
        const decimal jambSplThickX2 = 2.0m * 0.09375m;
        const decimal jambSpltRed = 0.1908m;
        const decimal jambDimW = 1.5m;
        const decimal jambDimW2X = 2.0m * 1.46875m;
        const decimal jambInset = 0.375m;
        const decimal screenRed2X = 2.0m * 0.84375m;
        const decimal sillPanAdd2X = 2.0m * 0.09375m;
        const decimal yTrack = 2.0m;
        const decimal yTrAccess = 4.4798m;
        const decimal notchHDPEadd = 4.0275m;
        const decimal headHDPEadd = 1.0m;
        const decimal headHDPEadd2X = 1.0m * 2.0m;
        const decimal reducHDPE = 0.75m;
        const decimal calkGap = 0.125m;
        const decimal trackAddO = 1.25m;

        //static int createID;

        #endregion

        #region Constructor

        public FrameXO()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3210-FrameXO";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            TrackHelper trackHelper = new TrackHelper (panelCount, m_subAssemblyWidth - jambReduce2X - doorGap2X, 0);

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();

            #region TopTrack

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Top22mmTrack_X
            part = new Part(4447, "Top22mmTrack_X", this, 1, m_subAssemblyWidth - 1.375m  );
            part.PartGroupType = "TopTrack";
            part.PartLabel = "";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // Top22mmTrackO_
            part = new Part(4447, "Top22mmTrackO_", this, 1, trackHelper.DoorPanelWidth - calkGap);
            part.PartGroupType = "TopTrack";
            part.PartLabel = "";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region BotTrack

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // BotTrackX
            part = new Part(4730, "BotTrackX", this, 1, m_subAssemblyWidth - jambSplThickX2);
            part.PartGroupType = "BotTrack";
            part.PartLabel = "";
            m_parts.Add(part);

            // BotTrackO
            part = new Part(4730, "BotTrackO", this, 1, trackHelper.DoorPanelWidth + doorGap + trackAddO);
            part.PartGroupType = "BotTrack";
            part.PartLabel = "";
            m_parts.Add(part);

            // BotTrackScreenX
            part = new Part(4730, "BotTrackScreenX", this, 1, m_subAssemblyWidth - jambSplThickX2);
            part.PartGroupType = "BotTrack";
            part.PartLabel = "";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region TrackCoverSS

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // TrackCoverSSX
            part = new Part(4760, "TrackCoverSSX", this, 1, m_subAssemblyWidth - jambSplThickX2);
            part.PartGroupType = "TrackCoverSS";
            part.PartLabel = "";
            m_parts.Add(part);

            // TrackCoverSSO
            part = new Part(4760, "TrackCoverSSO", this, 1, trackHelper.DoorPanelWidth + doorGap + trackAddO);
            part.PartGroupType = "TrackCoverSS";
            part.PartLabel = "";
            m_parts.Add(part);

            // TrackCvrSSScrnX
            part = new Part(4760, "TrackCvrSSScrnX", this, 1, m_subAssemblyWidth - jambSplThickX2);
            part.PartGroupType = "TrackCoverSS";
            part.PartLabel = "";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region 316StainlessPan

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // 316_14gaAnglePan
            part = new Part(316, "316_14gaAnglePan", this, 1, m_subAssemblyWidth + sillPanAdd2X);
            part.PartGroupType = "316StainlessPan";
            part.PartLabel = "XO";
            part.PartThick = 0.875m;
            part.PartWidth = 5.50m;
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
          
            #endregion

            #region 464SheetMetal

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // ACRE_SMBacker
            part = new Part(4000, "ACRE_SMBacker", this, 1, m_subAssemblyWidth - trackHelper.DoorPanelWidth - 3.3125m );
            part.PartGroupType = "464SheetMetal";
            part.PartLabel = "B-25";
            part.PartThick = 0.75m;
            part.PartWidth = 1.9588m;
            m_parts.Add(part);

            // 464HdChl_OX
            part = new Part(299, "464HdChl_OX", this, 1, m_subAssemblyWidth - trackHelper.DoorPanelWidth - 3.3125m );
            part.PartGroupType = "464SheetMetal";
            part.PartLabel = "T-12";
            part.PartThick = 0.1563m;
            part.PartWidth = 1.9375m;
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // ACRE_SMBacker
            part = new Part(4000, "ACRE_SMBacker", this, 1, m_subAssemblyWidth - jambSplThickX2);
            part.PartGroupType = "464SheetMetal";
            part.PartLabel = "B-4";
            part.PartThick = 0.875m;
            part.PartWidth = 0.5166m;
            m_parts.Add(part);

            // 464SilChl_OX
            part = new Part(299, "464SilChl_OX", this, 1, m_subAssemblyWidth - jambSplThickX2);
            part.PartGroupType = "464SheetMetal";
            part.PartLabel = "T-4";
            part.PartThick = 0.875m;
            part.PartWidth = 0.6485m;
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // ACRE_SMBacker
            part = new Part(4000, "ACRE_SMBacker", this, 1, m_subAssemblyWidth + 1.5m);
            part.PartGroupType = "464SheetMetal";
            part.PartLabel = "B-3";
            part.PartThick = 0.875m;
            part.PartWidth = 0.9776m;
            m_parts.Add(part);

            // 464SilChl_OX
            part = new Part(299, "464SilChl_OX", this, 1, trackHelper.DoorPanelWidth + 1.5m);
            part.PartGroupType = "464SheetMetal";
            part.PartLabel = "T-3";
            part.PartThick = 0.3137m;
            part.PartWidth = 1.1102m;
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // ACRE_SMBacker
            part = new Part(4000, "ACRE_SMBacker", this, 1, trackHelper.DoorPanelWidth + 1.5m);
            part.PartGroupType = "464SheetMetal";
            part.PartLabel = "B-2";
            part.PartThick = 0.875m;
            part.PartWidth = 1.5807m;
            m_parts.Add(part);

            // 464SilChl_OX
            part = new Part(299, "464SilChl_OX", this, 1, trackHelper.DoorPanelWidth + 1.5m);
            part.PartGroupType = "464SheetMetal";
            part.PartLabel = "T-2";
            part.PartThick = 0.3137m;
            part.PartWidth = 1.7133m;
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // ACRE_SMBacker_OX
            part = new Part(4000, "ACRE_SMBacker_OX", this, 1, m_subAssemblyWidth - trackHelper.DoorPanelWidth - jambDimW - jambSplThickX2);
            part.PartGroupType = "464SheetMetal";
            part.PartLabel = "B-29";
            part.PartThick = 0.875m;
            part.PartWidth = 3.1438m;
            m_parts.Add(part);

            // 464SilChl_OX
            part = new Part(299, "464SilChl_OX", this, 1, m_subAssemblyWidth - trackHelper.DoorPanelWidth - jambDimW - jambSplThickX2);
            part.PartGroupType = "464SheetMetal";
            part.PartLabel = "T-16";
            part.PartThick = 0.3137m;
            part.PartWidth = 3.2764m;
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // ACRE_SMBacker -->>
            part = new Part(4000, "ACRE_SMBacker", this, 1, m_subAssemblyWidth - jambSplThickX2);
            part.PartGroupType = "464SheetMetal";
            part.PartLabel = "B-1";
            part.PartThick = 0.875m;
            part.PartWidth = 0.7128m;
            m_parts.Add(part);

            // 464SilChl_XO -->>
            part = new Part(299, "464SilChl_XO", this, 1, m_subAssemblyWidth - jambSplThickX2 );
            part.PartGroupType = "464SheetMetal";
            part.PartLabel = "T-1";
            part.PartThick = 0.5625m;
            part.PartWidth = 0.9191m;
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // ACRE_SMBacker -->>
            part = new Part(4000, "ACRE_SMBacker", this, 1, m_subAssemblyHieght - reducHDPE);
            part.PartGroupType = "464SheetMetal";
            part.PartLabel = "B-14";
            part.PartThick = 0.575m;
            part.PartWidth = 3.4588m;
            m_parts.Add(part);

            // 464_JambScrnChanl <<--
            part = new Part(299, "464_JambScrnChanl", this, 1, m_subAssemblyHieght - reducHDPE);
            part.PartGroupType = "464SheetMetal";
            part.PartLabel = "T-7";
            part.PartThick = 0.4063m;
            part.PartWidth = 3.3963m;
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // ACRE_SMBacker -->>
            part = new Part(4000, "ACRE_SMBacker", this, 1, m_subAssemblyHieght - reducHDPE);
            part.PartGroupType = "464SheetMetal";
            part.PartLabel = "B-8";
            part.PartThick = 0.575m;
            part.PartWidth = 1.2926m;
            m_parts.Add(part);

            // 464_JambScrnChanl <<--
            part = new Part(299, "464_JambScrnChanl", this, 1, m_subAssemblyHieght - reducHDPE);
            part.PartGroupType = "464SheetMetal";
            part.PartLabel = "T-6";
            part.PartThick = 0.4063m;
            part.PartWidth = 1.2301m;
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // ACRE_SMBacker -->>
            part = new Part(4000, "ACRE_SMBacker", this, 1, m_subAssemblyHieght - reducHDPE);
            part.PartGroupType = "464SheetMetal";
            part.PartLabel = "B-10";
            part.PartThick = 0.5766m;
            part.PartWidth = 2.1662m;
            m_parts.Add(part);

            // 464_JambScrnChanl <<--
            part = new Part(299, "464_JambScrnChanl", this, 1, m_subAssemblyHieght - reducHDPE);
            part.PartGroupType = "464SheetMetal";
            part.PartLabel = "T-5";
            part.PartThick = 0.4063m;
            part.PartWidth = 2.1037m;
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Frame

            //////////////////////////////////////////////////////////////////////////////

            //BrzSplitJamb <<--
            part = new Part(4891, "BrzSplitJamb", this, 1, m_subAssemblyHieght - jambSpltRed);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //BrzSplitJamb <<--
            part = new Part(4891, "BrzSplitJamb", this, 1, m_subAssemblyHieght - jambSpltRed);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //BrzSplitJamb -->> 
            part = new Part(4891, "BrzSplitJamb", this, 1, m_subAssemblyHieght - jambSpltRed);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //BrzSplitJamb -->> 
            part = new Part(4891, "BrzSplitJamb", this, 1, m_subAssemblyHieght - jambSpltRed);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
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

            #region Pile_Seals

            //////////////////////////////////////////////////////////////////////////////

            //Pile_Seals -->> 
            part = new Part(1032, "Pile_Seals", this, 1, m_subAssemblyHieght - jambSpltRed);
            part.PartGroupType = "Pile_Seals";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //Pile_Seals -->> 
            part = new Part(979, "Pile_Seals", this, 3, m_subAssemblyHieght - jambSpltRed);
            part.PartGroupType = "Pile_Seals";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // Pile_Seals ^^
            part = new Part(1032, "Pile_Seals", this, 2, m_subAssemblyWidth - jambDimW2X);
            part.PartGroupType = "Pile_Seals";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region ACRE_HD_JMB

            //////////////////////////////////////////////////////////////////////////////

            // ACRE_Head ^^
            part = new Part(4000, "ACRE_Head", this, 1, m_subAssemblyWidth - jambSplThickX2);
            part.PartGroupType = "ACRE_HD_JMB";
            part.PartLabel = "B-11";
            part.PartThick = 0.75m;
            part.PartWidth = 5.5m;
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // ACRE_Jamb
            part = new Part(4000, "ACRE_Jamb", this, 1, m_subAssemblyHieght - reducHDPE);
            part.PartGroupType = "ACRE_HD_JMB";
            part.PartLabel = "B-13";
            part.PartThick = 0.75m;
            part.PartWidth = 5.5m;
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // ACRE_Jamb
            part = new Part(4000, "ACRE_Jamb", this, 1, m_subAssemblyHieght - reducHDPE);
            part.PartGroupType = "ACRE_HD_JMB";
            part.PartLabel = "B-13";
            part.PartThick = 0.75m;
            part.PartWidth = 5.5m;
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
            part.PartWidth = 0.8507m;
            m_parts.Add(part);

            // HDPE_JmbGuide
            part = new Part(5296, "HDPE_JmbGuide", this, 1, m_subAssemblyHieght - reducHDPE);
            part.PartGroupType = "HDPE_HD_JMB";
            part.PartLabel = "B-6";
            part.PartThick = 0.5625m;
            part.PartWidth = 0.8507m;
            m_parts.Add(part);

            // HDPE_ScreenTrack ^^
            part = new Part(5296, "HDPE_ScreenTrack", this, 1, m_subAssemblyWidth - screenRed2X);
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