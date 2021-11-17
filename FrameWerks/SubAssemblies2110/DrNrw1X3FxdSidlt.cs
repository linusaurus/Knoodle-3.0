#region Copyright (c) 2019 WeaselWare Software
/************************************************************************************
'
' Copyright  2019 WeaselWare Software 
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
' Portions Copyright 2019 WeaselWare Software
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
using FrameWorks.Makes.System2110;

namespace FrameWorks.Makes.System2110
{

    public class DrNrw1X3FxdSidlt : SubAssemblyBase
    {

        #region Fields

        // The values we can change for different layouts
        const decimal aluminumCrnBrk = 0.625m;
        const decimal calkJoint = 0.125m;
        const decimal trhGutterAdd = 6.0m;
        const decimal headReduct = 1.375m;
        const decimal botumRedut = .75m;
        const decimal kFoldRedut = .8125m;
        // The values we can change for different layouts
        const decimal stopReduce = 1.59375m;
        const decimal stopReduceX2 = 2.0m * 1.59375m;
        const decimal glsDrGap = 1.9375m;
        const decimal glsDrGapBot = 7.5625m;
        const decimal glsDrGapX2 = 2.0m * 1.9375m;
        const decimal frameReduce = 0.875m;
        const decimal frameRedBot = 0.75m;
        const decimal frameRedX2 = 2.0m * 0.875m;
        const decimal edgeSealAdd = 0.375m;
        const decimal hdpExtnd = 0.25m;
        const decimal epdmReduce = 1.9675m;
        const decimal epdmADD = 1.60m;
        const decimal muntinReduce2X = 2.46875m * 2.0m;
        const decimal panelCoreRed2X = 1.59375m * 2.0m;
        //
        #endregion

        #region Constructor

        public DrNrw1X3FxdSidlt()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System2110-DrNrw1X3FxdSidlt";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {
            Part part;

            decimal pweight = FrameWorks.Functions.PanelWieghtS2000(m_subAssemblyWidth, m_subAssemblyHieght);

            string labelStileR = string.Empty;
            string labelStileL = string.Empty;
            string labelTopRail = string.Empty;
            string labelBotRail = string.Empty;

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #region Frame

            //////////////////////////////////////////////////////////////////////////////////////////

            // JambsAlum -->> 
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4352, "JambsAlum<>", this, 1, m_subAssemblyHieght - calkJoint);
                part.PartGroupType = "Frame";
                part.PartLabel = "1) MiterTop";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////////////////

            // HeadAlum ^^
            part = new Part(4352, "HeadAlum", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame";
            part.PartLabel = "1)MiterEnd";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region ThrehGutAssy

            //////////////////////////////////////////////////////////////////////////////////////////

            // ThresGut ^^
            part = new Part(5587, "ThresGut", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "ThrehGutAssy";
            part.PartLabel = "Top";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////

            // ThresGutBot ^^
            part = new Part(5587, "ThresGut", this, 1, m_subAssemblyWidth + trhGutterAdd);
            part.PartGroupType = "ThrehGutAssy";
            part.PartLabel = "Bottom";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////

            // Drain ^^
            part = new Part(6911, "Drain", this, 1, 0.0m);
            part.PartGroupType = "ThrehGutAssy";
            part.PartLabel = "Body";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////

            // Drain ^^
            part = new Part(5477, "Drain", this, 1, 0.0m);
            part.PartGroupType = "ThrehGutAssy";
            part.PartLabel = "FlipperDoor";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////

            // Drain ^^
            part = new Part(5596, "Drain", this, 1, 0.0m);
            part.PartGroupType = "ThrehGutAssy";
            part.PartLabel = "Spout";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region AssyHrdwrFrame

            //////////////////////////////////////////////////////////////////////////////////////////

            // AglBrktAlum
            part = new Part(3206, "AglBrktAlum", this, 4, aluminumCrnBrk);
            part.PartGroupType = "AssyHrdwrFrame";
            part.PartLabel = "Angle_1.5";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////

            // PointSetScrew
            part = new Part(1545, "PointSetScrew", this, 16, 0.0m);
            part.PartGroupType = "AssyHrdwrFrame";
            part.PartLabel = "1/4x20x.375";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region HardWare

            //////////////////////////////////////////////////////////////////////////////////////////


            //////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Seal/Weatherstripping

            decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {
                peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - kFoldRedut - calkJoint, m_subAssemblyWidth - 2 * kFoldRedut);
                //FrameSealKfolD
                part = new Part(2274, "FrameSealKfolD", this, 1, peri - m_subAssemblyWidth);
                part.PartGroupType = "Seal";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #region AlumTBNrw

            ////////////////////////////////////////////////////////////////////////////////////

            // StileLeft
            part = new Part(5710, "StileLeft", this, 1, m_subAssemblyHieght - frameReduce - frameRedBot);
            part.PartGroupType = "AlumTBNrw";
            part.PartLabel = "1) Miter_Ends";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // StileRight
            part = new Part(5710, "StileRight", this, 1, m_subAssemblyHieght - frameReduce - frameRedBot);
            part.PartGroupType = "AlumTBNrw";
            part.PartLabel = "1) Miter_Ends";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // RailTop
            part = new Part(5710, "RailTop", this, 1, m_subAssemblyWidth - frameRedX2);
            part.PartGroupType = "AlumTBNrw";
            part.PartLabel = "1) Miter_Ends ";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // RailMid
            part = new Part(5710, "RailMid", this, 1, m_subAssemblyWidth - frameRedX2 - stopReduceX2);
            part.PartGroupType = "AlumTBNrw";
            part.PartLabel = "1) Miter_Ends ";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // RailBot
            part = new Part(5710, "RailBot", this, 1, m_subAssemblyWidth - frameRedX2);
            part.PartGroupType = "AlumTBNrw";
            part.PartLabel = "1) Miter_Ends ";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region MuntinBars

            //////////////////////////////////////////////////////////////////////////////

            // MuntinBars
            for (int i = 0; i < 2; i++)
            {
                part = new Part(6924, "MuntinBarsInt", this, 1, m_subAssemblyWidth - muntinReduce2X);
                part.PartGroupType = "MuntinBars";
                part.PartLabel = "Horz";
                part.PartWidth = 1.0m;
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            // MuntinBars
            for (int i = 0; i < 2; i++)
            {
                part = new Part(3736, "MuntinBarsExt", this, 1, m_subAssemblyWidth - muntinReduce2X);
                part.PartGroupType = "MuntinBars";
                part.PartLabel = "Horz";
                part.PartWidth = 1.0m;
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region KickPanel

            //////////////////////////////////////////////////////////////////////////////

            // KickPanelInt
            part = new Part(6962, "KickPanelInt", this, 1, m_subAssemblyWidth - muntinReduce2X);
            part.PartGroupType = "KickPanel";
            part.PartWidth = 5.78125m;
            part.PartLabel = "PanelCladInt";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //PanelCore
            part = new Part(4043, "PanelCore", this, 1, m_subAssemblyWidth - panelCoreRed2X);
            part.PartGroupType = "KickPanel";
            part.PartWidth = 6.1906m;
            part.PartThick = 1.0m;
            part.PartLabel = "PanelCore";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // KickPanChanelExt
            part = new Part(6963, "KickPanChanelExt", this, 1, m_subAssemblyWidth - muntinReduce2X);
            part.PartGroupType = "KickPanel";
            part.PartWidth = 4.90625m;
            part.PartLabel = "PanalCladExt";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region HDPE

            ////////////////////////////////////////////////////////////////////////////////////

            // HDPE_FixedEdge
            for (int i = 0; i < 3; i++)
            {
                part = new Part(6970, "HDPE_FixedEdge", this, 1, 5.0m);
                part.PartGroupType = "HDPE";
                part.PartLabel = labelStileL = "";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            // HDPE_FixedEdge
            for (int i = 0; i < 3; i++)
            {
                part = new Part(6970, "HDPE_FixedEdge", this, 1, 5.0m);
                part.PartGroupType = "HDPE";
                part.PartLabel = labelStileR = "";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            // HDPEFixedTop
            part = new Part(6970, "HDPEFixedTop", this, 1, 5.0m);
            part.PartGroupType = "HDPE";
            part.PartLabel = labelTopRail = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // HDPEBot
            part = new Part(6971, "HDPEBot", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "HDPE";
            part.PartLabel = labelBotRail = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region StopAlum

            ////////////////////////////////////////////////////////////////////////////////////

            // AlumGlsStpLeft
            part = new Part(5711, "AlumGlsStpLeft", this, 1, m_subAssemblyHieght - stopReduceX2);
            part.PartGroupType = "StopAlum";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // AlumGlsStpRight
            part = new Part(5711, "AlumGlsStpRight", this, 1, m_subAssemblyHieght - stopReduceX2);
            part.PartGroupType = "StopAlum";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // AlumGlsStpTop
            part = new Part(5711, "AlumGlsStpTop", this, 1, m_subAssemblyWidth - stopReduceX2);
            part.PartGroupType = "StopAlum";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // AlumGlsStpBot
            part = new Part(5711, "AlumGlsStpBot", this, 1, m_subAssemblyWidth - stopReduceX2);
            part.PartGroupType = "StopAlum";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Glass

            //GlassPanel
            part = new Part(6883);
            part.FunctionalName = "Glass";
            part.PartGroupType = "Glass";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = (m_subAssemblyWidth - glsDrGapX2);
            part.PartLength = (m_subAssemblyHieght - glsDrGap - glsDrGapBot);
            part.PartThick = 1.25m;
            part.PartLabel = "";
            m_parts.Add(part);

            #endregion

            #region Handle

            // Handle_Set
            part = new Part(5218, "Handle_Set", this, 1, 0.0m);
            part.PartGroupType = "Handle";
            part.PartLabel = "";
            m_parts.Add(part);

            #endregion

            #region AssyHrdwrDoor

            //////////////////////////////////////////////////////////////////////////////

            // SS_0.4625_InsetCrnBrace 
            part = new Part(4784, "SS_0.4625_InsetCrnBrace", this, 4, 0.0m);
            part.PartGroupType = "AssyHrdwrDoor";
            part.PartLabel = "";
            m_parts.Add(part);

            // FlatHead
            part = new Part(502, "FlatHead", this, 16, 0.0m);
            part.PartGroupType = "AssyHrdwrDoor";
            part.PartLabel = "#8-32x3/16_UndercutHead";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // AlumCnrBrace
            part = new Part(4830, "AlumCnrBrace", this, 4, 0.0m);
            part.PartGroupType = "AssyHrdwrDoor";
            part.PartLabel = "";
            m_parts.Add(part);

            // FlatHead
            part = new Part(5180, "FlatHead", this, 16, 0.0m);
            part.PartGroupType = "AssyHrdwrDoor";
            part.PartLabel = "#10x5/8_SheetMetal_18_8_SS";
            m_parts.Add(part);

            // AlumCnrBrace
            part = new Part(4831, "AlumCnrBrace", this, 4, 0.0m);
            part.PartGroupType = "AssyHrdwrDoor";
            part.PartLabel = "";
            m_parts.Add(part);

            // FlatHead
            part = new Part(5180, "FlatHead", this, 16, 0.0m);
            part.PartGroupType = "AssyHrdwrDoor";
            part.PartLabel = "#10x5/8_SheetMetal_18_8_SS";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // SS_0.7049_OutsetCrnBrace 
            part = new Part(4829, "SS_0.7049_OutsetCrnBrace", this, 8, 0.0m);
            part.PartGroupType = "AssyHrdwrDoor";
            part.PartLabel = "";
            m_parts.Add(part);

            // FlatHead
            part = new Part(502, "FlatHead", this, 32, 0.0m);
            part.PartGroupType = "AssyHrdwrDoor";
            part.PartLabel = "#8-32x3/16_UndercutHead";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////


            #endregion

            #region Seal/Weatherstripping

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {
                decimal periSeal = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

                //KfolDrEdge
                part = new Part(2274, "KfolDrEdge", this, 1, periSeal + edgeSealAdd);
                part.PartGroupType = "Seal";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //DoorBotPVC
            part = new Part(1518, "DoorBotPVC", this, 1, m_subAssemblyWidth + 2.0m * hdpExtnd);
            part.PartGroupType = "Seal";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {
                decimal periSeal = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

                //EPDM_PreSet
                part = new Part(4314, "EPDM_PreSet", this, 1, periSeal - 4.0m * epdmReduce + 4.0m * epdmADD);
                part.PartGroupType = "Seal";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {
                decimal periSeal = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

                //EPDM_Wedge
                part = new Part(4284, "EPDM_Wedge", this, 1, periSeal - 4.0m * epdmReduce + 4.0m * epdmADD);
                part.PartGroupType = "Seal";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        }

        #endregion

    }

}