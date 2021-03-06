﻿#region Copyright (c) 2015 WeaselWare Software
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
using FrameWorks.Makes.System5010;


namespace FrameWorks.Makes.System5010
{

    public class DoorBrzWd_Swg_RHR : SubAssemblyBase
    {

        #region Fields

        // The values we can change for different layouts
        const decimal glsDrGapX2 = 2.59375m * 2.0m;
        const decimal epdmReduce = 2.73129921m;
        const decimal epdmADD = 2.375m;
        const decimal edgeSealAdd = .390m;
        const decimal hdpExtnd = 0.1250m;
        const decimal stopReduceX2 = 2.25m * 2.0m;




        #endregion

        #region Constructor

        public DoorBrzWd_Swg_RHR()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System5010-DoorBrzWd_Swg_RHR";
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




            #region BRZtbAlWD


            ////////////////////////////////////////////////////////////////////////////////////

            // StileLeft
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4325, "StileLeft", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "BRZtbAlWD";
                part.PartLabel = "1) Miter_Ends";
                m_parts.Add(part);

            }


            // StileRight
            for (int i = 0; i < 1; i++)
            {

                part = new Part(4325, "StileRight", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "BRZtbAlWD";
                part.PartLabel = "1) Miter_Ends";

                m_parts.Add(part);

            }


            // RailTop
            for (int i = 0; i < 1; i++)
            {

                part = new Part(4325, "RailTop", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "BRZtbAlWD";
                part.PartLabel = "1) Miter_Ends ";

                m_parts.Add(part);

            }


            // RailBot
            for (int i = 0; i < 1; i++)
            {

                part = new Part(4325, "RailBot", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "BRZtbAlWD";
                part.PartLabel = "1) Miter_Ends ";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region StopAlum


            // AlumGlsStpVert
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4327, "AlumGlsStpVert", this, 1, m_subAssemblyHieght - stopReduceX2);
                part.PartGroupType = "StopAlum-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////


            // AlumGlsStpTopBot
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4327, "AlumGlsStpTopBot", this, 1, m_subAssemblyWidth - stopReduceX2);
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

            // StileLeft
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4337, "StileLeft", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "WoodCladDr";
                part.PartLabel = "1) Miter_Ends";
                m_parts.Add(part);

            }


            // StileRight
            for (int i = 0; i < 1; i++)
            {

                part = new Part(4337, "StileRight", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "WoodCladDr";
                part.PartLabel = "1) Miter_Ends";

                m_parts.Add(part);

            }


            // RailTop
            for (int i = 0; i < 1; i++)
            {

                part = new Part(4337, "RailTop", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "WoodCladDr";
                part.PartLabel = "1) Miter_Ends ";

                m_parts.Add(part);

            }


            // RailBot
            for (int i = 0; i < 1; i++)
            {

                part = new Part(4337, "RailBot", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "WoodCladDr";
                part.PartLabel = "1) Miter_Ends ";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region StopWood


            // WoodGlsStpVert
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4331, "WoodGlsStpVert", this, 1, m_subAssemblyHieght - stopReduceX2);
                part.PartGroupType = "StopWood-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////


            // WoodGlsStpTopBot
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4331, "WoodGlsStpTopBot", this, 1, m_subAssemblyWidth - stopReduceX2);
                part.PartGroupType = "StopWood-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////




            #endregion

            #region HDPE



            // HDPELockEdge
            for (int i = 0; i < 1; i++)
            {

                part = new Part(4269, "HDPELockEdge", this, 1, m_subAssemblyHieght + hdpExtnd);
                part.PartGroupType = "HDPE-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = labelStileL = "";

                m_parts.Add(part);

            }



            // HDPEHingEdge
            for (int i = 0; i < 1; i++)
            {

                part = new Part(4268, "HDPEHingEdge", this, 1, m_subAssemblyHieght + hdpExtnd);
                part.PartGroupType = "HDPE-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = labelStileL = "";

                m_parts.Add(part);

            }



            // HDPETop
            for (int i = 0; i < 1; i++)
            {


                part = new Part(4269, "HDPETop", this, 1, m_subAssemblyWidth + 2.0m * hdpExtnd);
                part.PartGroupType = "HDPE-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = labelStileR = "";

                m_parts.Add(part);

            }


            // HDPEBot
            for (int i = 0; i < 1; i++)
            {


                part = new Part(4270, "HDPEBot", this, 1, m_subAssemblyWidth + 2.0M * hdpExtnd);
                part.PartGroupType = "HDPE-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = labelStileR = "";

                m_parts.Add(part);

            }



            #endregion

            #region Glass



            // GlassPanel
            for (int i = 0; i < 1; i++)
            {

                //Glass
                part = new Part(4550);
                part.FunctionalName = "Glass";
                part.PartGroupType = "Glass-Parts";
                part.Qnty = 1;
                part.ContainerAssembly = this;
                part.PartWidth = (m_subAssemblyWidth - glsDrGapX2);
                part.PartLength = (m_subAssemblyHieght - glsDrGapX2);
                part.PartThick = 1.230m;
                part.PartLabel = "";

                m_parts.Add(part);


            }



            #endregion

            #region AssyBraces

            //Alum_PVC_Corner_Bracket

            for (int i = 0; i < 4; i++)
            {
                part = new Part(4857, "Alum_PVC_Corner_Bracket", this, 1, 0.0m);
                part.PartGroupType = "AssyBraces-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //MS_FlatHead_8-32x3/4_SS

            for (int i = 0; i < 32; i++)
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

            for (int i = 0; i < 4; i++)
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

            for (int i = 0; i < 4; i++)
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

            for (int i = 0; i < 4; i++)
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

            for (int i = 0; i < 48; i++)
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

            #region HardWare Logic

            // Hinges
            part = new Part(3685, "Hinges", this, HingeCount(m_subAssemblyHieght), 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = ".25_RAD_Corner";

            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////

            //AmesburyMultipointActive

            FrameWorks.Makes.Hardware.Amesbury40.Premiere2000.MultipointActive GearAssy =
                new FrameWorks.Makes.Hardware.Amesbury40.Premiere2000.MultipointActive(m_subAssemblyHieght, this);
            foreach (Part innerpart in GearAssy.Parts)
            {
                //inner
                this.Parts.Add(innerpart);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Lever

            //OlivariChiara

            part = new Part(5132, "OlivariChiara", this, 1, 0);
            part.PartGroupType = "Lever";
            part.PartLabel = "";
            m_parts.Add(part);



            #endregion

            #region Seal/Weatherstripping


            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < 1; i++)
            {
                decimal periSeal = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

                //KfolDrEdge
                part = new Part(2274, "KfolDrEdge", this, 1, periSeal - m_subAssemblyWidth + 4.0m * edgeSealAdd);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //DoorBotPVC

            part = new Part(1518, "DoorBotPVC", this, 1, m_subAssemblyWidth + 2.0m * hdpExtnd);
            part.PartGroupType = "Seal-Parts";
            part.PartLabel = "";

            m_parts.Add(part);


            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {

                decimal periSeal = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

                //GlazPreSetEPDM
                part = new Part(4314, "GlazPreSetEPDM", this, 1, periSeal - 4.0m * epdmReduce + 4.0m * epdmADD);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < 1; i++)
            {

                decimal periSeal = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

                //GlazWedgEPDM
                part = new Part(4284, "GlazWedgEPDM", this, 1, periSeal - 4.0m * epdmReduce + 4.0m * epdmADD);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////





            #endregion



        }

        private int HingeCount(decimal HingeAxisLength)
        {
            int result = 0;

            if (HingeAxisLength < 84.0m)
            {
                result = 4;
            }
            else if ((HingeAxisLength >= 84.0m) && (HingeAxisLength < 108.0m))
            {
                result = 5;
            }
            else if ((HingeAxisLength >= 108.0m) && (HingeAxisLength < 134.0m))
            {
                result = 6;
            }
            else if ((HingeAxisLength >= 134.0m) && (HingeAxisLength < 164.0m))
            {
                result = 7;
            }


            return result;
        }




        #endregion

    }




}