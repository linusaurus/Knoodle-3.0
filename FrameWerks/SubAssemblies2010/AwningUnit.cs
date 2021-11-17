#region Copyright (c) 2015 WeaselWare Software
/************************************************************************************
'
' Copyright  2015 WeaselWare Software 
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
' Portions Copyright 2015 WeaselWare Software
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
using System.Diagnostics;

namespace FrameWorks.Makes.System2010
{

    public class AwningUnit : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal frameReduce2X = 0.9375m * 2.0m;
        const decimal screenReduce2X = 1.51202m * 2.0m;
        const decimal gaskFrmReduce = 1.250m;
        const decimal gstopReduce2X = 1.88285m * 2.0m;
        const decimal glassReduce2X = 2.21875m * 2.0m;
        const decimal gaskSashReduce = 2.1875m;
        const decimal edgeSealAdd = 0.375m;

        //static int createID;

        #endregion

        #region Constructor

        public AwningUnit()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System2010-AwningUnit";
            this.WrkOrder = new Workorder(this, 1);
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

            // AlumWndAwnLeft <<--
            part = new Part(4347, "AlumWndAwnLeft", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // AlumWndAwnRight -->>
            part = new Part(4347, "AlumWndAwnRight", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // AlumWndAwnHead ^^
            part = new Part(4347, "AlumWndAwnHead", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // AlumWndAwnSill ||
            part = new Part(4347, "AlumWndAwnSill", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Screen

            //////////////////////////////////////////////////////////////////////////////

            // ScrnFrmLeft <<--
            part = new Part(4430, "ScrnFrmLeft", this, 1, m_subAssemblyHieght - screenReduce2X);
            part.PartGroupType = "Screen";
            part.PartLabel = "1)MiterEnds";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // ScrnFrmRight -->>
            part = new Part(4430, "ScrnFrmRights", this, 1, m_subAssemblyHieght - screenReduce2X);
            part.PartGroupType = "Screen";
            part.PartLabel = "1)MiterEnds";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // ScrnFrmTop ^^
            part = new Part(4430, "ScrnFrmTop", this, 1, m_subAssemblyWidth - screenReduce2X);
            part.PartGroupType = "Screen";
            part.PartLabel = "1)MiterEnds";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // ScrnFrmBot ||
            part = new Part(4430, "ScrnFrmBot", this, 1, m_subAssemblyWidth - screenReduce2X);
            part.PartGroupType = "Screen";
            part.PartLabel = "1)MiterEnds";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region AssyHrdwrFrame

            //////////////////////////////////////////////////////////////////////////////

            // AglBrktAlum
            part = new Part(3206, "AglBrktAlum", this, 8, 0.0m);
            part.PartGroupType = "AssyHrdwrFrame";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // PointSetScrew
            part = new Part(1545, "PointSetScrew", this, 32, 0.0m);
            part.PartGroupType = "AssyHrdwrFrame";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // ScreenAssyBrace
            part = new Part(1118, "ScreenAssyBrace", this, 4, 0.0m);
            part.PartGroupType = "AssyHrdwrFrame";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // CupPoint#8-32x3/16
            part = new Part(1537, "CupPoint#8-32x3/16", this, 8, 0.0m);
            part.PartGroupType = "AssyHrdwrFrame";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Handle

            //////////////////////////////////////////////////////////////////////////////

            // LH_Encore®CoverHandle
            //part = new Part(4912, "LH_Encore®CoverHandle", this, 1, 0.0m);
            //part.PartGroupType = "Handle";
            //part.PartLabel = "";
            //m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region HardWare

            //////////////////////////////////////////////////////////////////////////////////////////////

            // Operator
            int[] Parts = FrameWorks.Functions.OperatorAwningPivotShoeSeries22(this.SubAssemblyWidth);
            for (int i = 0; i < Parts.Length; i++)
            {
                string desc = string.Empty;
                if (i == 0) { desc = "Operator22Series"; }
                else { desc = "Pivot Tracks"; }

                // Operator22Series
                part = new Part(Parts[i], desc, this, 1, 0.0m);
                part.PartGroupType = "HardWare";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////

            // FoldingHandle
            part = new Part(1764, "FoldingHandle", this, 1, 0.0m);
            part.PartGroupType = "HardWare";
            part.PartLabel = "";
            m_parts.Add(part);

            // LockLeft
            part = new Part(3800, "LockLeft", this, 1, 0.0m);
            part.PartGroupType = "HardWare";
            part.PartLabel = "";
            m_parts.Add(part);

            // LockRight
            part = new Part(3800, "LockRight", this, 1, 0.0m);
            part.PartGroupType = "HardWare";
            part.PartLabel = "";
            m_parts.Add(part);

            //KeeperStrikeLeft
            part = new Part(3516, "KeeperStrikeLeft", this, 1, 0m);
            part.PartGroupType = "HardWare";
            part.PartLabel = "";
            m_parts.Add(part);

            //KeeperStrikeRight
            part = new Part(3516, "KeeperStrikeRight", this, 1, 0m);
            part.PartGroupType = "HardWare";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Seal/Weatherstripping

            //////////////////////////////////////////////////////////////////////////////

            //FrameSeal
            decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gaskFrmReduce, m_subAssemblyWidth - gaskFrmReduce);
            for (int i = 0; i < 1; i++)
            {
                peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gaskFrmReduce, m_subAssemblyWidth - gaskFrmReduce);
                part = new Part(2274, "FrameSeal", this, 1, peri);
                part.PartGroupType = "Seal";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            //////////////////////////////////////////////////////////////////////////////

            #region Sash

            //////////////////////////////////////////////////////////////////////////////

            // StileAlumL <<--
            part = new Part(4350, "StileAlumL", this, 1, m_subAssemblyHieght - frameReduce2X);
            part.PartGroupType = "Sash";
            part.PartLabel = labelStileL = "MiterEnds";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // StileAlumR -->>
            part = new Part(4350, "StileAlumR", this, 1, m_subAssemblyHieght - frameReduce2X);
            part.PartGroupType = "Sash";
            part.PartLabel = labelStileR = "1)MiterEnds" + "r\n" +
                                           "2)MachineKeeper";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // RailAlumT ^^
            part = new Part(4350, "RailAlumT", this, 1, m_subAssemblyWidth - frameReduce2X);
            part.PartGroupType = "Sash";
            part.PartLabel = labelTopRail = "1)MiterEnds" + "\r\n" +
                                            "2)Machine3121Left";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // RailAlumB ||
            part = new Part(4350, "RailAlumB", this, 1, m_subAssemblyWidth - frameReduce2X);
            part.PartGroupType = "Sash";
            part.PartLabel = labelBotRail = "1)MiterEnds" + "\r\n" +
                                            "2)Machine3121Left";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region StopAlum

            //////////////////////////////////////////////////////////////////////////////

            // AlumGlsStpLeft <<--
            part = new Part(4341, "AlumGlsStpLeft", this, 1, m_subAssemblyHieght - gstopReduce2X);
            part.PartGroupType = "StopAlum";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // AlumGlsStpRight -->>
            part = new Part(4341, "AlumGlsStpLeft", this, 1, m_subAssemblyHieght - gstopReduce2X);
            part.PartGroupType = "StopAlum";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // AlumGlsStpTop ^^
            part = new Part(4341, "AlumGlsStpHz", this, 1, m_subAssemblyWidth - gstopReduce2X);
            part.PartGroupType = "StopAlum";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // AlumGlsStpBot ||
            part = new Part(4341, "AlumGlsStpHz", this, 1, m_subAssemblyWidth - gstopReduce2X);
            part.PartGroupType = "StopAlum";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region AssyHrdwrSash

            //////////////////////////////////////////////////////////////////////////////

            // SS_0.4625_InsetCrnBrace 
            part = new Part(4784, "SS_0.4625_InsetCrnBrace", this, 4, 0.0m);
            part.PartGroupType = "AssyHrdwrSash";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // FlatHead_8-32x3/16_UndercutHead
            part = new Part(502, "FlatHead_8-32x3/16_UndercutHead", this, 16, 0.0m);
            part.PartGroupType = "AssyHrdwrSash";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // AlumCnrBrkt
            part = new Part(3206, "AlumCnrBrkt", this, 4, 0.0m);
            part.PartGroupType = "AssyHrdwrSash";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // PointSet1/4x20Screw
            part = new Part(1545, "PointSet1/4x20Screw", this, 16, 0.0m);
            part.PartGroupType = "AssyHrdwrSash";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region HardWare

            ////////////////////////////////////////////////////////////////////////////////

            // HDPE_HingeBacker
            part = new Part(5080, "HDPE_HingeBacker", this, 1, 0.0m);
            part.PartGroupType = "HardWare";
            part.PartThick = 0.75m;
            part.PartWidth = 0.5625m;
            part.PartLength = 9.0m;
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // Hinges
            decimal _wieght = FrameWorks.Functions.PanelWieghtS3000(SubAssemblyWidth, SubAssemblyHieght);
            decimal hingesize = SubAssemblyHieght;
            string id = this.Parent.UnitID.ToString();
            if (_wieght < 250.0m)
            {
                part = new Part(Functions.S3000AwningHinge(hingesize), "Awning Hinge", this, 2, 0.0m);
                part.PartGroupType = "HardWare";
                m_parts.Add(part);
            }
            else
            {
                string message = "The Component is too heavy-" + id.ToString();
                Debug.WriteLine(message);
            }

            int hardwarecount = 1;
            if (m_subAssemblyHieght < 48.0m)
            {
                hardwarecount = 1;
            }
            else
            {
                hardwarecount = 2;
            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Glass

            //////////////////////////////////////////////////////////////////////////////

            // Glass Panels
            part = new Part(5503);
            part.FunctionalName = "GlassLite";
            part.PartGroupType = "Glass";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = (m_subAssemblyWidth - glassReduce2X);
            part.PartLength = (m_subAssemblyHieght - glassReduce2X);
            part.PartThick = 1.25m;
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Seal/Weatherstripping

            //////////////////////////////////////////////////////////////////////////////

            //SashEdgeSeal
            for (int i = 0; i < 1; i++)
            {
                decimal periSash = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - edgeSealAdd, m_subAssemblyWidth - edgeSealAdd);
                part = new Part(2274, "SashEdgeSeal", this, 1, peri);
                part.PartGroupType = "Seal";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            //GlazingEPDM
            for (int i = 0; i < 1; i++)
            {
                decimal periSash = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gaskSashReduce, m_subAssemblyWidth - gaskSashReduce);
                part = new Part(4314, "GlazPreSetEPDM", this, 1, peri);
                part.PartGroupType = "Seal";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            //GlazWedgEPDM
            for (int i = 0; i < 1; i++)
            {
                decimal periSash = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gaskSashReduce, m_subAssemblyWidth - gaskSashReduce);
                part = new Part(4399, "GlazWedgEPDM", this, 1, peri);
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