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

    public class SlideWndOLft : SubAssemblyBase
    {

        #region Fields

        // The values we can change for different layouts

        const decimal glassReduce = 0.75m;
        const decimal glassRedX2 = 2.0m * 0.75m;
        const decimal cladRed = 0.035m;
        const decimal cladRed2X = 0.035m * 2.0m;
        const decimal cutModify = 0.050m;

        //

        #endregion

        #region Constructor

        public SlideWndOLft()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System1140-SlideWndOLft";
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

            ////////////////////////////////////////////////////////////////////////////////////

            #region AlumCore

            ////////////////////////////////////////////////////////////////////////////////////

            // StileCore
            part = new Part(7388, "StileCore", this, 1, m_subAssemblyHieght - cladRed2X);
            part.PartGroupType = "AlumCore";
            part.PartLabel = "";
            m_parts.Add(part);

            // StileCore
            part = new Part(7388, "StileCore", this, 1, m_subAssemblyHieght - cladRed2X);
            part.PartGroupType = "AlumCore";
            part.PartLabel = "MOD";
            m_parts.Add(part);

            // StileHook
            part = new Part(4144, "StileHook", this, 1, m_subAssemblyHieght - cladRed2X);
            part.PartGroupType = "AlumCore";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // RailCoreTop
            part = new Part(7388, "RailCoreTop", this, 1, m_subAssemblyWidth - cladRed2X);
            part.PartGroupType = "AlumCore";
            part.PartLabel = "";
            m_parts.Add(part);

            // RailCoreBot
            part = new Part(7388, "RailCoreBot", this, 1, m_subAssemblyWidth - cladRed2X);
            part.PartGroupType = "AlumCore";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region SSClad

            ////////////////////////////////////////////////////////////////////////////////////

            // Stile316
            part = new Part(4173, "Stile316", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "SSClad";
            part.PartLabel = "";
            part.PartWidth = 1.1875m;            
            part.PartThick = 0.2875m;
            m_parts.Add(part);

            // Stile316
            part = new Part(4173, "Stile316", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "SSClad";
            part.PartLabel = "";
            part.PartWidth = 1.1875m;
            part.PartThick = 0.2875m;
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // Stile316
            part = new Part(911, "Stile316", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "SSClad";
            part.PartLabel = "1";
            part.PartWidth = 0.9688m;
            part.PartThick = 0.2188m;
            m_parts.Add(part);

            // StileHook316
            part = new Part(911, "StileHook316", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "SSClad";
            part.PartLabel = "2";
            part.PartWidth = 1.1875m;
            part.PartThick = 1.625m;
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // RailTop
            part = new Part(4173, "RailTop316", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "SSClad";
            part.PartLabel = "";
            part.PartWidth = 1.1875m;
            part.PartThick = 0.2875m;
            m_parts.Add(part);

            // RailTop
            part = new Part(4173, "RailTop316", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "SSClad";
            part.PartLabel = "";
            part.PartWidth = 1.1875m;
            part.PartThick = 0.2875m;
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // RailBot316
            part = new Part(4176, "RailBot316", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "SSClad";
            part.PartLabel = "";
            part.PartWidth = 1.1875m;
            part.PartThick = 0.2188m;
            m_parts.Add(part);

            // RailBot316
            part = new Part(4176, "RailBot316", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "SSClad";
            part.PartLabel = "";
            part.PartWidth = 1.1875m;
            part.PartThick = 0.2188m;
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Glass

            //////////////////////////////////////////////////////////////////////////////////////////////

            // GlassPanel
            part = new Part(4231);
            part.FunctionalName = "Glass";
            part.PartGroupType = "Glass";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = (m_subAssemblyWidth - glassRedX2);
            part.PartLength = (m_subAssemblyHieght - glassRedX2);
            part.PartThick = 0.5625m;
            part.PartLabel = "ClearXIR®";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Seal/Weatherstripping

            //////////////////////////////////////////////////////////////////////////////////////////////

            //PileTSlot
            part = new Part(3959, "PileTSlot", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Seal";
            part.PartLabel = "";
            m_parts.Add(part);

            //PileKerf
            part = new Part(978, "PileKerf", this, 4, m_subAssemblyWidth);
            part.PartGroupType = "Seal";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

        }

        #endregion

    }

}