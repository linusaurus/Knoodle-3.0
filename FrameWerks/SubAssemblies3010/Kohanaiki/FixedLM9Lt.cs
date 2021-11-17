
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

namespace FrameWorks.Makes.System3010
{

    public class FixedLM9Lt : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal bronzeCrnBrk = 0.625m;
        const decimal stopReduceX2 = 2.0m * 0.625m;
        const decimal spaceReduceX2 = 2.0m * 0.7686m;
        const decimal muntReduceX2 = 2.0m * 1.5m;
        const decimal glassReduce = .96875m;
        const decimal gasketReduce = 1.09375m;
        const decimal muntinUpper = 35.125m;
        const decimal muntinMiddle = 32.625m;
        const decimal muntinLower = 34.50m;

        #endregion

        #region Constructor

        public FixedLM9Lt()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3010-FixedLM9Lt";
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
            part = new Part(4300, "BrzFixedIGVert", this, 2, m_subAssemblyHieght);
            part.PartGroupType = "FrameBrz-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // BrzFixedIGHorz
            part = new Part(4300, "BrzFixedIGHorz", this, 2, m_subAssemblyWidth);
            part.PartGroupType = "FrameBrz-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Muntin_1"

            //////////////////////////////////////////////////////////////////////////////

            //BrzMntHrz9Lt  
            part = new Part(4313, "BrzMntHrz9Lt", this, 4, m_subAssemblyWidth - muntReduceX2);
            part.PartGroupType = "Muntin_1-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            //BrzMntVrt9Lt_UP 
            part = new Part(4313, "BrzMntVrt9Lt_UP", this, 4, muntinUpper);
            part.PartGroupType = "Muntin_1-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            //BrzMntVrt9Lt_MID 
            part = new Part(4313, "BrzMntVrt9Lt_MID", this, 4, muntinMiddle);
            part.PartGroupType = "Muntin_1-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            //BrzMntVrt9Lt_LOW  
            part = new Part(4313, "BrzMntVrt9Lt_LOW", this, 4, muntinLower);
            part.PartGroupType = "Muntin_1-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region StopBrz

            //////////////////////////////////////////////////////////////////////////////

            // BrzGlsStpVt
            part = new Part(4298, "BrzGlsStpVt", this, 2, m_subAssemblyHieght - stopReduceX2);
            part.PartGroupType = "StopBrz-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // BrzGlsStpHz 
            part = new Part(4298, "BrzGlsStpHz", this, 2, m_subAssemblyWidth - stopReduceX2);
            part.PartGroupType = "StopBrz-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // BrzGlsSPCRVt
            part = new Part(4317, "BrzGlsSPCRVt", this, 2, m_subAssemblyHieght - spaceReduceX2);
            part.PartGroupType = "StopBrz-Parts";
            part.PartThick = part.Source.Height;
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // BrzGlsSPCRHz 
            part = new Part(4317, "BrzGlsSPCRHz", this, 2, m_subAssemblyWidth - spaceReduceX2);
            part.PartGroupType = "StopBrz-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Glass

            //Glass Panel
            part = new Part(2137);
            part.FunctionalName = "Gls9ADL";
            part.PartGroupType = "Glass-Parts";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyWidth - (glassReduce * 2.0m);
            part.PartLength = m_subAssemblyHieght - (glassReduce * 2.0m);
            part.PartThick = 0.5625m;
            m_parts.Add(part);

            #endregion

            #region GlazingSeal

            //////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {
                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);
                //EPDMpreSet
                part = new Part(4314, "EPDMpreSet", this, 1, peri);
                part.PartGroupType = "GlazingSeal-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {
                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);
                //WedgEPDM
                part = new Part(4284, "WedgEPDM", this, 1, peri);
                part.PartGroupType = "GlazingSeal-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Hardware

            //CornerBrackets
            part = new Part(4265, "CornerBrackets", this, 8, bronzeCrnBrk);
            part.PartGroupType = "Hardware-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";
            m_parts.Add(part);
  
            #endregion

        }

        #endregion

    }

}