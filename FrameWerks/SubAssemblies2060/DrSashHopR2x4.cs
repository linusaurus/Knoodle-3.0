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

    public class DrSashHopR2x4 : SubAssemblyBase
    {

        #region Fields

        // The values we can change for different layouts
        const decimal doorReduceX2 = 0.875m * 2.0m;
        const decimal MuntGapX2 = 3.125m * 2.0m;
        const decimal PointSetScrew = 0.25m;
        const decimal gaskFrmReduce = 1.250m;
        const decimal screenReduce2X = 1.51202m * 2.0m;
        const decimal epdmReduce = 2.73129921m;
        const decimal epdmADD = 2.375m;
        const decimal edgeSealAdd = .390m;
        const decimal hdpExtnd = 0.21875m;
        const decimal hdpExtX2 = 0.21875m * 2.0m;
        const decimal stopRedBot = 2.8125m;
        const decimal stopReduce = 3.125m;
        const decimal stopRed2x = 3.125m * 2.0m;
        const decimal glsDrGapX2 = 3.46875m * 2.0m;

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        #endregion

        #region Constructor

        public DrSashHopR2x4()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System2060-DrSashHopR2x4";
        }

        #endregion

        #region Methods


        //Bill of Material
        public override void Build()
        {

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();

            decimal pweight = FrameWorks.Functions.PanelWieghtS2000(m_subAssemblyWidth, m_subAssemblyHieght);

            string labelStileR = string.Empty;
            string labelStileL = string.Empty;
            string labelTopRail = string.Empty;
            string labelBotRail = string.Empty;

            ////////////////////////////////////////////////////////////////////////////////////

            #region Frame

            ////////////////////////////////////////////////////////////////////////////////////

            // AlumWndHopL <<-- 
            part = new Part(4347, "AlumWndHopL", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "FrameAlum-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // AlumWndHopR -->>
            part = new Part(4347, "AlumWndHopR", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "FrameAlum-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // AlumWndHopHead ^^
            part = new Part(4347, "AlumWndHopHead", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "FrameAlum-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // AlumWndHopSill  ||
            part = new Part(4347, "AlumWndHopSill", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "FrameAlum-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Screen

            ////////////////////////////////////////////////////////////////////////////////////

            // ScreenAlumR -->>
            part = new Part(5304, "ScreenAlumR", this, 1, m_subAssemblyHieght - screenReduce2X);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterEnds";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // ScreenAlumL <<-- 
            part = new Part(5304, "ScreenAlumL", this, 1, m_subAssemblyHieght - screenReduce2X);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterEnds";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // ScreenAlum ^^
            part = new Part(5304, "ScreenAlumHd", this, 1, m_subAssemblyWidth - screenReduce2X);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterEnds";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // ScreenAlum ||
            part = new Part(5304, "ScreenAlumSl", this, 1, m_subAssemblyWidth - screenReduce2X);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterEnds";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region AssyHrdwrFrame

            ////////////////////////////////////////////////////////////////////////////////////

            // AglBrktAlum
            part = new Part(3206, "AglBrktAlum", this, 8, 0.0m);
            part.PartGroupType = "AssyHrdwrFrame";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // PointSetScrew
            part = new Part(1545, "PointSetScrew", this, 32, 0.0m);
            part.PartGroupType = "AssyHrdwrFrame";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // ScreenAssyBrace
            part = new Part(1118, "ScreenAssyBrace", this, 4, 0.0m);
            part.PartGroupType = "AssyHrdwrFrame";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // CupPoint#8-32x3/16
            part = new Part(1537, "CupPoint#8-32x3/16", this, 8, 0.0m);
            part.PartGroupType = "AssyHrdwrFrame";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region OperHardware

            ////////////////////////////////////////////////////////////////////////////////////

            //Bracket_LH 
            part = new Part(5460, "Bracket_LH", this, 1, 0.0m);
            part.PartGroupType = "OperHardware";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            //Bracket_RH 
            part = new Part(5466, "Bracket_RH", this, 1, 0.0m);
            part.PartGroupType = "OperHardware";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // TruthMaxim24Lock
            part = new Part(4911, "TruthSeries24Lock", this, 2, 0m);
            part.PartGroupType = "OperHardware-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // Keeper
            part = new Part(3516, "Keeper", this, 2, 0m);
            part.PartGroupType = "OperHardware-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Seal/Weatherstripping

            ////////////////////////////////////////////////////////////////////////////////////

            //FrameSeal
            decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gaskFrmReduce, m_subAssemblyWidth - gaskFrmReduce);
            for (int i = 0; i < 1; i++)
            {
                peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gaskFrmReduce, m_subAssemblyWidth - gaskFrmReduce);
                part = new Part(2274, "FrameSeal", this, 1, peri);
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
            part = new Part(5131, "StileLeft|<", this, 1, m_subAssemblyHieght - doorReduceX2);
            part.PartGroupType = "AlumTB3inch";
            part.PartLabel = "1) Miter_Ends";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // StileRight
            part = new Part(5131, "StileRight>|", this, 1, m_subAssemblyHieght - doorReduceX2);
            part.PartGroupType = "AlumTB3inch";
            part.PartLabel = "1) Miter_Ends";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // RailTop
            part = new Part(5131, "RailTop^", this, 1, m_subAssemblyWidth - doorReduceX2);
            part.PartGroupType = "AlumTB3inch";
            part.PartLabel = "1) Miter_Ends ";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // RailBot
            part = new Part(5131, "RailBot_", this, 1, m_subAssemblyWidth - doorReduceX2);
            part.PartGroupType = "AlumTB3inch";
            part.PartLabel = "1) Miter_Ends ";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Muntins

            ////////////////////////////////////////////////////////////////////////////////////

            // MuntHorz
            for (int i = 0; i < 12; i++)
            {
                part = new Part(5306, "MuntHorz", this, 1, (m_subAssemblyWidth - MuntGapX2) / 2.0m);
                part.PartGroupType = "Muntins";
                part.PartLabel = "?_Ends";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            // MuntVert
            for (int i = 0; i < 8; i++)
            {
                part = new Part(5306, "MuntVert", this, 1, (m_subAssemblyHieght - MuntGapX2) / 4.0m);
                part.PartGroupType = "Muntins";
                part.PartLabel = "?_Ends";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region CrossBrace

            ////////////////////////////////////////////////////////////////////////////////////

            //CrossBrace2X2
            part = new Part(5267, "Cross_Bracket", this, 6, 0);
            part.PartGroupType = "AssyBrackets";
            part.PartLabel = "Cross_3.025";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            //SetScrew_10_32
            part = new Part(3518, "SetScrew_10_32", this, 48, PointSetScrew);
            part.PartGroupType = "AssyBrackets";
            part.PartLabel = "10-32x1/4";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region StopAlum

            ////////////////////////////////////////////////////////////////////////////////////

            // AlumGlsStpVert
            for (int i = 0; i < 2; i++)
            {
                part = new Part(5123, "AlumGlsStpVert", this, 1, m_subAssemblyHieght - stopReduce - stopRedBot);
                part.PartGroupType = "StopAlum-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            // AlumGlsStpTopBot
            for (int i = 0; i < 2; i++)
            {
                part = new Part(5123, "AlumGlsStpTopBot", this, 1, (m_subAssemblyWidth - stopRed2x));
                part.PartGroupType = "StopAlum-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Glass

            ////////////////////////////////////////////////////////////////////////////////////

            // GlassPanel
            part = new Part(5322);
            part.FunctionalName = "Glass";
            part.PartGroupType = "Glass-Parts";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = (m_subAssemblyWidth - glsDrGapX2);
            part.PartLength = (m_subAssemblyHieght - glsDrGapX2 );
            part.PartThick = 1.125m;
            part.PartLabel = "SDL_2x4";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region AssyHrdwrDoor

            ////////////////////////////////////////////////////////////////////////////////////

            // SS_0.4625_InsetCrnBrace 
            part = new Part(4784, "SS_0.4625_InsetCrnBrace", this, 4, 0.0m);
            part.PartGroupType = "AssyHrdwrDoor";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // FlatHead_8-32x3/16_UndercutHead
            part = new Part(502, "FlatHead_8-32x3/16_UndercutHead", this, 16, 0.0m);
            part.PartGroupType = "AssyHrdwrDoor";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // AlumCnrBrace
            part = new Part(4830, "AlumCnrBrace", this, 4, 0.0m);
            part.PartGroupType = "AssyHrdwrDoor";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // FlatHead_#10x5/8_SheetMetal_18_8_SS
            part = new Part(5180, "FlatHead_#10x5/8_SheetMetal_18_8_SS", this, 16, 0.0m);
            part.PartGroupType = "AssyHrdwrDoor";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // AlumCnrBrace
            part = new Part(4831, "AlumCnrBrace", this, 4, 0.0m);
            part.PartGroupType = "AssyHrdwrDoor";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // FlatHead_#10x5/8_SheetMetal_18_8_SS
            part = new Part(5180, "FlatHead_#10x5/8_SheetMetal_18_8_SS", this, 16, 0.0m);
            part.PartGroupType = "AssyHrdwrDoor";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // SS_0.7049_OutsetCrnBrace 
            part = new Part(4829, "SS_0.7049_OutsetCrnBrace", this, 8, 0.0m);
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

            #endregion

            #region HardWare Logic

            ////////////////////////////////////////////////////////////////////////////////////

            //HngHopAssy_LH 
            part = new Part(5464, "HngHopAssy_LH", this, 1, 0.0m);
            part.PartGroupType = "HardWare";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            //HngHopAssy_RH 
            part = new Part(5463, "HngHopAssy_RH", this, 1, 0.0m);
            part.PartGroupType = "HardWare";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Seal/Weatherstripping

            ////////////////////////////////////////////////////////////////////////////////////

            //KfolDrEdge
            for (int i = 0; i < 1; i++)
            {
                decimal periSeal = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);
                part = new Part(2274, "KfolDrEdge", this, 1, periSeal + 4.0m * edgeSealAdd);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            //EPDM_PreSet
            for (int i = 0; i < 1; i++)
            {
                decimal periSeal = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);
                part = new Part(4314, "EPDM_PreSet", this, 1, periSeal - 4.0m * epdmReduce + 4.0m * epdmADD);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            //EPDM_Wedge
            for (int i = 0; i < 1; i++)
            {
                decimal periSeal = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);
                part = new Part(4284, "EPDM_Wedge", this, 1, periSeal - 4.0m * epdmReduce + 4.0m * epdmADD);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            //EPDM_Wedge_Munt_INT
            for (int i = 0; i < 12; i++)
            {
                part = new Part(2772, "EPDM_Wedge_Munt_INT", this, 1, (m_subAssemblyWidth - MuntGapX2) / 2.0m);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            //EPDM_Wedge_Munt_EXT
            for (int i = 0; i < 12; i++)
            {
                part = new Part(5557, "EPDM_Wedge_Munt_EXT", this, 1, (m_subAssemblyWidth - MuntGapX2) / 2.0m);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            //EPDM_Wedge_Munt_INT
            for (int i = 0; i < 8; i++)
            {
                part = new Part(2772, "EPDM_Wedge_Munt_INT", this, 1, (m_subAssemblyHieght - MuntGapX2) / 4.0m);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            //EPDM_Wedge_Munt_EXT
            for (int i = 0; i < 8; i++)
            {
                part = new Part(5557, "EPDM_Wedge_Munt_EXT", this, 1, (m_subAssemblyHieght - MuntGapX2) / 4.0m);
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