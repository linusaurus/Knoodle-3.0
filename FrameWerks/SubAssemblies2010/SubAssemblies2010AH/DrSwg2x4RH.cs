﻿#region Copyright (c) 2017 WeaselWare Software
/************************************************************************************
'
' Copyright  2017 WeaselWare Software 
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
' Portions Copyright 2017 WeaselWare Software
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
using FrameWorks.Makes.System2010AH;


namespace FrameWorks.Makes.System2010AH
{

    public class DrSwg2x4RH : SubAssemblyBase
    {

        #region Fields

        // The values we can change for different layouts
        const decimal doorReduceX2 = 0.875m * 2.0m;
        const decimal doorReduce = 0.875m;
        const decimal doorGapBot = 0.75m;
        const decimal sidMuntGPExt2 = 3.7835m * 2.0m;
        const decimal sidMuntGPInt2 = 3.9582m * 2.0m;
        const decimal glsDrGap = 3.46875m;
        const decimal glsDrGapBot = 3.34375m;
        const decimal glsDrGapX2 = 3.46875m * 2.0m;
        const decimal epdmReduce = 2.73129921m;
        const decimal epdmADD = 2.375m;
        const decimal edgeSealAdd = .390m;
        const decimal hdpExtnd = 0.21875m;
        const decimal hdpExtX2 = 0.21875m * 2.0m;
        const decimal stopRedBot = 3.000m;
        const decimal stopReduce = 3.125m;
        const decimal stopRed2x = 3.125m * 2.0m;
        const decimal calkJoint = 0.125m;



        //



        #endregion

        #region Constructor

        public DrSwg2x4RH()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System2010AH-DrSwg2x4RH";
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

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #region Frame-Parts

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            // JamAlumL <<-- 
            decimal doorPanel = decimal.Zero;

            doorPanel = this.Parent.SubAssemblies[0].SubAssemblyHieght;

            part = new Part(4352, "JamAlumL|<", this, 1, m_subAssemblyHieght - calkJoint);
            part.PartGroupType = "Frame-Parts";
            decimal step = (doorPanel - 15.0m);
            step /= Convert.ToDecimal((FrameWorks.Functions.HingeCount(doorPanel) - 1));
            step = Math.Round(step, 4);
            //string msg = "";
            part.PartLabel = "1) MiterTop\r\n" +
                             "2) [911.m]Cope Jamb Bottom->\r\n" +
                             "3) Position 0rigin TOU @ ->" + (7.5m + 0.875m).ToString() + "\r\n" +
                             "4) Hinge Backer Prep->[1982.m] "
                   + FrameWorks.Functions.HingeCount(doorPanel).ToString() + "@<" + step.ToString() + ">O.C.";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            // JamAlumR -->>
            part = new Part(4352, "JamAlumR>|", this, 1, m_subAssemblyHieght - calkJoint);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterTop\r\n" +
                             "2)[1962.m]Position 0rigin Strike Plate";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            // HeadAlum ^^
            part = new Part(4352, "HeadAlum", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterEnds\r\n" +
                             "2)[1987.m]Position 0rigin Shoot Strike";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region AssyHrdwrFrame

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            // AglBrktAlum
            part = new Part(3206, "AglBrktAlum", this, 4, 0.0m);
            part.PartGroupType = "AssyHrdwrFrame";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            // PointSetScrew
            part = new Part(1545, "PointSetScrew", this, 16, 0.0m);
            part.PartGroupType = "AssyHrdwrFrame";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region HardWare

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            // StrikePlateRH_LHR 
            part = new Part(5334, "StrikePlateRH_LHR", this, 1, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            // ShootStrikeLH_RHR 
            part = new Part(5308, "ShootStrikeLH_RHR", this, 1, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            // ShootStrikeRH_LHR 
            part = new Part(5310, "ShootStrikeRH_LHR", this, 1, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Seal/Weatherstripping

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            //FrameSealKfolD
            for (int i = 0; i < 1; i++)
            {
                peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - calkJoint, m_subAssemblyWidth);
                
                part = new Part(2274, "FrameSealKfolD", this, 1, peri - m_subAssemblyWidth - 4.0m);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #region AlumTB3inch

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            // StileLeft
            part = new Part(4355, "StileLeft|<", this, 1, m_subAssemblyHieght - doorReduce - doorGapBot);
            part.PartGroupType = "AlumTB3inch";
            part.PartLabel = "1) Miter_Ends";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            // StileRight
            part = new Part(4355, "StileRight>|", this, 1, m_subAssemblyHieght - doorReduce - doorGapBot);
            part.PartGroupType = "AlumTB3inch";
            part.PartLabel = "1) Miter_Ends";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            // RailTop
            part = new Part(4355, "RailTop^", this, 1, m_subAssemblyWidth - doorReduceX2);
            part.PartGroupType = "AlumTB3inch";
            part.PartLabel = "1) Miter_Ends ";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            // RailBot
            part = new Part(4355, "RailBot_", this, 1, m_subAssemblyWidth - doorReduceX2);
            part.PartGroupType = "AlumTB3inch";
            part.PartLabel = "1) Miter_Ends ";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region HDPE

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            // HDPELockEdge
            part = new Part(4269, "HDPELockEdge", this, 1, m_subAssemblyHieght + hdpExtnd);
            part.PartGroupType = "HDPE-Parts";
            part.PartLabel = labelStileL = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            // HDPEHingEdge
            part = new Part(4268, "HDPEHingEdge", this, 1, m_subAssemblyHieght + hdpExtnd);
            part.PartGroupType = "HDPE-Parts";
            part.PartLabel = labelStileL = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            // HDPETop
            part = new Part(4269, "HDPETop", this, 1, (m_subAssemblyWidth - doorReduceX2 + hdpExtX2));
            part.PartGroupType = "HDPE-Parts";
            part.PartLabel = labelStileR = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            // HDPEBot
            part = new Part(4270, "HDPEBot", this, 2, (m_subAssemblyWidth - doorReduceX2 + hdpExtX2));
            part.PartGroupType = "HDPE";
            part.PartLabel = labelStileR = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Muntins

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            // ExtMuntHorz
            for (int i = 0; i < 4; i++)
            {
                part = new Part(4588, "ExtMuntVert", this, 1, (m_subAssemblyHieght - sidMuntGPExt2) / 4.0m);
                part.PartGroupType = "Muntins";
                part.PartLabel = "WELD_Ends";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            // IntMuntHorz
            for (int i = 0; i < 4; i++)
            {
                part = new Part(4587, "IntMuntVert", this, 1, (m_subAssemblyHieght - sidMuntGPInt2) / 4.0m);
                part.PartGroupType = "Muntins";
                part.PartLabel = "BEVEL_Ends";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            // ExtMuntHorz
            for (int i = 0; i < 6; i++)
            {
                part = new Part(4588, "ExtMuntHorz", this, 1, (m_subAssemblyWidth - sidMuntGPExt2) / 2.0m);
                part.PartGroupType = "Muntins";
                part.PartLabel = "WELD_Ends";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            // IntMuntHorz
            for (int i = 0; i < 6; i++)
            {
                part = new Part(4587, "IntMuntHorz", this, 1, (m_subAssemblyWidth - sidMuntGPInt2) / 2.0m);
                part.PartGroupType = "Muntins";
                part.PartLabel = "BEVEL_Ends";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region StopAlum

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            // AlumGlsStpLeft
            part = new Part(4341, "AlumGlsStpLeft", this, 1, m_subAssemblyHieght - stopReduce - stopRedBot);
            part.PartGroupType = "StopAlum-Parts";;
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            // AlumGlsStpRight
            part = new Part(4341, "AlumGlsStpRight", this, 1, m_subAssemblyHieght - stopReduce - stopRedBot);
            part.PartGroupType = "StopAlum-Parts"; ;
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            // AlumGlsStpTop
            part = new Part(4341, "AlumGlsStpTop", this, 1, (m_subAssemblyWidth - stopRed2x));
            part.PartGroupType = "StopAlum-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            // AlumGlsStpBot
            part = new Part(4341, "AlumGlsStpBot", this, 1, (m_subAssemblyWidth - stopRed2x));
            part.PartGroupType = "StopAlum-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Glass

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            // GlassPanel
            for (int i = 0; i < 1; i++)
            {               
                part = new Part(5503);
                part.FunctionalName = "GlassPanel";
                part.PartGroupType = "Glass";
                part.Qnty = 1;
                part.ContainerAssembly = this;
                part.PartWidth = (m_subAssemblyWidth - glsDrGapX2);
                part.PartLength = (m_subAssemblyHieght - glsDrGap - glsDrGapBot);
                part.PartThick = 1.25m;
                part.PartLabel = "SDL_2x4";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Handle

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            // Handle_Set
            part = new Part(5218, "Handle_Set", this, 1, 0.0m);
            part.PartGroupType = "Handle";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region AssyHrdwrDoor

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            // SS_0.4625_InsetCrnBrace 
            part = new Part(4784, "SS_0.4625_InsetCrnBrace", this, 4, 0.0m);
            part.PartGroupType = "AssyHrdwrDoor";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            // FlatHead_8-32x3/16_UndercutHead
            part = new Part(502, "FlatHead_8-32x3/16_UndercutHead", this, 16, 0.0m);
            part.PartGroupType = "AssyHrdwrDoor";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            // AlumCnrBrace
            part = new Part(4830, "AlumCnrBrace", this, 4, 0.0m);
            part.PartGroupType = "AssyHrdwrDoor";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            // FlatHead_#10x5/8_SheetMetal_18_8_SS
            part = new Part(5180, "FlatHead_#10x5/8_SheetMetal_18_8_SS", this, 16, 0.0m);
            part.PartGroupType = "AssyHrdwrDoor";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            // AlumCnrBrace
            part = new Part(4831, "AlumCnrBrace", this, 4, 0.0m);
            part.PartGroupType = "AssyHrdwrDoor";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            // FlatHead_#10x5/8_SheetMetal_18_8_SS
            part = new Part(5180, "FlatHead_#10x5/8_SheetMetal_18_8_SS", this, 16, 0.0m);
            part.PartGroupType = "AssyHrdwrDoor";            
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            // SS_0.7049_OutsetCrnBrace 
            part = new Part(4829, "SS_0.7049_OutsetCrnBrace", this, 8, 0.0m);
            part.PartGroupType = "AssyHrdwrDoor";;
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            // FlatHead_8-32x3/16_UndercutHead
            part = new Part(502, "FlatHead_8-32x3/16_UndercutHead", this, 32, 0.0m);
            part.PartGroupType = "AssyHrdwrDoor";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region HardWare

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            // Hinges
            part = new Part(3685, "Hinges", this, HingeCount(m_subAssemblyHieght), 0.0m);
            part.PartGroupType = "HardWare";
            part.PartLabel = ".25_RAD_Corner";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            // BackerHinge
            part = new Part(4101, "BackerHinge", this, HingeCount(m_subAssemblyHieght), 0.0m);
            part.PartGroupType = "HardWare";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            //AmesburyMultipointActive
            FrameWorks.Makes.Hardware.Amesbury40.Premiere2000.MultipointActive GearAssy =
                new FrameWorks.Makes.Hardware.Amesbury40.Premiere2000.MultipointActive(m_subAssemblyHieght - doorReduce - doorGapBot, this);
            foreach (Part innerpart in GearAssy.Parts)
            {
                //inner
                this.Parts.Add(innerpart);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Seal/Weatherstripping

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            //KfolDrEdge
            for (int i = 0; i < 1; i++)
            {
                decimal periSeal = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);
                
                part = new Part(2274, "KfolDrEdge", this, 1, periSeal - m_subAssemblyWidth + 4.0m * edgeSealAdd);
                part.PartGroupType = "Seal";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            //DoorBotPVC
            part = new Part(1518, "DoorBotPVC", this, 1, m_subAssemblyWidth + 2.0m * hdpExtnd);
            part.PartGroupType = "Seal";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            //EPDM_PreSet
            for (int i = 0; i < 1; i++)
            {
                decimal periSeal = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);
                
                part = new Part(4314, "EPDM_PreSet", this, 1, periSeal - 4.0m * epdmReduce + 4.0m * epdmADD);
                part.PartGroupType = "Seal";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            //EPDM_Wedge
            for (int i = 0; i < 1; i++)
            {
                decimal periSeal = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);
                
                part = new Part(4284, "EPDM_Wedge", this, 1, periSeal - 4.0m * epdmReduce + 4.0m * epdmADD);
                part.PartGroupType = "Seal";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            // EPDM_PreSet
            part = new Part(4314, "EPDM_PreSet", this, 8, (m_subAssemblyHieght - sidMuntGPExt2) / 4.0m);
            part.PartGroupType = "Seal";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            // EPDM_Wedge
            part = new Part(4284, "EPDM_Wedge", this, 8, (m_subAssemblyHieght - sidMuntGPInt2) / 4.0m);
            part.PartGroupType = "Seal";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            // EPDM_PreSet
            part = new Part(4314, "EPDM_PreSet", this, 12, (m_subAssemblyWidth - sidMuntGPExt2) / 2.0m);
            part.PartGroupType = "Seal";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            // EPDM_Wedge
            part = new Part(4284, "EPDM_Wedge", this, 12, (m_subAssemblyWidth - sidMuntGPInt2) / 2.0m);
            part.PartGroupType = "Seal";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

        }

        private int HingeCount(decimal HingeAxisLength)
        {
            int result = 0;

            if (HingeAxisLength < 84.0m)
            {
                result = 3;
            }
            else if ((HingeAxisLength >= 84.0m) && (HingeAxisLength < 108.0m))
            {
                result = 4;
            }
            else if ((HingeAxisLength >= 108.0m) && (HingeAxisLength < 134.0m))
            {
                result = 5;
            }
            else if ((HingeAxisLength >= 134.0m) && (HingeAxisLength < 164.0m))
            {
                result = 6;
            }

            return result;
        }

        #endregion

    }

}