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
using FrameWorks.Makes.System5010;


namespace FrameWorks.Makes.System5010
{

    public class DrBrzShMtlPan_RHR : SubAssemblyBase
    {

        #region Fields

        // The values we can change for different layouts
        const decimal glsDrGapX2 = 2.59375m * 2.0m;
        const decimal epdmReduce = 2.73129921m;
        const decimal epdmADD = 2.375m;
        const decimal edgeSealAdd = .390m;
        const decimal hdpExtnd = 0.1250m;
        
        #endregion

        #region Constructor

        public DrBrzShMtlPan_RHR()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System5010-DrBrzShMtlPan_RHR";
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


            #region BRZtbAlWD

            ////////////////////////////////////////////////////////////////////////////////////

            // StileLeft
            part = new Part(4325, "StileLeft", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "BRZtbAlWD";
            part.PartLabel = "1) Miter_Ends";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // StileRight
            part = new Part(4325, "StileRight", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "BRZtbAlWD";
            part.PartLabel = "1) Miter_Ends";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // RailTop
            part = new Part(4325, "RailTop", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "BRZtbAlWD";
            part.PartLabel = "1) Miter_Ends ";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // RailBot
            part = new Part(4325, "RailBot", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "BRZtbAlWD";
            part.PartLabel = "1) Miter_Ends ";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region HDPE

            ////////////////////////////////////////////////////////////////////////////////////

            // HDPELockEdge
            part = new Part(5003, "HDPELockEdge", this, 1, m_subAssemblyHieght + hdpExtnd);
            part.PartGroupType = "HDPE";
            part.PartLabel = labelStileL = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // HDPEHingEdge
            part = new Part(5386, "HDPEHingEdge", this, 1, m_subAssemblyHieght + hdpExtnd);
            part.PartGroupType = "HDPE";
            part.PartLabel = labelStileR = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // HDPETop
            part = new Part(911, "HDPETop", this, 1, m_subAssemblyWidth + 2.0m * hdpExtnd);
            part.PartGroupType = "HDPE";
            part.PartLabel = labelTopRail = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // HDPEBot
            part = new Part(911, "HDPEBot", this, 1, m_subAssemblyWidth + 2.0M * hdpExtnd);
            part.PartGroupType = "HDPE";
            part.PartLabel = labelBotRail = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region AssyBraces

            ////////////////////////////////////////////////////////////////////////////////////

            //Alum_PVC_Corner_Bracket        
            part = new Part(4857, "Alum_PVC_Corner_Bracket", this, 4, 0.0m);
            part.PartGroupType = "AssyBraces-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            //MS_FlatHead_8-32x3/4_SS
            part = new Part(1200, "MS_FlatHead_8-32x3/4_SS", this, 32, 0.0m);
            part.PartGroupType = "AssyBraces-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // Black_CrnBrSS14ga_0.6377
            part = new Part(4854, "Black_CrnBrSS14ga_0.6377", this, 4, 0.0m);
            part.PartGroupType = "AsemblHrdwr-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // Blue_CrnBrSS14ga_0.4662
            part = new Part(4855, "Blue_CrnBrSS14ga_0.4662", this, 4, 0.0m);
            part.PartGroupType = "AsemblHrdwr-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // Orange_CrnBrSS14ga_0.4662
            part = new Part(4866, "Orange_CrnBrSS14ga_0.4662", this, 4, 0.0m);
            part.PartGroupType = "AsemblHrdwr";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // MS_FlatHead_8-32x3/16_SS
            part = new Part(502, "MS_FlatHead_8-32x3/16_SS", this, 48, 0.0m);
            part.PartGroupType = "AsemblHrdwr";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region HardWare

            ////////////////////////////////////////////////////////////////////////////////////

            // Hinges
            //part = new Part(3685, "Hinges", this, HingeCount(m_subAssemblyHieght), 0.0m);
            //part.PartGroupType = "Hardware";
            //part.PartLabel = ".25_RAD_Corner";

            //m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Seal/Weatherstripping

            ////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {
                decimal periSeal = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);
                //KfolDrEdge
                part = new Part(2274, "KfolDrEdge", this, 1, periSeal - m_subAssemblyWidth + 4.0m * edgeSealAdd);
                part.PartGroupType = "Seal";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            //DoorBotPVC
            part = new Part(1518, "DoorBotPVC", this, 1, m_subAssemblyWidth + 2.0m * hdpExtnd);
            part.PartGroupType = "Seal";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {
                decimal periSeal = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);
                //GlazDartEPDM
                part = new Part(4314, "GlazDartEPDM", this, 1, periSeal - 4.0m * epdmReduce + 4.0m * epdmADD);
                part.PartGroupType = "Seal";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

        }

        private int HingeCount(decimal HingeAxisLength)
        {
            int result = 0;

            if (HingeAxisLength < 84.0m)
            {
                result = 4;
            }
            else if ((HingeAxisLength >= 84.0m) && (HingeAxisLength < 108.0m))
            {
                result = 5;
            }
            else if ((HingeAxisLength >= 108.0m) && (HingeAxisLength < 134.0m))
            {
                result = 6;
            }
            else if ((HingeAxisLength >= 134.0m) && (HingeAxisLength < 164.0m))
            {
                result = 7;
            }

            return result;
        }

        #endregion

    }


}