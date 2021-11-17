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
using FrameWorks.Makes.System8000;


namespace FrameWorks.Makes.System8000
{

    public class DoorPairEllipse : SubAssemblyBase
    {

        #region Fields

        // The values we can change for different layouts
        const decimal doorReduceX2 = 0.875m * 2.0m;
        const decimal doorReduce = 0.875m;
        const decimal doorGapBot = 0.75m;
        const decimal doorGapMid = 0.375m;
        const decimal jambsRedX2 = 1.0m * 2.0m;
        const decimal doorGapRedX2 = 0.125m * 2.0m;
        const decimal overlapRabt = 0.1875m;
        const decimal stileHinge = 3.5m;
        const decimal stileMeeting = 4.0m;
        const decimal arkLengthAdd = 7.9648m;
        const decimal arkLenAddHd = 17.7325m;
        const decimal arkLenAddStp = 14.0675m;
        const decimal ellipsRed = 19.00m;
        const decimal drStlRedMid = 7.125m;
        const decimal drStlRedJmb = 4.625m * 2.0m;
        const decimal railTenon = 0.75m;
        const decimal railTenon2X = 0.75m * 2.0m;
        const decimal munTennon4X = 0.25m * 4.0m;
        const decimal sidMuntGP2 = 4.625m * 2.0m;
        const decimal centMuntGP = 7.625m;
        const decimal PointSetScrew = 0.25m;
        const decimal muntinRedX3 = 0.375m * 3.0m;
        const decimal muntinGSredx3 = 0.25m * 3.0m;
        const decimal glsDrGap = 4.6875m;
        const decimal glsDrGapMID = 7.75m;
        const decimal glsDrGapBot = 6.8125m;
        const decimal glsDrGapX2 = 4.6875m * 2.0m;
        const decimal stopRedBot = 6.625m;
        const decimal stopReduce = 4.625m;
        const decimal stopRed2x = 4.625m * 2.0m;
        const decimal stopRedMid = 7.625m;
        const decimal stpAddarkX2 = 5.5276m * 2.0m;
        const decimal calkJoint = 0.1250m;
        const decimal headReduct = 1.375m;
        const decimal botumRedut = .75m;
        const decimal trhldReduce = 1.0m * 2.0m;
        const decimal rabbetRedut = 0.75m * 2.0m;

        //



        #endregion

        #region Constructor

        public DoorPairEllipse()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System8000-DoorPairEllipse";
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

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #region Frame-Parts

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // Jamb_Wd -->> 
            for (int i = 0; i < 2; i++)
            {
                decimal doorPanel = decimal.Zero;

                doorPanel = this.Parent.SubAssemblies[0].SubAssemblyHieght;

                part = new Part(2379, "Jamb_Wd", this, 1, m_subAssemblyHieght - calkJoint - ellipsRed);
                part.PartGroupType = "Frame-Parts";
                decimal step = (doorPanel - 15.0m);
                step /= Convert.ToDecimal((FrameWorks.Functions.HingeCount(doorPanel) - 1));
                step = Math.Round(step, 4);
                //string msg = "";
                part.PartThick = 1.0m;
                part.PartWidth = 3.625m;
                part.PartLabel = "Jamb";
                m_parts.Add(part);
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // Head_Wd ^^
            part = new Part(2379, "Head_Wd", this, 1, m_subAssemblyWidth + arkLenAddHd );
            part.PartGroupType = "Frame-Parts";
            part.PartThick = 1.0m;
            part.PartWidth = 3.625m;
            part.PartLabel = "EllipsHead";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // DoorStpVert
            for (int i = 0; i < 2; i++)
            {
                part = new Part(2373, "DoorStpVert", this, 1, m_subAssemblyHieght - calkJoint - doorGapBot - ellipsRed);
                part.PartGroupType = "Frame";
                part.PartThick = 0.75m;
                part.PartWidth = 1.5m;
                part.PartLabel = "";
                m_parts.Add(part);
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // DoorStpHorz ^^
            part = new Part(2373, "DoorStpHorz", this, 1, m_subAssemblyWidth + arkLenAddStp);
            part.PartGroupType = "Frame-Parts";
            part.PartThick = 0.75m;
            part.PartWidth = 1.5m;
            part.PartLabel = "EllipsStop";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Threshold

            ////////////////////////////////////////////////////////////////////////////////////

            // ThresRecAlmTube ^^
            part = new Part(2377, "ThresGut", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Threshold-Parts";
            part.PartLabel = "Sub_Threshold";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // PemkoBrzThrhld ^^
            part = new Part(5587, "PemkoBrzThrhld", this, 1, m_subAssemblyWidth - trhldReduce);
            part.PartGroupType = "Threshold-Parts";
            part.PartLabel = "Pemko_Threshold";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region AssyHrdwrFrame

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Seal/Weatherstripping

            decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////





            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #region WoodStileRails

            ////////////////////////////////////////////////////////////////////////////////////

            // StileHinge
            for (int i = 0; i < 2; i++)
            {
                part = new Part(2380, "StileHinge", this, 1, m_subAssemblyHieght - doorReduce - doorGapBot - ellipsRed);
                part.PartGroupType = "WoodStileRails";
                part.PartWidth = 3.50m;
                part.PartLabel = "HingeStile";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            // StileCenterRabbet
            for (int i = 0; i < 2; i++)
            {
                part = new Part(2380, "StileCenterRabbet", this, 1, m_subAssemblyHieght - doorReduce - doorGapBot);
                part.PartGroupType = "WoodStileRails";
                part.PartWidth = 4.00m;
                part.PartLabel = "1/2_Rabbet_Quirk";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            // RailTop
            for (int i = 0; i < 2; i++)
            {
                part = new Part(2380, "RailTop", this, 1, (m_subAssemblyWidth - jambsRedX2 - doorGapRedX2) / 2.0m - stileMeeting + railTenon + arkLengthAdd);
                part.PartGroupType = "WoodStileRails";
                part.PartWidth = 3.5m;
                part.PartLabel = "EllipsTopRail";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            // RailBot
            for (int i = 0; i < 2; i++)
            {
                part = new Part(2376, "RailBot", this, 1, (m_subAssemblyWidth - jambsRedX2 - doorGapRedX2) / 2.0m + overlapRabt - stileHinge - stileMeeting + railTenon2X);
                part.PartGroupType = "WoodStileRails";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Muntins

            /////////////////////////////////////////////////////////////////////////////////////////////////////

            // MuntHorz
            for (int i = 0; i < 6; i++)
            {
                part = new Part(2378, "MuntHorz", this, 1, (m_subAssemblyWidth - sidMuntGP2 - centMuntGP + munTennon4X) / 2.0m);
                part.PartGroupType = "Muntins";
                part.PartLabel = "";            
                m_parts.Add(part);
            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region StopWood

            /////////////////////////////////////////////////////////////////////////////////////////////////////

            // GlsStpVert
            for (int i = 0; i < 28; i++)
            {
                part = new Part(2375, "GlsStpVert", this, 1, (m_subAssemblyHieght - stopReduce - muntinGSredx3 - stopRedBot - calkJoint) / 4.0m);
                part.PartGroupType = "StopWood-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "Vert";
                m_parts.Add(part);
            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////

            // GlsStpTop
            for (int i = 0; i < 4; i++)
            {
                part = new Part(2375, "GlsStpTop", this, 1, (m_subAssemblyWidth - stopRed2x - stopRedMid + stpAddarkX2) / 2.0m);
                part.PartGroupType = "StopWood-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "Ellips";
                m_parts.Add(part);
            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////

            // GlsStp
            for (int i = 0; i < 16; i++)
            {
                part = new Part(2375, "GlsStp", this, 1, (m_subAssemblyWidth - stopRed2x - stopRedMid) / 2.0m);
                part.PartGroupType = "StopWood-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "Horz";
                m_parts.Add(part);
            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Glass

            /////////////////////////////////////////////////////////////////////////////////////////////////////

            // GlassPanel
            for (int i = 0; i < 6; i++)
            {                
                part = new Part(911);
                part.FunctionalName = "Glass";
                part.PartGroupType = "Glass-Parts";
                part.Qnty = 1;
                part.ContainerAssembly = this;
                part.PartWidth = (m_subAssemblyWidth - glsDrGapX2 - glsDrGapMID ) / 2.0m;
                part.PartLength = (m_subAssemblyHieght - glsDrGap - glsDrGapBot - muntinRedX3 ) / 4.0m;
                part.PartThick = 0.25m;
                part.PartLabel = "";
                m_parts.Add(part);
            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////

            //Glass Panel
            for (int i = 0; i < 2; i++)
            {                
                part = new Part(911);
                part.FunctionalName = "Glass";
                part.PartGroupType = "Glass-Parts";
                part.Qnty = 1;
                part.ContainerAssembly = this;
                part.PartWidth = (m_subAssemblyWidth - glsDrGapX2 - glsDrGapMID) / 2.0m;
                part.PartLength = (m_subAssemblyHieght - glsDrGap - glsDrGapBot - muntinRedX3) / 4.0m;
                part.PartThick = 0.25m;
                part.PartLabel = "EllipsPattern";
                m_parts.Add(part);
            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region HardWare Logic

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            // Hinges
            for (int i = 0; i < 2; i++)
            {
                part = new Part(5689, "Hinges", this, HingeCount(m_subAssemblyHieght), 0.0m);
                part.PartGroupType = "Hardware-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////

            // Ball_Finials
            for (int i = 0; i < 4; i++)
            {
                part = new Part(5694, "Ball_Finials", this, HingeCount(m_subAssemblyHieght), 0.0m);
                part.PartGroupType = "Hardware-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Seal/Weatherstripping

            //////////////////////////////////////////////////////////////////////////////////////////////////////
            

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

        }

        private int HingeCount(decimal HingeAxisLength)
        {
            int result = 0;

            if (HingeAxisLength < 84.0m)
            {
                result = 3;
            }
            else if ((HingeAxisLength >= 84.0m) && (HingeAxisLength < 108.0m))
            {
                result = 4;
            }
            else if ((HingeAxisLength >= 108.0m) && (HingeAxisLength < 134.0m))
            {
                result = 5;
            }
            else if ((HingeAxisLength >= 134.0m) && (HingeAxisLength < 164.0m))
            {
                result = 6;
            }

            return result;

        }

        #endregion

    }

}