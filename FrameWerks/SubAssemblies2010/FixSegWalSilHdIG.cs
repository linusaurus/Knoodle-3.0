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

    public class FixSegWalSilHdIG : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal stopReduce = .6250m;
        const decimal glassReduce = .96875m;
        const decimal glassRedMit = 0.40625m;
        const decimal gasketReduce = 1.09375m;


        #endregion

        #region Constructor

        public FixSegWalSilHdIG()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System2010-FixSegWalSilHdIG";
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

            // AlumFixedHead ^^
            part = new Part(4344, "AlumFixedHead", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "FrameAlum";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // AlumFixedSill ||       
            part = new Part(4344, "AlumFixedHead", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "FrameAlum";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////
            #endregion

            #region StopAlum

            //////////////////////////////////////////////////////////////////////////////

            //AlumGlsStpHead ^^
            part = new Part(4341, "AlumGlsStpHead", this, 1, m_subAssemblyWidth - stopReduce);
            part.PartGroupType = "StopAlum";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //AlumGlsStpSill ||
            part = new Part(4341, "AlumGlsStpSill", this, 1, m_subAssemblyWidth - stopReduce);
            part.PartGroupType = "StopAlum";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////
            #endregion

            #region Glass

            //////////////////////////////////////////////////////////////////////////////

            //Glass Panel
            part = new Part(3300);
            part.FunctionalName = "Glass";
            part.PartGroupType = "Glass";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyWidth - glassReduce - glassRedMit;
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
                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);
                part = new Part(4314, "GlazDartEPDM", this, 1, peri);
                part.PartGroupType = "GlazingSeal";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            //Glazing Seals
            for (int i = 0; i < 1; i++)
            {
                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);
                part = new Part(4399, "GlazWedgEPDM", this, 1, peri);
                part.PartGroupType = "GlazingSeal";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

        }

        #endregion

    }

}