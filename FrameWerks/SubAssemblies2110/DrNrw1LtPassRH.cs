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

    public class DrNrw1LtPassRH : SubAssemblyBase
    {

        #region Fields

        // The values we can change for different layouts

        const decimal stopReduce = 0.71875m;
        const decimal stopReduceX2 = 2.0m * 0.71875m;
        const decimal glsDrGapX2 = 2.0m * 1.0625m;
        const decimal edgeSealAdd = 0.375m;
        const decimal hdpExtnd = 0.25m;
        const decimal epdmReduce = 1.092m;
        const decimal epdmADD = 1.60m;

        //

        #endregion

        #region Constructor

        public DrNrw1LtPassRH()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System2110-DrNrw1LtPassRH";
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


            #region AlumTBNrw

            /////////////////////////////////////////////////////////////

            // StileLeft
            part = new Part(5710, "StileLeft", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "AlumTBNrw";
            part.PartLabel = "1) Miter_Ends";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////
            
            // StileRight
            part = new Part(5710, "StileRight", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "AlumTBNrw";
            part.PartLabel = "1) Miter_Ends";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////
            
            // RailTop
            part = new Part(5710, "RailTop", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "AlumTBNrw";
            part.PartLabel = "1) Miter_Ends ";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////
            
            // RailBot
            part = new Part(5710, "RailBot", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "AlumTBNrw";
            part.PartLabel = "1) Miter_Ends ";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region HardwareBump

            ////////////////////////////////////////////////////////////////////////////////////

            // StileBO
            part = new Part(5710, "StileBO", this, 1, 12.0m);
            part.PartGroupType = "HardwareBump";
            part.PartLabel = "1) Miter_Ends";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // AlumGlsStpVert
            part = new Part(5711, "AlumGlsStpVert", this, 1, 12.0m);
            part.PartGroupType = "HardwareBump";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // AlumGlsStpHorz1
            part = new Part(5711, "AlumGlsStpHorz", this, 1, 1.53125m);
            part.PartGroupType = "HardwareBump";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // AlumGlsStpHorz2
            part = new Part(5711, "AlumGlsStpHorz", this, 1, 1.53125m);
            part.PartGroupType = "HardwareBump";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region HDPE

            ////////////////////////////////////////////////////////////////////////////////////

            // HDPELockEdge1
            part = new Part(6879, "HDPELockEdge", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "HDPE";
            part.PartLabel = labelStileL = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // HDPELockEdge2
            part = new Part(6879, "HDPELockEdge", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "HDPE";
            part.PartLabel = labelStileL = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // HDPEHingEdge
            part = new Part(6880, "HDPEHingEdge", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "HDPE";
            part.PartLabel = labelStileR = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // HDPEBot
            part = new Part(6971, "HDPEBot", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "HDPE";
            part.PartLabel = labelBotRail = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

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

            #region Glass

            //Glass
            part = new Part(6883);
            part.FunctionalName = "Glass";
            part.PartGroupType = "Glass";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = (m_subAssemblyWidth - glsDrGapX2);
            part.PartLength = (m_subAssemblyHieght - glsDrGapX2);
            part.PartThick = 1.25m;
            part.PartLabel = "";
            m_parts.Add(part);

            #endregion

            #region Handle

            // Handle_Set
            part = new Part(5218, "Handle_Set", this, 1, 0.0m);
            part.PartGroupType = "Handle";
            part.PartLabel = "";
            m_parts.Add(part);

            #endregion

            #region AssyHrdwrDoor

            //////////////////////////////////////////////////////////////////////////////

            // SS_0.4625_InsetCrnBrace 
            part = new Part(4784, "SS_0.4625_InsetCrnBrace", this, 4, 0.0m);
            part.PartGroupType = "AssyHrdwrDoor";
            part.PartLabel = "";
            m_parts.Add(part);

            // FlatHead
            part = new Part(502, "FlatHead", this, 16, 0.0m);
            part.PartGroupType = "AssyHrdwrDoor";
            part.PartLabel = "#8-32x3/16_UndercutHead";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // AlumCnrBrace
            part = new Part(4830, "AlumCnrBrace", this, 4, 0.0m);
            part.PartGroupType = "AssyHrdwrDoor";
            part.PartLabel = "";
            m_parts.Add(part);

            // FlatHead
            part = new Part(5180, "FlatHead", this, 16, 0.0m);
            part.PartGroupType = "AssyHrdwrDoor";
            part.PartLabel = "#10x5/8_SheetMetal_18_8_SS";
            m_parts.Add(part);

            // AlumCnrBrace
            part = new Part(4831, "AlumCnrBrace", this, 4, 0.0m);
            part.PartGroupType = "AssyHrdwrDoor";
            part.PartLabel = "";
            m_parts.Add(part);

            // FlatHead
            part = new Part(5180, "FlatHead", this, 16, 0.0m);
            part.PartGroupType = "AssyHrdwrDoor";
            part.PartLabel = "#10x5/8_SheetMetal_18_8_SS";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // SS_0.7049_OutsetCrnBrace 
            part = new Part(4829, "SS_0.7049_OutsetCrnBrace", this, 8, 0.0m);
            part.PartGroupType = "AssyHrdwrDoor";
            part.PartLabel = "";
            m_parts.Add(part);

            // FlatHead
            part = new Part(502, "FlatHead", this, 32, 0.0m);
            part.PartGroupType = "AssyHrdwrDoor";
            part.PartLabel = "#8-32x3/16_UndercutHead";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region HardWare

            /////////////////////////////////////////////////////////////////////////////////////////////////////

            //AmesburyMultipointPassive
            FrameWorks.Makes.Hardware.Amesbury40.Premiere2000.MultipointPassive GearBox =
            new FrameWorks.Makes.Hardware.Amesbury40.Premiere2000.MultipointPassive(m_subAssemblyHieght, this);
            foreach (Part innerpart in GearBox.Parts)
            {
                //inner
                this.Parts.Add(innerpart);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            // StrikePlateRH_LHR
            part = new Part(5338, "StrikePlateRH_LHR", this, 1, 0.0m);
            part.PartGroupType = "Hardware";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            // Hinges
            part = new Part(3685, "Hinges", this, HingeCount(m_subAssemblyHieght), 0.0m);
            part.PartGroupType = "Hardware";
            part.PartLabel = ".25_RAD_Corner";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Seal/Weatherstripping

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 2; i++)
            {
                decimal periSeal = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

                //KfolDrEdge
                part = new Part(2274, "KfolDrEdge", this, 1, (periSeal - m_subAssemblyWidth + 4.0m * edgeSealAdd) / 2.0m);
                part.PartGroupType = "Seal";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            
            //DoorBotPVC
            part = new Part(1518, "DoorBotPVC", this, 1, m_subAssemblyWidth + 2.0m * hdpExtnd);
            part.PartGroupType = "Seal";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 2; i++)
            {
                decimal periSeal = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

                //EPDM_PreSet
                part = new Part(4314, "EPDM_PreSet", this, 1, periSeal - 4.0m * epdmReduce + 4.0m * epdmADD);
                part.PartGroupType = "Seal";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 2; i++)
            {
                decimal periSeal = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

                //EPDM_Wedge
                part = new Part(4284, "EPDM_Wedge", this, 1, periSeal - 4.0m * epdmReduce + 4.0m * epdmADD);
                part.PartGroupType = "Seal";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

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