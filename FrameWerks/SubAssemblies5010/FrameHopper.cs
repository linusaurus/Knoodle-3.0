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

namespace FrameWorks.Makes.System5010
{

    public class FrameHopper : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal gasketReduce = 1.250m;
        const decimal bronzeCrnBrk = 0.6250m;


        #endregion

        #region Constructor

        public FrameHopper()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System5010-FrameHopper";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();


            #region Frame

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // BrzOperWndVert
            part = new Part(4526, "BrzOperWndVert", this, 2, m_subAssemblyHieght);
            part.PartGroupType = "FrameBrz";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // BrzOperWndHorz
            part = new Part(4526, "BrzOperWndHorz", this, 2, m_subAssemblyWidth);
            part.PartGroupType = "FrameBrz";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region WoodFrame

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // WoodOperWndVert
            part = new Part(4333, "WoodOperWndVert", this, 2, m_subAssemblyHieght);
            part.PartGroupType = "WoodFrame";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // WoodOperWndHorz
            part = new Part(4333, "WoodOperWndHorz", this, 2, m_subAssemblyWidth);
            part.PartGroupType = "WoodFrame";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////           

            #endregion

            #region AssyBrackets

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // BrzCnrBrkt
            part = new Part(4265, "BrzCnrBrkt", this, 4, bronzeCrnBrk);
            part.PartGroupType = "AssyBrackets";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // AluCnrBrkt
            part = new Part(3206, "AluCnrBrkt", this, 4, 0.0m);
            part.PartGroupType = "AssyBrackets";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // SocSetScrw.25_20
            part = new Part(1545, "SocSetScrw.25_20", this, 32, 0.0m);
            part.PartGroupType = "AssyBrackets";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Seal/Weatherstripping

            decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {
                peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);
                //FrameSeal
                part = new Part(2274, "FrameSeal", this, 1, peri);
                part.PartGroupType = "Seal";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

        }

        #endregion

    }

}