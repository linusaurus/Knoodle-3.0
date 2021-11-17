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
using FrameWorks.Makes.SystemSTEEL;


namespace FrameWorks.Makes.SystemSTEEL
{

    public class DrSteelPr1X3AtRH : SubAssemblyBase
    {

        #region Fields

        // The values we can change for different layouts
        const decimal doorReduceX2 = 1.375m * 2.0m;
        const decimal doorReduce = 1.375m;
        const decimal doorGapBot = 0.5317m;
        const decimal doorGapMid = 0.25m;
        const decimal sidMuntGPExt2 = 2.375m * 2.0m;
        const decimal sidMuntGPInt2 = 2.375m * 2.0m;
        const decimal centMuntGPExt = 2.25m;
        const decimal centMuntGPInt = 2.25m;
        const decimal glsMuntGap2X = 0.25m * 2.0m;
        const decimal glsDrGap = 2.5625m;
        const decimal glsDrGapMID = 2.625m;
        const decimal glsDrGapBot = 1.7192m;
        const decimal glsDrGapX2 = 2.5625m * 2.0m;
        const decimal epdmReduce = 2.73129921m;
        const decimal epdmADD = 2.375m;
        const decimal edgeSealAdd = .390m;
        const decimal stopRedBot = 3.00m;
        const decimal stopReduce = 2.375m;
        const decimal stopRed2x = 2.375m * 2.0m;
        const decimal stopRedMid = 2.25m;
        const decimal calkJoint = 0.125m;
        const decimal headReduct = 1.0m * 2.0m;
        const decimal botumRedut = .5317m;
        const decimal kFoldRedut = 1.25m;
        const decimal morticeBox = 9.5477m;


        //



        #endregion

        #region Constructor

        public DrSteelPr1X3AtRH()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "SystemSTEEL-DrSteelPr1X3AtRH";
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


            // JambsWood -->> 

            for (int i = 0; i < 2; i++)
            {
                decimal doorPanel = decimal.Zero;

                doorPanel = this.Parent.SubAssemblies[0].SubAssemblyHieght;

                part = new Part(225, "JambsWood<>", this, 1, m_subAssemblyHieght - calkJoint);
                part.PartGroupType = "Frame-Parts";
                decimal step = (doorPanel - 15.0m);
                step /= Convert.ToDecimal((FrameWorks.Functions.HingeCount(doorPanel) - 1));
                step = Math.Round(step, 4);
                //string msg = "";
                part.PartLabel = "1) Rabbit\r\n" +
                                 "2) [911.m]Cope Jamb Bottom->\r\n" +
                                 "3) Position 0rigin TOU @ ->" + (7.5m + 0.875m).ToString() + "\r\n" +
                                 "4) Hinge Backer Prep->[1982.m] "
                       + FrameWorks.Functions.HingeCount(doorPanel).ToString() + "@<" + step.ToString() + ">O.C.";

                m_parts.Add(part);
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // HeadWood ^^
            part = new Part(225, "HeadWood", this, 1, m_subAssemblyWidth - headReduct);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterEnds";

            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region ASTRAGAL

            // STEEL_FACE_1.0

            part = new Part(2004, "STEEL_FACE_1.0", this, 1, m_subAssemblyHieght - doorReduce - doorGapBot);
            part.PartGroupType = "ASTRAGAL-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            // STEEL_STND_OFF_0.50

            part = new Part(2003, "STEEL_STND_OFF_0.50", this, 1, m_subAssemblyHieght - doorReduce - doorGapBot);
            part.PartGroupType = "ASTRAGAL-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region Seal/Weatherstripping

            decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {

                peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - calkJoint, m_subAssemblyWidth - kFoldRedut);

                //FrameSealCfolD
                part = new Part(2147, "FrameSealCfolD", this, 1, peri - m_subAssemblyWidth);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #region STEEL_DOORS

            ////////////////////////////////////////////////////////////////////////////////////

            // StileLeft
            for (int i = 0; i < 2; i++)
            {
                part = new Part(1999, "StileLeft", this, 1, m_subAssemblyHieght - doorReduce - doorGapBot);
                part.PartGroupType = "STEEL_DOORS";
                part.PartLabel = "1) Miter_Ends";
                m_parts.Add(part);

            }

            // StileRight
            for (int i = 0; i < 2; i++)
            {

                part = new Part(1999, "StileRight", this, 1, m_subAssemblyHieght - doorReduce - doorGapBot);
                part.PartGroupType = "STEEL_DOORS";
                part.PartLabel = "1) Miter_Ends";

                m_parts.Add(part);

            }

            // RailTop
            for (int i = 0; i < 2; i++)
            {

                part = new Part(1999, "RailTop", this, 1, (m_subAssemblyWidth - doorReduceX2 - doorGapMid) / 2.0m);
                part.PartGroupType = "STEEL_DOORS";
                part.PartLabel = "1) Miter_Ends ";

                m_parts.Add(part);

            }

            // RailBot
            for (int i = 0; i < 2; i++)
            {

                part = new Part(1999, "RailBot", this, 1, (m_subAssemblyWidth - doorReduceX2 - doorGapMid) / 2.0m);
                part.PartGroupType = "STEEL_DOORS";
                part.PartLabel = "1) Miter_Ends ";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region HardwareBox

            ////////////////////////////////////////////////////////////////////////////////////

            // MBox_Face
            for (int i = 0; i < 4; i++)
            {

                part = new Part(2350, "MBox_Face", this, 1, morticeBox );
                part.PartGroupType = "HardwareBox";
                part.PartWidth = 3.875m;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            // MBox_Edges
            for (int i = 0; i < 4; i++)
            {

                part = new Part(2350, "MBox_Edges", this, 1, morticeBox);
                part.PartGroupType = "HardwareBox";
                part.PartWidth = 1.75m;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Muntins

            ////////////////////////////////////////////////////////////////////////////////////

            // TeeMuntHorz
            for (int i = 0; i < 4; i++)
            {

                part = new Part(2803, "TeeMuntHorz", this, 1, (m_subAssemblyWidth - sidMuntGPExt2 - centMuntGPExt) / 2.0m);
                part.PartGroupType = "Muntins";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            // RoundMuntHorz
            for (int i = 0; i < 4; i++)
            {

                part = new Part(2002, "RoundMuntHorz", this, 1, (m_subAssemblyWidth - sidMuntGPExt2 - centMuntGPExt) / 2.0m);
                part.PartGroupType = "Muntins";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            // BarMuntHorz
            for (int i = 0; i < 8; i++)
            {

                part = new Part(2509, "BarMuntHorz", this, 1, (m_subAssemblyWidth - sidMuntGPInt2 - centMuntGPInt) / 2.0m);
                part.PartGroupType = "Muntins";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region StpStlBar

            // StpStlBarVert
            for (int i = 0; i < 4; i++)
            {
                part = new Part(2001, "StpStlBarVert", this, 1, m_subAssemblyHieght - stopReduce - stopRedBot);
                part.PartGroupType = "StpStlBar-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////
            
            // StpStlAngVert
            for (int i = 0; i < 4; i++)
            {
                part = new Part(2000, "StpStlAngVert", this, 1, m_subAssemblyHieght - stopReduce - stopRedBot);
                part.PartGroupType = "StpStlBar-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////


            // StpStlRoundVert
            for (int i = 0; i < 4; i++)
            {
                part = new Part(2002, "StpStlRoundVert", this, 1, m_subAssemblyHieght - stopReduce - stopRedBot);
                part.PartGroupType = "StpStlBar-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            // StpStlBarTopBot
            for (int i = 0; i < 4; i++)
            {
                part = new Part(2001, "StpStlBarTopBot", this, 1, (m_subAssemblyWidth - stopRed2x - stopRedMid) / 2.0m);
                part.PartGroupType = "StpStlBar-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////
           
            // StpStlRoundTopBot
            for (int i = 0; i < 4; i++)
            {
                part = new Part(2002, "StpStlRoundTopBot", this, 1, (m_subAssemblyWidth - stopRed2x - stopRedMid) / 2.0m);
                part.PartGroupType = "StpStlBar-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            // StpStlAngTopBot
            for (int i = 0; i < 4; i++)
            {
                part = new Part(2000, "StpStlBarTopBot", this, 1, (m_subAssemblyWidth - stopRed2x - stopRedMid) / 2.0m);
                part.PartGroupType = "StpStlAngTopBot-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Glass

            // GlassPanel
            for (int i = 0; i < 4; i++)
            {

                //GlassPanel
                part = new Part(911);
                part.FunctionalName = "GlassPanel";
                part.PartGroupType = "Glass-Parts";
                part.Qnty = 1;
                part.ContainerAssembly = this;
                part.PartWidth = (m_subAssemblyWidth - glsDrGapX2 - glsDrGapMID) / 2.0m;
                part.PartLength = (m_subAssemblyHieght - glsDrGap - glsDrGapBot - glsMuntGap2X) / 3.0m   ;
                part.PartThick = 0.25m;
                part.PartLabel = "Div_1x3";

                m_parts.Add(part);

            }

            // GlassPanel
            for (int i = 0; i < 2; i++)
            {

                //GlassPanel
                part = new Part(911);
                part.FunctionalName = "GlassPanel";
                part.PartGroupType = "Glass-Parts";
                part.Qnty = 1;
                part.ContainerAssembly = this;
                part.PartWidth = (m_subAssemblyWidth - glsDrGapX2 - glsDrGapMID) / 2.0m;
                part.PartLength = (m_subAssemblyHieght - glsDrGap - glsDrGapBot - glsMuntGap2X) / 3.0m;
                part.PartThick = 0.25m;
                part.PartLabel = "Div_1x3_NOTCH";

                m_parts.Add(part);

            }

            #endregion

            #region Delivery

            for (int i = 0; i < 2; i++)

            {
                // Handle_Sets
                part = new Part(5218, "Handle_Sets", this, 1, 0.0m);
                part.PartGroupType = "Delivery-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            // Dummy_Block
            part = new Part(5422, "Dummy_Block", this, 1, 0.0m);
            part.PartGroupType = "Delivery-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            // SpindleSplit_Dummy
            part = new Part(3270, "SpindleSplit_Dummy", this, 1, 0.0m);
            part.PartGroupType = "Delivery-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            #endregion

            #region AssyHrdwrDoor




            #endregion

            #region HardWare Logic

            // Hinges

            for (int i = 0; i < 2; i++)
            {
                part = new Part(911, "Hinges", this, HingeCount(m_subAssemblyHieght), 0.0m);
                part.PartGroupType = "Hardware-Parts";
                part.PartLabel = ".25_RAD_Corner";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Seal/Weatherstripping

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 2; i++)
            {
                decimal periSeal = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

                //KfolDrEdge
                part = new Part(2274, "KfolDrEdge", this, 1, (periSeal - m_subAssemblyWidth + 4.0m * edgeSealAdd) / 2.0m);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 2; i++)
            {
                //DoorBot

                part = new Part(911, "DoorBot", this, 1, (m_subAssemblyWidth - doorReduceX2 - doorGapMid ) / 2.0m);
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