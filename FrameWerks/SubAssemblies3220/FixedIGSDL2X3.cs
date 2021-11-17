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

namespace FrameWorks.Makes.System3220
{

    public class FixedIGSDL2X3 : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal bronzeCrnBrk = 0.625m;
        const decimal stopReduceX2 = 0.625m * 2.0m;
        const decimal frameStopX2 = 1.125m * 2.0m;
        const decimal glassReduce = 0.9375m;
        const decimal glassReduceX2 = 0.9375m * 2.0m;
        const decimal gasketReduce = 1.09375m;
        const decimal frameFxReduce = 1.5m;
        const decimal frameFxReduceX2 = 1.5m * 2.0m;
        const decimal frameFxReduceX3 = 1.5m * 3.0m;
        const decimal muntinCenter = 0.50m;
        const decimal muntinCenterX2 = 0.50m * 2.0m;
        const decimal muntinWidth = 1.25m;
        const decimal muntinWidthX2 = 2.0m * 1.25m;
        const decimal muntinWidthX3 = 3.0m * 1.25m;

        #endregion

        #region Constructor

        public FixedIGSDL2X3()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3220-FixedIGSDL2X3";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();

            #region FrameBrz

            //////////////////////////////////////////////////////////////////////////////

            // BrzFixedIGVert
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4300, "BrzFixedIGVert", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "FrameBrz-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            // BrzFixedIGHorz
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4300, "BrzFixedIGHorz", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "FrameBrz-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region StopBrz

            //////////////////////////////////////////////////////////////////////////////

            //BrzGlsStpVt
            for (int i = 0; i < 2; i++)
            {
                part = new Part(6888, "BrzGlsStpVt", this, 1, m_subAssemblyHieght - stopReduceX2);
                part.PartGroupType = "StopBrz-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            //BrzGlsStpHz 
            for (int i = 0; i < 2; i++)
            {
                part = new Part(6888, "BrzGlsStpHz", this, 1, m_subAssemblyWidth - stopReduceX2);
                part.PartGroupType = "StopBrz-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region BeadMuntin

            //////////////////////////////////////////////////////////////////////////////

            // BeadMuntin_Hrz
            for (int i = 0; i < 2; i++)
            {
                part = new Part(6889, "BeadMuntin_Hrz", this, 1, m_subAssemblyWidth - frameStopX2);
                part.PartGroupType = "BeadMuntin";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            // BeadMuntin_Vert
            for (int i = 0; i < 3; i++)
            {
                part = new Part(6889, "BeadMuntin_Vert", this, 1, (m_subAssemblyHieght - frameStopX2 - muntinCenterX2) / 3.0m);
                part.PartGroupType = "BeadMuntin";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Muntin_Flat

            //////////////////////////////////////////////////////////////////////////////

            // Muntin_FlatHrz
            for (int i = 0; i < 2; i++)
            {
                part = new Part(6887, "Muntin_FlatHrz", this, 1, m_subAssemblyWidth - frameFxReduceX2 );
                part.PartGroupType = "Muntin_Flat";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            // Muntin_FlatVrt
            for (int i = 0; i < 3; i++)
            {
                part = new Part(6887, "Muntin_FlatVrt", this, 1, (m_subAssemblyHieght - frameFxReduceX2 - muntinWidthX2) / 3.0m ); 
                part.PartGroupType = "Muntin_Flat";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Glass

            //////////////////////////////////////////////////////////////////////////////

            //GlassSDL2x3
            part = new Part(6898);
            part.FunctionalName = "GlassSDL2x3";
            part.PartGroupType = "GlassSDL2x3-Parts";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyWidth - (glassReduce * 2.0m);
            part.PartLength = m_subAssemblyHieght - (glassReduce * 2.0m);
            part.PartThick = 1.0m;
            part.PartLabel = "SDL2x3";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region GlazingSeal

            //////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {
                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);
                //GlazePreSet
                part = new Part(5713, "GlazePreSet", this, 1, peri);
                part.PartGroupType = "GlazingSeal-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {
                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);
                //GlazeWedgeSeals
                part = new Part(5714, "GlazeWedgeSeals", this, 1, peri);
                part.PartGroupType = "GlazingSeal-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////
            
            // GlazeWedgeSeals
            for (int i = 0; i < 4; i++)
            {
                part = new Part(5714, "GlazeWedgeSeals", this, 1, m_subAssemblyWidth - stopReduceX2);
                part.PartGroupType = "GlazingSeal";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region AsemblHrdwr

            //////////////////////////////////////////////////////////////////////////////

            // BrzCnrBrkt
            part = new Part(4853, "BrzCnrBrkt", this, 8, bronzeCrnBrk);
            part.PartGroupType = "AsemblHrdwr-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // SetSocScrew_1/4-20x1/4
            part = new Part(1545, "SetSocScrew_1/4-20x1/4", this, 32, 0.0m);
            part.PartGroupType = "AsemblHrdwr-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

        }

        #endregion

    }
}