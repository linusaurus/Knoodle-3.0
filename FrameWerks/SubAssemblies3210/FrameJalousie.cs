#region Copyright (c) 2021 WeaselWare Software
/************************************************************************************
'
' Copyright  2021 WeaselWare Software 
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
' Portions Copyright 2021 WeaselWare Software
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

namespace FrameWorks.Makes.System3210
{

    public class FrameJalousie : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal bronzeCrnBrk = 0.64m;
        const decimal gasketReduce = 1.250m;
        const decimal angleReduce2X = 2.0m * 1.25m;
        const decimal screenReduce2X = 2.0m * 1.50m;
       
        #endregion

        #region Constructor

        public FrameJalousie()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3210-FrameJalousie";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();

            #region Frame

            //////////////////////////////////////////////////////////////////////////////

            // BrzOperWndVert
            part = new Part(4303, "BrzOperWndVert", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            // BrzOperWndVert
            part = new Part(4303, "BrzOperWndVert", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // BrzOperWndHorz
            part = new Part(4303, "BrzOperWndHorz", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            // BrzOperWndHorz
            part = new Part(4303, "BrzOperWndHorz", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Screen

            //////////////////////////////////////////////////////////////////////////////

            // BrzScreenVert
            part = new Part(4429, "BrzScreenVert", this, 1, m_subAssemblyHieght - screenReduce2X);
            part.PartGroupType = "Screen";
            part.PartLabel = "";
            m_parts.Add(part);

            // BrzScreenVert
            part = new Part(4429, "BrzScreenVert", this, 1, m_subAssemblyHieght - screenReduce2X);
            part.PartGroupType = "Screen";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // BrzScreenHorz
            part = new Part(4429, "BrzScreenHorz", this, 1, m_subAssemblyWidth - screenReduce2X);
            part.PartGroupType = "Screen";
            part.PartLabel = "MOD_CutHook";
            m_parts.Add(part);

            // BrzScreenHorz
            part = new Part(4429, "BrzScreenHorz", this, 1, m_subAssemblyWidth - screenReduce2X);
            part.PartGroupType = "Screen";
            part.PartLabel = "MOD_CutHook";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////
            
            // BraceCrnScreen
            part = new Part(5638, "BraceCrnScreen", this, 4, 0);
            part.PartGroupType = "Screen";
            part.PartLabel = "1_Inch_Leg ";
            m_parts.Add(part);

            // SetScrews_#8-32 x 3/16"- Cup Point 
            part = new Part(1537, "SetScrews", this, 8, 0);
            part.PartGroupType = "Screen";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region BrzAngle

            ////////////////////////////////////////////////////////////////////////////////

            // BrzAngleHorz
            part = new Part(2798, "BrzAngleHorz", this, 1, m_subAssemblyWidth - angleReduce2X);
            part.PartGroupType = "BrzAngle";
            part.PartLabel = "1";
            m_parts.Add(part);

            // BrzAngleHorz
            part = new Part(2798, "BrzAngleHorz", this, 1, m_subAssemblyWidth - angleReduce2X);
            part.PartGroupType = "BrzAngle";
            part.PartLabel = "2";
            m_parts.Add(part);

            // BrzAngleHorz
            part = new Part(2798, "BrzAngleHorz", this, 1, m_subAssemblyWidth - angleReduce2X);
            part.PartGroupType = "BrzAngle";
            part.PartLabel = "3";
            m_parts.Add(part);

            // BrzAngleHorz
            part = new Part(2798, "BrzAngleHorz", this, 1, m_subAssemblyWidth - angleReduce2X);
            part.PartGroupType = "BrzAngle";
            part.PartLabel = "4";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region AsemblHrdwr

            //////////////////////////////////////////////////////////////////////////////

            // BrzCnrBrkt
            part = new Part(4265, "BrzCnrBrkt", this, 8, bronzeCrnBrk);
            part.PartGroupType = "AsemblHrdwr-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // SetSocScrew_1/4-20x3/8
            part = new Part(1545, "SetSocScrew_1/4-20x3/8", this, 32, 0.0m);
            part.PartGroupType = "AsemblHrdwr-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Seal/Weatherstripping

            decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);

            ////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {
                peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);
                //FrameSeal
                part = new Part(2274, "FrameSeal", this, 1, peri);
                part.PartGroupType = "Seal";
                part.PartLabel = "";
                m_parts.Add(part);
            }
            
            
            // SmokeSeal
            part = new Part(589, "SmokeSeal", this, 4, m_subAssemblyWidth - angleReduce2X);
            part.PartGroupType = "Seal";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

        }

        #endregion

    }

}