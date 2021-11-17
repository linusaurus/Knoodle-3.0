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
using FrameWorks.Makes.System3210;


namespace FrameWorks.Makes.System3210
{

    public class DoorBrz_Lead_RtX : SubAssemblyBase
    {

        #region Fields


        // The values we can change for different layouts
        const int panelCount = 1;

        const decimal stopReduceX2 = 2.0m * 2.25m;
        const decimal glassReduceX2 = 2.0m * 2.5625m;
        const decimal gasketReduce = 2.625m;


        #endregion

        #region Constructor

        public DoorBrz_Lead_RtX()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3210-DoorBrz_Lead_RtX";
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

            //////////////////////////////////////////////////////////////////////////////

            #region DoorBrzTB

            //////////////////////////////////////////////////////////////////////////////

            // StileLeft <--
            part = new Part(4112, "StileLeft", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "DoorBrzTB";
            part.PartLabel = "1) Miter Ends";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // StileRight -->
            part = new Part(4112, "StileRight", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "DoorBrzTB";
            part.PartLabel = "1) Miter Ends";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // RailTop ^^
            part = new Part(4112, "RailTop", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "DoorBrzTB";
            part.PartLabel = "1) Miter Ends ";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // RailBot ||
            part = new Part(4112, "RailBot", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "DoorBrzTB";
            part.PartLabel = "1) Miter Ends ";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            //////////////////////////////////////////////////////////////////////////////

            #region StopBrz

            ////////////////////////////////////////////////////////////////////////////////

            // BrzGlsStpL <--
            part = new Part(7134, "BrzGlsStpL", this, 1, m_subAssemblyHieght - stopReduceX2);
            part.PartGroupType = "StopBrz";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // BrzGlsStpR -->
            part = new Part(7134, "BrzGlsStpR", this, 1, m_subAssemblyHieght - stopReduceX2);
            part.PartGroupType = "StopBrz";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // BrzGlsStpTop ^^
            part = new Part(7134, "BrzGlsStpTop", this, 1, m_subAssemblyWidth - stopReduceX2);
            part.PartGroupType = "StopBrz";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // BrzGlsStpBot ||
            part = new Part(7134, "BrzGlsStpBot", this, 1, m_subAssemblyWidth - stopReduceX2);
            part.PartGroupType = "StopBrz";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            //////////////////////////////////////////////////////////////////////////////

            #region Twin_Roller

            // TwinRoller
            part = new Part(4679, "Twin_Roller", this, 2, 0.0m);
            part.PartGroupType = "Twin_Roller";
            part.PartLabel = "Twin_Roller";
            m_parts.Add(part);

            // ACRE™BkrRoller
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4000, "ACRE™BkrRoller", this, 1, 0.0m);
                part.PartGroupType = "Twin_Roller";
                part.PartThick = 0.8043m;
                part.PartWidth = 1.3537m;
                part.PartLength = 3.0m;
                part.PartLabel = "B-20";
                m_parts.Add(part);
            }

            #endregion

            //////////////////////////////////////////////////////////////////////////////

            #region AssyHrdwrDoor

            //////////////////////////////////////////////////////////////////////////////

            // SS_0.7049_CrnBrace 
            part = new Part(4829, "SS_0.7049_CrnBrace", this, 4, 0.0m);
            part.PartGroupType = "AssyHrdwrDoor";
            part.PartLabel = "Green";
            m_parts.Add(part);

            // SS_0.638_CrnBrace 
            part = new Part(4854, "SS_0.638_CrnBrace", this, 4, 0.0m);
            part.PartGroupType = "AssyHrdwrDoor";
            part.PartLabel = "Black";
            m_parts.Add(part);

            // SS_0.4625_CrnBrace 
            part = new Part(4784, "SS_0.4625_CrnBrace", this, 4, 0.0m);
            part.PartGroupType = "AssyHrdwrDoor";
            part.PartLabel = "Yellow";
            m_parts.Add(part);

            // FlatHead_8-32x3/16_UndercutHead
            part = new Part(502, "FH_8-32x3/16_SS", this, 48, 0.0m);
            part.PartGroupType = "AssyHrdwrDoor";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // AlumPVC_CornerBrace 
            for (int i = 0; i < 4; i++)
            {
                part = new Part(2473, "AlumPVC_CornerBrace", this, 1, 1.3125m);
                part.PartGroupType = "AssyHrdwrDoor";
                part.PartWidth = 2.0m;
                part.PartThick = 0.25m;
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            //////////////////////////////////////////////////////////////////////////////

            #region FlushPulls

            //////////////////////////////////////////////////////////////////////////////

            // FP_RearShort <--
            part = new Part(4672, "FP_RearShort", this, 1, 0.0m);
            part.PartGroupType = "FlushPulls";
            part.PartLabel = "";
            m_parts.Add(part);

            // FP_FaceShort <--
            part = new Part(4673, "FP_FaceShort", this, 1, 0.0m);
            part.PartGroupType = "FlushPulls";
            part.PartLabel = "";
            m_parts.Add(part);

            // MachScewOval30mm <--
            part = new Part(4677, "MachScewOval30mm", this, 2, 0.0m);
            part.PartGroupType = "FlushPulls";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            //////////////////////////////////////////////////////////////////////////////

            #region GuidesTop

            //////////////////////////////////////////////////////////////////////////////

            // DelrinTopGuide
            part = new Part(7393, "DelrinTopGuide", this, 1, 2.0m);
            part.PartGroupType = "GuidesTop";
            part.PartLabel = "";
            part.PartThick = 0.95m;
            part.PartWidth = 0.84m;
            m_parts.Add(part);


            // DelrinTopGuide
            part = new Part(7393, "DelrinTopGuide", this, 1, 2.0m);
            part.PartGroupType = "GuidesTop";
            part.PartLabel = "";
            part.PartThick = 0.95m;
            part.PartWidth = 0.84m;
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////


            #endregion

            //////////////////////////////////////////////////////////////////////////////

            #region HookCap

            //////////////////////////////////////////////////////////////////////////////

            // EndCap
            part = new Part(4904, "EndCap", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "HookCap";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // HookStrip
            part = new Part(3710, "HookStrip", this, 1, m_subAssemblyHieght + 0.0625m);
            part.PartGroupType = "HookCap";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            //////////////////////////////////////////////////////////////////////////////

            #region Glass

            //////////////////////////////////////////////////////////////////////////////

            //Glass Panel
            part = new Part(4813);
            part.FunctionalName = "Glass";
            part.PartGroupType = "Glass";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyWidth - glassReduceX2;
            part.PartLength = m_subAssemblyHieght - glassReduceX2;
            part.PartThick = 0.5625m;
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            //////////////////////////////////////////////////////////////////////////////

            #region HDPE

            //////////////////////////////////////////////////////////////////////////////

            // HDPE_BiPartDrGuide
            part = new Part(5296, "HDPE_BiPartDrGuide", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "HDPE";
            part.PartLabel = "B-15";
            part.PartThick = 0.8494m;
            part.PartWidth = 1.3438m;
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            //////////////////////////////////////////////////////////////////////////////

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

            // BottomSeal
            part = new Part(5468, "BottomSeal", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Seal";
            part.PartLabel = "";
            m_parts.Add(part);


            // BottomSeal
            part = new Part(5468, "BottomSeal", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Seal";
            part.PartLabel = "";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////

            // HookPileT+Fin
            part = new Part(3959, "HookPileT+Fin", this, 1, m_subAssemblyHieght + 0.0625m);
            part.PartGroupType = "Seal";
            part.PartLabel = "";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////

            // HookPileT+Fin
            part = new Part(3959, "HookPileT+Fin", this, 1, m_subAssemblyHieght + 0.0625m);
            part.PartGroupType = "Seal";
            part.PartLabel = "";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            //////////////////////////////////////////////////////////////////////////////

        }

        #endregion

    }

}