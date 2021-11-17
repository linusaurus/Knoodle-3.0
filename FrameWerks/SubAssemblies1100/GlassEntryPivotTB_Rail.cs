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
using FrameWorks.Makes.System1100;


namespace FrameWorks.Makes.System1100
{

    public class GlassEntryPivotTB_Rail : SubAssemblyBase
    {

        #region Fields

        // The values we can change for different layouts

        const decimal glsDrGapX2 = 2.8125m * 2.0m;

        //

        #endregion

        #region Constructor

        public GlassEntryPivotTB_Rail()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System1100-GlassEntryPivotTB_Rail";
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

            #region Alum_0.5_GR

            ////////////////////////////////////////////////////////////////////////////////////

            // RailTop
            part = new Part(327, "RailTop", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Alum_0.5_GR";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // RailBot
            part = new Part(327, "RailBot", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Alum_0.5_GR";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region CladRail

            //////////////////////////////////////////////////////////////////////////////////////////////

            // RailClad
            for (int i = 0; i < 4; i++)
            {
                part = new Part(911, "RailClad", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "CladRail";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Glass

            //////////////////////////////////////////////////////////////////////////////////////////////

            // GlassPanel
            part = new Part(3013);
            part.FunctionalName = "GlassPanel";
            part.PartGroupType = "Glass";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = (m_subAssemblyWidth);
            part.PartLength = (m_subAssemblyHieght - glsDrGapX2);
            part.PartThick = 0.5m;
            part.PartLabel = "PolishEdges";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Handle

            //////////////////////////////////////////////////////////////////////////////////////////////

            // Handle_Set
            part = new Part(911, "Handle_SetTBD", this, 1, 0.0m);
            part.PartGroupType = "Handle";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region HardWare

            //////////////////////////////////////////////////////////////////////////////////////////////

            // TopPivotWB
            part = new Part(28, "TopPivotWB", this, 1, 0.0m);
            part.PartGroupType = "Hardware";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////

            // BottomArm
            part = new Part(209, "BottomArm", this, 1, 0.0m);
            part.PartGroupType = "Hardware";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Seal/Weatherstripping

            //////////////////////////////////////////////////////////////////////////////////////////////

            //Brush
            part = new Part(1028, "Brush", this, 4, m_subAssemblyWidth);
            part.PartGroupType = "Seal";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

        }

        #endregion

    }

}