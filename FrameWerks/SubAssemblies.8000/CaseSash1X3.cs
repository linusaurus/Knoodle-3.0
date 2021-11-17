
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

namespace FrameWorks.Makes.System8000
{

    public class CaseSash1X3 : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal stileRedX2 = 2.5625m * 2.0m;
        const decimal topRailRed = 2.5625m;
        const decimal botRailRed = 2.9375m;
        const decimal muntRed2X = 0.3125m * 2.0m;
        const decimal glassGap2X = 0.0625m * 2.0m;
        const decimal glassGap6X = 0.0625m * 6.0m;




        //static int createID;

        #endregion

        #region Constructor

        public CaseSash1X3()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System8000-CaseSash1X3";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();

            decimal pweight = FrameWorks.Functions.PanelWieghtS2000(m_subAssemblyWidth, m_subAssemblyHieght);

            string labelStileR = string.Empty;
            string labelStileL = string.Empty;
            string labelTopRail = string.Empty;
            string labelBotRail = string.Empty;

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #region Sash

            ////////////////////////////////////////////////////////////////////////////////////

            // StileWoodL <<--
            part = new Part(269, "StileWoodL", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Sash-Parts";
            part.PartWidth = 2.875m;
            part.PartThick = 1.75m;
            part.PartLabel = labelStileL = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // StileWoodR -->>
            part = new Part(269, "StileWoodR", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Sash-Parts";
            part.PartWidth = 2.875m;
            part.PartThick = 1.75m;
            part.PartLabel = labelStileR = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // RailWoodTop ^^
            part = new Part(269, "RailWoodTop", this, 1, m_subAssemblyWidth - stileRedX2);
            part.PartGroupType = "Sash-Parts";
            part.PartWidth = 2.875m;
            part.PartThick = 1.75m;
            part.PartLabel = labelTopRail = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // RailWoodBot ||
            part = new Part(262, "RailWoodBot", this, 1, m_subAssemblyWidth - stileRedX2);
            part.PartGroupType = "Sash-Parts";
            part.PartWidth = 3.25m;
            part.PartThick = 1.75m;
            part.PartLabel = labelBotRail = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Muntins

            ////////////////////////////////////////////////////////////////////////////////////

            // MuntHorz
            for (int i = 0; i < 2; i++)
            {
                part = new Part(600, "MuntHorz", this, 1, m_subAssemblyWidth - stileRedX2);
                part.PartGroupType = "Muntins";
                part.PartWidth = 0.9375m;
                part.PartThick = 1.75m;
                part.PartLabel = "";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region GlassStopWood

            ////////////////////////////////////////////////////////////////////////////////////

            // GlsStpWdVert
            for (int i = 0; i < 6; i++)
            {
                part = new Part(334, "GlsStpWdVert", this, 1, (m_subAssemblyHieght - topRailRed - botRailRed - muntRed2X) / 3.0m);
                part.PartGroupType = "GlassStopWood-Parts";
                part.PartWidth = 0.625m;
                part.PartThick = 0.3125m;
                part.PartLabel = "";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            // GlsStpWdHorz
            for (int i = 0; i < 6; i++)
            {
                part = new Part(334, "GlsStpWdHorz", this, 1, m_subAssemblyWidth - stileRedX2);
                part.PartGroupType = "GlassStopWood-Parts";
                part.PartWidth = 0.625m;
                part.PartThick = 0.3125m;
                part.PartLabel = "";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Glass

            ////////////////////////////////////////////////////////////////////////////////////

            // Glass
            for (int i = 0; i < 3; i++)
            {                
                part = new Part(911);
                part.FunctionalName = "Glass";
                part.PartGroupType = "Glass-Parts";
                part.Qnty = 1;
                part.ContainerAssembly = this;
                part.PartWidth = (m_subAssemblyWidth - stileRedX2 - glassGap2X);
                part.PartLength = (m_subAssemblyHieght - topRailRed - botRailRed - muntRed2X - glassGap6X) / 3.0m; ;
                part.PartThick = 0.25m;
                part.PartLabel = "";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

        }

        #endregion

    }

}