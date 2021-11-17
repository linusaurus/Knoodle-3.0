#region Copyright (c) 2017 WeaselWare Software
/************************************************************************************
'
' Copyright  2017 WeaselWare Software 
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
' Portions Copyright 2017 WeaselWare Software
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

    public class FixInsideMiterIG : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal aluminumCrnBrk = 0.625m;
        const decimal PointSetScrew = 0.25m;
        const decimal stopReduceX2 = .6250m * 2.0m;
        const decimal stopReduce = .6250m;
        const decimal stopRedMitr = 0.179m;
        const decimal glassReduce = .96875m;
        const decimal glassRedMitrD = 2.28125m;
        const decimal glassRedMitrW = 0.78125m;
        const decimal gasketReduce = 1.09375m;


        #endregion

        #region Constructor

        public FixInsideMiterIG()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System2010-FixInsideMiterIG";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();

            #region FrameAlumMtr

            //////////////////////////////////////////////////////////////////////////////

            // AlumFixMonoJambR -->>
            part = new Part(4344, "AlumFixMonoJambR", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "FrameAlumMtr";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // AlumFixMonoJambL <<--
            part = new Part(4344, "AlumFixMonoJambL", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "FrameAlumMtr";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////
            // AlumFixMonoHead ^^
            part = new Part(4344, "AlumFixMonoWidth", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "FrameAlumMtr";
            part.PartLabel = "InsideVertMtr";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // AlumFixMonoSill ||
            part = new Part(4344, "AlumFixMonoWidth", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "FrameAlumMtr";
            part.PartLabel = "InsideVertMtr";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // AlumFixMonoDepHead ^^
            part = new Part(4344, "AlumFixMonoDepTop", this, 1, m_subAssemblyDepth);
            part.PartGroupType = "FrameAlumMtr";
            part.PartLabel = "InsideVertMtr";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // AlumFixMonoDepSill ||
            part = new Part(4344, "AlumFixMonoDepTop", this, 1, m_subAssemblyDepth);
            part.PartGroupType = "FrameAlumMtr";
            part.PartLabel = "InsideVertMtr";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region StopAlum

            //////////////////////////////////////////////////////////////////////////////

            //AlumGlsStpL <<--
            part = new Part(4341, "AlumGlsStpL", this, 1, m_subAssemblyHieght - stopReduceX2);
            part.PartGroupType = "StopAlum";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //AlumGlsStpR -->>
            part = new Part(4341, "AlumGlsStpR", this, 1, m_subAssemblyHieght - stopReduceX2);
            part.PartGroupType = "StopAlum";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////
            
            //AlumGlsStpTop ^^  
            part = new Part(4341, "AlumGlsStpWidth", this, 1, m_subAssemblyWidth - stopReduce - stopRedMitr);
            part.PartGroupType = "StopAlum";
            part.PartLabel = "BackVertMtr";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //AlumGlsStpBot ||  
            part = new Part(4341, "AlumGlsStpBot", this, 1, m_subAssemblyWidth - stopReduce - stopRedMitr);
            part.PartGroupType = "StopAlum";
            part.PartLabel = "BackVertMtr";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //AlumGlsStpDepTop ^^  
            part = new Part(4341, "AlumGlsStpDepTop", this, 1, m_subAssemblyDepth - stopReduce - stopRedMitr);
            part.PartGroupType = "StopAlum";
            part.PartLabel = "BackVertMtr";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //AlumGlsStpDepBot ||  
            part = new Part(4341, "AlumGlsStpDepBot", this, 1, m_subAssemblyDepth - stopReduce - stopRedMitr);
            part.PartGroupType = "StopAlum";
            part.PartLabel = "BackVertMtr";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////
            
            #endregion

            #region Glass

            //////////////////////////////////////////////////////////////////////////////

            //Glass Panel
            part = new Part(5503);
            part.FunctionalName = "Glass";
            part.PartGroupType = "Glass";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyWidth - (glassReduce + glassRedMitrW);
            part.PartLength = m_subAssemblyHieght - (glassReduce * 2.0m);
            part.PartThick = 1.25m;
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //Glass Panel
            part = new Part(5503);
            part.FunctionalName = "Glass";
            part.PartGroupType = "Glass";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyDepth - (glassReduce + glassRedMitrD);
            part.PartLength = m_subAssemblyHieght - (glassReduce * 2.0m);
            part.PartThick = 1.25m;
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region GlazingSeal

            //////////////////////////////////////////////////////////////////////////////

            //Glazing Seals
            for (int i = 0; i < 1; i++)
            {
                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce, m_subAssemblyDepth);
                part = new Part(4314, "GlazDartEPDM", this, 1, peri);
                part.PartGroupType = "GlazingSeal";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            //Glazing Seals
            for (int i = 0; i < 1; i++)
            {
                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce, m_subAssemblyDepth);
                part = new Part(4399, "GlazWedgEPDM", this, 1, peri);
                part.PartGroupType = "GlazingSeal";
                part.PartLabel = "";
                m_parts.Add(part);
            }

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
            part = new Part(1545, "PointSetScrew_1/4_20", this, 32, PointSetScrew);
            part.PartGroupType = "AssyBrackets";
            part.PartLabel = "1/4_20x.25";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

        }

        #endregion

    }

}