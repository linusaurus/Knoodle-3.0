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

    public class FixedIGRound : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal bronzeCrnBrk = 0.625m;
        const decimal stopReduceX2 = 2.0m * 0.625m;
        const decimal spaceReduceX2 = 2.0m * 0.7686m;
        const decimal frameFxReduceX2 = 1.5m * 2.0m;
        const decimal glassReduce = 0.9375m;
        const decimal gasketReduce = 1.09375m;
        const decimal π = 3.14159m;
        const decimal grip2X = 12.0m * 2.0m;

        #endregion

        #region Constructor

        public FixedIGRound()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3220-FixedIGRound";
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

            // BrzFixedIG_ROUND
            for (int i = 0; i < 4; i++)
            {
                part = new Part(4300, "BrzFixedIG_ROUND", this, 1, m_subAssemblyDepth);
                part.PartGroupType = "FrameBrz-Parts";
                part.PartLabel = "1/4_Round";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region StopBrz

            //////////////////////////////////////////////////////////////////////////////

            // BrzGlsStp_ROUND
            for (int i = 0; i < 4; i++)
            {
                part = new Part(6888, "BrzGlsStp_ROUND", this, 1, m_subAssemblyDepth);
                part.PartGroupType = "StopBrz-Parts";
                part.PartLabel = "1/4_Round";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Glass

            //////////////////////////////////////////////////////////////////////////////

            //GlassSDL2x2
            part = new Part(6898);
            part.FunctionalName = "GlassSDL1x2";
            part.PartGroupType = "GlassSDL1x2-Parts";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyWidth - (glassReduce * 2.0m);
            part.PartLength = m_subAssemblyHieght - (glassReduce * 2.0m);
            part.PartThick = 1.0m;
            part.PartLabel = "RoundSDL2x2";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region GlazingSeal

            for (int i = 0; i < 1; i++)
            {
                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);
                //EPDMpreSet
                part = new Part(4314, "EPDMpreSet", this, 1, peri);
                part.PartGroupType = "GlazingSeal-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            for (int i = 0; i < 1; i++)
            {
                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);
                //WedgEPDM
                part = new Part(4284, "WedgEPDM", this, 1, peri);
                part.PartGroupType = "GlazingSeal-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            #endregion

            #region Hardware

            //CornerBrackets
            //part = new Part(4265, "CornerBrackets", this, 8, bronzeCrnBrk);
            //part.PartGroupType = "Hardware-Parts";
            //part.PartLabel = "";
            //m_parts.Add(part);

            #endregion

        }

        #endregion

    }

}