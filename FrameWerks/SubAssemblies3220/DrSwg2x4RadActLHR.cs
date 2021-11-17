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

    public class DrSwg2x4RadActLHR : SubAssemblyBase
    {

        #region Fields

        // The values we can change for different layouts
        const decimal glsDrGapX2 = 2.5625m * 2.0m;
        const decimal panelReduceX2 = 2.59375m * 2.0m;
        const decimal epdmReduce = 2.73129921m;
        const decimal epdmADD = 2.375m;
        const decimal edgeSealAdd = .390m;
        const decimal hdpExtnd = 0.1250m;
        const decimal stopReduceX2 = 2.25m * 2.0m;
        const decimal muntinDrReduceX2 = 3.125m * 2.0m;
        const decimal π = 3.14159m;
        const decimal grip2X = 12.0m * 2.0m;

        //

        #endregion

        #region Constructor

        public DrSwg2x4RadActLHR()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3220-DrSwg2x4RadActLHR";
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
            part = new Part(4312, "StileLeft", this, 1, m_subAssemblyHieght - m_subAssemblyDepth);
            part.PartGroupType = "BrzTB3inch";
            part.PartLabel = "1) Miter_Ends";
            m_parts.Add(part);

            // StileRight
            part = new Part(4312, "StileRight", this, 1, m_subAssemblyHieght - m_subAssemblyDepth);
            part.PartGroupType = "BrzTB3inch";
            part.PartLabel = "1) Miter_Ends";
            m_parts.Add(part);

            // RailT_StretchForm
            part = new Part (4312, "RailT_StretchForm", this, 1, (m_subAssemblyWidth * π) / 2.0m);
            part.PartGroupType = "BrzTB3inch";
            part.PartLabel = "1) Miter_Ends ";
            m_parts.Add(part);


            // RailBot
            part = new Part(4312, "RailBot", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "BrzTB3inch";
            part.PartLabel = "1) Miter_Ends ";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region HDPE

            // HDPELockEdge
            part = new Part(4780, "HDPELockEdge", this, 2, m_subAssemblyHieght + hdpExtnd);
            part.PartGroupType = "HDPE-Parts";;
            part.PartLabel = labelStileL = "";
            m_parts.Add(part);

            // HDPEHingEdge
            part = new Part(5536, "HDPEHingEdge", this, 1, m_subAssemblyHieght + hdpExtnd);
            part.PartGroupType = "HDPE-Parts";
            part.PartLabel = labelStileR = "";
            m_parts.Add(part);

            // HDPEHingEdge
            part = new Part(5060, "HDPEHingEdge", this, 1, m_subAssemblyHieght + hdpExtnd);
            part.PartGroupType = "HDPE-Parts";
            part.PartLabel = labelStileR = "";
            m_parts.Add(part);

            // HDPEBot
            part = new Part(5538, "HDPEBot", this, 1, m_subAssemblyWidth + 2.0M * hdpExtnd);
            part.PartGroupType = "HDPE-Parts";
            part.PartLabel = labelBotRail = "";
            m_parts.Add(part);

            // HDPEBot
            part = new Part(5539, "HDPEBot", this, 1, m_subAssemblyWidth + 2.0M * hdpExtnd);
            part.PartGroupType = "HDPE-Parts";
            part.PartLabel = labelBotRail = "";
            m_parts.Add(part);

            #endregion

            #region StopBrz

            ////////////////////////////////////////////////////////////////////////////////

            // BrzGlsStpVert
            part = new Part(6888, "BrzGlsStpVert", this, 2, m_subAssemblyHieght - stopReduceX2 - m_subAssemblyDepth);
            part.PartGroupType = "StopBrz-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // BrzGlsStpT_StretchForm
            part = new Part(6888, "BrzGlsStpT_StretchForm", this, 1, (m_subAssemblyWidth - stopReduceX2 * π / 2.0m) + grip2X);
            part.PartGroupType = "StopBrz-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // BrzGlsStpBot
            part = new Part(6888, "BrzGlsStpTopBot", this, 1, m_subAssemblyWidth - stopReduceX2);
            part.PartGroupType = "StopBrz-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Muntin_1.25

            //////////////////////////////////////////////////////////////////////////////

            // BrzMntHrz6Lt
            for (int i = 0; i < 3; i++)
            {
                part = new Part(6887, "BrzMntHrz6Lt", this, 1, m_subAssemblyWidth - muntinDrReduceX2);
                part.PartGroupType = "Muntin_1.25";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            // BrzMntVert6Lt
            for (int i = 0; i < 4; i++)
            {
                part = new Part(6887, "BrzMntVert6Lt", this, 1, (m_subAssemblyHieght - muntinDrReduceX2) / 4.0m);
                part.PartGroupType = "Muntin_1.25";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            // BeadMuntHrz6Lt
            for (int i = 0; i < 6; i++)
            {
                part = new Part(6889, "BeadMuntHrz6Lt", this, 1, (m_subAssemblyWidth - stopReduceX2) / 2.0m);
                part.PartGroupType = "StopBrz";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            // BeadMuntVert6Lt
            for (int i = 0; i < 4; i++)
            {
                part = new Part(6889, "BeadMuntVert6Lt", this, 1, (m_subAssemblyHieght - stopReduceX2) / 4.0m);
                part.PartGroupType = "StopBrz";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Glass


            ////////////////////////////////////////////////////////////////////////////////

            // GlassPanel
            part = new Part(6898);
            part.FunctionalName = "Gls2x4_SDL";
            part.PartGroupType = "Glass-Parts";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = (m_subAssemblyWidth - glsDrGapX2);
            part.PartLength = (m_subAssemblyHieght - glsDrGapX2);
            part.PartThick = 1.00m;
            part.PartLabel = "2x4_Pattern";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Delivery

            // Handle_Set
            part = new Part(5218, "Handle_Set", this, 1, 0.0m);
            part.PartGroupType = "Delivery-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            #endregion

            #region HardWare Logic

            // Hinges
            part = new Part(3685, "Hinges", this, HingeCount2(m_subAssemblyHieght), 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = ".25_RAD_Corner";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////

            //AmesburyMultipointActive

            FrameWorks.Makes.Hardware.Amesbury40.Premiere2000.MultipointActive GearAssy =
                new FrameWorks.Makes.Hardware.Amesbury40.Premiere2000.MultipointActive(m_subAssemblyHieght, this);
            foreach (Part innerpart in GearAssy.Parts)
            {
                //inner
                this.Parts.Add(innerpart);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region AssyBrackets

            // AlumPVC_CornerBrace
            part = new Part(5611, "AlumPVC_CornerBrace", this, 4, 0.0m);
            part.PartGroupType = "AssyBrackets-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            //Green_CnrBrcSS14ga_0.7049
            part = new Part(4829, "Green_CnrBrcSS14ga_0.7049", this, 8, 0.0m);
            part.PartGroupType = "AssyBrackets-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            //Blue_CnrBrcSS14ga_0.4662
            part = new Part(4855, "Blue_CnrBrcSS14ga_0.4662", this, 4, 0.0m);
            part.PartGroupType = "AssyBrackets-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            //MS_FlatHead_8-32x3/16_SS
            part = new Part(502, "MS_FlatHead_8-32x3/16_SS", this, 48, 0.0m);
            part.PartGroupType = "AssyBrackets-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Seal/Weatherstripping

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {
                decimal periSeal = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);
                //KfolDrEdge
                part = new Part(2274, "KfolDrEdge", this, 1, periSeal - m_subAssemblyWidth + 4.0m * edgeSealAdd);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //DoorBotPVC
            part = new Part(1518, "DoorBotPVC", this, 1, m_subAssemblyWidth + 2.0m * hdpExtnd);
            part.PartGroupType = "Seal-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {
                decimal periSeal = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);
                //GlazePreSet
                part = new Part(4314, "GlazePreSet", this, 1, periSeal - 4.0m * epdmReduce + 4.0m * epdmADD);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";
                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {
                decimal periSeal = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);
                //GlazeWedgeSeals
                part = new Part(4399, "GlazeWedgeSeals", this, 1, periSeal - 4.0m * epdmReduce + 4.0m * epdmADD);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

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