 #region Copyright (c) 2018 WeaselWare Software
/************************************************************************************
'
' Copyright  2018 WeaselWare Software 
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
' Portions Copyright 2018 WeaselWare Software
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

    public class FixedIG : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal aluminumCrnBrk = 0.625m;
        const decimal stopReduceX2 = .6250m * 2.0m;
        const decimal glassReduce = .96875m;
        const decimal gasketReduce = 1.0046m;


        #endregion

        #region Constructor

        public FixedIG()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System2110-FixedIG";
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

            // AlumFixedL <--
            part = new Part(4344, "AlumFixedIG", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "FrameAlum";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // AlumFixedR -->
            part = new Part(4344, "AlumFixedR", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "FrameAlum";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // AlumFixedTop ^^
            part = new Part(4344, "AlumFixedIG", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "FrameAlum";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // AlumFixedSill ||
            part = new Part(4344, "AlumFixedSill", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "FrameAlum";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region StopAlum

            //////////////////////////////////////////////////////////////////////////////

            //AlumGlsStopL <--
            part = new Part(5711, "AlumGlsStopL", this, 1, m_subAssemblyHieght - stopReduceX2);
            part.PartGroupType = "StopAlum";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //AlumGlsStopR -->
            part = new Part(5711, "AlumGlsStopR", this, 1, m_subAssemblyHieght - stopReduceX2);
            part.PartGroupType = "StopAlum";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //AlumGlsStopT ^^
            part = new Part(5711, "AlumGlsStopT", this, 1, m_subAssemblyWidth - stopReduceX2);
            part.PartGroupType = "StopAlum";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            //AlumGlsStopB ||
            part = new Part(5711, "AlumGlsStopB", this, 1, m_subAssemblyWidth - stopReduceX2);
            part.PartGroupType = "StopAlum";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Glass

            //Glass Panel

            part = new Part(5785);
            part.FunctionalName = "Glass";
            part.PartGroupType = "Glass";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyWidth - (glassReduce * 2.0m);
            part.PartLength = m_subAssemblyHieght - (glassReduce * 2.0m);
            part.PartThick = 1.25m;
            part.PartLabel = "SNX 62/27";

            m_parts.Add(part);

            #endregion

            #region GlazingSeal

            for (int i = 0; i < 1; i++)
            {
                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);
                //EPDM_PreSet
                part = new Part(5713, "EPDM_PreSet", this, 1, peri);
                part.PartGroupType = "GlazingSeal";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            for (int i = 0; i < 1; i++)
            {
                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);
                //EPDM_Wedge
                part = new Part(5714, "EPDM_Wedge", this, 1, peri);
                part.PartGroupType = "GlazingSeal";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            #endregion

            #region AssyBrackets

            /////////////////////////////////////////////////////////////////////////

            //AglBrktAlum
            part = new Part(3206, "AglBrktAlum", this, 8, aluminumCrnBrk);
            part.PartGroupType = "AssyBrackets";
            part.PartLabel = "Angle_1.5";
            m_parts.Add(part);

            //PointSetScrew
            part = new Part(1545, "PointSetScrew", this, 32, 0.0m);
            part.PartGroupType = "AssyBrackets";
            part.PartLabel = "1/4_20x.375";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////

            #endregion

        }


        #endregion


    }
}