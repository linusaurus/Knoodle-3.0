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

    public class FixedDoorBP : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal bronzeCrnBrk = 0.64m;
        const decimal frmToDrGapX2 = 0.875m * 2.0m;
        const decimal panelReduce = 3.46875m * 2.0m;
        const decimal epdmReduce = 3.503125m;
        const decimal epdmADD = 2.375m;
        const decimal edgeSealAdd = .390m;
        const decimal hdpExtnd = 0.1250m;
        const decimal stopReduceX2 = 3.125m * 2.0m;

        #endregion

        #region Constructor

        public FixedDoorBP()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3090-FixedDoorBP";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();

            string labelStileR = string.Empty;
            string labelStileL = string.Empty;
            string labelTopRail = string.Empty;
            string labelBotRail = string.Empty;


            #region Frame-Parts


            // JamBrz

            for (int i = 0; i < 2; i++)
            {

                part = new Part(4306, "JamBrz", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "1)MiterEnds";

                m_parts.Add(part);

            }

            // HeadSillBrz

            for (int i = 0; i < 2; i++)
            {

                part = new Part(4306, "HeadSillBrz", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "1)MiterEnds";

                m_parts.Add(part);

            }


            #endregion

            #region AsemblHrdwr

            //////////////////////////////////////////////////////////////////////////////

            // BrzCnrBrkt
            for (int i = 0; i < 8; i++)
            {
                part = new Part(4265, "BrzCnrBrkt", this, 1, bronzeCrnBrk);
                part.PartGroupType = "AsemblHrdwr-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // SetSocScrew_1/4-20x1/4
            for (int i = 0; i < 32; i++)
            {
                part = new Part(1545, "SetSocScrew_1/4-20x1/4", this, 1, 0.0m);
                part.PartGroupType = "AsemblHrdwr-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Seal/Weatherstripping


            decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {

                peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

                //FrameSealKfolD
                part = new Part(2274, "FrameSealKfolD", this, 1, peri);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            #endregion

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #region BrzTB3inch

            ////////////////////////////////////////////////////////////////////////////////////

            // StileLeft
            for (int i = 0; i < 1; i++)
            {
                part = new Part(5319, "StileLeft", this, 1, m_subAssemblyHieght - frmToDrGapX2);
                part.PartGroupType = "BrzTB3inch";
                part.PartLabel = "1) Miter_Ends";
                m_parts.Add(part);

            }

            // StileRight
            for (int i = 0; i < 1; i++)
            {

                part = new Part(5319, "StileRight", this, 1, m_subAssemblyHieght - frmToDrGapX2);
                part.PartGroupType = "BrzTB3inch";
                part.PartLabel = "1) Miter_Ends";

                m_parts.Add(part);

            }

            // RailTop
            for (int i = 0; i < 1; i++)
            {

                part = new Part(5319, "RailTop", this, 1, m_subAssemblyWidth - frmToDrGapX2);
                part.PartGroupType = "BrzTB3inch";
                part.PartLabel = "1) Miter_Ends ";

                m_parts.Add(part);

            }

            // RailBot
            for (int i = 0; i < 1; i++)
            {

                part = new Part(5319, "RailBot", this, 1, m_subAssemblyWidth - frmToDrGapX2);
                part.PartGroupType = "BrzTB3inch";
                part.PartLabel = "1) Miter_Ends ";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region HDPE

            // HDPELockEdge
            for (int i = 0; i < 1; i++)
            {

                part = new Part(5672, "HDPELockEdge", this, 1, m_subAssemblyHieght - frmToDrGapX2 + hdpExtnd);
                part.PartGroupType = "HDPE-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = labelStileL = "";

                m_parts.Add(part);

            }

            // HDPEHingEdge
            for (int i = 0; i < 1; i++)
            {

                part = new Part(5672, "HDPEHingEdge", this, 1, m_subAssemblyHieght - frmToDrGapX2 + hdpExtnd);
                part.PartGroupType = "HDPE-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = labelStileL = "";

                m_parts.Add(part);

            }

            // HDPETop
            for (int i = 0; i < 1; i++)
            {

                part = new Part(5672, "HDPETop", this, 1, m_subAssemblyWidth - frmToDrGapX2 + 2.0m * hdpExtnd);
                part.PartGroupType = "HDPE-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = labelStileR = "";

                m_parts.Add(part);

            }

            // HDPEBot
            for (int i = 0; i < 1; i++)
            {

                part = new Part(5672, "HDPEBot", this, 1, m_subAssemblyWidth - frmToDrGapX2 + 2.0M * hdpExtnd);
                part.PartGroupType = "HDPE-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = labelStileR = "";

                m_parts.Add(part);

            }

            #endregion

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

            #region BronzePanelAssy

            //BlueStyro

            part = new Part(5671);

            part.FunctionalName = "BlueStyro";
            part.PartGroupType = "BronzePanelAssy-Parts";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyWidth - panelReduce ;
            part.PartLength = m_subAssemblyHieght - panelReduce ;
            part.PartThick = 0.50m;

            m_parts.Add(part);


            //464Sheet

            for (int i = 0; i < 1; i++)
            {
                part = new Part(5467);

                part.FunctionalName = "464Sheet";
                part.PartGroupType = "BronzePanelAssy-Parts";
                part.Qnty = 1;
                part.ContainerAssembly = this;
                part.PartWidth = m_subAssemblyWidth - (panelReduce);
                part.PartLength = m_subAssemblyHieght - (panelReduce);
                part.PartThick = 0.03196m;

                m_parts.Add(part);

            }

            //Poly_Back

            for (int i = 0; i < 1; i++)
            {
                part = new Part(4581);

                part.FunctionalName = "Poly_Back";
                part.PartGroupType = "BronzePanelAssy-Parts";
                part.Qnty = 1;
                part.ContainerAssembly = this;
                part.PartWidth = m_subAssemblyWidth - (panelReduce);
                part.PartLength = m_subAssemblyHieght - (panelReduce);
                part.PartThick = 0.03196m;

                m_parts.Add(part);

            }

            #endregion

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

            #region Seal/Weatherstripping


            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < 1; i++)
            {
                decimal periSeal = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

                //KfolDrEdge
                part = new Part(2274, "KfolDrEdge", this, 1, periSeal + 4.0m * edgeSealAdd);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            for (int i = 0; i < 1; i++)
            {

                decimal periSeal = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

                //GlazePreSet
                part = new Part(4314, "GlazePreSet", this, 1, periSeal - 4.0m * epdmReduce + 4.0m * epdmADD);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < 1; i++)
            {

                decimal periSeal = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

                //GlazeWedgeSeals
                part = new Part(4399, "GlazeWedgeSeals", this, 1, periSeal - 4.0m * epdmReduce + 4.0m * epdmADD);
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