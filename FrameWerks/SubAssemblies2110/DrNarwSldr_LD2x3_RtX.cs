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

    public class DrNarwSldr_LD2x3_RtX : SubAssemblyBase
    {

        #region Fields

        // The values we can change for different layouts
        const int panelCount = 1;

        const decimal stopReduceX2 = 2.0m * 0.71875m;
        const decimal glassReduceX2 = 2.0m * 1.0625m;
        const decimal muntinThick = 1.0m;
        const decimal muntinThick2X = 2.0m * 1.0m;
        const decimal gasketReduce = 1.0625m;
        const decimal muntinReduce2X = 1.59375m * 2.0m;

        #endregion

        #region Constructor

        public DrNarwSldr_LD2x3_RtX()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System2110-DrNarwSldr_LD2x3_RtX";
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



            #region DoorAlumTB

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // StileLeft
            part = new Part(5710, "StileLeft", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "DoorAlumTB";
            part.PartLabel = "1) Miter Ends";
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

            ////////////////////////////////////////////////////////////////////////////////

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

            #region MuntinBars

            /////////////////////////////////////////////////////////////////////////////////////////////////////////

            // MuntinBar1
            part = new Part(6924, "MuntinBarsInt", this, 1, (m_subAssemblyHieght - muntinReduce2X - muntinThick2X) / 3.0m);
            part.PartGroupType = "MuntinBar1";
            part.PartLabel = "";
            part.PartWidth = 1.0m; 
            m_parts.Add(part);

            // MuntinBar2
            part = new Part(6924, "MuntinBarsInt", this, 1, (m_subAssemblyHieght - muntinReduce2X - muntinThick2X) / 3.0m);
            part.PartGroupType = "MuntinBar2";
            part.PartLabel = "";
            part.PartWidth = 1.0m;
            m_parts.Add(part);

            // MuntinBar3
            part = new Part(6924, "MuntinBarsInt", this, 1, (m_subAssemblyHieght - muntinReduce2X - muntinThick2X) / 3.0m);
            part.PartGroupType = "MuntinBar3";
            part.PartLabel = "";
            part.PartWidth = 1.0m;
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////

            // MuntinBar1
            part = new Part(6924, "MuntinBarsInt", this, 1, m_subAssemblyWidth - muntinReduce2X);
            part.PartGroupType = "MuntinBar1";
            part.PartLabel = "Horz";
            part.PartWidth = 1.0m;
            m_parts.Add(part);

            // MuntinBar2
            part = new Part(6924, "MuntinBarsInt", this, 1, m_subAssemblyWidth - muntinReduce2X);
            part.PartGroupType = "MuntinBar2";
            part.PartLabel = "Horz";
            part.PartWidth = 1.0m;
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////

            // MuntinBar1
            part = new Part(3736, "MuntinBarsExt", this, 1, (m_subAssemblyHieght - muntinReduce2X - muntinThick2X) / 3.0m);
            part.PartGroupType = "MuntinBar1";
            part.PartLabel = "Vert";
            part.PartWidth = 1.0m;
            m_parts.Add(part);

            // MuntinBar2
            part = new Part(3736, "MuntinBarsExt", this, 1, (m_subAssemblyHieght - muntinReduce2X - muntinThick2X) / 3.0m);
            part.PartGroupType = "MuntinBar2";
            part.PartLabel = "Vert";
            part.PartWidth = 1.0m;
            m_parts.Add(part);

            // MuntinBar3
            part = new Part(3736, "MuntinBarsExt", this, 1, (m_subAssemblyHieght - muntinReduce2X - muntinThick2X) / 3.0m);
            part.PartGroupType = "MuntinBar3";
            part.PartLabel = "Vert";
            part.PartWidth = 1.0m;
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////

            // MuntinBar1
            part = new Part(3736, "MuntinBarsExt", this, 1, m_subAssemblyWidth - muntinReduce2X);
            part.PartGroupType = "MuntinBar1";
            part.PartLabel = "Horz";
            part.PartWidth = 1.0m;
            m_parts.Add(part);

            // MuntinBar2
            part = new Part(3736, "MuntinBarsExt", this, 1, m_subAssemblyWidth - muntinReduce2X);
            part.PartGroupType = "MuntinBar2";
            part.PartLabel = "Horz";
            part.PartWidth = 1.0m;
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region HDPE

            /////////////////////////////////////////////////////////////////////////////////////////////////////////

            // HDPE_BotFiller           
            part = new Part(6923, "HDPE_BotFiller", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "HDPE";
            part.PartWidth = part.Source.Width = 0.9227m;
            part.PartThick = part.Source.Height = 0.7155m;
            part.PartLabel = "labelBotRail";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////

            // EPDM_Gasket
            part = new Part(3783, "EPDM_Gasket", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "HDPE";
            part.PartLabel = "labelBotRail";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region AssyHrdwrDoor

            //////////////////////////////////////////////////////////////////////////////

            // SS_0.4625_InsetCrnBrace 
            part = new Part(4784, "SS_0.4625_InsetCrnBrace", this, 4, 0.0m);
            part.PartGroupType = "AssyHrdwrDoor";
            part.PartLabel = "Yellow";
            m_parts.Add(part);

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

            // PointSetScrew
            part = new Part(5190, "PointSetScrew", this, 16, 0.0m);
            part.PartGroupType = "AssyHrdwrDoor";
            part.PartLabel = "1/4x20";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region Handle

            // Slde_LeverPull_Set
            part = new Part(6914, "Slde_LeverPull_Set", this, 1, 0.0m);
            part.PartGroupType = "Handle";
            part.PartLabel = "";
            m_parts.Add(part);

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region HookCap

            // HDPE
            part = new Part(6961, "HDPE", this, 1, m_subAssemblyHieght + 0.0625m);
            part.PartGroupType = "HookCap";
            part.PartWidth = part.Source.Width = 2.1315m;
            part.PartLabel = "";
            m_parts.Add(part);

            // EdgeCap
            part = new Part(3623, "EdgeCap", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "HookCap";
            part.PartLabel = "";
            m_parts.Add(part);

            // HookStrip
            part = new Part(3710, "HookStrip", this, 1, m_subAssemblyHieght + 0.0625m);
            part.PartGroupType = "HookCap";
            part.PartWidth = part.Source.Width = 1.3411m;
            part.PartLabel = "CutWidthTo_1.3411";
            m_parts.Add(part);

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region Glass

            //Glass
            part = new Part(6883);
            part.FunctionalName = "Glass";
            part.PartGroupType = "Glass";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyWidth - glassReduceX2;
            part.PartLength = m_subAssemblyHieght - glassReduceX2;
            part.PartThick = 1.25m;
            part.PartLabel = "2x3_SDL";
            m_parts.Add(part);

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region HardWare

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // CarriageBarX
            part = new Part(4279, "CarriageBarX", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "HardWare";
            part.PartLabel = "";
            m_parts.Add(part); ;

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // BearingAxel
            part = new Part(4277, "BearingAxel", this, FrameWorks.Functions.BearingCountByWeight(Wieght), 0.0m);
            part.PartGroupType = "Hardware";
            part.PartLength = 1.598m;
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //for (int i = 0; i < bearingcount; i++)
            part = new Part(6972, "WHEEL_304SS", this, FrameWorks.Functions.BearingCountByWeight(Wieght), 0.0m);
            part.PartGroupType = "HardWare";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // LockBoltKits
            part = new Part(3431, "LockBoltKits", this, 2, m_subAssemblyHieght);
            part.PartGroupType = "Hardware";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // ShimsLockBolt
            part = new Part(3383, "ShimsLockBolt", this, 2, m_subAssemblyHieght);
            part.PartGroupType = "Hardware";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region Seal/Weatherstripping

            /////////////////////////////////////////////////////////////////////////////////////////////////////////

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

            // Edge_Seal
            part = new Part(1005, "Edge_Seal", this, 2, m_subAssemblyHieght);
            part.PartGroupType = "Seal";
            part.PartLabel = "";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////

            // BotPileKerf+Fin
            part = new Part(5468, "BotPileKerf+Fin", this, 2, m_subAssemblyWidth);
            part.PartGroupType = "Seal";
            part.PartLabel = "";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////

            // HookPileT+Fin
            part = new Part(3959, "HookPileT+Fin", this, 2, m_subAssemblyHieght + 0.0625m);
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