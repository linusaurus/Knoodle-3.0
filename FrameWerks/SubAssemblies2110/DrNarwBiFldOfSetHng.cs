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
using FrameWorks.Makes.System2110;


namespace FrameWorks.Makes.System2110
{

    public class DrNarwBiFldOfSetHng : SubAssemblyBase
    {

        #region Fields


        // The values we can change for different layouts
        const int panelCount = 1;

        const decimal stopReduceX2 = 2.0m * 0.71875m;
        const decimal glassReduceX2 = 2.0m * 1.0625m;
        const decimal gasketReduce = 1.0625m;

        #endregion

        #region Constructor

        public DrNarwBiFldOfSetHng()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System2110-DrNarwBiFldOfSetHng";
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

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region DoorAlumTB

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // StileLeft
            part = new Part(5710, "StileLeft", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "DoorAlumTB";
            part.PartLabel = "1) Miter Ends ";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // StileRight
            part = new Part(5710, "StileRight", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "DoorAlumTB";
            part.PartLabel = "1) Miter Ends ";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // RailTop
            part = new Part(5710, "RailTop", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "DoorAlumTB";
            part.PartLabel = "1) Miter Ends ";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // RailBot
            part = new Part(5710, "RailBot", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "DoorAlumTB";
            part.PartLabel = "1) Miter Ends ";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region StopAlum

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // AlumGlsStopL <--
            part = new Part(5711, "AlumGlsStopL", this, 1, m_subAssemblyHieght - stopReduceX2);
            part.PartGroupType = "StopAlum";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // AlumGlsStopR -->
            part = new Part(5711, "AlumGlsStopR", this, 1, m_subAssemblyHieght - stopReduceX2);
            part.PartGroupType = "StopAlum";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // AlumGlsStopT ^^
            part = new Part(5711, "AlumGlsStopT", this, 1, m_subAssemblyWidth - stopReduceX2);
            part.PartGroupType = "StopAlum";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // AlumGlsStopB ||
            part = new Part(5711, "AlumGlsStopB", this, 1, m_subAssemblyWidth - stopReduceX2);
            part.PartGroupType = "StopAlum";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region AssyHrdwrDoor

            //////////////////////////////////////////////////////////////////////////////

            // SS_0.4625_InsetCrnBrace 
            part = new Part(4784, "SS_0.4625_InsetCrnBrace", this, 4, 0.0m);
            part.PartGroupType = "AssyHrdwrDoor";
            part.PartLabel = "Yellow";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // FlatHead
            part = new Part(502, "FlatHead", this, 16, 0.0m);
            part.PartGroupType = "AssyHrdwrDoor";
            part.PartLabel = "#8-32x3/16_UndercutHead";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // AglBrktAlum
            part = new Part(2931, "AglBrktAlum", this, 4, 0.0m);
            part.PartGroupType = "AssyHrdwrDoor";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // PointSetScrew
            part = new Part(5190, "PointSetScrew", this, 16, 0.0m);
            part.PartGroupType = "AssyHrdwrDoor";
            part.PartLabel = "1/4x20";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region Handle


            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region HDPE_EDGE

            // HDPE
            part = new Part(5050, "HDPE", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "HDPE_EDGE";
            part.PartWidth = 1.5881m;
            part.PartThick = 1.0398m;
            part.PartLabel = "Tongue";
            m_parts.Add(part);

            // HDPE
            part = new Part(5121, "HDPE", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "HDPE_EDGE";
            part.PartWidth = 1.5881m;
            part.PartThick = 0.6569m;
            part.PartLabel = "Groove";
            m_parts.Add(part);

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region Glass

            //////////////////////////////////////////////////////////////////////////////

            //Glass
            part = new Part(5643);
            part.FunctionalName = "Glass";
            part.PartGroupType = "Glass";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyWidth - glassReduceX2;
            part.PartLength = m_subAssemblyHieght - glassReduceX2;
            part.PartThick = 1.25m;
            part.PartLabel = "SNX 51/23_IS20";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // LeftSpacer_875
            part = new Part(4976, "LeftSpacer_875", this, 1, m_subAssemblyHieght - glassReduceX2);
            part.PartGroupType = "Glass";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // RightSpacer_875
            part = new Part(4976, "RightSpacer_875", this, 1, m_subAssemblyHieght - glassReduceX2);
            part.PartGroupType = "Glass";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // TopSpacer_875
            part = new Part(4976, "TopSpacer_875", this, 1, m_subAssemblyWidth - glassReduceX2);
            part.PartGroupType = "Glass";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // BotSpacer_875
            part = new Part(4976, "BotSpacer_875", this, 1, m_subAssemblyWidth - glassReduceX2);
            part.PartGroupType = "Glass";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region HardWare

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // E4_Offset_Hinge
            part = new Part(3971, "E4_Offset_Hinge", this, 2, 0.0m);
            part.PartGroupType = "HardWare";
            part.PartLabel = "";
            m_parts.Add(part);

            // BI-FOLD HNG BKR (2)
            part = new Part(3984, "BI-FOLD HNG BKR (2)", this, 2, 0.0m);
            part.PartGroupType = "HardWare";
            part.PartLabel = "";
            m_parts.Add(part);

            // CARRIER HNG BKR (4)
            part = new Part(3985, "CARRIER HNG BKR (4)", this, 2, 0.0m);
            part.PartGroupType = "HardWare";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region Seal/Weatherstripping

            //EPDM_PreSet
            for (int i = 0; i < 1; i++)
            {
                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);
                part = new Part(5713, "EPDM_PreSet", this, 1, peri);
                part.PartGroupType = "Seal";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////

            //EPDM_Wedge
            for (int i = 0; i < 1; i++)
            {
                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);
                part = new Part(5714, "EPDM_Wedge", this, 1, peri);
                part.PartGroupType = "Seal";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////

            // Top_Pile
            part = new Part(1025, "Top_Pile", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Seal";
            part.PartLabel = "";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////

            // Edge_Seal
            part = new Part(2274, "Edge_Seal", this, 2, m_subAssemblyHieght);
            part.PartGroupType = "Seal";
            part.PartLabel = "";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////

            // DoorBottom
            part = new Part(1518, "DoorBottom", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Seal";
            part.PartLabel = "";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

        }

        #endregion

    }

}