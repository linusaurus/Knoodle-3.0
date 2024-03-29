﻿#region Copyright (c) 2016 WeaselWare Software
/************************************************************************************
'
' Copyright  2016 WeaselWare Software 
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
' Portions Copyright 2016 WeaselWare Software
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

namespace FrameWorks.Makes.System2010AH
{

    public class FixedIG_3x3SDL : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal aluminumCrnBrk = 0.625m;
        const decimal PointSetScrew = 0.25m;
        const decimal stopReduceX2 = .6250m * 2.0m;
        const decimal glassReduce = .96875m;
        const decimal gasketReduce = 1.09375m;
        const decimal sidMuntGPExt2 = 1.35465335m * 2.0m;
        const decimal sidMuntGPInt2 = 1.47049216m * 2.0m;
        const decimal vrtMuntGPExt2 = 1.29909927m * 2.0m;
        const decimal vrtMuntGPInt2 = 1.38031624m * 2.0m;


        #endregion

        #region Constructor

        public FixedIG_3x3SDL()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System2010AH-FixedIG_3x3SDL";
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

            // AlumFixedIGLeft <<--
            part = new Part(4344, "AlumFixedIGLeft", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "FrameAlum";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////
           
            // AlumFixedIGRight -->>
            part = new Part(4344, "AlumFixedIGRight", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "FrameAlum";
            part.PartLabel = "";
            m_parts.Add(part);
      
            //////////////////////////////////////////////////////////////////////////////

            // AlumFixedIGTop ^^
            part = new Part(4344, "AlumFixedIGTop", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "FrameAlum";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////
            
            // AlumFixedIGBot ||
            part = new Part(4344, "AlumFixedIGBot", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "FrameAlum";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region StopAlum

            //////////////////////////////////////////////////////////////////////////////

            // AlumGlsStpLeft <<--
            part = new Part(4341, "AlumGlsStpLeft", this, 1, m_subAssemblyHieght - stopReduceX2);
            part.PartGroupType = "StopAlum";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // AlumGlsStpRight -->>
            part = new Part(4341, "AlumGlsStpLeft", this, 1, m_subAssemblyHieght - stopReduceX2);
            part.PartGroupType = "StopAlum";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //AlumGlsStpTop ^^  
            part = new Part(4341, "AlumGlsStpTop", this, 1, m_subAssemblyWidth - stopReduceX2);
            part.PartGroupType = "StopAlum";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            //AlumGlsStpBot ||  
            part = new Part(4341, "AlumGlsStpBot", this, 1, m_subAssemblyWidth - stopReduceX2);
            part.PartGroupType = "StopAlum";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Muntins

            ////////////////////////////////////////////////////////////////////////////////////

            // ExtMuntHorz
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4588, "ExtMuntHorz", this, 1, m_subAssemblyWidth - sidMuntGPExt2);
                part.PartGroupType = "Muntins";
                part.PartLabel = "BEVEL_BISHOP_Ends";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            // IntMuntHorz
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4587, "IntMuntHorz", this, 1, m_subAssemblyWidth - sidMuntGPInt2);
                part.PartGroupType = "Muntins";
                part.PartLabel = "BEVEL_BISHOP_Ends";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            // ExtMuntVert
            for (int i = 0; i < 6; i++)
            {
                part = new Part(4588, "ExtMuntVert", this, 1, (m_subAssemblyHieght - sidMuntGPExt2 - vrtMuntGPExt2) / 3.0m);
                part.PartGroupType = "Muntins";
                part.PartLabel = "BEVEL_BISHOP_Ends";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            // IntMuntVert
            for (int i = 0; i < 6; i++)
            {
                part = new Part(4587, "IntMuntVert", this, 1, (m_subAssemblyHieght - sidMuntGPInt2 - vrtMuntGPInt2) / 3.0m);
                part.PartGroupType = "Muntins";
                part.PartLabel = "BEVEL_BISHOP_Ends";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Glass

            //GlassPanel
            part = new Part(5503);
            part.FunctionalName = "GlassPanel";
            part.PartGroupType = "Glass";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyWidth - (glassReduce * 2.0m);
            part.PartLength = m_subAssemblyHieght - (glassReduce * 2.0m);
            part.PartThick = 1.25m;
            part.PartLabel = "SDL_3x3";
            m_parts.Add(part);

            #endregion

            #region GlazingSeal

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {
                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);

                //EPDM_PreSet
                part = new Part(4314, "EPDM_PreSet", this, 1, peri);
                part.PartGroupType = "GlazingSeal";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {
                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);

                //EPDM_Wedge
                part = new Part(4284, "EPDM_Wedge", this, 1, peri);
                part.PartGroupType = "GlazingSeal";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // EPDM_PreSet
            part = new Part(4314, "EPDM_PreSet", this, 4, m_subAssemblyWidth - sidMuntGPExt2);
            part.PartGroupType = "GlazingSeal";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // EPDM_Wedge
            part = new Part(4284, "EPDM_Wedge", this, 4, m_subAssemblyWidth - sidMuntGPInt2);
            part.PartGroupType = "GlazingSeal";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // EPDM_PreSet
            part = new Part(4314, "EPDM_PreSet", this, 4, m_subAssemblyHieght - sidMuntGPExt2);
            part.PartGroupType = "GlazingSeal";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // EPDM_Wedge
            part = new Part(4284, "EPDM_Wedge", this, 4, m_subAssemblyHieght - sidMuntGPInt2);
            part.PartGroupType = "GlazingSeal";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region AssyBrackets

            /////////////////////////////////////////////////////////////////////////

            //AglBrktAlum
            part = new Part(3206, "AglBrktAlum", this, 8, aluminumCrnBrk);
            part.PartGroupType = "AssyBrackets";
            part.PartLabel = "Angle_1.5";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////

            //PointSetScrew_1/4_20
            part = new Part(1545, "PointSetScrew_1/4_20", this, 32, PointSetScrew);
            part.PartGroupType = "AssyBrackets";
            part.PartLabel = "1/4_20x.25";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////

            // Cross_Bracket
            part = new Part(5267, "Cross_Bracket", this, 8, aluminumCrnBrk);
            part.PartGroupType = "AssyBrackets";
            part.PartLabel = "Cross_3.025";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////

            // SetScrew_10_32
            part = new Part(3518, "SetScrew_10_32", this, 64, PointSetScrew);
            part.PartGroupType = "AssyBrackets";
            part.PartLabel = "1/4_20x.25";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////

            #endregion

        }

        #endregion

    }

}