﻿#region Copyright (c) 2017 WeaselWare Software
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

namespace FrameWorks.Makes.System2060
{

    public class FixedIG_2x2SDL : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal aluminumCrnBrk = 0.625m;
        const decimal PointSetScrew = 0.25m;
        const decimal stopReduceX2 = .6250m * 2.0m;
        const decimal glassReduce = .96875m;
        const decimal gasketReduce = 1.09375m;
        const decimal MuntGapX2 = .6250m * 2.0m;


        #endregion

        #region Constructor

        public FixedIG_2x2SDL()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System2060-FixedIG_2x2SDL";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();

            #region FrameAlum

            ////////////////////////////////////////////////////////////////////////////////////

            // AlumFixedIGLeft <--
            part = new Part(5125, "AlumFixedIGLeft", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "FrameAlum";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // AlumFixedIGRight -->
            part = new Part(5125, "AlumFixedIGRight", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "FrameAlum";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // AlumFixedIGHead ^^
            part = new Part(5125, "AlumFixedIGHead", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "FrameAlum";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // AlumFixedIGSill ||
            part = new Part(5125, "AlumFixedIGSill", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "FrameAlum";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region StopAlum

            ////////////////////////////////////////////////////////////////////////////////////

            //AlumGlsStpLeft
            part = new Part(5123, "AlumGlsStpLeft", this, 1, m_subAssemblyHieght - stopReduceX2);
            part.PartGroupType = "StopAlum";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            //AlumGlsStpRight
            part = new Part(5123, "AlumGlsStpRight", this, 1, m_subAssemblyHieght - stopReduceX2);
            part.PartGroupType = "StopAlum";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            //AlumGlsStpTop
            part = new Part(5123, "AlumGlsStpTop", this, 1, m_subAssemblyWidth - stopReduceX2);
            part.PartGroupType = "StopAlum";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            //AlumGlsStpBot
            part = new Part(5123, "AlumGlsStpBot", this, 1, m_subAssemblyWidth - stopReduceX2);
            part.PartGroupType = "StopAlum";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Muntins

            ////////////////////////////////////////////////////////////////////////////////////

            // MuntHorz
            for (int i = 0; i < 8; i++)
            {
                part = new Part(5306, "MuntHorz", this, 1, (m_subAssemblyWidth - MuntGapX2) / 2.0m);
                part.PartGroupType = "Muntins";
                part.PartLabel = "?_Ends";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            // MuntVert
            for (int i = 0; i < 8; i++)
            {
                part = new Part(5306, "MuntVert", this, 1, (m_subAssemblyHieght - MuntGapX2) / 2.0m);
                part.PartGroupType = "Muntins";
                part.PartLabel = "1)?_Ends";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region CrossBrace

            ////////////////////////////////////////////////////////////////////////////////////

            //CrossBrace2X2
            part = new Part(5267, "CrossBrace2X2", this, 2, 0);
            part.PartGroupType = "CrossBrace";
            part.PartLabel = "Cross_3.025";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            //SetScrew_10_32
            part = new Part(3518, "SetScrew_10_32", this, 16, PointSetScrew);
            part.PartGroupType = "CrossBrace";
            part.PartLabel = "10-32x1/4";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Glass

            ////////////////////////////////////////////////////////////////////////////////////

            //Glass Panel
            part = new Part(5323);
            part.FunctionalName = "Glass";
            part.PartGroupType = "Glass";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyWidth - (glassReduce * 2.0m);
            part.PartLength = m_subAssemblyHieght - (glassReduce * 2.0m);
            part.PartThick = 1.25m;
            part.PartLabel = "SDL_2x2";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region GlazingSeal

            ////////////////////////////////////////////////////////////////////////////////////

            //EPDM_PreSet
            for (int i = 0; i < 1; i++)
            {
                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);
                part = new Part(4314, "EPDM_PreSet", this, 1, peri);
                part.PartGroupType = "GlazingSeal";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            //EPDM_Wedge
            for (int i = 0; i < 1; i++)
            {
                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);
                part = new Part(4284, "EPDM_Wedge", this, 1, peri);
                part.PartGroupType = "GlazingSeal";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            // EPDM_Wedge_Munt_INT
            for (int i = 0; i < 4; i++)
            {
                part = new Part(2772, "EPDM_Wedge_Munt_INT", this, 1, m_subAssemblyWidth - MuntGapX2 / 2.0m);
                part.PartGroupType = "GlazingSeal";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            // EPDM_Wedge_Munt_EXT
            for (int i = 0; i < 4; i++)
            {
                part = new Part(5557, "EPDM_Wedge_Munt_EXT", this, 1, m_subAssemblyWidth - MuntGapX2 / 2.0m);
                part.PartGroupType = "GlazingSeal";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            // EPDM_Wedge_Munt_INT
            for (int i = 0; i < 4; i++)
            {
                part = new Part(2772, "EPDM_Wedge_Munt_INT", this, 1, m_subAssemblyHieght - MuntGapX2 / 2.0m);
                part.PartGroupType = "GlazingSeal";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            // EPDM_Wedge_Munt_EXT
            for (int i = 0; i < 4; i++)
            {
                part = new Part(5557, "EPDM_Wedge_Munt_EXT", this, 1, m_subAssemblyHieght - MuntGapX2 / 2.0m);
                part.PartGroupType = "GlazingSeal";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region AssyBrackets

            ////////////////////////////////////////////////////////////////////////////////////

            //AglBrktAlum
            part = new Part(3206, "AglBrktAlum", this, 8, aluminumCrnBrk);
            part.PartGroupType = "AssyBrackets";
            part.PartLabel = "Angle_1.5";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            //PointSetScrew_1/4_20
            part = new Part(1545, "PointSetScrew_1/4_20", this, 32, PointSetScrew);
            part.PartGroupType = "AssyBrackets";
            part.PartLabel = "1/4_20x.25";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

        }

        #endregion

    }

}