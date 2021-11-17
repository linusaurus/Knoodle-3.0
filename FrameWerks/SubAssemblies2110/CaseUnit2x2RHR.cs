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

namespace FrameWorks.Makes.System2110
{

    public class CaseUnit2x2RHR : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal aluminumCrnBrk = 0.625m;
        const decimal frameReduce2X = 0.875m * 2.0m;
        const decimal gstopReduce2X = 1.59375m * 2.0m;
        const decimal screenReduce2X = 1.512m * 2.0m;
        const decimal gaskFrmReduce = 1.250m;
        const decimal glassReduce2X = 1.9375m * 2.0m;
        const decimal gaskSashReduce = 1.9667m;
        const decimal edgeSealAdd = 0.375m;
        const decimal muntinReduce2X = 2.46875m * 2.0m;

        //static int createID;

        #endregion

        #region Constructor

        public CaseUnit2x2RHR()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System2110-CaseUnit2x2RHR";
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

            #region Frame

            //////////////////////////////////////////////////////////////////////////////

            // JmbAlumR -->>
            part = new Part(4347, "JmbAlumR", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame";
            part.PartLabel = "1)MiterEnds";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // JmbAlumL <<-- 
            part = new Part(4347, "JmbAlumL", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame";
            part.PartLabel = "1)MiterEnds" + "\r\n" +
                             "2)" + FrameWorks.Functions.TieBarLockCenter(this.SubAssemblyHieght);
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // HeadAlum ^^
            part = new Part(4347, "HeadAlum", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame";
            part.PartLabel = "1)MiterEnds" + "\r\n" +
                             "2)Machine Right PN:1741";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // SillAlum ||
            part = new Part(4347, "SillAlum", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame";
            part.PartLabel = "1)MiterEnds" + "\r\n" +
                             "2)Machine Right PN:1741";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Screen

            //////////////////////////////////////////////////////////////////////////////

            // ScrnFrmVertL <--
            part = new Part(4430, "ScrnFrmVertL", this, 1, m_subAssemblyHieght - screenReduce2X);
            part.PartGroupType = "Screen";
            part.PartLabel = "1)MiterEnds";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // ScrnFrmVertR -->
            part = new Part(4430, "ScrnFrmVertR", this, 1, m_subAssemblyHieght - screenReduce2X);
            part.PartGroupType = "Screen";
            part.PartLabel = "1)MiterEnds";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // ScrnFrmHorzT ^^
            part = new Part(4430, "ScrnFrmHorzT", this, 1, m_subAssemblyWidth - screenReduce2X);
            part.PartGroupType = "Screen";
            part.PartLabel = "1)MiterEnds";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // ScrnFrmHorzB ||
            part = new Part(4430, "ScrnFrmHorzB", this, 1, m_subAssemblyWidth - screenReduce2X);
            part.PartGroupType = "Screen";
            part.PartLabel = "1)MiterEnds";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region AssyHrdwrFrame

            //////////////////////////////////////////////////////////////////////////////

            // AglBrktAlum
            part = new Part(3206, "AglBrktAlum", this, 8, aluminumCrnBrk);
            part.PartGroupType = "AssyHrdwrFrame";
            part.PartLabel = "Angle_1.5";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // PointSetScrew
            part = new Part(1545, "PointSetScrew", this, 32, 0.0m);
            part.PartGroupType = "AssyHrdwrFrame";
            part.PartLabel = "1/4x20x.375";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // ScreenAssyBrace
            part = new Part(1118, "ScreenAssyBrace", this, 4, 0.0m);
            part.PartGroupType = "AssyHrdwrFrame";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // CupPoint
            part = new Part(1537, "CupPoint", this, 8, 0.0m);
            part.PartGroupType = "AssyHrdwrFrame";
            part.PartLabel = "#8-32x3/16";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Handle

            //////////////////////////////////////////////////////////////////////////////

            // LongHandle
            part = new Part(6919, "LongHandle", this, 1, 0.0m);
            part.PartGroupType = "Handle";
            part.PartLabel = "";
            m_parts.Add(part);

            // HandleFolding
            //part = new Part(2268, "HandleFolding", this, 1, 0.0m);
            //part.PartGroupType = "Handle";
            //part.PartLabel = "";
            //m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Hardware-Parts

            //////////////////////////////////////////////////////////////////////////////

            // Operator23SeriesLH
            part = new Part(FrameWorks.Functions.OperatorSeries23(SubAssemblyWidth, "LH"), "OperatorLH", this, 1, 0.0m);
            part.PartGroupType = "Hardware";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // Gasket23
            part = new Part(2652, "Gasket23", this, 1, 0.0m);
            part.PartGroupType = "Hardware";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // OperatorBacker
            //part = new Part(5253, "OperatorBacker", this, 1, 0.0m);
            //part.PartGroupType = "Hardware";
            //part.PartLabel = "";
            //m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            int hardwarecount = 1;
            if (m_subAssemblyHieght < 51.9999m)
            {
                hardwarecount = 1;
            }
            else
            {
                hardwarecount = 2;
            }

            // Truth24LockingHandle
            part = new Part(6916, "Truth24LockingHandle", this, hardwarecount, 0m);
            part.PartGroupType = "Hardware";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // Keeper
            part = new Part(3516, "Keeper", this, hardwarecount, 0m);
            part.PartGroupType = "Hardware";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //Get the size of the tiebar partNo--
            decimal tieBarLength = FrameWorks.Functions.S2000TieBar(m_subAssemblyHieght);
            //check is sash even requires a tiebar
            if (tieBarLength != 0)
            {
                // Tie Bars
                part = new Part(3625, "Tie Bars", this, 1, tieBarLength);
                part.PartGroupType = "Hardware";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Seal/Weatherstripping

            //////////////////////////////////////////////////////////////////////////////

            //FrameSeal
            decimal periFrame = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gaskFrmReduce, m_subAssemblyWidth - gaskFrmReduce);
            for (int i = 0; i < 1; i++)
            {
                periFrame = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gaskFrmReduce, m_subAssemblyWidth - gaskFrmReduce);
                part = new Part(2274, "FrameSeal", this, 1, periFrame);
                part.PartGroupType = "Seal";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            //////////////////////////////////////////////////////////////////////////////

            #region Sash

            //////////////////////////////////////////////////////////////////////////////

            // StileAlumL <--
            part = new Part(5710, "StileAlumL", this, 1, m_subAssemblyHieght - frameReduce2X);
            part.PartGroupType = "Sash";
            part.PartLabel = labelStileL = "1)MiterEnds" + "r\n" +
                                           "2)MachineKeeper";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // StileAlumR -->
            part = new Part(5710, "StileAlumR", this, 1, m_subAssemblyHieght - frameReduce2X);
            part.PartGroupType = "Sash";
            part.PartLabel = labelStileR = "MiterEnds";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // RailAlumT ^^
            part = new Part(5710, "RailAlumT", this, 1, m_subAssemblyWidth - frameReduce2X);
            part.PartGroupType = "Sash";
            part.PartLabel = labelTopRail = "1)MiterEnds" + "\r\n" +
                                            "2)Machine1741Right";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // RailAlumB ||
            part = new Part(5710, "RailAlumB", this, 1, m_subAssemblyWidth - frameReduce2X);
            part.PartGroupType = "Sash";
            part.PartLabel = labelBotRail = "1)MiterEnds" + "\r\n" +
                                            "2)Machine1741Right";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region StopAlum

            //////////////////////////////////////////////////////////////////////////////

            // AlumGlsStopL <--
            part = new Part(5711, "AlumGlsStopL", this, 1, m_subAssemblyHieght - gstopReduce2X);
            part.PartGroupType = "StopAlum";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // AlumGlsStopR -->
            part = new Part(5711, "AlumGlsStopR", this, 1, m_subAssemblyHieght - gstopReduce2X);
            part.PartGroupType = "StopAlum";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // AlumGlsStopT ^^
            part = new Part(5711, "AlumGlsStopT", this, 1, m_subAssemblyWidth - gstopReduce2X);
            part.PartGroupType = "StopAlum";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // AlumGlsStopB ||
            part = new Part(5711, "AlumGlsStopB", this, 1, m_subAssemblyWidth - gstopReduce2X);
            part.PartGroupType = "StopAlum";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region MuntinBars

            //////////////////////////////////////////////////////////////////////////////

            // MuntinBars
            part = new Part(6924, "MuntinBarsInt", this, 1, (m_subAssemblyHieght - muntinReduce2X - 1.0m) / 2.0m );
            part.PartGroupType = "MuntinBars";
            part.PartLabel = "Vert";
            part.PartWidth = 1.0m;
            m_parts.Add(part);

            // MuntinBars
            part = new Part(6924, "MuntinBarsInt", this, 1, (m_subAssemblyHieght - muntinReduce2X - 1.0m) / 2.0m);
            part.PartGroupType = "MuntinBars";
            part.PartLabel = "Vert";
            part.PartWidth = 1.0m;
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // MuntinBars
            part = new Part(6924, "MuntinBarsInt", this, 1, m_subAssemblyWidth - muntinReduce2X);
            part.PartGroupType = "MuntinBars";
            part.PartLabel = "Horz";
            part.PartWidth = 1.0m;
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // MuntinBars
            part = new Part(3736, "MuntinBarsExt", this, 1, (m_subAssemblyHieght - muntinReduce2X - 1.0m) / 2.0m);
            part.PartGroupType = "MuntinBars";
            part.PartLabel = "Vert";
            m_parts.Add(part);

            // MuntinBars
            part = new Part(3736, "MuntinBarsExt", this, 1, (m_subAssemblyHieght - muntinReduce2X - 1.0m) / 2.0m);
            part.PartGroupType = "MuntinBars";
            part.PartLabel = "Vert";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // MuntinBars
            part = new Part(3736, "MuntinBarsExt", this, 1, m_subAssemblyWidth - muntinReduce2X);
            part.PartGroupType = "MuntinBars-Parts";
            part.PartLabel = "Horz";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region AssyHrdwrSash

            //////////////////////////////////////////////////////////////////////////////

            // SS_0.4625_InsetCrnBrace 
            part = new Part(4784, "SS_0.4625_InsetCrnBrace", this, 4, 0.0m);
            part.PartGroupType = "AssyHrdwrSash";
            part.PartLabel = "Yellow";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // FlatHead
            part = new Part(502, "FlatHead", this, 16, 0.0m);
            part.PartGroupType = "AssyHrdwrSash";
            part.PartLabel = "#8-32x3/16_UndercutHead";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // AlumCnrBrkt
            part = new Part(2931, "AlumCnrBrkt", this, 4, 0.0m);
            part.PartGroupType = "AssyHrdwrSash";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //PointSetScrew
            part = new Part(1545, "PointSetScrew", this, 16, 0.0m);
            part.PartGroupType = "AssyHrdwrSash";
            part.PartLabel = "1/4_20x.375";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Hardware

            //////////////////////////////////////////////////////////////////////////////

            // HingeCaseUL
            part = new Part(996, "HingeCaseUL", this, 1, 0.0m);
            part.PartGroupType = "Hardware";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // HingeCaseLL
            part = new Part(995, "HingeCaseLL", this, 1, 0.0m);
            part.PartGroupType = "Hardware";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // HingeSpacer
            for (int i = 0; i < 2; i++)
            {
                part = new Part(219, "HingeSpacer", this, 1, 0.0m);
                part.PartGroupType = "Hardware";
                part.PartThick = 0.2819m;
                part.PartWidth = 0.75m;
                part.PartLength = 7.75m;
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Glass

            //////////////////////////////////////////////////////////////////////////////

            // Glass
            part = new Part(6883);
            part.FunctionalName = "Glass";
            part.PartGroupType = "Glass";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = (m_subAssemblyWidth - glassReduce2X);
            part.PartLength = (m_subAssemblyHieght - glassReduce2X);
            part.PartThick = 1.25m;
            part.PartLabel = "2x2_SDL";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Seal/Weatherstripping

            //////////////////////////////////////////////////////////////////////////////

            //SashEdgeSeal
            for (int i = 0; i < 1; i++)
            {
                decimal periSash = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - edgeSealAdd, m_subAssemblyWidth - edgeSealAdd);
                part = new Part(2274, "SashEdgeSeal", this, 1, periSash);
                part.PartGroupType = "Seal";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            //EPDM_PreSet
            for (int i = 0; i < 1; i++)
            {
                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gaskSashReduce, m_subAssemblyWidth - gaskSashReduce);
                part = new Part(5713, "EPDM_PreSet", this, 1, peri);
                part.PartGroupType = "Seal";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            //EPDM_Wedge
            for (int i = 0; i < 1; i++)
            {
                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gaskSashReduce, m_subAssemblyWidth - gaskSashReduce);
                part = new Part(5714, "EPDM_Wedge", this, 1, peri);
                part.PartGroupType = "Seal";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

        }

        #endregion

    }

}