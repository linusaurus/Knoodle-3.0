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
using FrameWorks.Makes.System3220;


namespace FrameWorks.Makes.System3220
{

    public class WndBrz_LS1x3LX : SubAssemblyBase
    {

        #region Fields


        // The values we can change for different layouts
        const int panelCount = 1;

        const decimal stopReduceX2 = 2.0m * 2.25m;
        const decimal glassReduceX2 = 2.0m * 2.5625m;
        const decimal sashStopRedX2 = 2.0m * 2.75m;
        const decimal muntinDrReduce = 3.125m;
        const decimal muntinDrReduceX2 = 3.125m * 2.0m;

        #endregion

        #region Constructor

        public WndBrz_LS1x3LX()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3220-WndBrz_LS1x3LX";
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

            // StileLeft
            part = new Part(4312, "StileLeft", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "DoorBrzTB-Parts";
            part.PartLabel = "1) Miter Ends";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // StileRight
            part = new Part(4312, "StileRight", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "DoorBrzTB-Parts";
            part.PartLabel = "1) Miter Ends";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // RailTop
            part = new Part(4312, "RailTop", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "DoorBrzTB-Parts";
            part.PartLabel = "1) Miter Ends ";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // RailBot
            part = new Part(4312, "RailBot", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "DoorBrzTB-Parts";
            part.PartLabel = "1) Miter Ends ";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            //////////////////////////////////////////////////////////////////////////////

            #region StopBzBead

            //////////////////////////////////////////////////////////////////////////////

            // BzBeadStpVert
            for (int i = 0; i < 2; i++)
            {
                part = new Part(6888, "BzBeadStpVert", this, 1, m_subAssemblyHieght - stopReduceX2);
                part.PartGroupType = "StopBzBead-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            // BzBeadStpTopBot
            for (int i = 0; i < 2; i++)
            {
                part = new Part(6888, "BzBeadStpTopBot", this, 1, m_subAssemblyWidth - stopReduceX2);
                part.PartGroupType = "StopBzBead-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            //////////////////////////////////////////////////////////////////////////////
            
            #region BeadMuntin

            //////////////////////////////////////////////////////////////////////////////

            // BeadMuntin_Hrz
            for (int i = 0; i < 2; i++)
            {
                part = new Part(6889, "BeadMuntin_Hrz", this, 1, m_subAssemblyWidth - sashStopRedX2);
                part.PartGroupType = "BeadMuntin";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Muntin_Flat

            //////////////////////////////////////////////////////////////////////////////

            // Muntin_FlatHrz
            for (int i = 0; i < 2; i++)
            {
                part = new Part(6887, "Muntin_FlatHrz", this, 1, m_subAssemblyWidth - muntinDrReduceX2);
                part.PartGroupType = "Muntin_Flat";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            //////////////////////////////////////////////////////////////////////////////

            #region HDPE

            //////////////////////////////////////////////////////////////////////////////

            // HDPE_LS_LockEdge
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4780, "HDPE_LS_LockEdge", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "HDPE-Parts";
                part.PartLabel = labelStileR = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            // HDPETop
            for (int i = 0; i < 2; i++)
            {
                part = new Part(5217, "HDPETop", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "HDPE-Parts";
                part.PartLabel =  labelTopRail = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            // HDPETop
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4438, "HDPETop", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "HDPE-Parts";
                part.PartLabel = labelTopRail = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            // HDPETop
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4438, "HDPETop", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "HDPE-Parts";
                part.PartLabel = labelTopRail = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            //////////////////////////////////////////////////////////////////////////////

            #region AssyBrackets

            //AlumPVC_CornerBrace
            part = new Part(5611, "AlumPVC_CornerBrace", this, 4, 0.0m);
            part.PartGroupType = "AssyBrackets-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            //Green_CnrBrcSS14ga_0.7049
            part = new Part(4829, "Green_CnrBrcSS14ga_0.7049", this, 8, 0.0m);
            part.PartGroupType = "AssyBrackets-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            //Blue_CnrBrcSS14ga_0.4662
            part = new Part(4855, "Blue_CnrBrcSS14ga_0.4662", this, 4, 0.0m);
            part.PartGroupType = "AssyBrackets-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            //MS_FlatHead_8-32x3/16_SS
            part = new Part(502, "MS_FlatHead_8-32x3/16_SS", this, 48, 0.0m);
            part.PartGroupType = "AssyBrackets-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            //////////////////////////////////////////////////////////////////////////////

            #region GuidesTop

            //////////////////////////////////////////////////////////////////////////////

            // TopGuide4440
            part = new Part(4440, "TopGuide4440", this, 1, 0.0m);
            part.PartGroupType = "GuidesTop-Parts";
            part.PartLabel = "4440_LockStile";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // TopGuide5212
            part = new Part(5212, "TopGuide5212", this, 1, 0.0m);
            part.PartGroupType = "GuidesTop-Parts";
            part.PartLabel = "5212_Overlap";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            //////////////////////////////////////////////////////////////////////////////

            #region HookCap

            //////////////////////////////////////////////////////////////////////////////

            // EndCap
            part = new Part(4498, "EndCap", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "HookCap-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // HookStrip
            part = new Part(3710, "HookStrip", this, 1, m_subAssemblyHieght + 0.0625m);
            part.PartGroupType = "HookCap-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            //////////////////////////////////////////////////////////////////////////////

            #region Glass

            //////////////////////////////////////////////////////////////////////////////

            //GlassSDL1x3
            part = new Part(6898);
            part.FunctionalName = "GlassSDL1x3";
            part.PartGroupType = "GlassSDL1x3-Parts";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyWidth - glassReduceX2;
            part.PartLength = m_subAssemblyHieght - glassReduceX2;
            part.PartThick = 1.0m;
            part.PartLabel = "SDL1x3";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            //////////////////////////////////////////////////////////////////////////////

            #region HardWare Logic

            //////////////////////////////////////////////////////////////////////////////

            // LiftSlideGear
            part = new Part(3958, "LiftSlideGear", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // CoverExtension
            if (m_subAssemblyHieght >= 104.0m)
            {
                int c;
                decimal result = decimal.Zero;
                result = (m_subAssemblyHieght - 104.0m);
                result = decimal.Divide(result, 24.0m);
                if (result > 0.0m && result < 24.0m)
                {
                    c = 1;
                }
                else
                {
                    c = Convert.ToInt32(Math.Round(result, 0)) + 1;
                }
                part = new Part(3430, "CoverExtension", this, c, 24.0m);
                part.PartGroupType = "Hardware-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            // LockBoltKits
            part = new Part(3431, "LockBoltKits", this, 2, m_subAssemblyHieght);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // ShimsLockBolt
            part = new Part(3383, "ShimsLockBolt", this, 2, m_subAssemblyHieght);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // CarrageKit
            part = new Part(3422, "CarrageKit", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // LinkRod
            if (m_subAssemblyWidth >= 25.5m && m_subAssemblyWidth < 130.0m)
            {
                if (m_subAssemblyWidth >= 25.5m && m_subAssemblyWidth <= 50.0m)
                {
                    part = new Part(5483, "LinkRod", this, 1, m_subAssemblyWidth);
                }
                if (m_subAssemblyWidth > 50.0m && m_subAssemblyWidth <= 78.0m)
                {
                    part = new Part(5483, "LinkRod", this, 1, m_subAssemblyWidth);
                }
                if (m_subAssemblyWidth > 78.0m && m_subAssemblyWidth <= 130.0m)
                {
                    part = new Part(3424, "LinkRod", this, 1, m_subAssemblyWidth);
                }
            }
            else
            {
                part = new Part(911, "LinkRod", this, 1, m_subAssemblyWidth);
            }
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            //////////////////////////////////////////////////////////////////////////////

            #region Seal/Weatherstripping

            //////////////////////////////////////////////////////////////////////////////

            //GlazPreSetEPDM
            for (int i = 0; i < 1; i++)
            {
                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - 2.7313m, m_subAssemblyWidth - 2.7313m);
                part = new Part(4314, "GlazPreSetEPDM", this, 1, peri);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            //GlazWedgEPDM
            for (int i = 0; i < 1; i++)
            {
                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - 2.6286m, m_subAssemblyWidth - 2.6286m);
                part = new Part(4399, "GlazWedgEPDM", this, 1, peri);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            // Edge & Bottom Seal
            for (int i = 0; i < 2; i++)
            {
                part = new Part(1005, "Edge & Bottom Seal", this, 1, m_subAssemblyHieght + m_subAssemblyWidth);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            // Top Seal
            for (int i = 0; i < 2; i++)
            {
                part = new Part(3783, "Top Seal", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            // HookPileT+Fin
            for (int i = 0; i < 2; i++)
            {
                part = new Part(3959, "HookPileT+Fin", this, 1, m_subAssemblyHieght + 0.0625m);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            //////////////////////////////////////////////////////////////////////////////

        }

        #endregion

    }

}