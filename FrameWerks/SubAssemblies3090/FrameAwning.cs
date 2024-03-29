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

namespace FrameWorks.Makes.System3090
{

    public class FrameAwning : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal bronzeCrnBrk = 0.64m;
        const decimal gasketReduce = 1.250m;
        const decimal screenReduce2X = 1.5173m * 2.0m;

        #endregion

        #region Constructor

        public FrameAwning()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3090-Awning";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();

            decimal pweight = FrameWorks.Functions.PanelWieghtS2000(m_subAssemblyWidth, m_subAssemblyHieght);

            string labelStileR = string.Empty;
            string labelStileL = string.Empty;
            string labelTopRail = string.Empty;
            string labelBotRail = string.Empty;

            #region Frame

            //////////////////////////////////////////////////////////////////////////////

            // BrzOperWndVert
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4303, "BrzOperWndVert", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "FrameBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            // BrzOperWndHorz
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4303, "BrzOperWndHorz", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "FrameBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region ScreenFrame

            //////////////////////////////////////////////////////////////////////////////
   
            // ScreenBrzR -->>
            //part = new Part(4429, "ScreenBrzR", this, 1, m_subAssemblyHieght - screenReduce2X);
            //part.PartGroupType = "Frame-Parts";
            //part.PartLabel = "1)MiterEnds";
            //m_parts.Add(part);

            // ScreenBrzL <<-- 
            //part = new Part(4429, "ScreenBrzL", this, 1, m_subAssemblyHieght - screenReduce2X);
            //part.PartGroupType = "Frame-Parts";
            //part.PartLabel = "1)MiterEnds";
            //m_parts.Add(part);

            // ScreenBrz ^^
            //part = new Part(4429, "ScreenBrzHd", this, 1, m_subAssemblyWidth - screenReduce2X);
            //part.PartGroupType = "Frame-Parts";
            //part.PartLabel = "1)MiterEnds";
            //m_parts.Add(part);

            // ScreenBrz ||
            //part = new Part(4429, "ScreenBrzSl", this, 1, m_subAssemblyWidth - screenReduce2X);
            //part.PartGroupType = "Frame-Parts";
            //part.PartLabel = "1)MiterEnds";
            //m_parts.Add(part);

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

            // SetSocScrew_1/4-20x1/4
            part = new Part(1545, "SetSocScrew_1/4-20x1/4", this, 32, 0.0m);
            part.PartGroupType = "AsemblHrdwr-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Hardware-Parts

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // OperatorEncoreAwning
            part = new Part(5096, "OperatorEncoreAwning", this, 1, 0.0m);
            part.PartGroupType = "OperHardware-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // OperatorBacker
            part = new Part(5253, "OperatorBacker", this, 1, 0.0m);
            part.PartGroupType = "OperHardware-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Seal/Weatherstripping

            decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {
                peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);

                //FrameSeal
                part = new Part(2274, "FrameSeal", this, 1, peri);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }
           
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

        }



        #endregion


    }
}