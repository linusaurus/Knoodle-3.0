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
using System.Diagnostics;

namespace FrameWorks.Makes.System2110
{

    public class Awning2Actuator : SubAssemblyBase
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

        //static int createID;

        #endregion

        #region Constructor

        public Awning2Actuator()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System2110-Awning2Actuator";
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

            // JmbAlumL <--
            part = new Part(4347, "JmbAlumL", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame";
            part.PartLabel = "SeeDetail";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // JmbAlumR -->
            part = new Part(4347, "JmbAlumR", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame";
            part.PartLabel = "SeeDetail";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // HeadAlum ^^
            part = new Part(4347, "HeadAlum", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame";
            part.PartLabel = "SeeDetail";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // SillAlum ||
            part = new Part(4347, "SillAlum", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame";
            part.PartLabel = "SeeDetail";
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
            part = new Part(4430, "ScrnFrmVertL", this, 1, m_subAssemblyHieght - screenReduce2X);
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

            #region OperHardware

            //////////////////////////////////////////////////////////////////////////////

            // LM/2_Actuator_Tandem
            part = new Part(5454, "LM/2_Actuator_Tandem", this, 1, 0.0m);
            part.PartGroupType = "OperHardware";
            part.PartLabel = "";
            m_parts.Add(part);

           //////////////////////////////////////////////////////////////////////////////

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
            part = new Part(5710, "StileAlumL", this, 1, m_subAssemblyHieght - frameReduce2X);
            part.PartGroupType = "Sash";
            part.PartLabel = labelStileL = "MiterEnds";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // StileAlumR -->>
            part = new Part(5710, "StileAlumR", this, 1, m_subAssemblyHieght - frameReduce2X);
            part.PartGroupType = "Sash";
            part.PartLabel = labelStileR = "1)MiterEnds" + "r\n" +
                                           "2)MachineKeeper";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // RailAlumT ^^
            part = new Part(5710, "RailAlumT", this, 1, m_subAssemblyWidth - frameReduce2X);
            part.PartGroupType = "Sash";
            part.PartLabel = labelTopRail = "1)MiterEnds" + "\r\n" +
                                            "2)Machine3121Left";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // RailAlumB ||
            part = new Part(5710, "RailAlumB", this, 1, m_subAssemblyWidth - frameReduce2X);
            part.PartGroupType = "Sash";
            part.PartLabel = labelBotRail = "1)MiterEnds" + "\r\n" +
                                            "2)Machine3121Left";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region StopAlum

            //////////////////////////////////////////////////////////////////////////////

            // AlumGlsStopL <--
            part = new Part(5711, "AlumGlsStpVt", this, 1, m_subAssemblyHieght - gstopReduce2X);
            part.PartGroupType = "StopAlum";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // AlumGlsStopR <--
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

            // AglBrktAlum
            part = new Part(2931, "AglBrktAlum", this, 4, 0.0m);
            part.PartGroupType = "AssyHrdwrSash";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // PointSetScrew
            part = new Part(5190, "PointSetScrew", this, 16, 0.0m);
            part.PartGroupType = "AssyHrdwrSash";
            part.PartLabel = "1/4x20x.375";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region HardWare

            ////////////////////////////////////////////////////////////////////////////////

            // HDPE_HingeBacker
            part = new Part(5080, "HDPE_HingeBacker", this, 2, 0.0m);
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

            // Glass 
            part = new Part(2903);
            part.FunctionalName = "Glass";
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

            //EPDM_PreSet
            for (int i = 0; i < 1; i++)
            {
                decimal periSash = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gaskSashReduce, m_subAssemblyWidth - gaskSashReduce);
                part = new Part(5713, "EPDM_PreSet", this, 1, peri);
                part.PartGroupType = "Seal";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            //EPDM_Wedge
            for (int i = 0; i < 1; i++)
            {
                decimal periSash = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gaskSashReduce, m_subAssemblyWidth - gaskSashReduce);
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