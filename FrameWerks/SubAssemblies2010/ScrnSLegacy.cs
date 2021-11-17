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

namespace FrameWorks.Makes.System2010
{

    public class ScrnSLegacy : SubAssemblyBase
    {

        #region Fields

        //Constant Values

        const int panelCount = 1;
        const decimal headRedX2 = 2.0m * 0.375m;
        const decimal frameRedX2 = 2.0m * 1.0m;
        const decimal scrnFrmAdd = 0.4769m;
        const decimal scrnTgapRed = 2.03125m;
        const decimal scrnBgapRed = 0.25m;

        //static int createID;

        #endregion

        #region Constructor

        public ScrnSLegacy()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System2010-ScrnSLegacy";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();

            #region SlidingScreen

            //////////////////////////////////////////////////////////////////////////////

            // Sld_Screen_StileL <--
            part = new Part(1677, "Sld_Screen_StileL", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "SlidingScreen";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // Sld_Screen_StileR <--
            part = new Part(1677, "Sld_Screen_StileR", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "SlidingScreen";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // Sld_Screen_RailT ^^
            part = new Part(1677, "Sld_Screen_RailT", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "SlidingScreen";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // Sld_Screen_RailB ^^
            part = new Part(1677, "Sld_Screen_RailB", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "SlidingScreen";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

        }

        #endregion

    }

    #endregion

}





