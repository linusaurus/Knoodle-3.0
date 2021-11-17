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
using System.Text;
using FrameWorks;
using FrameWorks.Makes.System2060;


namespace FrameWorks.Makes.System2060
{

    public class DoorPair2x4Fixed : SubAssemblyBase
    {

        #region Fields

        // The values we can change for different layouts
        const decimal doorReduceX2 = 0.875m * 2.0m;
        const decimal doorReduce = 0.875m;
        const decimal doorGapBot = 0.75m;
        const decimal doorGapMid = 0.375m;
        const decimal topMuntGp = 3.125m;
        const decimal botMuntGp = 3.0m;
        const decimal sidMuntGP2 = 3.125m * 2.0m;
        const decimal centMuntGP = 4.875m;
        const decimal PointSetScrew = 0.25m;
        const decimal glsDrGap = 3.46875m;
        const decimal glsDrGapMID = 5.5625m;
        const decimal glsDrGapBot = 3.3475m;
        const decimal glsDrGapX2 = 3.46875m * 2.0m;
        const decimal epdmReduce = 2.73129921m;
        const decimal epdmADD = 2.375m;
        const decimal edgeSealAdd = .390m;
        const decimal hdpExtnd = 0.21875m;
        const decimal hdpExtX2 = 0.21875m * 2.0m;
        const decimal stopRedBot = 3.0000m;
        const decimal stopReduce = 3.125m;
        const decimal stopRed2x = 3.125m * 2.0m;
        const decimal stopRedMid = 2.4375m * 2.0m;
        const decimal calkJoint = 0.1250m;
        const decimal headReduct = 1.375m;
        const decimal botumRedut = .75m;
        const decimal kFoldRedut = .8125m;
        const decimal trhGutterAdd = 6.0m;


        //



        #endregion

        #region Constructor

        public DoorPair2x4Fixed()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System2060-DoorPair2x4Fixed";
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

            ////////////////////////////////////////////////////////////////////////////////////

            #region Frame-Parts

            ////////////////////////////////////////////////////////////////////////////////////

            // JambsAlum -->> 
            for (int i = 0; i < 2; i++)
            {
                decimal doorPanel = decimal.Zero;
                doorPanel = this.Parent.SubAssemblies[0].SubAssemblyHieght;
                part = new Part(4352, "JambsAlum<>", this, 1, m_subAssemblyHieght - calkJoint);
                part.PartGroupType = "Frame-Parts";
                decimal step = (doorPanel - 15.0m);
                step /= Convert.ToDecimal((FrameWorks.Functions.HingeCount(doorPanel) - 1));
                step = Math.Round(step, 4);
                //string msg = "";
                part.PartLabel = "1) MiterTop";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            // HeadAlum ^^
            part = new Part(4352, "HeadAlum", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterEnd";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region ThrehGutAssy

            ////////////////////////////////////////////////////////////////////////////////////

            // ThresGut ^^
            part = new Part(5587, "ThresGut", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "ThrehGutAssy-Parts";
            part.PartLabel = "Top";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // ThresGutBot ^^
            part = new Part(5587, "ThresGut", this, 1, m_subAssemblyWidth + trhGutterAdd);
            part.PartGroupType = "ThrehGutAssy-Parts";
            part.PartLabel = "Bottom";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region AssyHrdwrFrame

            ////////////////////////////////////////////////////////////////////////////////////

            // AglBrktAlum
            part = new Part(3206, "AglBrktAlum", this, 4, 0.0m);
            part.PartGroupType = "AssyHrdwrFrame";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // PointSetScrew
            part = new Part(1545, "PointSetScrew", this, 16, 0.0m);
            part.PartGroupType = "AssyHrdwrFrame";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region HardWare

            ////////////////////////////////////////////////////////////////////////////////////

            // PVC ASTRAGAL
            part = new Part(1901, "PVC ASTRAGAL", this, 1, m_subAssemblyHieght - headReduct - botumRedut);
            part.PartGroupType = "HardWare-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // ASTRAGAL_COVER
            part = new Part(4496, "ASTRAGAL_COVER", this, 1, m_subAssemblyHieght - headReduct - botumRedut);
            part.PartGroupType = "HardWare-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Seal/Weatherstripping

            ////////////////////////////////////////////////////////////////////////////////////
            
            //FrameSealKfolD
            decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);
            for (int i = 0; i < 1; i++)
            {
                peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - kFoldRedut - calkJoint, m_subAssemblyWidth - 2 * kFoldRedut);
                part = new Part(2274, "FrameSealKfolD", this, 1, peri - m_subAssemblyWidth);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            ////////////////////////////////////////////////////////////////////////////////////

            #region AlumTB3inch

            ////////////////////////////////////////////////////////////////////////////////////

            // StileLeft
            part = new Part(5131, "StileLeft", this, 2, m_subAssemblyHieght - doorReduce - doorGapBot);
            part.PartGroupType = "AlumTB3inch";
            part.PartLabel = "1) Miter_Ends";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // StileRight
            part = new Part(5131, "StileRight", this, 2, m_subAssemblyHieght - doorReduce - doorGapBot);
            part.PartGroupType = "AlumTB3inch";
            part.PartLabel = "1) Miter_Ends";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // RailTop
            part = new Part(5131, "RailTop", this, 2, (m_subAssemblyWidth - doorReduceX2 - doorGapMid) / 2.0m);
            part.PartGroupType = "AlumTB3inch";
            part.PartLabel = "1) Miter_Ends ";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // RailBot
            part = new Part(5131, "RailBot", this, 2, (m_subAssemblyWidth - doorReduceX2 - doorGapMid) / 2.0m);
            part.PartGroupType = "AlumTB3inch";
            part.PartLabel = "1) Miter_Ends ";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Muntins

            ////////////////////////////////////////////////////////////////////////////////////

            // MuntHorz
            for (int i = 0; i < 24; i++)
            {
                part = new Part(5306, "MuntHorz", this, 1, (m_subAssemblyWidth - sidMuntGP2 - centMuntGP) / 4.0m);
                part.PartGroupType = "Muntins";
                part.PartLabel = "?_Ends";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            // MuntVert
            for (int i = 0; i < 16; i++)
            {
                part = new Part(5306, "MuntVert", this, 1, (m_subAssemblyHieght - topMuntGp - botMuntGp) / 4.0m);
                part.PartGroupType = "Muntins";
                part.PartLabel = "?_Ends";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region CrossBrace

            ////////////////////////////////////////////////////////////////////////////////////

            //CrossBrace2X2
            part = new Part(5267, "Cross_Bracket", this, 12, 0);
            part.PartGroupType = "AssyBrackets";
            part.PartLabel = "Cross_3.025";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            //SetScrew_10_32
            part = new Part(3518, "SetScrew_10_32", this, 96, PointSetScrew);
            part.PartGroupType = "AssyBrackets";
            part.PartLabel = "10-32x1/4";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region StopAlum

            ////////////////////////////////////////////////////////////////////////////////////

            // AlumGlsStpVert
            for (int i = 0; i < 4; i++)
            {
                part = new Part(5123, "AlumGlsStpVert", this, 1, m_subAssemblyHieght - stopReduce - stopRedBot);
                part.PartGroupType = "StopAlum-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            // AlumGlsStpTopBot
            for (int i = 0; i < 4; i++)
            {
                part = new Part(5123, "AlumGlsStpTopBot", this, 1, (m_subAssemblyWidth - stopRed2x - stopRedMid) / 2.0m);
                part.PartGroupType = "StopAlum-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Glass

            ////////////////////////////////////////////////////////////////////////////////////

            // GlassPanel
            for (int i = 0; i < 2; i++)
            {
                part = new Part(5322);
                part.FunctionalName = "Glass";
                part.PartGroupType = "Glass-Parts";
                part.Qnty = 1;
                part.ContainerAssembly = this;
                part.PartWidth = (m_subAssemblyWidth - glsDrGapX2 - glsDrGapMID) / 2.0m;
                part.PartLength = (m_subAssemblyHieght - glsDrGap - glsDrGapBot);
                part.PartThick = 1.125m;
                part.PartLabel = "SDL_2x4";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region AssyHrdwrDoor

            ////////////////////////////////////////////////////////////////////////////////////

            // SS_0.4625_InsetCrnBrace 
            part = new Part(4784, "SS_0.4625_InsetCrnBrace", this, 8, 0.0m);
            part.PartGroupType = "AssyHrdwrDoor";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // FlatHead_8-32x3/16_UndercutHead
            part = new Part(502, "FlatHead_8-32x3/16_UndercutHead", this, 32, 0.0m);
            part.PartGroupType = "AssyHrdwrDoor";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // AlumCnrBrace
            part = new Part(4830, "AlumCnrBrace", this, 8, 0.0m);
            part.PartGroupType = "AssyHrdwrDoor";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // FlatHead_#10x5/8_SheetMetal_18_8_SS
            part = new Part(5180, "FlatHead_#10x5/8_SheetMetal_18_8_SS", this, 32, 0.0m);
            part.PartGroupType = "AssyHrdwrDoor";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // AlumCnrBrace
            part = new Part(4831, "AlumCnrBrace", this, 8, 0.0m);
            part.PartGroupType = "AssyHrdwrDoor";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // FlatHead_#10x5/8_SheetMetal_18_8_SS
            part = new Part(5180, "FlatHead_#10x5/8_SheetMetal_18_8_SS", this, 32, 0.0m);
            part.PartGroupType = "AssyHrdwrDoor";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // SS_0.7049_OutsetCrnBrace 
            part = new Part(4829, "SS_0.7049_OutsetCrnBrace", this, 16, 0.0m);
            part.PartGroupType = "AssyHrdwrDoor";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // FlatHead_8-32x3/16_UndercutHead
            part = new Part(502, "FlatHead_8-32x3/16_UndercutHead", this, 64, 0.0m);
            part.PartGroupType = "AssyHrdwrDoor";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Seal/Weatherstripping

            ////////////////////////////////////////////////////////////////////////////////////

            //KfolDrEdge
            for (int i = 0; i < 2; i++)
            {
                decimal periSeal = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);
                part = new Part(2274, "KfolDrEdge", this, 1, (periSeal - m_subAssemblyWidth + 4.0m * edgeSealAdd) / 2.0m);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            //DoorBotPVC
            for (int i = 0; i < 2; i++)
            {
                part = new Part(1518, "DoorBotPVC", this, 1, (m_subAssemblyWidth - doorReduceX2 - doorGapMid + hdpExtX2) / 2.0m);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            //EPDM_PreSet
            for (int i = 0; i < 2; i++)
            {
                decimal periSeal = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);
                part = new Part(4314, "EPDM_PreSet", this, 1, periSeal - 4.0m * epdmReduce + 4.0m * epdmADD);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            //EPDM_Wedge
            for (int i = 0; i < 2; i++)
            {
                decimal periSeal = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);
                part = new Part(4284, "EPDM_Wedge", this, 1, periSeal - 4.0m * epdmReduce + 4.0m * epdmADD);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            // EPDM_Wedge_Munt_INT
            for (int i = 0; i < 16; i++)
            {
                part = new Part(2772, "EPDM_Wedge_Munt_INT", this, 1, (m_subAssemblyWidth - sidMuntGP2 - centMuntGP) / 4.0m);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            // EPDM_Wedge_Munt_EXT
            for (int i = 0; i < 16; i++)
            {
                part = new Part(5557, "EPDM_Wedge_Munt_EXT", this, 1, (m_subAssemblyWidth - sidMuntGP2 - centMuntGP) / 4.0m);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            // EPDM_Wedge_Munt_INT
            for (int i = 0; i < 24; i++)
            {
                part = new Part(2772, "EPDM_Wedge_Munt_INT", this, 1, (m_subAssemblyHieght - topMuntGp - botMuntGp) / 4.0m);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            // EPDM_Wedge_Munt_EXT
            for (int i = 0; i < 24; i++)
            {
                part = new Part(5557, "EPDM_Wedge_Munt_EXT", this, 1, (m_subAssemblyHieght - topMuntGp - botMuntGp) / 4.0m);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

        }

        #endregion

    }

}