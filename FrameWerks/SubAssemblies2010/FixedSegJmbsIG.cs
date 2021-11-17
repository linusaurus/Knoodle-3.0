#region Copyright (c) 2015 WeaselWare Software
/************************************************************************************
'
' Copyright  2015 WeaselWare Software 
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
' Portions Copyright 2015 WeaselWare Software
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

    public class FixedSegJmbsIG : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal aluminumCrnBrk = 0.625m;
        const decimal stopReduceX2 = .6250m * 2.0m;

        #endregion

        #region Constructor

        public FixedSegJmbsIG()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System2010-FixedSegJmbsIG";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();

            #region FrameAlum

            //////////////////////////////////////////////////////////////////////////////

            // AlumFixedIGL <<--
            part = new Part(4344, "AlumFixedIGVert", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "FrameAlum-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // AlumFixedIGR -->>
            part = new Part(4344, "AlumFixedIGVert", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "FrameAlum-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////
            
            #endregion

            #region StopAlum

            //////////////////////////////////////////////////////////////////////////////

            //AlumGlsStpL <<--
            part = new Part(4341, "AlumGlsStpVt", this, 1, m_subAssemblyHieght - stopReduceX2);
            part.PartGroupType = "StopAlum-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //AlumGlsStpR -->>
            part = new Part(4341, "AlumGlsStpVt", this, 1, m_subAssemblyHieght - stopReduceX2);
            part.PartGroupType = "StopAlum-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////
            #endregion

            #region AssyBrackets

            //////////////////////////////////////////////////////////////////////////////

            //AglBrktAlum
            part = new Part(3206, "AglBrktAlum", this, 8, aluminumCrnBrk);
            part.PartGroupType = "AssyBrackets";
            part.PartLabel = "Angle_1.5";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //PointSetScrew_1/4_20
            part = new Part(1545, "PointSetScrew_1/4_20", this, 32, 0.0m);
            part.PartGroupType = "AssyBrackets";
            part.PartLabel = "1/4_20x.25";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

        }

        #endregion

    }

}