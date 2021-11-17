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

    public class DrSwgElip1x4ActLHR : SubAssemblyBase
    {

        #region Fields

        // The values we can change for different layouts
        const decimal glsDrGapX2 = 2.5625m * 2.0m;
        const decimal epdmReduce = 2.73129921m;
        const decimal epdmADD = 2.375m;
        const decimal edgeSealAdd = .390m;
        const decimal hdpExtnd = 0.1250m;
        const decimal stopReduce = 2.25m;
        const decimal stopReduceX2 = 2.25m * 2.0m;
        const decimal muntinDrReduce = 3.125m;
        const decimal muntinDrReduceX2 = 3.125m * 2.0m;
        const decimal π = 3.14159m;
        const decimal grip2X = 12.0m * 2.0m;
        const decimal rise = 27.125m;

        ////////////////////////////////////////////////////////////////////////////////////

        #endregion

        #region Constructor

        public DrSwgElip1x4ActLHR()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3220-DrSwgElip1x4ActLHR";
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

            #region BrzTB3inch

            ////////////////////////////////////////////////////////////////////////////////////

            // StileLeft
            part = new Part(4312, "StileLeft", this, 1, m_subAssemblyHieght - rise);
            part.PartGroupType = "BrzTB3inch";
            part.PartLabel = "1) Miter_Ends";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // StileRight
            part = new Part(4312, "StileRight", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "BrzTB3inch";
            part.PartLabel = "1) Miter_Ends";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // RailTop
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4312, "RailTop_Stretch_Form", this, 1, m_subAssemblyDepth);
                part.PartGroupType = "BrzTB3inch";
                part.PartLabel = "1) Miter_Ends ";
                m_parts.Add(part);
            }


            ////////////////////////////////////////////////////////////////////////////////////

            // RailBot
            part = new Part(4312, "RailBot", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "BrzTB3inch";
            part.PartLabel = "1) Miter_Ends ";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region HDPE

            ////////////////////////////////////////////////////////////////////////////////////

            // HDPELockEdge
            part = new Part(5330, "HDPELockEdge", this, 1, m_subAssemblyHieght + hdpExtnd);
            part.PartGroupType = "HDPE-Parts";
            part.PartLabel = labelStileL = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // HDPEHingEdge
            part = new Part(5536, "HDPEHingEdge", this, 1, m_subAssemblyHieght + hdpExtnd);
            part.PartGroupType = "HDPE-Parts";
            part.PartLabel = labelStileR = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // HDPEHingEdge
            part = new Part(5060, "HDPEHingEdge", this, 1, m_subAssemblyHieght + hdpExtnd);
            part.PartGroupType = "HDPE-Parts";
            part.PartLabel = labelStileR = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // HDPEBot
            part = new Part(5538, "HDPEBot", this, 1, m_subAssemblyWidth + 2.0M * hdpExtnd);
            part.PartGroupType = "HDPE-Parts";
            part.PartLabel = labelBotRail = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // HDPEBot
            part = new Part(5539, "HDPEBot", this, 1, m_subAssemblyWidth + 2.0M * hdpExtnd);
            part.PartGroupType = "HDPE-Parts";
            part.PartLabel = labelBotRail = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region BeadMuntin

            //////////////////////////////////////////////////////////////////////////////

            // BeadMuntin_Hrz
            for (int i = 0; i < 3; i++)
            {
                part = new Part(6889, "BeadMuntin_Hrz", this, 1, m_subAssemblyWidth - stopReduceX2);
                part.PartGroupType = "BeadMuntin";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Muntin_Flat

            //////////////////////////////////////////////////////////////////////////////
            
            // Muntin_FlatHrz
            for (int i = 0; i < 3; i++)
            {
                part = new Part(6887, "Muntin_FlatHrz", this, 1, m_subAssemblyWidth - muntinDrReduceX2);
                part.PartGroupType = "Muntin_Flat";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Muntin_Dia

            //////////////////////////////////////////////////////////////////////////////

            // 3in_Ø_Circle
            for (int i = 0; i < 8; i++)
            {
                part = new Part(6910, "3in_Ø_Circle", this, 1, 3.0m);
                part.PartGroupType = "Muntin_Dia";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            // MntDiaExt
            for (int i = 0; i < 16; i++)
            {
                part = new Part(6903, "MntDiaExt", this, 1, 28.125m);
                part.PartGroupType = "Muntin_Dia";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            // MntDiaInt
            for (int i = 0; i < 16; i++)
            {
                part = new Part(6903, "MntDiaInt", this, 1, 28.125m);
                part.PartGroupType = "Muntin_Dia";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region StopBrz

            ////////////////////////////////////////////////////////////////////////////////////

            // BrzGlsStpVert
            part = new Part(6888, "BrzGlsStpVert", this, 1, m_subAssemblyHieght - stopReduceX2);
            part.PartGroupType = "StopBrz-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // BrzGlsStpVert
            part = new Part(6888, "BrzGlsStpVert", this, 1, m_subAssemblyHieght - rise - stopReduce);
            part.PartGroupType = "StopBrz-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // BrzGlsStpTop
            for (int i = 0; i < 2; i++)
            {
                part = new Part(6888, "BrzGlsStp_Stretch_Form", this, 1, m_subAssemblyDepth);
                part.PartGroupType = "StopBrz-Parts";
                part.PartLabel = "Stretch_Form";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////

            // BrzGlsStpBot
            part = new Part(6888, "BrzGlsStpBot", this, 2, m_subAssemblyWidth - stopReduceX2);
            part.PartGroupType = "StopBrz-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Glass

            ////////////////////////////////////////////////////////////////////////////////

            // GlassPanel
            part = new Part(6898);
            part.FunctionalName = "Gls1x4_SDL";
            part.PartGroupType = "Glass-Parts";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = (m_subAssemblyWidth - glsDrGapX2);
            part.PartLength = (m_subAssemblyHieght - glsDrGapX2);
            part.PartThick = 1.0m;
            part.PartLabel = "1x4_Pattern";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Delivery

            ////////////////////////////////////////////////////////////////////////////////

            // Handle_Set
            part = new Part(5218, "Handle_Set", this, 1, 0.0m);
            part.PartGroupType = "Delivery-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region HardWare Logic

            ////////////////////////////////////////////////////////////////////////////////

            // Hinges
            part = new Part(5594, "Hinges", this, HingeCount2 (m_subAssemblyHieght), 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = ".25_RAD_Corner";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            //AmesburyMultipointActive
            FrameWorks.Makes.Hardware.Amesbury40.Premiere2000.MultipointActive GearAssy =
                new FrameWorks.Makes.Hardware.Amesbury40.Premiere2000.MultipointActive(m_subAssemblyHieght, this);
            foreach (Part innerpart in GearAssy.Parts)
            {
                //inner
                this.Parts.Add(innerpart);
            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region AssyBrackets

            ////////////////////////////////////////////////////////////////////////////////

            //AlumPVC_CornerBrace
            part = new Part(5611, "AlumPVC_CornerBrace", this, 4, 0.0m);
            part.PartGroupType = "AssyBrackets-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            //Blue_CnrBrcSS14ga_0.4662
            part = new Part(4855, "Blue_CnrBrcSS14ga_0.4662", this, 4, 0.0m);
            part.PartGroupType = "AssyBrackets-Parts";
            part.PartLabel = "Blue";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            //Black_CnrBrcSS14ga_0.638
            part = new Part(4854, "Black_CnrBrcSS14ga_0.638", this, 8, 0.0m);
            part.PartGroupType = "AssyBrackets-Parts";
            part.PartLabel = "Black";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            //MS_FlatHead_8-32x3/16_SS
            part = new Part(502, "MS_FlatHead_8-32x3/16_SS", this, 48, 0.0m);
            part.PartGroupType = "AssyBrackets-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Seal/Weatherstripping

            ////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {
                decimal periSeal = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);
                //KfolDrEdge
                part = new Part(2274, "KfolDrEdge", this, 1, periSeal - m_subAssemblyWidth + 4.0m * edgeSealAdd);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////

            //DoorBotPVC
            part = new Part(1518, "DoorBotPVC", this, 1, m_subAssemblyWidth + 2.0m * hdpExtnd);
            part.PartGroupType = "Seal-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // GlazeWedgeSeals
            for (int i = 0; i < 6; i++)
            {
                part = new Part(5714, "GlazeWedgeSeals", this, 1, m_subAssemblyWidth - stopReduceX2);
                part.PartGroupType = "Seal";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {
                decimal periSeal = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);
                //GlazePreSet
                part = new Part(5713, "GlazePreSet", this, 1, periSeal - 4.0m * epdmReduce + 4.0m * epdmADD);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {
                decimal periSeal = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);
                //GlazeWedgeSeals
                part = new Part(5714, "GlazeWedgeSeals", this, 1, periSeal - 4.0m * epdmReduce + 4.0m * epdmADD);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

        }

        //BRONZE
        public static int HingeCount2(decimal HingeAxisLength)
        {
            int result = 0;

            if ((HingeAxisLength >= 42.0m) && (HingeAxisLength < 80.0m))
            {
                result = 3;
            }
            else if ((HingeAxisLength >= 80.0m) && (HingeAxisLength < 84.0m))
            {
                result = 4;
            }
            else if ((HingeAxisLength >= 84.0m) && (HingeAxisLength <= 120.0m))
            {
                result = 5;
            }
            else if (HingeAxisLength > 120.0m)
            {
                result = 6;

            }

            return result;
        }

        #endregion

    }

}