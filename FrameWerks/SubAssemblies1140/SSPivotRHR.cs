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
using FrameWorks.Makes.System1140;


namespace FrameWorks.Makes.System1140
{

    public class SSPivotRHR : SubAssemblyBase
    {

        #region Fields

        // The values we can change for different layouts  
        const decimal doorGap = 0.25m;
        const decimal frameRedAlum = 0.902m;
        const decimal frameRedSS = 0.875m;
        const decimal cladReduce = 0.035m;
        const decimal cladRed2X = 2.0m * 0.035m;
        const decimal stopReduceX2 = 2.0m * 0.71875m;
        const decimal glsFrmDrGap = 1.625m;
        const decimal glsDrGap = 0.75m;
        const decimal glsDrGapX2 = 2.0m * 0.75m;
        const decimal edgeSealAdd = 0.375m;
        const decimal hdpExtnd = 0.25m;
        const decimal epdmReduce = 1.092m;
        const decimal epdmADD = 1.60m;
        //

        #endregion

        #region Constructor

        public SSPivotRHR()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System1140-SSPivotRHR";
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

            ///////////////////////////////////////////////////////////////////////////

            #region Frame

            // JambSSR -->>
            part = new Part(911, "JambSSR >|", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            // JambSSR -->>
            part = new Part(4166, "JambSSR >|", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            // HeadAlum ^^
            part = new Part(911, "HeadAlum", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            // HeadAlum ^^
            part = new Part(4166, "HeadAlum", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            #endregion

            ///////////////////////////////////////////////////////////////////////////

            #region AlumCore

            ////////////////////////////////////////////////////////////////////////////////////

            // StileCore
            part = new Part(7388, "StileCore", this, 1, m_subAssemblyHieght - frameRedSS - cladRed2X);
            part.PartGroupType = "AlumCore";
            part.PartLabel = "1) Miter_Ends";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // StileCore
            part = new Part(7388, "StileCore", this, 1, m_subAssemblyHieght - frameRedSS - cladRed2X);
            part.PartGroupType = "AlumCore";
            part.PartLabel = "1) Miter_Ends";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // RailCoreTop
            part = new Part(7388, "RailCoreTop", this, 1, m_subAssemblyWidth  - frameRedSS - cladRed2X);
            part.PartGroupType = "AlumCore";
            part.PartLabel = "1) Miter_Ends ";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // RailCoreBot
            part = new Part(7388, "RailCoreBot", this, 1, m_subAssemblyWidth - frameRedSS - cladRed2X);
            part.PartGroupType = "AlumCore";
            part.PartLabel = "1) Miter_Ends ";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region SS_Clad

            ////////////////////////////////////////////////////////////////////////////////////

            // SS316_Clad_L <--
            part = new Part(911, "SS316_Clad_L", this, 1, m_subAssemblyHieght - frameRedSS);
            part.PartGroupType = "SS_Clad";
            part.PartLabel = "";
            m_parts.Add(part);

            // SS316_Clad_L <--
            part = new Part(911, "SS316_Clad_L", this, 1, m_subAssemblyHieght - frameRedSS);
            part.PartGroupType = "SS_Clad";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // SS316_Clad_R -->
            part = new Part(911, "SS316_Clad_R", this, 1, m_subAssemblyHieght - frameRedSS);
            part.PartGroupType = "SS_Clad";
            part.PartLabel = "";
            m_parts.Add(part);

            // SS316_Clad_R -->
            part = new Part(911, "SS316_Clad_R", this, 1, m_subAssemblyHieght - frameRedSS);
            part.PartGroupType = "SS_Clad";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // RailTop316 ^^
            part = new Part(4176, "RailTop316", this, 1, m_subAssemblyWidth - frameRedSS);
            part.PartGroupType = "SS_Clad";
            part.PartLabel = "";
            part.PartWidth = 1.1875m;
            part.PartThick = 0.21875m;
            m_parts.Add(part);

            // RailTop316 ^^
            part = new Part(4176, "RailTop316", this, 1, m_subAssemblyWidth - frameRedSS);
            part.PartGroupType = "SS_Clad";
            part.PartLabel = "";
            part.PartWidth = 1.1875m;
            part.PartThick = 0.21875m;
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // RailBot316 ||
            part = new Part(4176, "RailBot316", this, 1, m_subAssemblyWidth - frameRedSS);
            part.PartGroupType = "SS_Clad";
            part.PartLabel = "";
            part.PartWidth = 1.1875m;
            part.PartThick = 0.21875m;
            m_parts.Add(part);

            // RailBot316 ||
            part = new Part(4176, "RailBot316", this, 1, m_subAssemblyWidth - frameRedSS);
            part.PartGroupType = "SS_Clad";
            part.PartLabel = "";
            part.PartWidth = 1.1875m;
            part.PartThick = 0.21875m;
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Glass

            //Glass
            part = new Part(4231);
            part.FunctionalName = "Glass";
            part.PartGroupType = "Glass";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = (m_subAssemblyWidth - glsDrGap - glsFrmDrGap);
            part.PartLength = (m_subAssemblyHieght - glsDrGap - glsFrmDrGap - doorGap);
            part.PartThick = 0.5625m;
            part.PartLabel = "ClearXIR®";
            m_parts.Add(part);

            #endregion

            #region Hardware

            // DormaBTS80 
            part = new Part(300, "DormaBTS80", this, 1, 0.0m);
            part.PartGroupType = "Hardware";
            part.PartLabel = "LH_80030_Spindle";
            m_parts.Add(part);

            // CRL_0PF20LBS_TOP
            part = new Part(911, "CRL_0PF20LBS_TOP", this, 1, 0.0m);
            part.PartGroupType = "Hardware";
            part.PartLabel = "";
            m_parts.Add(part);

            // CRL_0PF10LBS_BOT
            part = new Part(911, "CRL_0PF10LBS_BOT", this, 1, 0.0m);
            part.PartGroupType = "Hardware";
            part.PartLabel = "";
            m_parts.Add(part);

            #endregion

            #region Seal/Weatherstripping

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {
                decimal periSeal = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

                //KfolDrEdge
                part = new Part(2274, "KfolDrEdge", this, 1, periSeal + edgeSealAdd);
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

            #endregion

            ///////////////////////////////////////////////////////////////////////////

        }

        #endregion

    }

}