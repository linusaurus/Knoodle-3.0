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

    public class CrnSampDoorSash : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal bronzeCrnBrk = 0.640m;
        const decimal glsDrGap = 3.46875m;
        const decimal epdmReduce = 3.5m;
        const decimal epdmADD = 2.375m;
        const decimal kFoldReduce = 0.5625m;
        const decimal edgeSealAdd = .390m;
        const decimal hdpExtnd = 0.1250m;
        const decimal stopReduce = 3.125m;



        #endregion

        #region Constructor

        public CrnSampDoorSash()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System5010-CrnSampDoorSash";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            decimal pweight = FrameWorks.Functions.PanelWieghtS2000(m_subAssemblyWidth, m_subAssemblyHieght);

            string labelStileR = string.Empty;
            string labelStileL = string.Empty;
            string labelTopRail = string.Empty;
            string labelBotRail = string.Empty;



            #region Frame-Parts

            //////////////////////////////////////////////////////////////////////////////////////////

            // JamBrz -->> 
            for (int i = 0; i < 10; i++)

            {
                part = new Part(4306, "JamBrz", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "1)Miter_1_End";

                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////////////////

            // HeadBrz ^^
            for (int i = 0; i < 10; i++)

            {
                part = new Part(4306, "HeadBrz", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "1)Miter_1_End";

                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Wood-Clad

            //////////////////////////////////////////////////////////////////////////////////////////

            //Frame_CladJamb

            for (int i = 0; i < 10; i++)
            {
                part = new Part(4361, "WoodCladJamb", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "WoodFrameInt-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////////////////

            //Frame_CladHead

            for (int i = 0; i < 10; i++)
            {
                part = new Part(4361, "WoodCladHead", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "WoodFrameInt-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region AssyBrackets

            //////////////////////////////////////////////////////////////////////////////////////////

            // BrzCnrBrkt
            for (int i = 0; i < 10; i++)
            {
                part = new Part(4265, "BrzCnrBrkt", this, 1, bronzeCrnBrk);
                part.PartGroupType = "Hardware-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            /////////////////////////////////////////////////////////////////////////////////////////

            // SocSetScrw.25_20
            for (int i = 0; i < 40; i++)
            {
                part = new Part(1545, "SocSetScrw.25_20", this, 1, 0.0m);
                part.PartGroupType = "AssemblyHdw-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            /////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Seal/Weatherstripping


            decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 10; i++)
            {

                peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - kFoldReduce , m_subAssemblyWidth - kFoldReduce);

                //FrameSealKfolD
                part = new Part(2274, "FrameSealKfolD", this, 1, peri / 2.0m);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion


            //////////////////////////////////////////////////////////////////////////////////////////

            #region BRZtbAlWD


            //////////////////////////////////////////////////////////////////////////////////////////

            // Stile

            for (int i = 0; i < 10; i++)
            {
                part = new Part(4325, "Stile", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "BRZtbAlWD";
                part.PartLabel = "1) Miter_Ends";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////////////////

            // Rail

            for (int i = 0; i < 10; i++)
            {

                part = new Part(4325, "Rail", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "BRZtbAlWD";
                part.PartLabel = "1) Miter_Ends ";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region StopAlum

            // AlumGlsStpVert

            for (int i = 0; i < 10; i++)
            {
                part = new Part(4327, "AlumGlsStpVert", this, 1, m_subAssemblyHieght - stopReduce);
                part.PartGroupType = "StopAlum-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////

            // AlumGlsStpHorz

            for (int i = 0; i < 10; i++)
            {
                part = new Part(4327, "AlumGlsStpHorz", this, 1, m_subAssemblyWidth - stopReduce);
                part.PartGroupType = "StopAlum-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region WoodCladDr

            ////////////////////////////////////////////////////////////////////////////////////

            // Stile
            for (int i = 0; i < 10; i++)
            {
                part = new Part(4337, "Stile", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "WoodCladDr";
                part.PartLabel = "1) Miter_1_End";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            // Rail
            for (int i = 0; i < 10; i++)
            {
                part = new Part(4337, "Rail", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "WoodCladDr";
                part.PartLabel = "1) Miter_1_End ";

                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region StopWood

            //////////////////////////////////////////////////////////////////////////////////////////

            // WoodGlsStpVert

            for (int i = 0; i < 10; i++)
            {
                part = new Part(4331, "WoodGlsStpVert", this, 1, m_subAssemblyHieght - stopReduce);
                part.PartGroupType = "StopWood-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////////////////

            // WoodGlsStpHorz

            for (int i = 0; i < 10; i++)
            {
                part = new Part(4331, "WoodGlsStpHorz", this, 1, m_subAssemblyWidth - stopReduce);
                part.PartGroupType = "StopWood-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region HDPE

            //////////////////////////////////////////////////////////////////////////////////////////

            // HDPEHingEdge

            for (int i = 0; i < 10; i++)
            {
                part = new Part(4268, "HDPEHingEdge", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "HDPE-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = labelStileL = "";

                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////////////////

            // HDPETop

            for (int i = 0; i < 10; i++)
            {
                part = new Part(4269, "HDPETop", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "HDPE-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = labelStileR = "";

                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region PlexiGlass

            //PlexiGlassClear 
            for (int i = 0; i < 20; i++)

            {
                part = new Part(5513);

                part.FunctionalName = "PlexiGlassClear";
                part.PartGroupType = "PlexiGlassClear-Parts";
                part.Qnty = 1;
                part.ContainerAssembly = this;
                part.PartWidth = m_subAssemblyWidth - (glsDrGap);
                part.PartLength = m_subAssemblyHieght - (glsDrGap);
                part.PartThick = 0.1875m;

                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            // BlackWoodSpacerV
            for (int i = 0; i < 10; i++)
            {
                part = new Part(5175, "BlackWoodSpacerV", this, 1, m_subAssemblyHieght - glsDrGap);
                part.PartGroupType = "PlexiGlass-Parts";
                part.PartWidth = 0.875m;
                part.PartThick = 0.50m;
                part.PartLabel = "";

                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            // BlackWoodSpacerH
            for (int i = 0; i < 10; i++)
            {
                part = new Part(5175, "BlackWoodSpacerH", this, 1, m_subAssemblyWidth - glsDrGap);
                part.PartGroupType = "PlexiGlass-Parts";
                part.PartWidth = 0.875m;
                part.PartThick = 0.50m;
                part.PartLabel = "";

                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region AssyBraces

            //Alum_PVC_Corner_Bracket

            for (int i = 0; i < 10; i++)
            {
                part = new Part(4857, "Alum_PVC_Corner_Bracket", this, 1, 0.0m);
                part.PartGroupType = "AssyBraces-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //MS_FlatHead_8-32x3/4_SS

            for (int i = 0; i < 80; i++)
            {
                part = new Part(4858, "MS_FlatHead_8-32x3/4_SS", this, 1, 0.0m);
                part.PartGroupType = "AssyBraces-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            /////////////////////////////////////////////////////////////////////////////

            // Black_CrnBrSS14ga_0.6377

            for (int i = 0; i < 10; i++)
            {
                part = new Part(4854, "Black_CrnBrSS14ga_0.6377", this, 1, 0.0m);
                part.PartGroupType = "AsemblHrdwr-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // Blue_CrnBrSS14ga_0.4662

            for (int i = 0; i < 10; i++)
            {
                part = new Part(4855, "Blue_CrnBrSS14ga_0.4662", this, 1, 0.0m);
                part.PartGroupType = "AsemblHrdwr-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // Orange_CrnBrSS14ga_0.4662

            for (int i = 0; i < 10; i++)
            {
                part = new Part(4866, "Orange_CrnBrSS14ga_0.4662", this, 1, 0.0m);
                part.PartGroupType = "AsemblHrdwr-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // MS_FlatHead_8-32x3/16_SS

            for (int i = 0; i < 120; i++)
            {
                part = new Part(1545, "MS_FlatHead_8-32x3/16_SS", this, 1, 0.0m);
                part.PartGroupType = "AsemblHrdwr-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Seal/Weatherstripping

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < 10; i++)
            {
                decimal periSeal = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - kFoldReduce, m_subAssemblyWidth - kFoldReduce);

                //KfolDrEdge
                part = new Part(2274, "KfolDrEdge", this, 1, periSeal / 2.0m);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);
            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 10; i++)
            {
                decimal periSeal = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - epdmReduce , m_subAssemblyWidth - epdmReduce);

                //GlazPreSetEPDM
                part = new Part(4314, "GlazPreSetEPDM", this, 1, periSeal / 2.0m);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 10; i++)
            {
                decimal periSeal = FrameWorks.Functions.Perimeter(m_subAssemblyHieght -epdmReduce, m_subAssemblyWidth - epdmReduce);

                //GlazWedgEPDM
                part = new Part(4284, "GlazWedgEPDM", this, 1, periSeal / 2.0m);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion


        }


        #endregion

    }



}