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

namespace FrameWorks.Makes.System2110
{

    public class SashFixed_SDL2x2 : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal gstopReduce2X = 0.71875m * 2.0m;     
        const decimal glassReduce2X = 1.0625m * 2.0m;
        const decimal gaskSashReduce = 1.0917m;
        const decimal edgeSealAdd = 0.375m;
        const decimal muntinReduce2X = 1.5938m * 2.0m;

        //static int createID;

        #endregion

        #region Constructor

        public SashFixed_SDL2x2()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System2110-SashFixed_SDL2x2";
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


            //////////////////////////////////////////////////////////////////////////////

            #region Sash

            //////////////////////////////////////////////////////////////////////////////

            // StileAlumR -->
            part = new Part(5710, "StileAlumR", this, 1, m_subAssemblyHieght );
            part.PartGroupType = "Sash";
            part.PartLabel = labelStileR = "MiterEnds";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // StileAlumL <--
            part = new Part(5710, "StileAlumL", this, 1, m_subAssemblyHieght );
            part.PartGroupType = "Sash";
            part.PartLabel = labelStileL = "MiterEnds";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // RailAlumT ^^
            part = new Part(5710, "RailAlumT", this, 1, m_subAssemblyWidth );
            part.PartGroupType = "Sash";
            part.PartLabel = labelTopRail = "MiterEnds";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // RailAlumB ||
            part = new Part(5710, "RailAlumB", this, 1, m_subAssemblyWidth );
            part.PartGroupType = "Sash";
            part.PartLabel = labelBotRail = "MiterEnds";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region StopAlum

            //////////////////////////////////////////////////////////////////////////////

            // AlumGlsStopL <--
            part = new Part(5711, "AlumGlsStopL", this, 1, m_subAssemblyHieght - gstopReduce2X);
            part.PartGroupType = "StopAlum";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // AlumGlsStopR -->
            part = new Part(5711, "AlumGlsStopR", this, 1, m_subAssemblyHieght - gstopReduce2X);
            part.PartGroupType = "StopAlum";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // AlumGlsStopT ^^
            part = new Part(5711, "AlumGlsStopT", this, 1, m_subAssemblyWidth - gstopReduce2X);
            part.PartGroupType = "StopAlum";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // AlumGlsStopB ||
            part = new Part(5711, "AlumGlsStopB", this, 1, m_subAssemblyWidth - gstopReduce2X);
            part.PartGroupType = "StopAlum";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region MuntinBars

            //////////////////////////////////////////////////////////////////////////////

            // MuntinBars
            part = new Part(6924, "MuntinBarsInt", this, 1, (m_subAssemblyHieght - muntinReduce2X - 1.0m) / 2.0m);
            part.PartGroupType = "MuntinBars";
            part.PartLabel = "Vert";
            part.PartWidth = 1.0m;
            m_parts.Add(part);

            // MuntinBars
            part = new Part(6924, "MuntinBarsInt", this, 1, (m_subAssemblyHieght - muntinReduce2X - 1.0m) / 2.0m);
            part.PartGroupType = "MuntinBars";
            part.PartLabel = "Vert";
            part.PartWidth = 1.0m;
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // MuntinBars
            part = new Part(6924, "MuntinBarsInt", this, 1, m_subAssemblyWidth - muntinReduce2X);
            part.PartGroupType = "MuntinBars";
            part.PartLabel = "Horz";
            part.PartWidth = 1.0m;
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // MuntinBars
            part = new Part(3736, "MuntinBarsExt", this, 1, (m_subAssemblyHieght - muntinReduce2X - 1.0m) / 2.0m);
            part.PartGroupType = "MuntinBars";
            part.PartLabel = "Vert";
            part.PartWidth = 1.0m;
            m_parts.Add(part);

            // MuntinBars
            part = new Part(3736, "MuntinBarsExt", this, 1, (m_subAssemblyHieght - muntinReduce2X - 1.0m) / 2.0m);
            part.PartGroupType = "MuntinBars";
            part.PartLabel = "Vert";
            part.PartWidth = 1.0m;
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // MuntinBars
            part = new Part(3736, "MuntinBarsExt", this, 1, m_subAssemblyWidth - muntinReduce2X);
            part.PartGroupType = "MuntinBars";
            part.PartLabel = "Horz";
            part.PartWidth = 1.0m;
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region AssyHrdwrSash

            //////////////////////////////////////////////////////////////////////////////

            // SS_0.4625_InsetCrnBrace 
            part = new Part(4784, "SS_0.4625_InsetCrnBrace", this, 4, 0.0m);
            part.PartGroupType = "AssyHrdwrSash";
            part.PartLabel = "Yellow";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // FlatHead
            part = new Part(502, "FlatHead", this, 16, 0.0m);
            part.PartGroupType = "AssyHrdwrSash";
            part.PartLabel = "#8-32x3/16_UndercutHead";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // AlumCnrBrkt
            part = new Part(2931, "AlumCnrBrkt", this, 4, 0.0m);
            part.PartGroupType = "AssyHrdwrSash";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //PointSetScrew
            part = new Part(1545, "PointSetScrew", this, 16, 0.0m);
            part.PartGroupType = "AssyHrdwrSash";
            part.PartLabel = "1/4_20x.375";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Glass

            //////////////////////////////////////////////////////////////////////////////

            // Glass
            part = new Part(5785);
            part.FunctionalName = "Glass_2x2_SDL";
            part.PartGroupType = "Glass_2x2_SDL";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = (m_subAssemblyWidth - glassReduce2X);
            part.PartLength = (m_subAssemblyHieght - glassReduce2X);
            part.PartThick = 1.25m;
            part.PartLabel = "SNX 62/27";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // LeftSpacer_875
            part = new Part(4976, "LeftSpacer_875", this, 1, m_subAssemblyHieght - glassReduce2X);
            part.PartGroupType = "Glass";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // RightSpacer_875
            part = new Part(4976, "RightSpacer_875", this, 1, m_subAssemblyHieght - glassReduce2X);
            part.PartGroupType = "Glass";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // TopSpacer_875
            part = new Part(4976, "TopSpacer_875", this, 1, m_subAssemblyWidth - glassReduce2X);
            part.PartGroupType = "Glass";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // BotSpacer_875
            part = new Part(4976, "BotSpacer_875", this, 1, m_subAssemblyWidth - glassReduce2X);
            part.PartGroupType = "Glass";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////



            #endregion

            #region Seal/Weatherstripping

            //////////////////////////////////////////////////////////////////////////////

            //SashEdgeSeal
            for (int i = 0; i < 1; i++)
            {
                decimal periSash = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - edgeSealAdd, m_subAssemblyWidth - edgeSealAdd);
                part = new Part(2274, "SashEdgeSeal", this, 1, periSash);
                part.PartGroupType = "Seal";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            //EPDM_PreSet
            for (int i = 0; i < 1; i++)
            {
                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gaskSashReduce, m_subAssemblyWidth - gaskSashReduce);
                part = new Part(5713, "EPDM_PreSet", this, 1, peri);
                part.PartGroupType = "Seal";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            //EPDM_Wedge
            for (int i = 0; i < 1; i++)
            {
                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gaskSashReduce, m_subAssemblyWidth - gaskSashReduce);
                part = new Part(5714, "EPDM_Wedge", this, 1, peri);
                part.PartGroupType = "Seal";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

        }

        #endregion

    }

}