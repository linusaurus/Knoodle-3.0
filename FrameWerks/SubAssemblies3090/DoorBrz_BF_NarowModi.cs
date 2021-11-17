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
using FrameWorks.Makes.System3090;


namespace FrameWorks.Makes.System3090
{

    public class DoorBrz_BF_NarowModi : SubAssemblyBase
    {

        #region Fields


        // The values we can change for different layouts
        const int panelCount = 1;

        const decimal stopReduceX2 = 2.0m * 0.7136m;
        const decimal glassReduceX2 = 2.0m * 1.0625m;
        const decimal hdpeAddX2 = 2.0m * 0.0339m;
        const decimal hdpeReduceX2 = 2.0m * 0.877m;
        const decimal capReduceX2 = 2.0m * 1.5286m;


        #endregion

        #region Constructor

        public DoorBrz_BF_NarowModi()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3090-DoorBrz_BF_NarowModi";
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
            part = new Part(5319, "StileBTBLeft", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "DoorBzTB-Parts";
            part.PartLabel = "1) Miter Ends";
            part.PartWidth = 1.58864m;
            m_parts.Add(part);

            // StileBTBRight
            part = new Part(5319, "StileBTBRight", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "DoorBzTB-Parts";
            part.PartLabel = "1) Miter Ends";
            part.PartWidth = 1.58864m;
            m_parts.Add(part);

            // RailBTBtop
            part = new Part(5319, "RailBTBtop", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "DoorBzTB-Parts";
            part.PartLabel = "1) Miter Ends ";
            part.PartWidth = 1.58864m;
            m_parts.Add(part);

            // RailBTBbot
            part = new Part(5319, "RailBTBbot", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "DoorBzTB-Parts";
            part.PartLabel = "1) Miter Ends ";
            part.PartWidth = 1.58864m;
            m_parts.Add(part);

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

            // BrzGlsStpCapVert
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4042, "BrzGlsStpCapVert", this, 1, m_subAssemblyHieght - capReduceX2);
                part.PartGroupType = "StopBrz-Parts";
                part.PartWidth = 0.7476m;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////

            // BrzGlsStpCapHorz
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4042, "BrzGlsStpCapHorz", this, 1, m_subAssemblyWidth - capReduceX2);
                part.PartGroupType = "StopBrz-Parts";
                part.PartWidth = 0.7476m;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region HDPE

            // HDPE_BF_Vert
            for (int i = 0; i < 2; i++)
            {
                part = new Part(2932, "HDPE_BF_Vert", this, 1, m_subAssemblyHieght + hdpeAddX2);
                part.PartGroupType = "HDPE-Parts";
                part.PartWidth = 2.0625m;
                part.PartThick = 0.713m;
                part.PartLabel = labelStileL = "";
                m_parts.Add(part);
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // HDPE_BF_Horz
            for (int i = 0; i < 2; i++)
            {
                part = new Part(2932, "HDPE_BF_Horz", this, 1, m_subAssemblyWidth + hdpeAddX2);
                part.PartGroupType = "HDPE-Parts";
                part.PartWidth = 2.0625m;
                part.PartThick = 0.713m;
                part.PartLabel = labelStileL = "";
                m_parts.Add(part);
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////
         
            // HDPE_SF_Vert
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4528, "HDPE_SF_Vert", this, 1, m_subAssemblyHieght - hdpeReduceX2 );
                part.PartGroupType = "HDPE-Parts";
                part.PartWidth = 0.7939m;
                part.PartThick = 0.6516m;
                part.PartLabel = labelStileL = "";
                m_parts.Add(part);
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // HDPE_SF_Horz
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4528, "HDPE_SF_Horz", this, 1, m_subAssemblyWidth - hdpeReduceX2 );
                part.PartGroupType = "HDPE-Parts";
                part.PartWidth = 0.7939m;
                part.PartThick = 0.6516m;
                part.PartLabel = labelStileL = "";
                m_parts.Add(part);
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region AssyBrackets

            //AlumPVC_CornerBrace
            part = new Part(5611, "AlumPVC_CornerBrace", this, 4, 0.0m);
            part.PartGroupType = "AssyBrackets-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            //Green_CnrBrcSS14ga_0.7049
            part = new Part(4829, "Green_CnrBrcSS14ga_0.7049", this, 8, 0.0m);
            part.PartGroupType = "AssyBrackets-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            //Blue_CnrBrcSS14ga_0.4662
            part = new Part(4855, "Blue_CnrBrcSS14ga_0.4662", this, 4, 0.0m);
            part.PartGroupType = "AssyBrackets-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            //MS_FlatHead_8-32x3/16_SS
            part = new Part(502, "MS_FlatHead_8-32x3/16_SS", this, 48, 0.0m);
            part.PartGroupType = "AssyBrackets-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region Glass

            //Glass Panel
            part = new Part(5280);
            part.FunctionalName = "Glass";
            part.PartGroupType = "Glass-Parts";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyWidth - glassReduceX2;
            part.PartLength = m_subAssemblyHieght - glassReduceX2;
            part.PartThick = 0.25m;
            m_parts.Add(part);

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region Seal/Weatherstripping

            //GlazePreSet
            for (int i = 0; i < 1; i++)
            {
                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - 1.09215m, m_subAssemblyWidth - 1.09215m);
                part = new Part(4314, "GlazePreSet", this, 1, peri);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////

            //GlazeWedgeSeals
            for (int i = 0; i < 1; i++)
            {
                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - 1.092m, m_subAssemblyWidth - 1.09215m);
                part = new Part(4399, "GlazeWedgeSeals", this, 1, peri);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////

            // Bottom Seal
            part = new Part(1518, "Edge & Bottom Seal", this, 1, m_subAssemblyWidth + hdpeAddX2);
            part.PartGroupType = "Seal-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

        }

        #endregion

    }

}