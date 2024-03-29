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

namespace FrameWorks.Makes.System2110
{

    public class WndFrm : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal aluminumCrnBrk = 0.625m;
        const decimal gaskFrmReduce = 1.250m;
    
        //static int createID;

        #endregion

        #region Constructor

        public WndFrm()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System2110-WndFrm";
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

            #region Frame

            //////////////////////////////////////////////////////////////////////////////

            // JmbAlumR -->>
            part = new Part(4347, "JmbAlumR", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame";
            part.PartLabel = "1)MiterEnds";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // JmbAlumL <<-- 
            part = new Part(4347, "JmbAlumL", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame";
            part.PartLabel = "1)MiterEnds";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // HeadAlum ^^
            part = new Part(4347, "HeadAlum", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame";
            part.PartLabel = "1)MiterEnds";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // SillAlum ||
            part = new Part(4347, "SillAlum", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame";
            part.PartLabel = "1)MiterEnds";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region AssyHrdwrFrame

            //////////////////////////////////////////////////////////////////////////////

            // AglBrktAlum
            part = new Part(3206, "AglBrktAlum", this, 8, aluminumCrnBrk);
            part.PartGroupType = "AssyHrdwrFrame";
            part.PartLabel = "Angle_1.5";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // PointSetScrew
            part = new Part(1545, "PointSetScrew", this, 32, 0.0m);
            part.PartGroupType = "AssyHrdwrFrame";
            part.PartLabel = "1/4x20x.375";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Seal/Weatherstripping

            //////////////////////////////////////////////////////////////////////////////

            //FrameSeal
            decimal periFrame = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gaskFrmReduce, m_subAssemblyWidth - gaskFrmReduce);
            for (int i = 0; i < 1; i++)
            {
                periFrame = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gaskFrmReduce, m_subAssemblyWidth - gaskFrmReduce);
                part = new Part(2274, "FrameSeal", this, 1, periFrame);
                part.PartGroupType = "Seal";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            //////////////////////////////////////////////////////////////////////////////

        }

        #endregion

    }

}