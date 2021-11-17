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

    public class Astragal_Flat : SubAssemblyBase
    {

        #region Fields

        // The values we can change for different layouts

        //

        #endregion

        #region Constructor

        public Astragal_Flat()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System8000-Astragal_Flat ";
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

            #region Astragals

            ////////////////////////////////////////////////////////////////////////////////////

            // Flat_Astragal
            for (int i = 0; i < 1; i++)
            {
                part = new Part(911, "Flat_Astragal", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "Astragals";
                part.PartWidth = 0.625m;
                part.PartThick = 1.5m;
                part.PartLabel = "Flat_Astragal";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

        }

        #endregion

    }

}
