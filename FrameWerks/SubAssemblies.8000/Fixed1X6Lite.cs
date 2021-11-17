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
using FrameWorks.Makes.System8000;


namespace FrameWorks.Makes.System8000
{

    public class Fixed1X6Lite : SubAssemblyBase
    {

        #region Fields

        // The values we can change for different layouts

        const decimal sillRedX1 = 1.875m;
        const decimal jmbRedX1 = 1.125m;
        const decimal jmbRedX2 = 1.125m * 2.0m;
        const decimal tenonAddX2 = 0.25m * 2.0m;
        const decimal munThkRedX5 = 0.3125m * 4.0m;
        const decimal glsGap2X = 0.0625m * 2.0m;
        const decimal glsGap12X = 0.0625m * 12.0m;

        //

        #endregion

        #region Constructor

        public Fixed1X6Lite()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System8000-Fixed1X6Lite";
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

            #region Frame

            ////////////////////////////////////////////////////////////////////////////////////

            // JambL
            part = new Part(911, "JambL", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame";
            part.PartWidth = 5.25m;
            part.PartThick = 1.25m;
            part.PartLabel = "Jambs";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // JambR
            part = new Part(911, "JambR", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame";
            part.PartWidth = 5.25m;
            part.PartThick = 1.25m;
            part.PartLabel = "Jambs";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // Head
            part = new Part(911, "Head", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame";
            part.PartWidth = 5.25m;
            part.PartThick = 1.25m;
            part.PartLabel = "Head";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // Sill
            part = new Part(911, "Sill", this, 1, m_subAssemblyWidth );
            part.PartGroupType = "Frame";
            part.PartWidth = 5.25m;
            part.PartThick = 1.875m;
            part.PartLabel = "Sill_Fixed";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Muntins

            ////////////////////////////////////////////////////////////////////////////////////

            // MuntVert
            for (int i = 0; i < 5; i++)
            {
                part = new Part(600, "MuntVert", this, 1, m_subAssemblyHieght - sillRedX1 - jmbRedX1 + tenonAddX2);
                part.PartGroupType = "Muntins";
                part.PartWidth = 0.9375m;
                part.PartThick = 1.75m;
                part.PartLabel = "MuntVert";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region StopWood

            ////////////////////////////////////////////////////////////////////////////////////

            // GlsStpV_Int
            for (int i = 0; i < 12; i++)
            {
                part = new Part(911, "GlsStpV_Int", this, 1, m_subAssemblyHieght - sillRedX1 - jmbRedX1 );
                part.PartGroupType = "StopWood-Parts";
                part.PartWidth = 2.125m; 
                part.PartThick = 0.5m;
                part.PartLabel = "VertInt";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            // GlsStpH_Int
            for (int i = 0; i < 12; i++)
            {
                part = new Part(911, "GlsStpH_Int", this, 1, (m_subAssemblyWidth - jmbRedX2 - munThkRedX5 ) /6 );
                part.PartGroupType = "StopWood-Parts";
                part.PartWidth = 2.125m;
                part.PartThick = 0.5m;
                part.PartLabel = "HorzInt";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            // GlsStpV_Ext
            for (int i = 0; i < 12; i++)
            {
                part = new Part(334, "GlsStpV_Ext", this, 1, m_subAssemblyHieght - sillRedX1 - jmbRedX1);
                part.PartGroupType = "StopWood-Parts";
                part.PartWidth = 0.625m;
                part.PartThick = 0.5m;
                part.PartLabel = "VertExt";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            // GlsStpH_Ext
            for (int i = 0; i < 12; i++)
            {
                part = new Part(334, "GlsStpH_Ext", this, 1, (m_subAssemblyWidth - jmbRedX2 - munThkRedX5) / 6);
                part.PartGroupType = "StopWood-Parts";
                part.PartWidth = 0.625m;
                part.PartThick = 0.5m;
                part.PartLabel = "HorzExt";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Glass

            ////////////////////////////////////////////////////////////////////////////////////

            // GlassPanel
            for (int i = 0; i < 6; i++)
            {                
                part = new Part(911);
                part.FunctionalName = "Glass";
                part.PartGroupType = "Glass";
                part.Qnty = 1;
                part.ContainerAssembly = this;
                part.PartWidth = (m_subAssemblyWidth -jmbRedX2 - munThkRedX5 - glsGap12X) / 4;
                part.PartLength = (m_subAssemblyHieght - sillRedX1 - jmbRedX1 - glsGap2X);
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