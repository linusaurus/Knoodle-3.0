#region Copyright (c) 2018 WeaselWare Software
/************************************************************************************
'
' Copyright  2018 WeaselWare Software 
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
' Portions Copyright 2018 WeaselWare Software
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
using FrameWorks.Makes.System3090;


namespace FrameWorks.Makes.System3090
{

    public class DoorBrz_RolnScrn_LftX : SubAssemblyBase
    {

        #region Fields


        // The values we can change for different layouts
        const int panelCount = 1;

        const decimal stopReduceX2 = 2.0m * 2.25m;
        const decimal ScreeReducex2 = 2.0m * 2.9294m;
        const decimal FillerSchtX2 = 2.0m * 2.41339m;


        #endregion

        #region Constructor

        public DoorBrz_RolnScrn_LftX()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3090-DoorBrz_RolnScrn_LftX";
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


            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region DoorBzTB



            // StileBTBLeft
            for (int i = 0; i < 1; i++)
            {
                part = new Part(5319, "StileBTBLeft", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "DoorBzTB-Parts";
                part.PartLabel = "1) Miter Ends";
                m_parts.Add(part);

            }

            // StileBTBRight
            for (int i = 0; i < 1; i++)
            {

                part = new Part(5319, "StileBTBRight", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "DoorBzTB-Parts";
                part.PartLabel = "1) Miter Ends";

                m_parts.Add(part);

            }

            // RailBTBtop
            for (int i = 0; i < 1; i++)
            {

                part = new Part(5319, "RailBTBtop", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "DoorBzTB-Parts";
                part.PartLabel = "1) Miter Ends ";

                m_parts.Add(part);

            }

            // RailBTBbot
            for (int i = 0; i < 1; i++)
            {

                part = new Part(5319, "RailBTBbot", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "DoorBzTB-Parts";
                part.PartLabel = "1) Miter Ends ";

                m_parts.Add(part);

            }

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region StopBrz

            // BrzGlsStpVert
            for (int i = 0; i < 2; i++)
            {
                part = new Part(5316, "BrzGlsStpVert", this, 1, m_subAssemblyHieght - stopReduceX2);
                part.PartGroupType = "StopBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            // BrzGlsStpTopBot
            for (int i = 0; i < 2; i++)
            {
                part = new Part(5316, "BrzGlsStpTopBot", this, 1, m_subAssemblyWidth - stopReduceX2);
                part.PartGroupType = "StopBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region ScreenFrame

            // BzScreen_FrameVert
            for (int i = 0; i < 2; i++)
            {

                part = new Part(4429, "BzScreen_FrameVert", this, 1, m_subAssemblyHieght - ScreeReducex2);
                part.PartGroupType = "ScreenFrame-Parts";
                part.PartLabel = "1) Miter Ends";

                m_parts.Add(part);

            }

            // BzScreen_FrameHorz
            for (int i = 0; i < 2; i++)
            {

                part = new Part(4429, "BzScreen_FrameHorz", this, 1, m_subAssemblyWidth - ScreeReducex2);
                part.PartGroupType = "ScreenFrame-Parts";
                part.PartLabel = "1) Miter Ends ";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // AngleBronze
            for (int i = 0; i < 2; i++)
            {

                part = new Part(4223, "AngleBronzeVert", this, 1, m_subAssemblyHieght - FillerSchtX2);
                part.PartGroupType = "ScreenFrame-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "1) Miter Ends";

                m_parts.Add(part);

            }

            // AngleBronze
            for (int i = 0; i < 2; i++)
            {

                part = new Part(4223, "AngleBronzeHorz", this, 1, m_subAssemblyWidth - FillerSchtX2);
                part.PartGroupType = "ScreenFrame-Parts";
                part.PartLabel = "1) Miter Ends ";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // HDPE_StructureBlock
            for (int i = 0; i < 2; i++)
            {

                part = new Part(5680, "HDPE_StructureBlock_Vert", this, 1, m_subAssemblyHieght - FillerSchtX2);
                part.PartGroupType = "ScreenFrame-Parts";
                part.PartLabel = "1) Miter Ends";

                m_parts.Add(part);

            }

            // HDPE_StructureBlock
            for (int i = 0; i < 2; i++)
            {

                part = new Part(5680, "HDPE_StructureBlock_Horz", this, 1, m_subAssemblyWidth - FillerSchtX2);
                part.PartGroupType = "ScreenFrame-Parts";
                part.PartLabel = "1) Miter Ends ";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region HDPE

            // HDPE_ChannelEdgeBacker
            for (int i = 0; i < 2; i++)
            {

                part = new Part(5683, "HDPE_ChannelEdgeBacker", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "HDPE-Parts";
                part.PartWidth = 1.25m;
                part.PartThick = 0.789m;
                part.PartLabel = labelStileL = "";

                m_parts.Add(part);
            }

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region AssyBrackets

            //AlumPVC_CornerBrace

            for (int i = 0; i < 4; i++)
            {
                part = new Part(5611, "AlumPVC_CornerBrace", this, 1, 0.0m);
                part.PartGroupType = "AssyBrackets-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////////////////////

            //Green_CnrBrcSS14ga_0.7049

            for (int i = 0; i < 8; i++)
            {
                part = new Part(4829, "Green_CnrBrcSS14ga_0.7049", this, 1, 0.0m);
                part.PartGroupType = "AssyBrackets-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////////////////////

            //Blue_CnrBrcSS14ga_0.4662

            for (int i = 0; i < 4; i++)
            {
                part = new Part(4855, "Blue_CnrBrcSS14ga_0.4662", this, 1, 0.0m);
                part.PartGroupType = "AssyBrackets-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////////////////////

            //MS_FlatHead_8-32x3/16_SS

            for (int i = 0; i < 48; i++)
            {
                part = new Part(502, "MS_FlatHead_8-32x3/16_SS", this, 1, 0.0m);
                part.PartGroupType = "AssyBrackets-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region GuidesTop

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // TGParent_5651

            for (int i = 0; i < 2; i++)
            {
                part = new Part(5651, "TGParent_5651", this, 1, 0.0m);
                part.PartGroupType = "GuidesTop-Parts";
                part.PartLabel = "Top_Guide_Parent";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////

            // TopGuide5212

            for (int i = 0; i < 1; i++)
            {
                part = new Part(5212, "TopGuide5212", this, 1, 0.0m);
                part.PartGroupType = "GuidesTop-Parts";
                part.PartLabel = "5212_LeftOverlap";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // TopGuide4438

            for (int i = 0; i < 1; i++)
            {
                part = new Part(4438, "TopGuide4438", this, 1, 0.0m);
                part.PartGroupType = "GuidesTop-Parts";
                part.PartLabel = "4438_RightOverlap";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region EdgeCap


            // EdgeCapChannel

            part = new Part(2972, "EdgeCapChannel", this, 1, 0.0m);
            part.PartGroupType = "EdgeCap-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region HardWare Logic

            // TwinRollers
            for (int i = 0; i < 2; i++)

            {
                part = new Part(5152, "TwinRollers", this, 1, 0.0m);
                part.PartGroupType = "Hardware-Parts";
                part.PartLabel = "";

                m_parts.Add(part);
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // Edge_Pull
            for (int i = 0; i < 1; i++)

            {
                part = new Part(5158, "Edge_Pull", this, 1, 0.0m);
                part.PartGroupType = "Hardware-Parts";
                part.PartLabel = "";

                m_parts.Add(part);
            }


            // FP_RearMount
            for (int i = 0; i < 1; i++)

            {
                part = new Part(2017, "FP_RearMount", this, 1, 0.0m);
                part.PartGroupType = "Hardware-Parts";
                part.PartLabel = "";

                m_parts.Add(part);
            }


            // FP_FaceMount
            for (int i = 0; i < 1; i++)

            {
                part = new Part(5602, "FP_FaceMount", this, 1, 0.0m);
                part.PartGroupType = "Hardware-Parts";
                part.PartLabel = "";

                m_parts.Add(part);
            }


            // OvalHeadScrews
            for (int i = 0; i < 2; i++)

            {
                part = new Part(5688, "OvalHeadScrews", this, 1, 0.0m);
                part.PartGroupType = "Hardware-Parts";
                part.PartLabel = "";

                m_parts.Add(part);
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region Seal/Weatherstripping

            //GlazePreSet

            for (int i = 0; i < 1; i++)
            {
                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - 2.581266m, m_subAssemblyWidth - 2.581266m);

                part = new Part(4314, "GlazePreSet", this, 1, peri);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);


            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////

            //GlazeWedgeSeals

            for (int i = 0; i < 1; i++)
            {

                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - 2.581266m, m_subAssemblyWidth - 2.581266m);

                part = new Part(4399, "GlazeWedgeSeals", this, 1, peri);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);


            }

            ///////////////////////////

            // Top Seal

            for (int i = 0; i < 2; i++)
            {

                part = new Part(3783, "Top Seal", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            /////////////////////////

            // Pile_Kerf

            for (int i = 0; i < 2; i++)
            {

                part = new Part(4462, "Pile_Kerf", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

        }
        #endregion

    }

}