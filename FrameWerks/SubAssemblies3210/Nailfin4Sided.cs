﻿#region Copyright (c) 2021 WeaselWare Software
/************************************************************************************
'
' Copyright  2021 WeaselWare Software 
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
' Portions Copyright 2021 WeaselWare Software
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
using System.Diagnostics;


namespace FrameWorks.Makes.System3210
{
    [Serializable()]
    public class NailFin4Sided : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal nailFinAd = 1.1875m;
       
        //

        #endregion

        #region Constructor

        public NailFin4Sided()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3210-NailFin4Sided";
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


            #region NailFin

            /////////////////////////////////////////////////////////////////////////////////////////

            // NailerWidthExt
            part = new Part(3649, "NailerWidthExt", this, 2, m_subAssemblyWidth + nailFinAd * 2.0m);
            part.PartGroupType = "NailFin-Parts";
            part.PartLabel = "1)MiterEnds";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////

            //NailerVertExt
            part = new Part(3649, "NailerVertExt", this, 2, m_subAssemblyHieght + nailFinAd * 2.0m);
            part.PartGroupType = "NailFin-Parts";
            part.PartLabel = "1)MiterEnds";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////

            #endregion

        }

        #endregion

    }

}