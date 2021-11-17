

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

    public class SashCase3X3RHR : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal bronzeCrnBrk = 0.64m;
        const decimal braceCornerSS_Yellow = 0.4625m;
        const decimal stopReduceX2 = 2.0m * 0.9375m;
        const decimal stopReduce = 0.9375m;
        const decimal sashBeadRedX2 = 2.0m * 1.4375m;
        const decimal muntinThick2X = 2.0m * 1.25m;
        const decimal glassReduce = 1.25m;
        const decimal gasketReduce = 1.41875m;
        const decimal edgeSealAdd = .390m;
        const decimal muntinCenterX2 = 0.50m * 2.0m;
        const decimal muntSashRedX2 = 2.0m * 1.8125m;
        const decimal muntSashRedX3 = 3.0m * 1.25m;

        static int createID;

        #endregion

        #region Constructor

        public SashCase3X3RHR()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3220-SashCase3X3RHR";
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

            #region Sash

            /////////////////////////////////////////////////////////////////////////////////////////

            // StileBrzL <<--
            part = new Part(4305, "StileBrzL", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Sash-Parts";
            part.PartLabel = labelStileL = "1)MiterEnds" + "r\n" +
                                           "2)MachineKeeper";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////

            // StileBrzR -->>
            part = new Part(4305, "StileBrzR", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Sash-Parts";
            part.PartLabel = labelStileR = "MiterEnds";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////

            // RailBrzT ^^
            part = new Part(4305, "RailBrzT", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Sash-Parts";
            part.PartLabel = labelTopRail = "1)MiterEnds" + "\r\n" +
                                            "2)Machine3627Right";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////

            // RailBrzB ||
            part = new Part(4305, "RailBrzB", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Sash-Parts";
            part.PartLabel = labelBotRail = "1)MiterEnds" + "\r\n" +
                                            "2)Machine3627Right";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region BeadMuntin

            //////////////////////////////////////////////////////////////////////////////

            // BeadMuntin_Hrz
            for (int i = 0; i < 2; i++)
            {
                part = new Part(6889, "BeadMuntin_Hrz", this, 1, m_subAssemblyWidth - sashBeadRedX2 ) ;
                part.PartGroupType = "BeadMuntin";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            // BeadMuntin_Vert
            for (int i = 0; i < 6; i++)
            {
                part = new Part(6889, "BeadMuntin_Vert", this, 1, (m_subAssemblyHieght - sashBeadRedX2 - muntinCenterX2 ) / 3.0m);
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
                part = new Part(6887, "Muntin_FlatHrz", this, 1, m_subAssemblyWidth - muntSashRedX2);
                part.PartGroupType = "Muntin_Flat";
                part.PartLabel = "";
                m_parts.Add(part);
            }


            //////////////////////////////////////////////////////////////////////////////

            // Muntin_FlatVertExt
            for (int i = 0; i < 6; i++)
            {
                part = new Part(6887, "Muntin_FlatVertInt", this, 1, (m_subAssemblyHieght - muntSashRedX2 - muntinThick2X) / 3.0m);
                part.PartGroupType = "Muntin_Flat";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region StopBrz

            /////////////////////////////////////////////////////////////////////////////////////////

            // BrzGlsStpVt
            for (int i = 0; i < 2; i++)
            {
                part = new Part(6888, "BrzGlsStpVt", this, 1, m_subAssemblyHieght - stopReduceX2);
                part.PartGroupType = "StopBrz-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }


            /////////////////////////////////////////////////////////////////////////////////////////

            // BrzGlsStpHz
            for (int i = 0; i < 2; i++)
            {
                part = new Part(6888, "BrzGlsStpHz", this, 1, m_subAssemblyWidth - stopReduceX2);
                part.PartGroupType = "StopBrz-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }


            /////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region AsemblHrdwr

            /////////////////////////////////////////////////////////////////////////////////////////

            // SS_0.4525_YELLOW 
            part = new Part(4784, "SS_0.4525_YELLOW", this, 4, braceCornerSS_Yellow);
            part.PartGroupType = "AsemblHrdwr-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////

            // BrzCnrBrkt
            part = new Part(4265, "BrzCnrBrkt", this, 4, bronzeCrnBrk);
            part.PartGroupType = "AsemblHrdwr-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////

            // MS_FlatHead_8-32x3/16_SS
            part = new Part(502, "MS_FlatHead_8-32x3/16_SS", this, 16, 0.0m);
            part.PartGroupType = "AsemblHrdwr-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////

            // SetSocScrew_1/4-20x1/4
            part = new Part(1545, "SetSocScrew_1/4-20x1/4", this, 16, 0.0m);
            part.PartGroupType = "AsemblHrdwr-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Hardware

            ////////////////////////////////////////////////////////////////////////////////

            // Hinges
            part = new Part(5594, "Hinges", this, HingeCount2(m_subAssemblyHieght), 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = ".25_RAD_Corner";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region Glass

            /////////////////////////////////////////////////////////////////////////////////////////

            // GlassSDL3x3
            part = new Part(6898);
            part.FunctionalName = "GlassSDL3x3";
            part.PartGroupType = "Glass-Parts";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = (m_subAssemblyWidth - 2 * glassReduce);
            part.PartLength = (m_subAssemblyHieght - 2 * glassReduce);
            part.PartThick = 1.0m;
            part.PartLabel = "SDL3x3";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Seal/Weatherstripping

            /////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {
                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght + edgeSealAdd, m_subAssemblyWidth + edgeSealAdd);
                //SashEdgeSeal
                part = new Part(2274, "SashEdgeSeal", this, 1, peri);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            /////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {
                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);
                //GlazePreSet
                part = new Part(4314, "GlazePreSet", this, 1, peri);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            /////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {
                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);
                //GlazeWedgeSeals
                part = new Part(4399, "GlazeWedgeSeals", this, 1, peri);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            /////////////////////////////////////////////////////////////////////////////////////////

            #endregion

        }

        //BRONZE
        public static int HingeCount2(decimal HingeAxisLength)
        {
            int result = 0;

            if ((HingeAxisLength >= 42.0m) && (HingeAxisLength < 80.0m))
            {
                result = 3;
            }
            else if ((HingeAxisLength >= 80.0m) && (HingeAxisLength < 84.0m))
            {
                result = 4;
            }
            else if ((HingeAxisLength >= 84.0m) && (HingeAxisLength <= 120.0m))
            {
                result = 5;
            }
            else if (HingeAxisLength > 120.0m)
            {
                result = 6;

            }

            return result;
        }

        #endregion

    }

}